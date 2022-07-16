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
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace kurema.Epub.Xml.Epub30.MediaOverlay {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class smil : smilcontent {
        
        private smilVersion versionField;
        
        private string idField;
        
        private string prefixField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public smilVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops")]
        public string prefix {
            get {
                return this.prefixField;
            }
            set {
                this.prefixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    public enum smilVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3.0")]
        Item30,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="smil.content", Namespace="http://www.w3.org/ns/SMIL")]
    public partial class smilcontent {
        
        private head headField;
        
        private body bodyField;
        
        /// <remarks/>
        public head head {
            get {
                return this.headField;
            }
            set {
                this.headField = value;
            }
        }
        
        /// <remarks/>
        public body body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class head {
        
        private System.Xml.XmlElement metadataField;
        
        /// <remarks/>
        public System.Xml.XmlElement metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="smil.body.content", Namespace="http://www.w3.org/ns/SMIL")]
    public partial class smilbodycontent {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("par", typeof(par))]
        [System.Xml.Serialization.XmlElementAttribute("seq", typeof(seq))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class par : smilparcontent {
        
        private string typeField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops", DataType="NMTOKENS")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="smil.par.content", Namespace="http://www.w3.org/ns/SMIL")]
    public partial class smilparcontent {
        
        private text textField;
        
        private audio audioField;
        
        /// <remarks/>
        public text text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public audio audio {
            get {
                return this.audioField;
            }
            set {
                this.audioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class text {
        
        private string idField;
        
        private string srcField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class audio {
        
        private string idField;
        
        private string clipBeginField;
        
        private string clipEndField;
        
        private string srcField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clipBegin {
            get {
                return this.clipBeginField;
            }
            set {
                this.clipBeginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clipEnd {
            get {
                return this.clipEndField;
            }
            set {
                this.clipEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class seq {
        
        private object[] itemsField;
        
        private string typeField;
        
        private string idField;
        
        private string textrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("par", typeof(par))]
        [System.Xml.Serialization.XmlElementAttribute("seq", typeof(seq))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops", DataType="NMTOKENS")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops", DataType="anyURI")]
        public string textref {
            get {
                return this.textrefField;
            }
            set {
                this.textrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/ns/SMIL")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/ns/SMIL", IsNullable=false)]
    public partial class body : smilbodycontent {
        
        private string typeField;
        
        private string idField;
        
        private string textrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops", DataType="NMTOKENS")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2007/ops", DataType="anyURI")]
        public string textref {
            get {
                return this.textrefField;
            }
            set {
                this.textrefField = value;
            }
        }
    }
}
