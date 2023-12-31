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
    /// ResolutionEntryDTO
    /// </summary>
    [DataContract(Name = "ResolutionEntryDTO")]
    public partial class ResolutionEntryDTO : IEquatable<ResolutionEntryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionEntryDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResolutionEntryDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionEntryDTO" /> class.
        /// </summary>
        /// <param name="source">source (required).</param>
        /// <param name="resolved">resolved (required).</param>
        public ResolutionEntryDTO(SourceDTO source = default(SourceDTO), ResolutionEntryDTOResolved resolved = default(ResolutionEntryDTOResolved))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for ResolutionEntryDTO and cannot be null");
            }
            this.Source = source;
            // to ensure "resolved" is required (not null)
            if (resolved == null)
            {
                throw new ArgumentNullException("resolved is a required property for ResolutionEntryDTO and cannot be null");
            }
            this.Resolved = resolved;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public SourceDTO Source { get; set; }

        /// <summary>
        /// Gets or Sets Resolved
        /// </summary>
        [DataMember(Name = "resolved", IsRequired = true, EmitDefaultValue = true)]
        public ResolutionEntryDTOResolved Resolved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResolutionEntryDTO {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
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
            return this.Equals(input as ResolutionEntryDTO);
        }

        /// <summary>
        /// Returns true if ResolutionEntryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ResolutionEntryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResolutionEntryDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Resolved == input.Resolved ||
                    (this.Resolved != null &&
                    this.Resolved.Equals(input.Resolved))
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
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Resolved != null)
                {
                    hashCode = (hashCode * 59) + this.Resolved.GetHashCode();
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
