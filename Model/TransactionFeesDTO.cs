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
    /// TransactionFeesDTO
    /// </summary>
    [DataContract(Name = "TransactionFeesDTO")]
    public partial class TransactionFeesDTO : IEquatable<TransactionFeesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFeesDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionFeesDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFeesDTO" /> class.
        /// </summary>
        /// <param name="averageFeeMultiplier">Fee multiplier applied to transactions contained in block. (required).</param>
        /// <param name="medianFeeMultiplier">Fee multiplier applied to transactions contained in block. (required).</param>
        /// <param name="highestFeeMultiplier">Fee multiplier applied to transactions contained in block. (required).</param>
        /// <param name="lowestFeeMultiplier">Fee multiplier applied to transactions contained in block. (required).</param>
        /// <param name="minFeeMultiplier">Fee multiplier applied to transactions contained in block. (required).</param>
        public TransactionFeesDTO(long averageFeeMultiplier = default(long), long medianFeeMultiplier = default(long), long highestFeeMultiplier = default(long), long lowestFeeMultiplier = default(long), long minFeeMultiplier = default(long))
        {
            this.AverageFeeMultiplier = averageFeeMultiplier;
            this.MedianFeeMultiplier = medianFeeMultiplier;
            this.HighestFeeMultiplier = highestFeeMultiplier;
            this.LowestFeeMultiplier = lowestFeeMultiplier;
            this.MinFeeMultiplier = minFeeMultiplier;
        }

        /// <summary>
        /// Fee multiplier applied to transactions contained in block.
        /// </summary>
        /// <value>Fee multiplier applied to transactions contained in block.</value>
        /// <example>0</example>
        [DataMember(Name = "averageFeeMultiplier", IsRequired = true, EmitDefaultValue = true)]
        public long AverageFeeMultiplier { get; set; }

        /// <summary>
        /// Fee multiplier applied to transactions contained in block.
        /// </summary>
        /// <value>Fee multiplier applied to transactions contained in block.</value>
        /// <example>0</example>
        [DataMember(Name = "medianFeeMultiplier", IsRequired = true, EmitDefaultValue = true)]
        public long MedianFeeMultiplier { get; set; }

        /// <summary>
        /// Fee multiplier applied to transactions contained in block.
        /// </summary>
        /// <value>Fee multiplier applied to transactions contained in block.</value>
        /// <example>0</example>
        [DataMember(Name = "highestFeeMultiplier", IsRequired = true, EmitDefaultValue = true)]
        public long HighestFeeMultiplier { get; set; }

        /// <summary>
        /// Fee multiplier applied to transactions contained in block.
        /// </summary>
        /// <value>Fee multiplier applied to transactions contained in block.</value>
        /// <example>0</example>
        [DataMember(Name = "lowestFeeMultiplier", IsRequired = true, EmitDefaultValue = true)]
        public long LowestFeeMultiplier { get; set; }

        /// <summary>
        /// Fee multiplier applied to transactions contained in block.
        /// </summary>
        /// <value>Fee multiplier applied to transactions contained in block.</value>
        /// <example>0</example>
        [DataMember(Name = "minFeeMultiplier", IsRequired = true, EmitDefaultValue = true)]
        public long MinFeeMultiplier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionFeesDTO {\n");
            sb.Append("  AverageFeeMultiplier: ").Append(AverageFeeMultiplier).Append("\n");
            sb.Append("  MedianFeeMultiplier: ").Append(MedianFeeMultiplier).Append("\n");
            sb.Append("  HighestFeeMultiplier: ").Append(HighestFeeMultiplier).Append("\n");
            sb.Append("  LowestFeeMultiplier: ").Append(LowestFeeMultiplier).Append("\n");
            sb.Append("  MinFeeMultiplier: ").Append(MinFeeMultiplier).Append("\n");
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
            return this.Equals(input as TransactionFeesDTO);
        }

        /// <summary>
        /// Returns true if TransactionFeesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionFeesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionFeesDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AverageFeeMultiplier == input.AverageFeeMultiplier ||
                    this.AverageFeeMultiplier.Equals(input.AverageFeeMultiplier)
                ) && 
                (
                    this.MedianFeeMultiplier == input.MedianFeeMultiplier ||
                    this.MedianFeeMultiplier.Equals(input.MedianFeeMultiplier)
                ) && 
                (
                    this.HighestFeeMultiplier == input.HighestFeeMultiplier ||
                    this.HighestFeeMultiplier.Equals(input.HighestFeeMultiplier)
                ) && 
                (
                    this.LowestFeeMultiplier == input.LowestFeeMultiplier ||
                    this.LowestFeeMultiplier.Equals(input.LowestFeeMultiplier)
                ) && 
                (
                    this.MinFeeMultiplier == input.MinFeeMultiplier ||
                    this.MinFeeMultiplier.Equals(input.MinFeeMultiplier)
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
                hashCode = (hashCode * 59) + this.AverageFeeMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.MedianFeeMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.HighestFeeMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.LowestFeeMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.MinFeeMultiplier.GetHashCode();
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
