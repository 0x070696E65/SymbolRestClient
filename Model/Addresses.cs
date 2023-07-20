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
    /// Addresses
    /// </summary>
    [DataContract(Name = "addresses")]
    public partial class Addresses : IEquatable<Addresses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Addresses" /> class.
        /// </summary>
        /// <param name="addresses">Array of addresses..</param>
        public Addresses(List<string> addresses = default(List<string>))
        {
            this._Addresses = addresses;
        }

        /// <summary>
        /// Array of addresses.
        /// </summary>
        /// <value>Array of addresses.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<string> _Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Addresses {\n");
            sb.Append("  _Addresses: ").Append(_Addresses).Append("\n");
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
            return this.Equals(input as Addresses);
        }

        /// <summary>
        /// Returns true if Addresses instances are equal
        /// </summary>
        /// <param name="input">Instance of Addresses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Addresses input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Addresses == input._Addresses ||
                    this._Addresses != null &&
                    input._Addresses != null &&
                    this._Addresses.SequenceEqual(input._Addresses)
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
                if (this._Addresses != null)
                {
                    hashCode = (hashCode * 59) + this._Addresses.GetHashCode();
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
