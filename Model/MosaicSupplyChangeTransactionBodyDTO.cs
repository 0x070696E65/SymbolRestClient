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
    /// MosaicSupplyChangeTransactionBodyDTO
    /// </summary>
    [DataContract(Name = "MosaicSupplyChangeTransactionBodyDTO")]
    public partial class MosaicSupplyChangeTransactionBodyDTO : IEquatable<MosaicSupplyChangeTransactionBodyDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public MosaicSupplyChangeActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicSupplyChangeTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicSupplyChangeTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicSupplyChangeTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="mosaicId">Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier.  (required).</param>
        /// <param name="delta">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="action">action (required).</param>
        public MosaicSupplyChangeTransactionBodyDTO(string mosaicId = default(string), string delta = default(string), MosaicSupplyChangeActionEnum action = default(MosaicSupplyChangeActionEnum))
        {
            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new ArgumentNullException("mosaicId is a required property for MosaicSupplyChangeTransactionBodyDTO and cannot be null");
            }
            this.MosaicId = mosaicId;
            // to ensure "delta" is required (not null)
            if (delta == null)
            {
                throw new ArgumentNullException("delta is a required property for MosaicSupplyChangeTransactionBodyDTO and cannot be null");
            }
            this.Delta = delta;
            this.Action = action;
        }

        /// <summary>
        /// Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. 
        /// </summary>
        /// <value>Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. </value>
        /// <example>&quot;85BBEA6CC462B244&quot;</example>
        [DataMember(Name = "mosaicId", IsRequired = true, EmitDefaultValue = true)]
        public string MosaicId { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        /// <example>&quot;123456&quot;</example>
        [DataMember(Name = "delta", IsRequired = true, EmitDefaultValue = true)]
        public string Delta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MosaicSupplyChangeTransactionBodyDTO {\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as MosaicSupplyChangeTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if MosaicSupplyChangeTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicSupplyChangeTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicSupplyChangeTransactionBodyDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MosaicId == input.MosaicId ||
                    (this.MosaicId != null &&
                    this.MosaicId.Equals(input.MosaicId))
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                if (this.MosaicId != null)
                {
                    hashCode = (hashCode * 59) + this.MosaicId.GetHashCode();
                }
                if (this.Delta != null)
                {
                    hashCode = (hashCode * 59) + this.Delta.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
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
