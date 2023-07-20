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
    /// TransactionStatusDTO
    /// </summary>
    [DataContract(Name = "TransactionStatusDTO")]
    public partial class TransactionStatusDTO : IEquatable<TransactionStatusDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = true)]
        public TransactionGroupEnum Group { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public TransactionStatusEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionStatusDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusDTO" /> class.
        /// </summary>
        /// <param name="group">group (required).</param>
        /// <param name="code">code.</param>
        /// <param name="hash">hash (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="height">Height of the blockchain..</param>
        public TransactionStatusDTO(TransactionGroupEnum group = default(TransactionGroupEnum), TransactionStatusEnum? code = default(TransactionStatusEnum?), string hash = default(string), string deadline = default(string), string height = default(string))
        {
            this.Group = group;
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for TransactionStatusDTO and cannot be null");
            }
            this.Hash = hash;
            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new ArgumentNullException("deadline is a required property for TransactionStatusDTO and cannot be null");
            }
            this.Deadline = deadline;
            this.Code = code;
            this.Height = height;
        }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        /// <example>&quot;200&quot;</example>
        [DataMember(Name = "deadline", IsRequired = true, EmitDefaultValue = true)]
        public string Deadline { get; set; }

        /// <summary>
        /// Height of the blockchain.
        /// </summary>
        /// <value>Height of the blockchain.</value>
        /// <example>&quot;1&quot;</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public string Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionStatusDTO {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as TransactionStatusDTO);
        }

        /// <summary>
        /// Returns true if TransactionStatusDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionStatusDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionStatusDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Group == input.Group ||
                    this.Group.Equals(input.Group)
                ) && 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                hashCode = (hashCode * 59) + this.Group.GetHashCode();
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Deadline != null)
                {
                    hashCode = (hashCode * 59) + this.Deadline.GetHashCode();
                }
                if (this.Height != null)
                {
                    hashCode = (hashCode * 59) + this.Height.GetHashCode();
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