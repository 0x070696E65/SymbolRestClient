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
    /// AccountsNamesDTO
    /// </summary>
    [DataContract(Name = "AccountsNamesDTO")]
    public partial class AccountsNamesDTO : IEquatable<AccountsNamesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsNamesDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountsNamesDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsNamesDTO" /> class.
        /// </summary>
        /// <param name="accountNames">Array of account names. (required).</param>
        public AccountsNamesDTO(List<AccountNamesDTO> accountNames = default(List<AccountNamesDTO>))
        {
            // to ensure "accountNames" is required (not null)
            if (accountNames == null)
            {
                throw new ArgumentNullException("accountNames is a required property for AccountsNamesDTO and cannot be null");
            }
            this.AccountNames = accountNames;
        }

        /// <summary>
        /// Array of account names.
        /// </summary>
        /// <value>Array of account names.</value>
        [DataMember(Name = "accountNames", IsRequired = true, EmitDefaultValue = true)]
        public List<AccountNamesDTO> AccountNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountsNamesDTO {\n");
            sb.Append("  AccountNames: ").Append(AccountNames).Append("\n");
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
            return this.Equals(input as AccountsNamesDTO);
        }

        /// <summary>
        /// Returns true if AccountsNamesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsNamesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsNamesDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNames == input.AccountNames ||
                    this.AccountNames != null &&
                    input.AccountNames != null &&
                    this.AccountNames.SequenceEqual(input.AccountNames)
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
                if (this.AccountNames != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNames.GetHashCode();
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
