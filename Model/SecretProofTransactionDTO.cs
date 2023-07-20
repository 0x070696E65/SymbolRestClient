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
    /// Transaction to reveal a proof.
    /// </summary>
    [DataContract(Name = "SecretProofTransactionDTO")]
    public partial class SecretProofTransactionDTO : IEquatable<SecretProofTransactionDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public NetworkTypeEnum Network { get; set; }

        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name = "hashAlgorithm", IsRequired = true, EmitDefaultValue = true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProofTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretProofTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProofTransactionDTO" /> class.
        /// </summary>
        /// <param name="size">A number that allows uint 32 values. (required).</param>
        /// <param name="signature">Entity&#39;s signature generated by the signer. (required).</param>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="maxFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="recipientAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="secret">secret (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        /// <param name="proof">Original random set of bytes. (required).</param>
        public SecretProofTransactionDTO(long size = default(long), string signature = default(string), string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string maxFee = default(string), string deadline = default(string), string recipientAddress = default(string), string secret = default(string), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum), string proof = default(string))
        {
            this.Size = size;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.Signature = signature;
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new ArgumentNullException("signerPublicKey is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.SignerPublicKey = signerPublicKey;
            this._Version = version;
            this.Network = network;
            this.Type = type;
            // to ensure "maxFee" is required (not null)
            if (maxFee == null)
            {
                throw new ArgumentNullException("maxFee is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.MaxFee = maxFee;
            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new ArgumentNullException("deadline is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.Deadline = deadline;
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new ArgumentNullException("recipientAddress is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.RecipientAddress = recipientAddress;
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new ArgumentNullException("secret is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.Secret = secret;
            this.HashAlgorithm = hashAlgorithm;
            // to ensure "proof" is required (not null)
            if (proof == null)
            {
                throw new ArgumentNullException("proof is a required property for SecretProofTransactionDTO and cannot be null");
            }
            this.Proof = proof;
        }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        /// <example>2222212828</example>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public long Size { get; set; }

        /// <summary>
        /// Entity&#39;s signature generated by the signer.
        /// </summary>
        /// <value>Entity&#39;s signature generated by the signer.</value>
        /// <example>&quot;4B408BBEDF25F2AC8E0E44A6E51E3CCBA03885902055F75EB9FF50433532CA44BF9175FDA7502EEE2FC1617126E453A2BD692BAFDAAF06BC8EDEBA7961B3730D&quot;</example>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public string Signature { get; set; }

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
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        /// <example>&quot;123456&quot;</example>
        [DataMember(Name = "maxFee", IsRequired = true, EmitDefaultValue = true)]
        public string MaxFee { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        /// <example>&quot;200&quot;</example>
        [DataMember(Name = "deadline", IsRequired = true, EmitDefaultValue = true)]
        public string Deadline { get; set; }

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
            sb.Append("class SecretProofTransactionDTO {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
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
            return this.Equals(input as SecretProofTransactionDTO);
        }

        /// <summary>
        /// Returns true if SecretProofTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretProofTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretProofTransactionDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
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
                    this.MaxFee == input.MaxFee ||
                    (this.MaxFee != null &&
                    this.MaxFee.Equals(input.MaxFee))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
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
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.SignerPublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.SignerPublicKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.MaxFee != null)
                {
                    hashCode = (hashCode * 59) + this.MaxFee.GetHashCode();
                }
                if (this.Deadline != null)
                {
                    hashCode = (hashCode * 59) + this.Deadline.GetHashCode();
                }
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
