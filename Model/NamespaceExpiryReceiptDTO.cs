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
    /// Receipt stored when a namespace expires.
    /// </summary>
    [DataContract(Name = "NamespaceExpiryReceiptDTO")]
    public partial class NamespaceExpiryReceiptDTO : IEquatable<NamespaceExpiryReceiptDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ReceiptTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamespaceExpiryReceiptDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTO" /> class.
        /// </summary>
        /// <param name="version">Version of the receipt. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="artifactId">Namespace identifier. (required).</param>
        public NamespaceExpiryReceiptDTO(int version = default(int), ReceiptTypeEnum type = default(ReceiptTypeEnum), string artifactId = default(string))
        {
            this._Version = version;
            this.Type = type;
            // to ensure "artifactId" is required (not null)
            if (artifactId == null)
            {
                throw new ArgumentNullException("artifactId is a required property for NamespaceExpiryReceiptDTO and cannot be null");
            }
            this.ArtifactId = artifactId;
        }

        /// <summary>
        /// Version of the receipt.
        /// </summary>
        /// <value>Version of the receipt.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        /// <example>&quot;85BBEA6CC462B244&quot;</example>
        [DataMember(Name = "artifactId", IsRequired = true, EmitDefaultValue = true)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NamespaceExpiryReceiptDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as NamespaceExpiryReceiptDTO);
        }

        /// <summary>
        /// Returns true if NamespaceExpiryReceiptDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceExpiryReceiptDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceExpiryReceiptDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
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
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
