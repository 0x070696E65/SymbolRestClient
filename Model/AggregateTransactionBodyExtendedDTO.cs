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
    /// AggregateTransactionBodyExtendedDTO
    /// </summary>
    [DataContract(Name = "AggregateTransactionBodyExtendedDTO")]
    public partial class AggregateTransactionBodyExtendedDTO : IEquatable<AggregateTransactionBodyExtendedDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateTransactionBodyExtendedDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregateTransactionBodyExtendedDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateTransactionBodyExtendedDTO" /> class.
        /// </summary>
        /// <param name="transactionsHash">transactionsHash (required).</param>
        /// <param name="cosignatures">Array of transaction cosignatures..</param>
        /// <param name="transactions">Array of transactions initiated by different accounts..</param>
        public AggregateTransactionBodyExtendedDTO(string transactionsHash = default(string), List<CosignatureDTO> cosignatures = default(List<CosignatureDTO>), List<EmbeddedTransactionInfoDTO> transactions = default(List<EmbeddedTransactionInfoDTO>))
        {
            // to ensure "transactionsHash" is required (not null)
            if (transactionsHash == null)
            {
                throw new ArgumentNullException("transactionsHash is a required property for AggregateTransactionBodyExtendedDTO and cannot be null");
            }
            this.TransactionsHash = transactionsHash;
            this.Cosignatures = cosignatures;
            this.Transactions = transactions;
        }

        /// <summary>
        /// Gets or Sets TransactionsHash
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "transactionsHash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionsHash { get; set; }

        /// <summary>
        /// Array of transaction cosignatures.
        /// </summary>
        /// <value>Array of transaction cosignatures.</value>
        [DataMember(Name = "cosignatures", EmitDefaultValue = false)]
        public List<CosignatureDTO> Cosignatures { get; set; }

        /// <summary>
        /// Array of transactions initiated by different accounts.
        /// </summary>
        /// <value>Array of transactions initiated by different accounts.</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<EmbeddedTransactionInfoDTO> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggregateTransactionBodyExtendedDTO {\n");
            sb.Append("  TransactionsHash: ").Append(TransactionsHash).Append("\n");
            sb.Append("  Cosignatures: ").Append(Cosignatures).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as AggregateTransactionBodyExtendedDTO);
        }

        /// <summary>
        /// Returns true if AggregateTransactionBodyExtendedDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregateTransactionBodyExtendedDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateTransactionBodyExtendedDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionsHash == input.TransactionsHash ||
                    (this.TransactionsHash != null &&
                    this.TransactionsHash.Equals(input.TransactionsHash))
                ) && 
                (
                    this.Cosignatures == input.Cosignatures ||
                    this.Cosignatures != null &&
                    input.Cosignatures != null &&
                    this.Cosignatures.SequenceEqual(input.Cosignatures)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.TransactionsHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionsHash.GetHashCode();
                }
                if (this.Cosignatures != null)
                {
                    hashCode = (hashCode * 59) + this.Cosignatures.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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
