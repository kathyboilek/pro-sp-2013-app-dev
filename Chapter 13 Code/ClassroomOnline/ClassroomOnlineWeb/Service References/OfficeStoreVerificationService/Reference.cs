﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassroomOnlineWeb.OfficeStoreVerificationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VerifyEntitlementTokenRequest", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
        "rm.VerificationAgent.Service.Contract")]
    [System.SerializableAttribute()]
    public partial class VerifyEntitlementTokenRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitlementTokenField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitlementToken {
            get {
                return this.EntitlementTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitlementTokenField, value) != true)) {
                    this.EntitlementTokenField = value;
                    this.RaisePropertyChanged("EntitlementToken");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VerifyEntitlementTokenResponse", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
        "rm.VerificationAgent.Service.Contract")]
    [System.SerializableAttribute()]
    public partial class VerifyEntitlementTokenResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AssetIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeploymentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EntitlementAcquisitionDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> EntitlementExpiryDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitlementTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsEntitlementExpiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsExpiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSiteLicenseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsTestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint SeatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SignInDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TokenExpiryDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssetId {
            get {
                return this.AssetIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AssetIdField, value) != true)) {
                    this.AssetIdField = value;
                    this.RaisePropertyChanged("AssetId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeploymentId {
            get {
                return this.DeploymentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DeploymentIdField, value) != true)) {
                    this.DeploymentIdField = value;
                    this.RaisePropertyChanged("DeploymentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EntitlementAcquisitionDate {
            get {
                return this.EntitlementAcquisitionDateField;
            }
            set {
                if ((this.EntitlementAcquisitionDateField.Equals(value) != true)) {
                    this.EntitlementAcquisitionDateField = value;
                    this.RaisePropertyChanged("EntitlementAcquisitionDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EntitlementExpiryDate {
            get {
                return this.EntitlementExpiryDateField;
            }
            set {
                if ((this.EntitlementExpiryDateField.Equals(value) != true)) {
                    this.EntitlementExpiryDateField = value;
                    this.RaisePropertyChanged("EntitlementExpiryDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitlementType {
            get {
                return this.EntitlementTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitlementTypeField, value) != true)) {
                    this.EntitlementTypeField = value;
                    this.RaisePropertyChanged("EntitlementType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEntitlementExpired {
            get {
                return this.IsEntitlementExpiredField;
            }
            set {
                if ((this.IsEntitlementExpiredField.Equals(value) != true)) {
                    this.IsEntitlementExpiredField = value;
                    this.RaisePropertyChanged("IsEntitlementExpired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsExpired {
            get {
                return this.IsExpiredField;
            }
            set {
                if ((this.IsExpiredField.Equals(value) != true)) {
                    this.IsExpiredField = value;
                    this.RaisePropertyChanged("IsExpired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSiteLicense {
            get {
                return this.IsSiteLicenseField;
            }
            set {
                if ((this.IsSiteLicenseField.Equals(value) != true)) {
                    this.IsSiteLicenseField = value;
                    this.RaisePropertyChanged("IsSiteLicense");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsTest {
            get {
                return this.IsTestField;
            }
            set {
                if ((this.IsTestField.Equals(value) != true)) {
                    this.IsTestField = value;
                    this.RaisePropertyChanged("IsTest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsValid {
            get {
                return this.IsValidField;
            }
            set {
                if ((this.IsValidField.Equals(value) != true)) {
                    this.IsValidField = value;
                    this.RaisePropertyChanged("IsValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Seats {
            get {
                return this.SeatsField;
            }
            set {
                if ((this.SeatsField.Equals(value) != true)) {
                    this.SeatsField = value;
                    this.RaisePropertyChanged("Seats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SignInDate {
            get {
                return this.SignInDateField;
            }
            set {
                if ((this.SignInDateField.Equals(value) != true)) {
                    this.SignInDateField = value;
                    this.RaisePropertyChanged("SignInDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TokenExpiryDate {
            get {
                return this.TokenExpiryDateField;
            }
            set {
                if ((this.TokenExpiryDateField.Equals(value) != true)) {
                    this.TokenExpiryDateField = value;
                    this.RaisePropertyChanged("TokenExpiryDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceUnavailableFault", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
        "rm.Common.Fault")]
    [System.SerializableAttribute()]
    public partial class ServiceUnavailableFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceInternalErrorFault", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
        "rm.Common.Fault")]
    [System.SerializableAttribute()]
    public partial class ServiceInternalErrorFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OfficeStoreVerificationService.IVerificationService")]
    public interface IVerificationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVerificationService/VerifyEntitlementToken", ReplyAction="http://tempuri.org/IVerificationService/VerifyEntitlementTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClassroomOnlineWeb.OfficeStoreVerificationService.ServiceUnavailableFault), Action="http://tempuri.org/IVerificationService/VerifyEntitlementTokenServiceUnavailableF" +
            "aultFault", Name="ServiceUnavailableFault", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
            "rm.Common.Fault")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClassroomOnlineWeb.OfficeStoreVerificationService.ServiceInternalErrorFault), Action="http://tempuri.org/IVerificationService/VerifyEntitlementTokenServiceInternalErro" +
            "rFaultFault", Name="ServiceInternalErrorFault", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.OfficeMarketplace.ServicePlatfo" +
            "rm.Common.Fault")]
        ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenResponse VerifyEntitlementToken(ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVerificationService/VerifyEntitlementTokenRest", ReplyAction="http://tempuri.org/IVerificationService/VerifyEntitlementTokenRestResponse")]
        ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenResponse VerifyEntitlementTokenRest(string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVerificationServiceChannel : ClassroomOnlineWeb.OfficeStoreVerificationService.IVerificationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VerificationServiceClient : System.ServiceModel.ClientBase<ClassroomOnlineWeb.OfficeStoreVerificationService.IVerificationService>, ClassroomOnlineWeb.OfficeStoreVerificationService.IVerificationService {
        
        public VerificationServiceClient() {
        }
        
        public VerificationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VerificationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VerificationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VerificationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenResponse VerifyEntitlementToken(ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenRequest request) {
            return base.Channel.VerifyEntitlementToken(request);
        }
        
        public ClassroomOnlineWeb.OfficeStoreVerificationService.VerifyEntitlementTokenResponse VerifyEntitlementTokenRest(string token) {
            return base.Channel.VerifyEntitlementTokenRest(token);
        }
    }
}
