﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Design;
using Microsoft.Web.Services3.Security.Tokens;
using System.Net;
using Webpay.Transbank.Library.Wsdl.Capture;

/**
  * @brief      Ecommerce Plugin for chilean Webpay
  * @category   Plugins/SDK
  * @author     Allware Ltda. (http://www.allware.cl)
  * @copyright  2015 Transbank S.A. (http://www.tranbank.cl)
  * @date       May 2016
  * @license    GNU LGPL
  * @version    2.0.1
  * @link       http://transbankdevelopers.cl/
  *
  * This software was created for easy integration of ecommerce
  * portals with Transbank Webpay solution.
  *
  * Required:
  *  - .NET Framework 4.5
  *
  * See documentation and how to install at link site
  *
  * */

namespace Webpay.Transbank.Library
{

    /**
     * Este método permite a todo comercio habilitado realizar capturas de una transacción autorizada 
     * sin  captura  en  plataforma  Webpay  3G.  El  método  contempla  una  única  captura  por  cada 
     * autorización.  Para  ello  se  deberá  indicar  los  datos  asociados  a  la  transacción  de  venta  con 
     * autorización  sin  captura  y  el  monto  requerido  para  capturar  el  cual  debe  ser  menor  o  igual  al 
     * monto originalmente autorizado.
     * */

    public class WebpayCapture
    {

        Configuration config;

        string WSDL;

        /** Configuración de URL según Ambiente */
        private static string wsdlUrl(string environment)
        {

            Dictionary<string, string> wsdl = new Dictionary<string, string>();
            wsdl.Add("INTEGRACION", "https://webpay3gint.transbank.cl/WSWebpayTransaction/cxf/WSCommerceIntegrationService?wsdl");
            wsdl.Add("CERTIFICACION", "https://webpay3gint.transbank.cl/WSWebpayTransaction/cxf/WSCommerceIntegrationService?wsdl");
            wsdl.Add("PRODUCCION", "https://webpay3g.transbank.cl/WSWebpayTransaction/cxf/WSCommerceIntegrationService?wsdl");

            return wsdl[environment];

        }

        public WebpayCapture(Configuration config)
        {

            /** Configuración para ser consultado desde cualquier metodo de la clase */
            this.config = config;

            /** Obtiene URL de WSDL según parametro desde Configuración (INTEGRACION, CERTIFICACION, PRODUCCION) */
            string url = this.config.getEnvironmentDefault();
            WSDL = wsdlUrl(url);

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

        }

        /**
         * Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
         * */
        public captureOutput capture(string authorizationCode, decimal captureAmount, string buyOrder)
        {

            captureInput capture = new captureInput();

            capture.authorizationCode = authorizationCode;
            capture.buyOrder = buyOrder;
            capture.captureAmount = captureAmount;
            capture.commerceId = Int64.Parse(this.config.CommerceCode);

            using (WSCommerceIntegrationServiceImplService proxy = new WSCommerceIntegrationServiceImplService())
            {

                /** Define el ENDPOINT del Web Service Webpay*/
                proxy.Url = WSDL;

                Policy myPolicy = new Policy();
                myPolicy.Assertions.Add(new CustomPolicyAssertion(this.config));

                proxy.SetPolicy(myPolicy);
                proxy.Timeout = 60000;
                proxy.UseDefaultCredentials = false;

                captureOutput captureOutput = proxy.capture(capture);
                return captureOutput;

            }

        }


    }
}
