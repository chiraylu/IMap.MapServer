﻿namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("priorityLocation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PriorityLocationPropertyType : LocationPropertyType {
        
        private string priorityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
    }
}