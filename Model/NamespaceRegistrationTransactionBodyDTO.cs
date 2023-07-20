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
    /// NamespaceRegistrationTransactionBodyDTO
    /// </summary>
    [DataContract(Name = "NamespaceRegistrationTransactionBodyDTO")]
    public partial class NamespaceRegistrationTransactionBodyDTO : IEquatable<NamespaceRegistrationTransactionBodyDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RegistrationType
        /// </summary>
        [DataMember(Name = "registrationType", IsRequired = true, EmitDefaultValue = true)]
        public NamespaceRegistrationTypeEnum RegistrationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceRegistrationTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamespaceRegistrationTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceRegistrationTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="duration">Duration expressed in number of blocks..</param>
        /// <param name="parentId">Namespace identifier..</param>
        /// <param name="id">Namespace identifier. (required).</param>
        /// <param name="registrationType">registrationType (required).</param>
        /// <param name="name">Namespace name. (required).</param>
        public NamespaceRegistrationTransactionBodyDTO(string duration = default(string), string parentId = default(string), string id = default(string), NamespaceRegistrationTypeEnum registrationType = default(NamespaceRegistrationTypeEnum), string name = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for NamespaceRegistrationTransactionBodyDTO and cannot be null");
            }
            this.Id = id;
            this.RegistrationType = registrationType;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for NamespaceRegistrationTransactionBodyDTO and cannot be null");
            }
            this.Name = name;
            this.Duration = duration;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        /// <example>&quot;200&quot;</example>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        /// <example>&quot;85BBEA6CC462B244&quot;</example>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        /// <example>&quot;85BBEA6CC462B244&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Namespace name.
        /// </summary>
        /// <value>Namespace name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NamespaceRegistrationTransactionBodyDTO {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RegistrationType: ").Append(RegistrationType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as NamespaceRegistrationTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if NamespaceRegistrationTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceRegistrationTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceRegistrationTransactionBodyDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RegistrationType == input.RegistrationType ||
                    this.RegistrationType.Equals(input.RegistrationType)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RegistrationType.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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