﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JsonToFuncBuilderTests {
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
    internal class TestStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JsonToFuncBuilderTests.TestStrings", typeof(TestStrings).Assembly);
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
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;BirthDay&quot;,
        ///		&quot;Operator&quot;: &quot;NotEqual&quot;,
        ///		&quot;Value&quot;: &quot;10/10/2015&quot;
        ///	}]
        ///}].
        /// </summary>
        internal static string NotEqualDateTime {
            get {
                return ResourceManager.GetString("NotEqualDateTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Age&quot;,
        ///		&quot;Operator&quot;: &quot;NotEqual&quot;,
        ///		&quot;Value&quot;: &quot;10&quot;
        ///	}]
        ///}].
        /// </summary>
        internal static string NotEqualInteger {
            get {
                return ResourceManager.GetString("NotEqualInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Name&quot;,
        ///		&quot;Operator&quot;: &quot;NotEqual&quot;,
        ///		&quot;Value&quot;: &quot;Skippy&quot;
        ///	}]
        ///}].
        /// </summary>
        internal static string NotEqualString {
            get {
                return ResourceManager.GetString("NotEqualString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Name&quot;,
        ///		&quot;Operator&quot;: &quot;Equal&quot;,
        ///		&quot;Value&quot;: &quot;Skippy&quot;
        ///	}]
        ///}].
        /// </summary>
        internal static string OneCriteria {
            get {
                return ResourceManager.GetString("OneCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Address.Street&quot;,
        ///		&quot;Operator&quot;: &quot;Equal&quot;,
        ///		&quot;Value&quot;: &quot;123 Test St&quot;
        ///	}]
        ///}].
        /// </summary>
        internal static string OneCriteriaAddress {
            get {
                return ResourceManager.GetString("OneCriteriaAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Name&quot;,
        ///		&quot;Operator&quot;: &quot;NotEqual&quot;,
        ///		&quot;Value&quot;: &quot;Skippy&quot;
        ///	},
        ///	{
        ///		&quot;Field&quot;: &quot;Age&quot;,
        ///		&quot;Operator&quot;: &quot;GreaterThanEqualTo&quot;,
        ///		&quot;Value&quot;: 50
        ///	}]
        ///}].
        /// </summary>
        internal static string OneGroupTwoCriteria {
            get {
                return ResourceManager.GetString("OneGroupTwoCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///	&quot;Criteria&quot;: [{
        ///		&quot;Field&quot;: &quot;Name&quot;,
        ///		&quot;Operator&quot;: &quot;NotEqual&quot;,
        ///		&quot;Value&quot;: &quot;Skippy&quot;
        ///	},
        ///	{
        ///		&quot;Field&quot;: &quot;Age&quot;,
        ///		&quot;Operator&quot;: &quot;GreaterThanEqualTo&quot;,
        ///		&quot;Value&quot;: 50
        ///	}]
        ///}].
        /// </summary>
        internal static string TestData1 {
            get {
                return ResourceManager.GetString("TestData1", resourceCulture);
            }
        }
    }
}
