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
    /// MerkleProofInfoDTO
    /// </summary>
    [DataContract(Name = "MerkleProofInfoDTO")]
    public partial class MerkleProofInfoDTO : IEquatable<MerkleProofInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerkleProofInfoDTO" /> class.
        /// </summary>
        /// <param name="merklePath">List of complementary merkle path items needed to recalculate the merkle root..</param>
        public MerkleProofInfoDTO(List<MerklePathItemDTO> merklePath = default(List<MerklePathItemDTO>))
        {
            this.MerklePath = merklePath;
        }

        /// <summary>
        /// List of complementary merkle path items needed to recalculate the merkle root.
        /// </summary>
        /// <value>List of complementary merkle path items needed to recalculate the merkle root.</value>
        [DataMember(Name = "merklePath", EmitDefaultValue = false)]
        public List<MerklePathItemDTO> MerklePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerkleProofInfoDTO {\n");
            sb.Append("  MerklePath: ").Append(MerklePath).Append("\n");
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
            return this.Equals(input as MerkleProofInfoDTO);
        }

        /// <summary>
        /// Returns true if MerkleProofInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MerkleProofInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerkleProofInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerklePath == input.MerklePath ||
                    this.MerklePath != null &&
                    input.MerklePath != null &&
                    this.MerklePath.SequenceEqual(input.MerklePath)
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
                if (this.MerklePath != null)
                {
                    hashCode = (hashCode * 59) + this.MerklePath.GetHashCode();
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
