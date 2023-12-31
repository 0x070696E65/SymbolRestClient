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
    /// SecretLockNetworkPropertiesDTO
    /// </summary>
    [DataContract(Name = "SecretLockNetworkPropertiesDTO")]
    public partial class SecretLockNetworkPropertiesDTO : IEquatable<SecretLockNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="maxSecretLockDuration">Maximum number of blocks for which a secret lock can exist..</param>
        /// <param name="minProofSize">Minimum size of a proof in bytes..</param>
        /// <param name="maxProofSize">Maximum size of a proof in bytes..</param>
        public SecretLockNetworkPropertiesDTO(string maxSecretLockDuration = default(string), string minProofSize = default(string), string maxProofSize = default(string))
        {
            this.MaxSecretLockDuration = maxSecretLockDuration;
            this.MinProofSize = minProofSize;
            this.MaxProofSize = maxProofSize;
        }

        /// <summary>
        /// Maximum number of blocks for which a secret lock can exist.
        /// </summary>
        /// <value>Maximum number of blocks for which a secret lock can exist.</value>
        /// <example>&quot;30d&quot;</example>
        [DataMember(Name = "maxSecretLockDuration", EmitDefaultValue = false)]
        public string MaxSecretLockDuration { get; set; }

        /// <summary>
        /// Minimum size of a proof in bytes.
        /// </summary>
        /// <value>Minimum size of a proof in bytes.</value>
        /// <example>&quot;1&quot;</example>
        [DataMember(Name = "minProofSize", EmitDefaultValue = false)]
        public string MinProofSize { get; set; }

        /// <summary>
        /// Maximum size of a proof in bytes.
        /// </summary>
        /// <value>Maximum size of a proof in bytes.</value>
        /// <example>&quot;1000&quot;</example>
        [DataMember(Name = "maxProofSize", EmitDefaultValue = false)]
        public string MaxProofSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecretLockNetworkPropertiesDTO {\n");
            sb.Append("  MaxSecretLockDuration: ").Append(MaxSecretLockDuration).Append("\n");
            sb.Append("  MinProofSize: ").Append(MinProofSize).Append("\n");
            sb.Append("  MaxProofSize: ").Append(MaxProofSize).Append("\n");
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
            return this.Equals(input as SecretLockNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if SecretLockNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretLockNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretLockNetworkPropertiesDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxSecretLockDuration == input.MaxSecretLockDuration ||
                    (this.MaxSecretLockDuration != null &&
                    this.MaxSecretLockDuration.Equals(input.MaxSecretLockDuration))
                ) && 
                (
                    this.MinProofSize == input.MinProofSize ||
                    (this.MinProofSize != null &&
                    this.MinProofSize.Equals(input.MinProofSize))
                ) && 
                (
                    this.MaxProofSize == input.MaxProofSize ||
                    (this.MaxProofSize != null &&
                    this.MaxProofSize.Equals(input.MaxProofSize))
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
                if (this.MaxSecretLockDuration != null)
                {
                    hashCode = (hashCode * 59) + this.MaxSecretLockDuration.GetHashCode();
                }
                if (this.MinProofSize != null)
                {
                    hashCode = (hashCode * 59) + this.MinProofSize.GetHashCode();
                }
                if (this.MaxProofSize != null)
                {
                    hashCode = (hashCode * 59) + this.MaxProofSize.GetHashCode();
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
