﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAutomation {
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
    internal class ResourceTestFilePaths {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceTestFilePaths() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestAutomation.ResourceTestFilePaths", typeof(ResourceTestFilePaths).Assembly);
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
        ///   Looks up a localized string similar to chrome,firefox.
        /// </summary>
        internal static string BrowserToRunWith {
            get {
                return ResourceManager.GetString("BrowserToRunWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://127.0.0.1:4444/wd/hub.
        /// </summary>
        internal static string GridHubURL {
            get {
                return ResourceManager.GetString("GridHubURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestData\\SuiteA.xlsx.
        /// </summary>
        internal static string SuiteAExcelFilePath {
            get {
                return ResourceManager.GetString("SuiteAExcelFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestData\\SuiteB.xlsx.
        /// </summary>
        internal static string SuiteBExcelFilePath {
            get {
                return ResourceManager.GetString("SuiteBExcelFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestData\\SuiteC.xlsx.
        /// </summary>
        internal static string SuiteCExcelFilePath {
            get {
                return ResourceManager.GetString("SuiteCExcelFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TestData\\Suite.xlsx.
        /// </summary>
        internal static string SuitesExcelFilePath {
            get {
                return ResourceManager.GetString("SuitesExcelFilePath", resourceCulture);
            }
        }
    }
}
