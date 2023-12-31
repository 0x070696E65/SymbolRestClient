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
    /// MosaicExpiryReceiptDTOAllOf
    /// </summary>
    [DataContract(Name = "MosaicExpiryReceiptDTO_allOf")]
    public partial class MosaicExpiryReceiptDTOAllOf : IEquatable<MosaicExpiryReceiptDTOAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicExpiryReceiptDTOAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicExpiryReceiptDTOAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicExpiryReceiptDTOAllOf" /> class.
        /// </summary>
        /// <param name="artifactId">Mosaic identifier. (required).</param>
        public MosaicExpiryReceiptDTOAllOf(string artifactId = default(string))
        {
            // to ensure "artifactId" is required (not null)
            if (artifactId == null)
            {
                throw new ArgumentNullException("artifactId is a required property for MosaicExpiryReceiptDTOAllOf and cannot be null");
            }
            this.ArtifactId = artifactId;
        }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        /// <example>&quot;0DC67FBE1CAD29E3&quot;</example>
        [DataMember(Name = "artifactId", IsRequired = true, EmitDefaultValue = true)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MosaicExpiryReceiptDTOAllOf {\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
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
            return this.Equals(input as MosaicExpiryReceiptDTOAllOf);
        }

        /// <summary>
        /// Returns true if MosaicExpiryReceiptDTOAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicExpiryReceiptDTOAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicExpiryReceiptDTOAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArtifactId == input.ArtifactId ||
                    (this.ArtifactId != null &&
                    this.ArtifactId.Equals(input.ArtifactId))
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
                if (this.ArtifactId != null)
                {
                    hashCode = (hashCode * 59) + this.ArtifactId.GetHashCode();
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
