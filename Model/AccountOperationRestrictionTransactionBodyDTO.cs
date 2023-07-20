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
    /// AccountOperationRestrictionTransactionBodyDTO
    /// </summary>
    [DataContract(Name = "AccountOperationRestrictionTransactionBodyDTO")]
    public partial class AccountOperationRestrictionTransactionBodyDTO : IEquatable<AccountOperationRestrictionTransactionBodyDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RestrictionFlags
        /// </summary>
        [DataMember(Name = "restrictionFlags", IsRequired = true, EmitDefaultValue = true)]
        public AccountRestrictionFlagsEnum RestrictionFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountOperationRestrictionTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountOperationRestrictionTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountOperationRestrictionTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="restrictionFlags">restrictionFlags (required).</param>
        /// <param name="restrictionAdditions">Account restriction additions..</param>
        /// <param name="restrictionDeletions">Account restriction deletions..</param>
        public AccountOperationRestrictionTransactionBodyDTO(AccountRestrictionFlagsEnum restrictionFlags = default(AccountRestrictionFlagsEnum), List<TransactionTypeEnum> restrictionAdditions = default(List<TransactionTypeEnum>), List<TransactionTypeEnum> restrictionDeletions = default(List<TransactionTypeEnum>))
        {
            this.RestrictionFlags = restrictionFlags;
            this.RestrictionAdditions = restrictionAdditions;
            this.RestrictionDeletions = restrictionDeletions;
        }

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
            sb.Append("class AccountOperationRestrictionTransactionBodyDTO {\n");
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
            return this.Equals(input as AccountOperationRestrictionTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if AccountOperationRestrictionTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountOperationRestrictionTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountOperationRestrictionTransactionBodyDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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