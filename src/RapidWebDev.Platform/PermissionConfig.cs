﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace RapidWebDev.Platform {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rapidwebdev.org/schemas/permissions")]
    [System.Xml.Serialization.XmlRootAttribute("Permissions", Namespace="http://www.rapidwebdev.org/schemas/permissions", IsNullable=false)]
    public partial class PermissionConfigs {
        
        private PermissionDomain[] domainField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Domain")]
        public PermissionDomain[] Domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rapidwebdev.org/schemas/permissions")]
    public partial class PermissionDomain {
        
        private PermissionConfig[] permissionField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Permission")]
        public PermissionConfig[] Permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rapidwebdev.org/schemas/permissions")]
    public partial class PermissionConfig {
        
        private ImplicitPermissionConfig[] implicitPermissionField;
        
        private PermissionConfig[] permissionField;
        
        private string valueField;
        
        private string textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImplicitPermission")]
        public ImplicitPermissionConfig[] ImplicitPermission {
            get {
                return this.implicitPermissionField;
            }
            set {
                this.implicitPermissionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Permission")]
        public PermissionConfig[] Permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rapidwebdev.org/schemas/permissions")]
    public partial class ImplicitPermissionConfig {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
