﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Converter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Converter.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to text/richtext.
        /// </summary>
        public static string ContentRichtext {
            get {
                return ResourceManager.GetString("ContentRichtext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to text/xml.
        /// </summary>
        public static string ContentXml {
            get {
                return ResourceManager.GetString("ContentXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ,.
        /// </summary>
        public static string DelimeterComma {
            get {
                return ResourceManager.GetString("DelimeterComma", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write your text here.
        /// </summary>
        public static string LabelForStartedForm {
            get {
                return ResourceManager.GetString("LabelForStartedForm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to text.
        /// </summary>
        public static string StartXmlElement {
            get {
                return ResourceManager.GetString("StartXmlElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sentence.
        /// </summary>
        public static string TagSentence {
            get {
                return ResourceManager.GetString("TagSentence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Word.
        /// </summary>
        public static string TagWord {
            get {
                return ResourceManager.GetString("TagWord", resourceCulture);
            }
        }
    }
}
