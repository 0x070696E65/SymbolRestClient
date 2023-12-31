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
    /// EmbeddedAccountOperationRestrictionTransactionDTO
    /// </summary>
    [DataContract(Name = "EmbeddedAccountOperationRestrictionTransactionDTO")]
    public partial class EmbeddedAccountOperationRestrictionTransactionDTO : IEquatable<EmbeddedAccountOperationRestrictionTransactionDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public NetworkTypeEnum Network { get; set; }

        /// <summary>
        /// Gets or Sets RestrictionFlags
        /// </summary>
        [DataMember(Name = "restrictionFlags", IsRequired = true, EmitDefaultValue = true)]
        public AccountRestrictionFlagsEnum RestrictionFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountOperationRestrictionTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedAccountOperationRestrictionTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountOperationRestrictionTransactionDTO" /> class.
        /// </summary>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="restrictionFlags">restrictionFlags (required).</param>
        /// <param name="restrictionAdditions">Account restriction additions..</param>
        /// <param name="restrictionDeletions">Account restriction deletions..</param>
        public EmbeddedAccountOperationRestrictionTransactionDTO(string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), AccountRestrictionFlagsEnum restrictionFlags = default(AccountRestrictionFlagsEnum), List<TransactionTypeEnum> restrictionAdditions = default(List<TransactionTypeEnum>), List<TransactionTypeEnum> restrictionDeletions = default(List<TransactionTypeEnum>))
        {
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new ArgumentNullException("signerPublicKey is a required property for EmbeddedAccountOperationRestrictionTransactionDTO and cannot be null");
            }
            this.SignerPublicKey = signerPublicKey;
            this._Version = version;
            this.Network = network;
            this.Type = type;
            this.RestrictionFlags = restrictionFlags;
            this.RestrictionAdditions = restrictionAdditions;
            this.RestrictionDeletions = restrictionDeletions;
        }

        /// <summary>
        /// Public key.
        /// </summary>
        /// <value>Public key.</value>
        /// <example>&quot;AC1A6E1D8DE5B17D2C6B1293F1CAD3829EEACF38D09311BB3C8E5A880092DE26&quot;</example>
        [DataMember(Name = "signerPublicKey", IsRequired = true, EmitDefaultValue = true)]
        public string SignerPublicKey { get; set; }

        /// <summary>
        /// Entity version.
        /// </summary>
        /// <value>Entity version.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public int Type { get; set; }

        /// <summary>
        /// Account restriction additions.
        /// </summary>
        /// <value>Account restriction additions.</value>
        [DataMember(Name = "restrictionAdditions", EmitDefaultValue = false)]
        public List<TransactionTypeEnum> RestrictionAdditions { get; set; }

        /// <summary>
        /// Account restriction deletions.
        /// </summary>
        /// <value>Account restriction deletions.</value>
        [DataMember(Name = "restrictionDeletions", EmitDefaultValue = false)]
        public List<TransactionTypeEnum> RestrictionDeletions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedAccountOperationRestrictionTransactionDTO {\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RestrictionFlags: ").Append(RestrictionFlags).Append("\n");
            sb.Append("  RestrictionAdditions: ").Append(RestrictionAdditions).Append("\n");
            sb.Append("  RestrictionDeletions: ").Append(RestrictionDeletions).Append("\n");
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
            return this.Equals(input as EmbeddedAccountOperationRestrictionTransactionDTO);
        }

        /// <summary>
        /// Returns true if EmbeddedAccountOperationRestrictionTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedAccountOperationRestrictionTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedAccountOperationRestrictionTransactionDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignerPublicKey == input.SignerPublicKey ||
                    (this.SignerPublicKey != null &&
                    this.SignerPublicKey.Equals(input.SignerPublicKey))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.RestrictionFlags == input.RestrictionFlags ||
                    this.RestrictionFlags.Equals(input.RestrictionFlags)
                ) && 
                (
                    this.RestrictionAdditions == input.RestrictionAdditions ||
                    this.RestrictionAdditions != null &&
                    input.RestrictionAdditions != null &&
                    this.RestrictionAdditions.SequenceEqual(input.RestrictionAdditions)
                ) && 
                (
                    this.RestrictionDeletions == input.RestrictionDeletions ||
                    this.RestrictionDeletions != null &&
                    input.RestrictionDeletions != null &&
                    this.RestrictionDeletions.SequenceEqual(input.RestrictionDeletions)
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
                if (this.SignerPublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.SignerPublicKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.RestrictionFlags.GetHashCode();
                if (this.RestrictionAdditions != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictionAdditions.GetHashCode();
                }
                if (this.RestrictionDeletions != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictionDeletions.GetHashCode();
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
