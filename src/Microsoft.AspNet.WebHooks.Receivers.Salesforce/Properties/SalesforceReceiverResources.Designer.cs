﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.WebHooks.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SalesforceReceiverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SalesforceReceiverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.WebHooks.Properties.SalesforceReceiverResources", typeof(SalesforceReceiverResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No embedded resource found with the name &apos;{0}&apos;..
        /// </summary>
        internal static string EmbeddedResources_Unknown {
            get {
                return ResourceManager.GetString("EmbeddedResources_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP request body did not contain a required &apos;{0}&apos; property..
        /// </summary>
        internal static string Receiver_BadBody {
            get {
                return ResourceManager.GetString("Receiver_BadBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; query parameter provided in the HTTP request did not match the expected value..
        /// </summary>
        internal static string Receiver_BadCode {
            get {
                return ResourceManager.GetString("Receiver_BadCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter provided in the HTTP request did not match the expected value..
        /// </summary>
        internal static string Receiver_BadValue {
            get {
                return ResourceManager.GetString("Receiver_BadValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as valid XML..
        /// </summary>
        internal static string Receiver_BadXml {
            get {
                return ResourceManager.GetString("Receiver_BadXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request entity body cannot be empty..
        /// </summary>
        internal static string Receiver_NoBody {
            get {
                return ResourceManager.GetString("Receiver_NoBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook verification request must contain a &apos;{0}&apos; query parameter..
        /// </summary>
        internal static string Receiver_NoCode {
            get {
                return ResourceManager.GetString("Receiver_NoCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as XML..
        /// </summary>
        internal static string Receiver_NoXml {
            get {
                return ResourceManager.GetString("Receiver_NoXml", resourceCulture);
            }
        }
    }
}
