﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace B20.localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ProcitajSveValuteOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcitajKursNaDanOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpisiKursNaDanOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::B20.Properties.Settings.Default.B20_localhost_WebService1;
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
        public event ProcitajSveValuteCompletedEventHandler ProcitajSveValuteCompleted;
        
        /// <remarks/>
        public event ProcitajKursNaDanCompletedEventHandler ProcitajKursNaDanCompleted;
        
        /// <remarks/>
        public event UpisiKursNaDanCompletedEventHandler UpisiKursNaDanCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ProcitajSveValute", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ProcitajSveValute() {
            object[] results = this.Invoke("ProcitajSveValute", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void ProcitajSveValuteAsync() {
            this.ProcitajSveValuteAsync(null);
        }
        
        /// <remarks/>
        public void ProcitajSveValuteAsync(object userState) {
            if ((this.ProcitajSveValuteOperationCompleted == null)) {
                this.ProcitajSveValuteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcitajSveValuteOperationCompleted);
            }
            this.InvokeAsync("ProcitajSveValute", new object[0], this.ProcitajSveValuteOperationCompleted, userState);
        }
        
        private void OnProcitajSveValuteOperationCompleted(object arg) {
            if ((this.ProcitajSveValuteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcitajSveValuteCompleted(this, new ProcitajSveValuteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ProcitajKursNaDan", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double ProcitajKursNaDan(System.DateTime Datum, string valuta) {
            object[] results = this.Invoke("ProcitajKursNaDan", new object[] {
                        Datum,
                        valuta});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void ProcitajKursNaDanAsync(System.DateTime Datum, string valuta) {
            this.ProcitajKursNaDanAsync(Datum, valuta, null);
        }
        
        /// <remarks/>
        public void ProcitajKursNaDanAsync(System.DateTime Datum, string valuta, object userState) {
            if ((this.ProcitajKursNaDanOperationCompleted == null)) {
                this.ProcitajKursNaDanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcitajKursNaDanOperationCompleted);
            }
            this.InvokeAsync("ProcitajKursNaDan", new object[] {
                        Datum,
                        valuta}, this.ProcitajKursNaDanOperationCompleted, userState);
        }
        
        private void OnProcitajKursNaDanOperationCompleted(object arg) {
            if ((this.ProcitajKursNaDanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcitajKursNaDanCompleted(this, new ProcitajKursNaDanCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpisiKursNaDan", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool UpisiKursNaDan(System.DateTime Datum, string valuta, double Kurs) {
            object[] results = this.Invoke("UpisiKursNaDan", new object[] {
                        Datum,
                        valuta,
                        Kurs});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void UpisiKursNaDanAsync(System.DateTime Datum, string valuta, double Kurs) {
            this.UpisiKursNaDanAsync(Datum, valuta, Kurs, null);
        }
        
        /// <remarks/>
        public void UpisiKursNaDanAsync(System.DateTime Datum, string valuta, double Kurs, object userState) {
            if ((this.UpisiKursNaDanOperationCompleted == null)) {
                this.UpisiKursNaDanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpisiKursNaDanOperationCompleted);
            }
            this.InvokeAsync("UpisiKursNaDan", new object[] {
                        Datum,
                        valuta,
                        Kurs}, this.UpisiKursNaDanOperationCompleted, userState);
        }
        
        private void OnUpisiKursNaDanOperationCompleted(object arg) {
            if ((this.UpisiKursNaDanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpisiKursNaDanCompleted(this, new UpisiKursNaDanCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void ProcitajSveValuteCompletedEventHandler(object sender, ProcitajSveValuteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcitajSveValuteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcitajSveValuteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void ProcitajKursNaDanCompletedEventHandler(object sender, ProcitajKursNaDanCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcitajKursNaDanCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcitajKursNaDanCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void UpisiKursNaDanCompletedEventHandler(object sender, UpisiKursNaDanCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpisiKursNaDanCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpisiKursNaDanCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591