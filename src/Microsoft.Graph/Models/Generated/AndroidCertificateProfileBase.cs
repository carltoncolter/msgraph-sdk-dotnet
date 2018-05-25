// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Certificate Profile Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidCertificateProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AndroidCertificateProfileBase constructor
		///</summary>
        protected internal AndroidCertificateProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets renewal threshold percentage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewalThresholdPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RenewalThresholdPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormat", Required = Newtonsoft.Json.Required.Default)]
        public SubjectNameFormat? SubjectNameFormat { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameType", Required = Newtonsoft.Json.Required.Default)]
        public SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodScale", Required = Newtonsoft.Json.Required.Default)]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extendedKeyUsages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidTrustedRootCertificate RootCertificate { get; set; }
    
    }
}
