﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TournamentManager.ModelValidators {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MatchResultValidatorResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MatchResultValidatorResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TournamentManager.ModelValidators.MatchResultValidatorResource", typeof(MatchResultValidatorResource).Assembly);
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
        ///   Looks up a localized string similar to Actual match day differs from the fixture.
        /// </summary>
        internal static string RealMatchDateEqualsFixture {
            get {
                return ResourceManager.GetString("RealMatchDateEqualsFixture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start and end time of the match must be set.
        /// </summary>
        internal static string RealMatchDateIsSet {
            get {
                return ResourceManager.GetString("RealMatchDateIsSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match date in {0} must be within {1}.
        /// </summary>
        internal static string RealMatchDateWithinRoundLegs {
            get {
                return ResourceManager.GetString("RealMatchDateWithinRoundLegs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match duration of {0:h\:mm} h strongly differs from average time needed.
        /// </summary>
        internal static string RealMatchDurationIsPlausible {
            get {
                return ResourceManager.GetString("RealMatchDurationIsPlausible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one set is invalid.
        /// </summary>
        internal static string SetsValidatorSuccessful {
            get {
                return ResourceManager.GetString("SetsValidatorSuccessful", resourceCulture);
            }
        }
    }
}