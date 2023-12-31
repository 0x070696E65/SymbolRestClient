/*
 * Catapult REST Endpoints
 *
 * OpenAPI Specification of catapult-rest
 *
 * The version of the OpenAPI document: 1.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SymbolRestClient.Client.OpenAPIDateConverter;

namespace SymbolRestClient.Model
{
    /// <summary>
    /// NamespaceNetworkPropertiesDTO
    /// </summary>
    [DataContract(Name = "NamespaceNetworkPropertiesDTO")]
    public partial class NamespaceNetworkPropertiesDTO : IEquatable<NamespaceNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="maxNameSize">Maximum namespace name size..</param>
        /// <param name="maxChildNamespaces">Maximum number of children for a root namespace..</param>
        /// <param name="maxNamespaceDepth">Maximum namespace depth..</param>
        /// <param name="minNamespaceDuration">Minimum namespace duration..</param>
        /// <param name="maxNamespaceDuration">Maximum namespace duration..</param>
        /// <param name="namespaceGracePeriodDuration">Grace period during which time only the previous owner can renew an expired namespace..</param>
        /// <param name="reservedRootNamespaceNames">Reserved root namespaces that cannot be claimed..</param>
        /// <param name="namespaceRentalFeeSinkAddress">Address encoded using a 32-character set..</param>
        /// <param name="rootNamespaceRentalFeePerBlock">Root namespace rental fee per block..</param>
        /// <param name="childNamespaceRentalFee">Child namespace rental fee..</param>
        public NamespaceNetworkPropertiesDTO(string maxNameSize = default(string), string maxChildNamespaces = default(string), string maxNamespaceDepth = default(string), string minNamespaceDuration = default(string), string maxNamespaceDuration = default(string), string namespaceGracePeriodDuration = default(string), string reservedRootNamespaceNames = default(string), string namespaceRentalFeeSinkAddress = default(string), string rootNamespaceRentalFeePerBlock = default(string), string childNamespaceRentalFee = default(string))
        {
            this.MaxNameSize = maxNameSize;
            this.MaxChildNamespaces = maxChildNamespaces;
            this.MaxNamespaceDepth = maxNamespaceDepth;
            this.MinNamespaceDuration = minNamespaceDuration;
            this.MaxNamespaceDuration = maxNamespaceDuration;
            this.NamespaceGracePeriodDuration = namespaceGracePeriodDuration;
            this.ReservedRootNamespaceNames = reservedRootNamespaceNames;
            this.NamespaceRentalFeeSinkAddress = namespaceRentalFeeSinkAddress;
            this.RootNamespaceRentalFeePerBlock = rootNamespaceRentalFeePerBlock;
            this.ChildNamespaceRentalFee = childNamespaceRentalFee;
        }

        /// <summary>
        /// Maximum namespace name size.
        /// </summary>
        /// <value>Maximum namespace name size.</value>
        /// <example>&quot;64&quot;</example>
        [DataMember(Name = "maxNameSize", EmitDefaultValue = false)]
        public string MaxNameSize { get; set; }

        /// <summary>
        /// Maximum number of children for a root namespace.
        /// </summary>
        /// <value>Maximum number of children for a root namespace.</value>
        /// <example>&quot;500&quot;</example>
        [DataMember(Name = "maxChildNamespaces", EmitDefaultValue = false)]
        public string MaxChildNamespaces { get; set; }

        /// <summary>
        /// Maximum namespace depth.
        /// </summary>
        /// <value>Maximum namespace depth.</value>
        /// <example>&quot;3&quot;</example>
        [DataMember(Name = "maxNamespaceDepth", EmitDefaultValue = false)]
        public string MaxNamespaceDepth { get; set; }

        /// <summary>
        /// Minimum namespace duration.
        /// </summary>
        /// <value>Minimum namespace duration.</value>
        /// <example>&quot;1m&quot;</example>
        [DataMember(Name = "minNamespaceDuration", EmitDefaultValue = false)]
        public string MinNamespaceDuration { get; set; }

        /// <summary>
        /// Maximum namespace duration.
        /// </summary>
        /// <value>Maximum namespace duration.</value>
        /// <example>&quot;365d&quot;</example>
        [DataMember(Name = "maxNamespaceDuration", EmitDefaultValue = false)]
        public string MaxNamespaceDuration { get; set; }

        /// <summary>
        /// Grace period during which time only the previous owner can renew an expired namespace.
        /// </summary>
        /// <value>Grace period during which time only the previous owner can renew an expired namespace.</value>
        /// <example>&quot;2m&quot;</example>
        [DataMember(Name = "namespaceGracePeriodDuration", EmitDefaultValue = false)]
        public string NamespaceGracePeriodDuration { get; set; }

        /// <summary>
        /// Reserved root namespaces that cannot be claimed.
        /// </summary>
        /// <value>Reserved root namespaces that cannot be claimed.</value>
        /// <example>&quot;xem, nem, user, account, org, com, biz, net, edu, mil, gov, info&quot;</example>
        [DataMember(Name = "reservedRootNamespaceNames", EmitDefaultValue = false)]
        public string ReservedRootNamespaceNames { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        /// <example>&quot;TADP6C2GVEG654OP5LZI32P2GYJSCMEGQBYB7QY&quot;</example>
        [DataMember(Name = "namespaceRentalFeeSinkAddress", EmitDefaultValue = false)]
        public string NamespaceRentalFeeSinkAddress { get; set; }

        /// <summary>
        /// Root namespace rental fee per block.
        /// </summary>
        /// <value>Root namespace rental fee per block.</value>
        /// <example>&quot;1&quot;</example>
        [DataMember(Name = "rootNamespaceRentalFeePerBlock", EmitDefaultValue = false)]
        public string RootNamespaceRentalFeePerBlock { get; set; }

        /// <summary>
        /// Child namespace rental fee.
        /// </summary>
        /// <value>Child namespace rental fee.</value>
        /// <example>&quot;100&quot;</example>
        [DataMember(Name = "childNamespaceRentalFee", EmitDefaultValue = false)]
        public string ChildNamespaceRentalFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NamespaceNetworkPropertiesDTO {\n");
            sb.Append("  MaxNameSize: ").Append(MaxNameSize).Append("\n");
            sb.Append("  MaxChildNamespaces: ").Append(MaxChildNamespaces).Append("\n");
            sb.Append("  MaxNamespaceDepth: ").Append(MaxNamespaceDepth).Append("\n");
            sb.Append("  MinNamespaceDuration: ").Append(MinNamespaceDuration).Append("\n");
            sb.Append("  MaxNamespaceDuration: ").Append(MaxNamespaceDuration).Append("\n");
            sb.Append("  NamespaceGracePeriodDuration: ").Append(NamespaceGracePeriodDuration).Append("\n");
            sb.Append("  ReservedRootNamespaceNames: ").Append(ReservedRootNamespaceNames).Append("\n");
            sb.Append("  NamespaceRentalFeeSinkAddress: ").Append(NamespaceRentalFeeSinkAddress).Append("\n");
            sb.Append("  RootNamespaceRentalFeePerBlock: ").Append(RootNamespaceRentalFeePerBlock).Append("\n");
            sb.Append("  ChildNamespaceRentalFee: ").Append(ChildNamespaceRentalFee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NamespaceNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if NamespaceNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceNetworkPropertiesDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxNameSize == input.MaxNameSize ||
                    (this.MaxNameSize != null &&
                    this.MaxNameSize.Equals(input.MaxNameSize))
                ) && 
                (
                    this.MaxChildNamespaces == input.MaxChildNamespaces ||
                    (this.MaxChildNamespaces != null &&
                    this.MaxChildNamespaces.Equals(input.MaxChildNamespaces))
                ) && 
                (
                    this.MaxNamespaceDepth == input.MaxNamespaceDepth ||
                    (this.MaxNamespaceDepth != null &&
                    this.MaxNamespaceDepth.Equals(input.MaxNamespaceDepth))
                ) && 
                (
                    this.MinNamespaceDuration == input.MinNamespaceDuration ||
                    (this.MinNamespaceDuration != null &&
                    this.MinNamespaceDuration.Equals(input.MinNamespaceDuration))
                ) && 
                (
                    this.MaxNamespaceDuration == input.MaxNamespaceDuration ||
                    (this.MaxNamespaceDuration != null &&
                    this.MaxNamespaceDuration.Equals(input.MaxNamespaceDuration))
                ) && 
                (
                    this.NamespaceGracePeriodDuration == input.NamespaceGracePeriodDuration ||
                    (this.NamespaceGracePeriodDuration != null &&
                    this.NamespaceGracePeriodDuration.Equals(input.NamespaceGracePeriodDuration))
                ) && 
                (
                    this.ReservedRootNamespaceNames == input.ReservedRootNamespaceNames ||
                    (this.ReservedRootNamespaceNames != null &&
                    this.ReservedRootNamespaceNames.Equals(input.ReservedRootNamespaceNames))
                ) && 
                (
                    this.NamespaceRentalFeeSinkAddress == input.NamespaceRentalFeeSinkAddress ||
                    (this.NamespaceRentalFeeSinkAddress != null &&
                    this.NamespaceRentalFeeSinkAddress.Equals(input.NamespaceRentalFeeSinkAddress))
                ) && 
                (
                    this.RootNamespaceRentalFeePerBlock == input.RootNamespaceRentalFeePerBlock ||
                    (this.RootNamespaceRentalFeePerBlock != null &&
                    this.RootNamespaceRentalFeePerBlock.Equals(input.RootNamespaceRentalFeePerBlock))
                ) && 
                (
                    this.ChildNamespaceRentalFee == input.ChildNamespaceRentalFee ||
                    (this.ChildNamespaceRentalFee != null &&
                    this.ChildNamespaceRentalFee.Equals(input.ChildNamespaceRentalFee))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MaxNameSize != null)
                {
                    hashCode = (hashCode * 59) + this.MaxNameSize.GetHashCode();
                }
                if (this.MaxChildNamespaces != null)
                {
                    hashCode = (hashCode * 59) + this.MaxChildNamespaces.GetHashCode();
                }
                if (this.MaxNamespaceDepth != null)
                {
                    hashCode = (hashCode * 59) + this.MaxNamespaceDepth.GetHashCode();
                }
                if (this.MinNamespaceDuration != null)
                {
                    hashCode = (hashCode * 59) + this.MinNamespaceDuration.GetHashCode();
                }
                if (this.MaxNamespaceDuration != null)
                {
                    hashCode = (hashCode * 59) + this.MaxNamespaceDuration.GetHashCode();
                }
                if (this.NamespaceGracePeriodDuration != null)
                {
                    hashCode = (hashCode * 59) + this.NamespaceGracePeriodDuration.GetHashCode();
                }
                if (this.ReservedRootNamespaceNames != null)
                {
                    hashCode = (hashCode * 59) + this.ReservedRootNamespaceNames.GetHashCode();
                }
                if (this.NamespaceRentalFeeSinkAddress != null)
                {
                    hashCode = (hashCode * 59) + this.NamespaceRentalFeeSinkAddress.GetHashCode();
                }
                if (this.RootNamespaceRentalFeePerBlock != null)
                {
                    hashCode = (hashCode * 59) + this.RootNamespaceRentalFeePerBlock.GetHashCode();
                }
                if (this.ChildNamespaceRentalFee != null)
                {
                    hashCode = (hashCode * 59) + this.ChildNamespaceRentalFee.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
