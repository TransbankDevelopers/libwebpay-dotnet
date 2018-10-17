﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace Webpay.Transbank.Library.Wsdl.Mall.Normal.Certificacion {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSWebpayServiceImplServiceSoapBinding", Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class WSWebpayServiceImplService : Microsoft.Web.Services3.WebServicesClientProtocol
    {
        
        private System.Threading.SendOrPostCallback getTransactionResultOperationCompleted;
        
        private System.Threading.SendOrPostCallback acknowledgeTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback initTransactionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSWebpayServiceImplService() {
            this.Url = global::Webpay.Transbank.Library.Properties.Settings.Default.Webpay_Transbank_Library_Wsdl_Mall_Normal_Integracion_WSWebpayServiceImplService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getTransactionResultCompletedEventHandler getTransactionResultCompleted;
        
        /// <remarks/>
        public event acknowledgeTransactionCompletedEventHandler acknowledgeTransactionCompleted;
        
        /// <remarks/>
        public event initTransactionCompletedEventHandler initTransactionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.wswebpay.webpay.transbank.com/", ResponseNamespace="http://service.wswebpay.webpay.transbank.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public transactionResultOutput getTransactionResult([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string tokenInput) {
            object[] results = this.Invoke("getTransactionResult", new object[] {
                        tokenInput});
            return ((transactionResultOutput)(results[0]));
        }
        
        /// <remarks/>
        public void getTransactionResultAsync(string tokenInput) {
            this.getTransactionResultAsync(tokenInput, null);
        }
        
        /// <remarks/>
        public void getTransactionResultAsync(string tokenInput, object userState) {
            if ((this.getTransactionResultOperationCompleted == null)) {
                this.getTransactionResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTransactionResultOperationCompleted);
            }
            this.InvokeAsync("getTransactionResult", new object[] {
                        tokenInput}, this.getTransactionResultOperationCompleted, userState);
        }
        
        private void OngetTransactionResultOperationCompleted(object arg) {
            if ((this.getTransactionResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTransactionResultCompleted(this, new getTransactionResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.wswebpay.webpay.transbank.com/", ResponseNamespace="http://service.wswebpay.webpay.transbank.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void acknowledgeTransaction([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string tokenInput) {
            this.Invoke("acknowledgeTransaction", new object[] {
                        tokenInput});
        }
        
        /// <remarks/>
        public void acknowledgeTransactionAsync(string tokenInput) {
            this.acknowledgeTransactionAsync(tokenInput, null);
        }
        
        /// <remarks/>
        public void acknowledgeTransactionAsync(string tokenInput, object userState) {
            if ((this.acknowledgeTransactionOperationCompleted == null)) {
                this.acknowledgeTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnacknowledgeTransactionOperationCompleted);
            }
            this.InvokeAsync("acknowledgeTransaction", new object[] {
                        tokenInput}, this.acknowledgeTransactionOperationCompleted, userState);
        }
        
        private void OnacknowledgeTransactionOperationCompleted(object arg) {
            if ((this.acknowledgeTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.acknowledgeTransactionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.wswebpay.webpay.transbank.com/", ResponseNamespace="http://service.wswebpay.webpay.transbank.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public wsInitTransactionOutput initTransaction([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] wsInitTransactionInput wsInitTransactionInput) {
            object[] results = this.Invoke("initTransaction", new object[] {
                        wsInitTransactionInput});
            return ((wsInitTransactionOutput)(results[0]));
        }
        
        /// <remarks/>
        public void initTransactionAsync(wsInitTransactionInput wsInitTransactionInput) {
            this.initTransactionAsync(wsInitTransactionInput, null);
        }
        
        /// <remarks/>
        public void initTransactionAsync(wsInitTransactionInput wsInitTransactionInput, object userState) {
            if ((this.initTransactionOperationCompleted == null)) {
                this.initTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OninitTransactionOperationCompleted);
            }
            this.InvokeAsync("initTransaction", new object[] {
                        wsInitTransactionInput}, this.initTransactionOperationCompleted, userState);
        }
        
        private void OninitTransactionOperationCompleted(object arg) {
            if ((this.initTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.initTransactionCompleted(this, new initTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class transactionResultOutput {
        
        private string accountingDateField;
        
        private string buyOrderField;
        
        private cardDetail cardDetailField;
        
        private wsTransactionDetailOutput[] detailOutputField;
        
        private string sessionIdField;
        
        private System.DateTime transactionDateField;
        
        private bool transactionDateFieldSpecified;
        
        private string urlRedirectionField;
        
        private string vCIField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string accountingDate {
            get {
                return this.accountingDateField;
            }
            set {
                this.accountingDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string buyOrder {
            get {
                return this.buyOrderField;
            }
            set {
                this.buyOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public cardDetail cardDetail {
            get {
                return this.cardDetailField;
            }
            set {
                this.cardDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detailOutput", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public wsTransactionDetailOutput[] detailOutput {
            get {
                return this.detailOutputField;
            }
            set {
                this.detailOutputField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime transactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionDateSpecified {
            get {
                return this.transactionDateFieldSpecified;
            }
            set {
                this.transactionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string urlRedirection {
            get {
                return this.urlRedirectionField;
            }
            set {
                this.urlRedirectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VCI {
            get {
                return this.vCIField;
            }
            set {
                this.vCIField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class cardDetail {
        
        private string cardNumberField;
        
        private string cardExpirationDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardNumber {
            get {
                return this.cardNumberField;
            }
            set {
                this.cardNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardExpirationDate {
            get {
                return this.cardExpirationDateField;
            }
            set {
                this.cardExpirationDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class wsInitTransactionOutput {
        
        private string tokenField;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class wpmDetailInput {
        
        private string serviceIdField;
        
        private string cardHolderIdField;
        
        private string cardHolderNameField;
        
        private string cardHolderLastName1Field;
        
        private string cardHolderLastName2Field;
        
        private string cardHolderMailField;
        
        private string cellPhoneNumberField;
        
        private System.DateTime expirationDateField;
        
        private string commerceMailField;
        
        private bool ufFlagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serviceId {
            get {
                return this.serviceIdField;
            }
            set {
                this.serviceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardHolderId {
            get {
                return this.cardHolderIdField;
            }
            set {
                this.cardHolderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardHolderName {
            get {
                return this.cardHolderNameField;
            }
            set {
                this.cardHolderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardHolderLastName1 {
            get {
                return this.cardHolderLastName1Field;
            }
            set {
                this.cardHolderLastName1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardHolderLastName2 {
            get {
                return this.cardHolderLastName2Field;
            }
            set {
                this.cardHolderLastName2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cardHolderMail {
            get {
                return this.cardHolderMailField;
            }
            set {
                this.cardHolderMailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cellPhoneNumber {
            get {
                return this.cellPhoneNumberField;
            }
            set {
                this.cellPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string commerceMail {
            get {
                return this.commerceMailField;
            }
            set {
                this.commerceMailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ufFlag {
            get {
                return this.ufFlagField;
            }
            set {
                this.ufFlagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class wsInitTransactionInput {
        
        private wsTransactionType wSTransactionTypeField;
        
        private string commerceIdField;
        
        private string buyOrderField;
        
        private string sessionIdField;
        
        private string returnURLField;
        
        private string finalURLField;
        
        private wsTransactionDetail[] transactionDetailsField;
        
        private wpmDetailInput wPMDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public wsTransactionType wSTransactionType {
            get {
                return this.wSTransactionTypeField;
            }
            set {
                this.wSTransactionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string commerceId {
            get {
                return this.commerceIdField;
            }
            set {
                this.commerceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string buyOrder {
            get {
                return this.buyOrderField;
            }
            set {
                this.buyOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="anyURI")]
        public string returnURL {
            get {
                return this.returnURLField;
            }
            set {
                this.returnURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="anyURI")]
        public string finalURL {
            get {
                return this.finalURLField;
            }
            set {
                this.finalURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactionDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public wsTransactionDetail[] transactionDetails {
            get {
                return this.transactionDetailsField;
            }
            set {
                this.transactionDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public wpmDetailInput wPMDetail {
            get {
                return this.wPMDetailField;
            }
            set {
                this.wPMDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public enum wsTransactionType {
        
        /// <remarks/>
        TR_NORMAL_WS,
        
        /// <remarks/>
        TR_NORMAL_WS_WPM,
        
        /// <remarks/>
        TR_MALL_WS,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(wsTransactionDetailOutput))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class wsTransactionDetail {
        
        private decimal sharesAmountField;
        
        private bool sharesAmountFieldSpecified;
        
        private int sharesNumberField;
        
        private bool sharesNumberFieldSpecified;
        
        private decimal amountField;
        
        private string commerceCodeField;
        
        private string buyOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal sharesAmount {
            get {
                return this.sharesAmountField;
            }
            set {
                this.sharesAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sharesAmountSpecified {
            get {
                return this.sharesAmountFieldSpecified;
            }
            set {
                this.sharesAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int sharesNumber {
            get {
                return this.sharesNumberField;
            }
            set {
                this.sharesNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sharesNumberSpecified {
            get {
                return this.sharesNumberFieldSpecified;
            }
            set {
                this.sharesNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string commerceCode {
            get {
                return this.commerceCodeField;
            }
            set {
                this.commerceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string buyOrder {
            get {
                return this.buyOrderField;
            }
            set {
                this.buyOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.wswebpay.webpay.transbank.com/")]
    public partial class wsTransactionDetailOutput : wsTransactionDetail {
        
        private string authorizationCodeField;
        
        private string paymentTypeCodeField;
        
        private int responseCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string authorizationCode {
            get {
                return this.authorizationCodeField;
            }
            set {
                this.authorizationCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string paymentTypeCode {
            get {
                return this.paymentTypeCodeField;
            }
            set {
                this.paymentTypeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int responseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getTransactionResultCompletedEventHandler(object sender, getTransactionResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTransactionResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTransactionResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public transactionResultOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((transactionResultOutput)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void acknowledgeTransactionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void initTransactionCompletedEventHandler(object sender, initTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class initTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal initTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public wsInitTransactionOutput Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((wsInitTransactionOutput)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591