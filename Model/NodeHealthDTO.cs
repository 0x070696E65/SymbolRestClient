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
    /// NodeHealthDTO
    /// </summary>
    [DataContract(Name = "NodeHealthDTO")]
    public partial class NodeHealthDTO : IEquatable<NodeHealthDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApiNode
        /// </summary>
        [DataMember(Name = "apiNode", IsRequired = true, EmitDefaultValue = true)]
        public NodeStatusEnum ApiNode { get; set; }

        /// <summary>
        /// Gets or Sets Db
        /// </summary>
        [DataMember(Name = "db", IsRequired = true, EmitDefaultValue = true)]
        public NodeStatusEnum Db { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeHealthDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeHealthDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeHealthDTO" /> class.
        /// </summary>
        /// <param name="apiNode">apiNode (required).</param>
        /// <param name="db">db (required).</param>
        public NodeHealthDTO(NodeStatusEnum apiNode = default(NodeStatusEnum), NodeStatusEnum db = default(NodeStatusEnum))
        {
            this.ApiNode = apiNode;
            this.Db = db;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeHealthDTO {\n");
            sb.Append("  ApiNode: ").Append(ApiNode).Append("\n");
            sb.Append("  Db: ").Append(Db).Append("\n");
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
            return this.Equals(input as NodeHealthDTO);
        }

        /// <summary>
        /// Returns true if NodeHealthDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeHealthDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeHealthDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiNode == input.ApiNode ||
                    this.ApiNode.Equals(input.ApiNode)
                ) && 
                (
                    this.Db == input.Db ||
                    this.Db.Equals(input.Db)
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
                hashCode = (hashCode * 59) + this.ApiNode.GetHashCode();
                hashCode = (hashCode * 59) + this.Db.GetHashCode();
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
