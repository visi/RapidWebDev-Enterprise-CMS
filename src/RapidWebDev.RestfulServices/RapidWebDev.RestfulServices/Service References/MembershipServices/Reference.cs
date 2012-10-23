﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapidWebDev.RestfulServices.MembershipServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AbstractExtensionBizObject", Namespace="http://www.rapidwebdev.org/platform")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidWebDev.RestfulServices.MembershipServices.UserObject))]
    public partial class AbstractExtensionBizObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ExtensionDataTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, object> PropertiesField;
        
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
        public System.Guid ExtensionDataTypeId {
            get {
                return this.ExtensionDataTypeIdField;
            }
            set {
                if ((this.ExtensionDataTypeIdField.Equals(value) != true)) {
                    this.ExtensionDataTypeIdField = value;
                    this.RaisePropertyChanged("ExtensionDataTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, object> Properties {
            get {
                return this.PropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertiesField, value) != true)) {
                    this.PropertiesField = value;
                    this.RaisePropertyChanged("Properties");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserObject", Namespace="http://www.rapidwebdev.org/platform")]
    [System.SerializableAttribute()]
    public partial class UserObject : RapidWebDev.RestfulServices.MembershipServices.AbstractExtensionBizObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsApprovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsLockedOutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastActivityDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastLockoutDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastLoginDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastPasswordChangedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastUpdatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobilePinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid OrganizationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordQuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName {
            get {
                return this.DisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayNameField, value) != true)) {
                    this.DisplayNameField = value;
                    this.RaisePropertyChanged("DisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApproved {
            get {
                return this.IsApprovedField;
            }
            set {
                if ((this.IsApprovedField.Equals(value) != true)) {
                    this.IsApprovedField = value;
                    this.RaisePropertyChanged("IsApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsLockedOut {
            get {
                return this.IsLockedOutField;
            }
            set {
                if ((this.IsLockedOutField.Equals(value) != true)) {
                    this.IsLockedOutField = value;
                    this.RaisePropertyChanged("IsLockedOut");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline {
            get {
                return this.IsOnlineField;
            }
            set {
                if ((this.IsOnlineField.Equals(value) != true)) {
                    this.IsOnlineField = value;
                    this.RaisePropertyChanged("IsOnline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastActivityDate {
            get {
                return this.LastActivityDateField;
            }
            set {
                if ((this.LastActivityDateField.Equals(value) != true)) {
                    this.LastActivityDateField = value;
                    this.RaisePropertyChanged("LastActivityDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastLockoutDate {
            get {
                return this.LastLockoutDateField;
            }
            set {
                if ((this.LastLockoutDateField.Equals(value) != true)) {
                    this.LastLockoutDateField = value;
                    this.RaisePropertyChanged("LastLockoutDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastLoginDate {
            get {
                return this.LastLoginDateField;
            }
            set {
                if ((this.LastLoginDateField.Equals(value) != true)) {
                    this.LastLoginDateField = value;
                    this.RaisePropertyChanged("LastLoginDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastPasswordChangedDate {
            get {
                return this.LastPasswordChangedDateField;
            }
            set {
                if ((this.LastPasswordChangedDateField.Equals(value) != true)) {
                    this.LastPasswordChangedDateField = value;
                    this.RaisePropertyChanged("LastPasswordChangedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastUpdatedDate {
            get {
                return this.LastUpdatedDateField;
            }
            set {
                if ((this.LastUpdatedDateField.Equals(value) != true)) {
                    this.LastUpdatedDateField = value;
                    this.RaisePropertyChanged("LastUpdatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MobilePin {
            get {
                return this.MobilePinField;
            }
            set {
                if ((object.ReferenceEquals(this.MobilePinField, value) != true)) {
                    this.MobilePinField = value;
                    this.RaisePropertyChanged("MobilePin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OrganizationId {
            get {
                return this.OrganizationIdField;
            }
            set {
                if ((this.OrganizationIdField.Equals(value) != true)) {
                    this.OrganizationIdField = value;
                    this.RaisePropertyChanged("OrganizationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordQuestion {
            get {
                return this.PasswordQuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordQuestionField, value) != true)) {
                    this.PasswordQuestionField = value;
                    this.RaisePropertyChanged("PasswordQuestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="EnumerationValueCollection", Namespace="http://schemas.datacontract.org/2004/07/RapidWebDev.ExtensionModel", ItemName="EnumerationValue")]
    [System.SerializableAttribute()]
    public class EnumerationValueCollection : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebServiceQueryPredicate", Namespace="http://www.rapidwebdev.org/common")]
    [System.SerializableAttribute()]
    public partial class WebServiceQueryPredicate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExpressionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicateParameter[] ParametersField;
        
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
        public string Expression {
            get {
                return this.ExpressionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExpressionField, value) != true)) {
                    this.ExpressionField = value;
                    this.RaisePropertyChanged("Expression");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicateParameter[] Parameters {
            get {
                return this.ParametersField;
            }
            set {
                if ((object.ReferenceEquals(this.ParametersField, value) != true)) {
                    this.ParametersField = value;
                    this.RaisePropertyChanged("Parameters");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebServiceQueryPredicateParameter", Namespace="http://www.rapidwebdev.org/common")]
    [System.SerializableAttribute()]
    public partial class WebServiceQueryPredicateParameter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicateParameterTypes TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicateParameterTypes Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebServiceQueryPredicateParameterTypes", Namespace="http://www.rapidwebdev.org/common")]
    public enum WebServiceQueryPredicateParameterTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        String = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateTime = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Guid = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Integer = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Decimal = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Double = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="IdCollection", Namespace="http://www.rapidwebdev.org/platform", ItemName="Id")]
    [System.SerializableAttribute()]
    public class IdCollection : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="UserQueryResult", Namespace="http://www.rapidwebdev.org/platform", ItemName="UserObject")]
    [System.SerializableAttribute()]
    public class UserQueryResult : System.Collections.Generic.List<RapidWebDev.RestfulServices.MembershipServices.UserObject> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DateTimeFieldValue", Namespace="http://www.rapidwebdev.org/extensionmodel")]
    [System.SerializableAttribute()]
    public partial class DateTimeFieldValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
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
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DecimalFieldValue", Namespace="http://www.rapidwebdev.org/extensionmodel")]
    [System.SerializableAttribute()]
    public partial class DecimalFieldValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DecimalField;
        
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
        public decimal Decimal {
            get {
                return this.DecimalField;
            }
            set {
                if ((this.DecimalField.Equals(value) != true)) {
                    this.DecimalField = value;
                    this.RaisePropertyChanged("Decimal");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StringFieldValue", Namespace="http://www.rapidwebdev.org/extensionmodel")]
    [System.SerializableAttribute()]
    public partial class StringFieldValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringField;
        
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
        public string String {
            get {
                return this.StringField;
            }
            set {
                if ((object.ReferenceEquals(this.StringField, value) != true)) {
                    this.StringField = value;
                    this.RaisePropertyChanged("String");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IntegerFieldValue", Namespace="http://www.rapidwebdev.org/extensionmodel")]
    [System.SerializableAttribute()]
    public partial class IntegerFieldValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IntegerField;
        
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
        public int Integer {
            get {
                return this.IntegerField;
            }
            set {
                if ((this.IntegerField.Equals(value) != true)) {
                    this.IntegerField = value;
                    this.RaisePropertyChanged("Integer");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.rapidwebdev.org/platform", ConfigurationName="MembershipServices.MembershipService")]
    public interface MembershipService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/SaveJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/SaveJsonResponse")]
        string SaveJson(RapidWebDev.RestfulServices.MembershipServices.UserObject user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/SaveXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/SaveXmlResponse")]
        string SaveXml(RapidWebDev.RestfulServices.MembershipServices.UserObject user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/BulkGetJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/BulkGetJsonResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject[] BulkGetJson(RapidWebDev.RestfulServices.MembershipServices.IdCollection userIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/BulkGetXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/BulkGetXmlResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject[] BulkGetXml(RapidWebDev.RestfulServices.MembershipServices.IdCollection userIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/GetByNameJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/GetByNameJsonResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject GetByNameJson(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/GetByNameXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/GetByNameXmlResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject GetByNameXml(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/GetByIdJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/GetByIdJsonResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject GetByIdJson(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/GetByIdXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/GetByIdXmlResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserObject GetByIdXml(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/ChangePasswordJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/ChangePasswordJsonResponse")]
        bool ChangePasswordJson(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/ChangePasswordXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/ChangePasswordXmlResponse")]
        bool ChangePasswordXml(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/QueryUsersJson", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/QueryUsersJsonResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserQueryResult QueryUsersJson(string orderby, int pageIndex, int pageSize, RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicate predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.rapidwebdev.org/platform/MembershipService/QueryUsersXml", ReplyAction="http://www.rapidwebdev.org/platform/MembershipService/QueryUsersXmlResponse")]
        RapidWebDev.RestfulServices.MembershipServices.UserQueryResult QueryUsersXml(string orderby, int pageIndex, int pageSize, RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicate predicate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface MembershipServiceChannel : RapidWebDev.RestfulServices.MembershipServices.MembershipService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MembershipServiceClient : System.ServiceModel.ClientBase<RapidWebDev.RestfulServices.MembershipServices.MembershipService>, RapidWebDev.RestfulServices.MembershipServices.MembershipService {
        
        public MembershipServiceClient() {
        }
        
        public MembershipServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MembershipServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MembershipServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MembershipServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SaveJson(RapidWebDev.RestfulServices.MembershipServices.UserObject user) {
            return base.Channel.SaveJson(user);
        }
        
        public string SaveXml(RapidWebDev.RestfulServices.MembershipServices.UserObject user) {
            return base.Channel.SaveXml(user);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject[] BulkGetJson(RapidWebDev.RestfulServices.MembershipServices.IdCollection userIds) {
            return base.Channel.BulkGetJson(userIds);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject[] BulkGetXml(RapidWebDev.RestfulServices.MembershipServices.IdCollection userIds) {
            return base.Channel.BulkGetXml(userIds);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject GetByNameJson(string userName) {
            return base.Channel.GetByNameJson(userName);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject GetByNameXml(string userName) {
            return base.Channel.GetByNameXml(userName);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject GetByIdJson(string userId) {
            return base.Channel.GetByIdJson(userId);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserObject GetByIdXml(string userId) {
            return base.Channel.GetByIdXml(userId);
        }
        
        public bool ChangePasswordJson(string userId) {
            return base.Channel.ChangePasswordJson(userId);
        }
        
        public bool ChangePasswordXml(string userId) {
            return base.Channel.ChangePasswordXml(userId);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserQueryResult QueryUsersJson(string orderby, int pageIndex, int pageSize, RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicate predicate) {
            return base.Channel.QueryUsersJson(orderby, pageIndex, pageSize, predicate);
        }
        
        public RapidWebDev.RestfulServices.MembershipServices.UserQueryResult QueryUsersXml(string orderby, int pageIndex, int pageSize, RapidWebDev.RestfulServices.MembershipServices.WebServiceQueryPredicate predicate) {
            return base.Channel.QueryUsersXml(orderby, pageIndex, pageSize, predicate);
        }
    }
}
