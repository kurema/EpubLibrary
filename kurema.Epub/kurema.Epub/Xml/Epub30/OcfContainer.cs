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
namespace kurema.Epub.Xml.Epub30.OcfContainer {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class container : ocfcontainercontent {
        
        private containerVersion versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public containerVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    public enum containerVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.0")]
        Item10,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ocf.container.content", Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    public partial class ocfcontainercontent {
        
        private rootfile[] rootfilesField;
        
        private link[] linksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("rootfile", IsNullable=false)]
        public rootfile[] rootfiles {
            get {
                return this.rootfilesField;
            }
            set {
                this.rootfilesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("link", IsNullable=false)]
        public link[] links {
            get {
                return this.linksField;
            }
            set {
                this.linksField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class rootfile {
        
        private string mediaField;
        
        private rootfileLayout layoutField;
        
        private bool layoutFieldSpecified;
        
        private string languageField;
        
        private rootfileAccessMode accessModeField;
        
        private bool accessModeFieldSpecified;
        
        private string labelField;
        
        private string fullpathField;
        
        private rootfileMediatype mediatypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2013/rendition")]
        public string media {
            get {
                return this.mediaField;
            }
            set {
                this.mediaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2013/rendition")]
        public rootfileLayout layout {
            get {
                return this.layoutField;
            }
            set {
                this.layoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool layoutSpecified {
            get {
                return this.layoutFieldSpecified;
            }
            set {
                this.layoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2013/rendition", DataType="language")]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2013/rendition")]
        public rootfileAccessMode accessMode {
            get {
                return this.accessModeField;
            }
            set {
                this.accessModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessModeSpecified {
            get {
                return this.accessModeFieldSpecified;
            }
            set {
                this.accessModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.idpf.org/2013/rendition")]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("full-path", DataType="anyURI")]
        public string fullpath {
            get {
                return this.fullpathField;
            }
            set {
                this.fullpathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("media-type")]
        public rootfileMediatype mediatype {
            get {
                return this.mediatypeField;
            }
            set {
                this.mediatypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idpf.org/2013/rendition")]
    public enum rootfileLayout {
        
        /// <remarks/>
        reflowable,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pre-paginated")]
        prepaginated,
    }
    
    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idpf.org/2013/rendition")]
    public enum rootfileAccessMode {
        
        /// <remarks/>
        auditory = 1,
        
        /// <remarks/>
        tactile = 2,
        
        /// <remarks/>
        textual = 4,
        
        /// <remarks/>
        visual = 8,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idpf.org/2013/rendition")]
    public enum rootfileMediatype {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/oebps-package+xml")]
        applicationoebpspackagexml,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class link {
        
        private string hrefField;
        
        private string[] relField;
        
        private string mediatypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] rel {
            get {
                return this.relField;
            }
            set {
                this.relField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("media-type")]
        public string mediatype {
            get {
                return this.mediatypeField;
            }
            set {
                this.mediatypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ocf.rootfiles.content", Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute("rootfiles", Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class ocfrootfilescontent {
        
        private rootfile[] rootfileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rootfile")]
        public rootfile[] rootfile {
            get {
                return this.rootfileField;
            }
            set {
                this.rootfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ocf.links.content", Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute("links", Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class ocflinkscontent {
        
        private link[] linkField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public link[] link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
            }
        }
    }
}