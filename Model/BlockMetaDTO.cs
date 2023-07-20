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
    /// BlockMetaDTO
    /// </summary>
    [DataContract(Name = "BlockMetaDTO")]
    public partial class BlockMetaDTO : IEquatable<BlockMetaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockMetaDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockMetaDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockMetaDTO" /> class.
        /// </summary>
        /// <param name="hash">hash (required).</param>
        /// <param name="totalFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="generationHash">generationHash (required).</param>
        /// <param name="stateHashSubCacheMerkleRoots">stateHashSubCacheMerkleRoots (required).</param>
        /// <param name="totalTransactionsCount">Total number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block, including *embedded* transactions (i.e. transactions contained within aggregate transactions).  (required).</param>
        /// <param name="transactionsCount">Number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block. This does not count *embedded* transactions (i.e. transactions contained within aggregate transactions).  (required).</param>
        /// <param name="statementsCount">Number of statements (of any kind) present in this block. Bear in mind that some of them (like [resolution statements](https://docs.symbolplatform.com/concepts/receipt.html#resolution-statement)) are triggered by transactions present in the block, but in general, [transaction statements](https://docs.symbolplatform.com/concepts/receipt.html#transaction-statement) are not.  (required).</param>
        public BlockMetaDTO(string hash = default(string), string totalFee = default(string), string generationHash = default(string), List<string> stateHashSubCacheMerkleRoots = default(List<string>), int totalTransactionsCount = default(int), int transactionsCount = default(int), int statementsCount = default(int))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for BlockMetaDTO and cannot be null");
            }
            this.Hash = hash;
            // to ensure "totalFee" is required (not null)
            if (totalFee == null)
            {
                throw new ArgumentNullException("totalFee is a required property for BlockMetaDTO and cannot be null");
            }
            this.TotalFee = totalFee;
            // to ensure "generationHash" is required (not null)
            if (generationHash == null)
            {
                throw new ArgumentNullException("generationHash is a required property for BlockMetaDTO and cannot be null");
            }
            this.GenerationHash = generationHash;
            // to ensure "stateHashSubCacheMerkleRoots" is required (not null)
            if (stateHashSubCacheMerkleRoots == null)
            {
                throw new ArgumentNullException("stateHashSubCacheMerkleRoots is a required property for BlockMetaDTO and cannot be null");
            }
            this.StateHashSubCacheMerkleRoots = stateHashSubCacheMerkleRoots;
            this.TotalTransactionsCount = totalTransactionsCount;
            this.TransactionsCount = transactionsCount;
            this.StatementsCount = statementsCount;
        }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        /// <example>&quot;123456&quot;</example>
        [DataMember(Name = "totalFee", IsRequired = true, EmitDefaultValue = true)]
        public string TotalFee { get; set; }

        /// <summary>
        /// Gets or Sets GenerationHash
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "generationHash", IsRequired = true, EmitDefaultValue = true)]
        public string GenerationHash { get; set; }

        /// <summary>
        /// Gets or Sets StateHashSubCacheMerkleRoots
        /// </summary>
        [DataMember(Name = "stateHashSubCacheMerkleRoots", IsRequired = true, EmitDefaultValue = true)]
        public List<string> StateHashSubCacheMerkleRoots { get; set; }

        /// <summary>
        /// Total number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block, including *embedded* transactions (i.e. transactions contained within aggregate transactions). 
        /// </summary>
        /// <value>Total number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block, including *embedded* transactions (i.e. transactions contained within aggregate transactions). </value>
        /// <example>1</example>
        [DataMember(Name = "totalTransactionsCount", IsRequired = true, EmitDefaultValue = true)]
        public int TotalTransactionsCount { get; set; }

        /// <summary>
        /// Number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block. This does not count *embedded* transactions (i.e. transactions contained within aggregate transactions). 
        /// </summary>
        /// <value>Number of [transactions](https://docs.symbolplatform.com/concepts/transaction.html) confirmed in this block. This does not count *embedded* transactions (i.e. transactions contained within aggregate transactions). </value>
        /// <example>1</example>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = true)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Number of statements (of any kind) present in this block. Bear in mind that some of them (like [resolution statements](https://docs.symbolplatform.com/concepts/receipt.html#resolution-statement)) are triggered by transactions present in the block, but in general, [transaction statements](https://docs.symbolplatform.com/concepts/receipt.html#transaction-statement) are not. 
        /// </summary>
        /// <value>Number of statements (of any kind) present in this block. Bear in mind that some of them (like [resolution statements](https://docs.symbolplatform.com/concepts/receipt.html#resolution-statement)) are triggered by transactions present in the block, but in general, [transaction statements](https://docs.symbolplatform.com/concepts/receipt.html#transaction-statement) are not. </value>
        /// <example>1</example>
        [DataMember(Name = "statementsCount", IsRequired = true, EmitDefaultValue = true)]
        public int StatementsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockMetaDTO {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  TotalFee: ").Append(TotalFee).Append("\n");
            sb.Append("  GenerationHash: ").Append(GenerationHash).Append("\n");
            sb.Append("  StateHashSubCacheMerkleRoots: ").Append(StateHashSubCacheMerkleRoots).Append("\n");
            sb.Append("  TotalTransactionsCount: ").Append(TotalTransactionsCount).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
            sb.Append("  StatementsCount: ").Append(StatementsCount).Append("\n");
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
            return this.Equals(input as BlockMetaDTO);
        }

        /// <summary>
        /// Returns true if BlockMetaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockMetaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockMetaDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.TotalFee == input.TotalFee ||
                    (this.TotalFee != null &&
                    this.TotalFee.Equals(input.TotalFee))
                ) && 
                (
                    this.GenerationHash == input.GenerationHash ||
                    (this.GenerationHash != null &&
                    this.GenerationHash.Equals(input.GenerationHash))
                ) && 
                (
                    this.StateHashSubCacheMerkleRoots == input.StateHashSubCacheMerkleRoots ||
                    this.StateHashSubCacheMerkleRoots != null &&
                    input.StateHashSubCacheMerkleRoots != null &&
                    this.StateHashSubCacheMerkleRoots.SequenceEqual(input.StateHashSubCacheMerkleRoots)
                ) && 
                (
                    this.TotalTransactionsCount == input.TotalTransactionsCount ||
                    this.TotalTransactionsCount.Equals(input.TotalTransactionsCount)
                ) && 
                (
                    this.TransactionsCount == input.TransactionsCount ||
                    this.TransactionsCount.Equals(input.TransactionsCount)
                ) && 
                (
                    this.StatementsCount == input.StatementsCount ||
                    this.StatementsCount.Equals(input.StatementsCount)
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
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.TotalFee != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFee.GetHashCode();
                }
                if (this.GenerationHash != null)
                {
                    hashCode = (hashCode * 59) + this.GenerationHash.GetHashCode();
                }
                if (this.StateHashSubCacheMerkleRoots != null)
                {
                    hashCode = (hashCode * 59) + this.StateHashSubCacheMerkleRoots.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalTransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.StatementsCount.GetHashCode();
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