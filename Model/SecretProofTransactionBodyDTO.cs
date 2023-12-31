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
    /// SecretProofTransactionBodyDTO
    /// </summary>
    [DataContract(Name = "SecretProofTransactionBodyDTO")]
    public partial class SecretProofTransactionBodyDTO : IEquatable<SecretProofTransactionBodyDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name = "hashAlgorithm", IsRequired = true, EmitDefaultValue = true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProofTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretProofTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProofTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="recipientAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="secret">secret (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        /// <param name="proof">Original random set of bytes. (required).</param>
        public SecretProofTransactionBodyDTO(string recipientAddress = default(string), string secret = default(string), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum), string proof = default(string))
        {
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new ArgumentNullException("recipientAddress is a required property for SecretProofTransactionBodyDTO and cannot be null");
            }
            this.RecipientAddress = recipientAddress;
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new ArgumentNullException("secret is a required property for SecretProofTransactionBodyDTO and cannot be null");
            }
            this.Secret = secret;
            this.HashAlgorithm = hashAlgorithm;
            // to ensure "proof" is required (not null)
            if (proof == null)
            {
                throw new ArgumentNullException("proof is a required property for SecretProofTransactionBodyDTO and cannot be null");
            }
            this.Proof = proof;
        }

        /// <summary>
        /// Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA 
        /// </summary>
        /// <value>Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA </value>
        /// <example>&quot;TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA&quot;</example>
        [DataMember(Name = "recipientAddress", IsRequired = true, EmitDefaultValue = true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "secret", IsRequired = true, EmitDefaultValue = true)]
        public string Secret { get; set; }

        /// <summary>
        /// Original random set of bytes.
        /// </summary>
        /// <value>Original random set of bytes.</value>
        [DataMember(Name = "proof", IsRequired = true, EmitDefaultValue = true)]
        public string Proof { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecretProofTransactionBodyDTO {\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
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
            return this.Equals(input as SecretProofTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if SecretProofTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretProofTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretProofTransactionBodyDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    this.HashAlgorithm.Equals(input.HashAlgorithm)
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
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
                if (this.RecipientAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientAddress.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HashAlgorithm.GetHashCode();
                if (this.Proof != null)
                {
                    hashCode = (hashCode * 59) + this.Proof.GetHashCode();
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
