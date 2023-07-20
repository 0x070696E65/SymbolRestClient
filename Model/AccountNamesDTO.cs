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
    /// AccountNamesDTO
    /// </summary>
    [DataContract(Name = "AccountNamesDTO")]
    public partial class AccountNamesDTO : IEquatable<AccountNamesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNamesDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountNamesDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNamesDTO" /> class.
        /// </summary>
        /// <param name="address">Address encoded using a 32-character set. (required).</param>
        /// <param name="names">Account linked namespace names. (required).</param>
        public AccountNamesDTO(string address = default(string), List<string> names = default(List<string>))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for AccountNamesDTO and cannot be null");
            }
            this.Address = address;
            // to ensure "names" is required (not null)
            if (names == null)
            {
                throw new ArgumentNullException("names is a required property for AccountNamesDTO and cannot be null");
            }
            this.Names = names;
        }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        /// <example>&quot;TADP6C2GVEG654OP5LZI32P2GYJSCMEGQBYB7QY&quot;</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Account linked namespace names.
        /// </summary>
        /// <value>Account linked namespace names.</value>
        [DataMember(Name = "names", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountNamesDTO {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
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
            return this.Equals(input as AccountNamesDTO);
        }

        /// <summary>
        /// Returns true if AccountNamesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountNamesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountNamesDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    input.Names != null &&
                    this.Names.SequenceEqual(input.Names)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Names != null)
                {
                    hashCode = (hashCode * 59) + this.Names.GetHashCode();
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
