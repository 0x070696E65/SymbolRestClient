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
    /// StorageInfoDTO
    /// </summary>
    [DataContract(Name = "StorageInfoDTO")]
    public partial class StorageInfoDTO : IEquatable<StorageInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfoDTO" /> class.
        /// </summary>
        /// <param name="numBlocks">Number of blocks stored. (required).</param>
        /// <param name="numTransactions">Number of transactions stored. (required).</param>
        /// <param name="numAccounts">Number of accounts created. (required).</param>
        public StorageInfoDTO(int numBlocks = default(int), int numTransactions = default(int), int numAccounts = default(int))
        {
            this.NumBlocks = numBlocks;
            this.NumTransactions = numTransactions;
            this.NumAccounts = numAccounts;
        }

        /// <summary>
        /// Number of blocks stored.
        /// </summary>
        /// <value>Number of blocks stored.</value>
        /// <example>245053</example>
        [DataMember(Name = "numBlocks", IsRequired = true, EmitDefaultValue = true)]
        public int NumBlocks { get; set; }

        /// <summary>
        /// Number of transactions stored.
        /// </summary>
        /// <value>Number of transactions stored.</value>
        /// <example>58590</example>
        [DataMember(Name = "numTransactions", IsRequired = true, EmitDefaultValue = true)]
        public int NumTransactions { get; set; }

        /// <summary>
        /// Number of accounts created.
        /// </summary>
        /// <value>Number of accounts created.</value>
        /// <example>177</example>
        [DataMember(Name = "numAccounts", IsRequired = true, EmitDefaultValue = true)]
        public int NumAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StorageInfoDTO {\n");
            sb.Append("  NumBlocks: ").Append(NumBlocks).Append("\n");
            sb.Append("  NumTransactions: ").Append(NumTransactions).Append("\n");
            sb.Append("  NumAccounts: ").Append(NumAccounts).Append("\n");
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
            return this.Equals(input as StorageInfoDTO);
        }

        /// <summary>
        /// Returns true if StorageInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NumBlocks == input.NumBlocks ||
                    this.NumBlocks.Equals(input.NumBlocks)
                ) && 
                (
                    this.NumTransactions == input.NumTransactions ||
                    this.NumTransactions.Equals(input.NumTransactions)
                ) && 
                (
                    this.NumAccounts == input.NumAccounts ||
                    this.NumAccounts.Equals(input.NumAccounts)
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
                hashCode = (hashCode * 59) + this.NumBlocks.GetHashCode();
                hashCode = (hashCode * 59) + this.NumTransactions.GetHashCode();
                hashCode = (hashCode * 59) + this.NumAccounts.GetHashCode();
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
