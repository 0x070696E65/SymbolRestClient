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
    /// UnlockedAccountDTO
    /// </summary>
    [DataContract(Name = "UnlockedAccountDTO")]
    public partial class UnlockedAccountDTO : IEquatable<UnlockedAccountDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockedAccountDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnlockedAccountDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockedAccountDTO" /> class.
        /// </summary>
        /// <param name="unlockedAccount">unlockedAccount (required).</param>
        public UnlockedAccountDTO(List<string> unlockedAccount = default(List<string>))
        {
            // to ensure "unlockedAccount" is required (not null)
            if (unlockedAccount == null)
            {
                throw new ArgumentNullException("unlockedAccount is a required property for UnlockedAccountDTO and cannot be null");
            }
            this.UnlockedAccount = unlockedAccount;
        }

        /// <summary>
        /// Gets or Sets UnlockedAccount
        /// </summary>
        [DataMember(Name = "unlockedAccount", IsRequired = true, EmitDefaultValue = true)]
        public List<string> UnlockedAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnlockedAccountDTO {\n");
            sb.Append("  UnlockedAccount: ").Append(UnlockedAccount).Append("\n");
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
            return this.Equals(input as UnlockedAccountDTO);
        }

        /// <summary>
        /// Returns true if UnlockedAccountDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UnlockedAccountDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnlockedAccountDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnlockedAccount == input.UnlockedAccount ||
                    this.UnlockedAccount != null &&
                    input.UnlockedAccount != null &&
                    this.UnlockedAccount.SequenceEqual(input.UnlockedAccount)
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
                if (this.UnlockedAccount != null)
                {
                    hashCode = (hashCode * 59) + this.UnlockedAccount.GetHashCode();
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
