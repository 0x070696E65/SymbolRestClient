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
    /// EmbeddedAccountMetadataTransactionDTO
    /// </summary>
    [DataContract(Name = "EmbeddedAccountMetadataTransactionDTO")]
    public partial class EmbeddedAccountMetadataTransactionDTO : IEquatable<EmbeddedAccountMetadataTransactionDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountMetadataTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedAccountMetadataTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountMetadataTransactionDTO" /> class.
        /// </summary>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="targetAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="scopedMetadataKey">Metadata key scoped to source, target and type expressed. (required).</param>
        /// <param name="valueSizeDelta">Change in value size in bytes. (required).</param>
        /// <param name="valueSize">A number that allows uint 32 values. (required).</param>
        /// <param name="value">Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value). (required).</param>
        public EmbeddedAccountMetadataTransactionDTO(string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string targetAddress = default(string), string scopedMetadataKey = default(string), int valueSizeDelta = default(int), long valueSize = default(long), string value = default(string))
        {
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new ArgumentNullException("signerPublicKey is a required property for EmbeddedAccountMetadataTransactionDTO and cannot be null");
            }
            this.SignerPublicKey = signerPublicKey;
            this._Version = version;
            this.Network = network;
            this.Type = type;
            // to ensure "targetAddress" is required (not null)
            if (targetAddress == null)
            {
                throw new ArgumentNullException("targetAddress is a required property for EmbeddedAccountMetadataTransactionDTO and cannot be null");
            }
            this.TargetAddress = targetAddress;
            // to ensure "scopedMetadataKey" is required (not null)
            if (scopedMetadataKey == null)
            {
                throw new ArgumentNullException("scopedMetadataKey is a required property for EmbeddedAccountMetadataTransactionDTO and cannot be null");
            }
            this.ScopedMetadataKey = scopedMetadataKey;
            this.ValueSizeDelta = valueSizeDelta;
            this.ValueSize = valueSize;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for EmbeddedAccountMetadataTransactionDTO and cannot be null");
            }
            this.Value = value;
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
        /// Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA 
        /// </summary>
        /// <value>Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA </value>
        /// <example>&quot;TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA&quot;</example>
        [DataMember(Name = "targetAddress", IsRequired = true, EmitDefaultValue = true)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Metadata key scoped to source, target and type expressed.
        /// </summary>
        /// <value>Metadata key scoped to source, target and type expressed.</value>
        /// <example>&quot;0DC67FBE1CAD29E3&quot;</example>
        [DataMember(Name = "scopedMetadataKey", IsRequired = true, EmitDefaultValue = true)]
        public string ScopedMetadataKey { get; set; }

        /// <summary>
        /// Change in value size in bytes.
        /// </summary>
        /// <value>Change in value size in bytes.</value>
        [DataMember(Name = "valueSizeDelta", IsRequired = true, EmitDefaultValue = true)]
        public int ValueSizeDelta { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        /// <example>2222212828</example>
        [DataMember(Name = "valueSize", IsRequired = true, EmitDefaultValue = true)]
        public long ValueSize { get; set; }

        /// <summary>
        /// Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value).
        /// </summary>
        /// <value>Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value).</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedAccountMetadataTransactionDTO {\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
            sb.Append("  ScopedMetadataKey: ").Append(ScopedMetadataKey).Append("\n");
            sb.Append("  ValueSizeDelta: ").Append(ValueSizeDelta).Append("\n");
            sb.Append("  ValueSize: ").Append(ValueSize).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as EmbeddedAccountMetadataTransactionDTO);
        }

        /// <summary>
        /// Returns true if EmbeddedAccountMetadataTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedAccountMetadataTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedAccountMetadataTransactionDTO input)
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
                    this.TargetAddress == input.TargetAddress ||
                    (this.TargetAddress != null &&
                    this.TargetAddress.Equals(input.TargetAddress))
                ) && 
                (
                    this.ScopedMetadataKey == input.ScopedMetadataKey ||
                    (this.ScopedMetadataKey != null &&
                    this.ScopedMetadataKey.Equals(input.ScopedMetadataKey))
                ) && 
                (
                    this.ValueSizeDelta == input.ValueSizeDelta ||
                    this.ValueSizeDelta.Equals(input.ValueSizeDelta)
                ) && 
                (
                    this.ValueSize == input.ValueSize ||
                    this.ValueSize.Equals(input.ValueSize)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.TargetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAddress.GetHashCode();
                }
                if (this.ScopedMetadataKey != null)
                {
                    hashCode = (hashCode * 59) + this.ScopedMetadataKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueSizeDelta.GetHashCode();
                hashCode = (hashCode * 59) + this.ValueSize.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
