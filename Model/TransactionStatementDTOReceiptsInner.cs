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
using System.Reflection;

namespace SymbolRestClient.Model
{
    /// <summary>
    /// TransactionStatementDTOReceiptsInner
    /// </summary>
    [JsonConverter(typeof(TransactionStatementDTOReceiptsInnerJsonConverter))]
    [DataContract(Name = "TransactionStatementDTO_receipts_inner")]
    public partial class TransactionStatementDTOReceiptsInner : AbstractOpenAPISchema, IEquatable<TransactionStatementDTOReceiptsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatementDTOReceiptsInner" /> class
        /// with the <see cref="BalanceTransferReceiptDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BalanceTransferReceiptDTO.</param>
        public TransactionStatementDTOReceiptsInner(BalanceTransferReceiptDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatementDTOReceiptsInner" /> class
        /// with the <see cref="BalanceChangeReceiptDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BalanceChangeReceiptDTO.</param>
        public TransactionStatementDTOReceiptsInner(BalanceChangeReceiptDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatementDTOReceiptsInner" /> class
        /// with the <see cref="NamespaceExpiryReceiptDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NamespaceExpiryReceiptDTO.</param>
        public TransactionStatementDTOReceiptsInner(NamespaceExpiryReceiptDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatementDTOReceiptsInner" /> class
        /// with the <see cref="MosaicExpiryReceiptDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MosaicExpiryReceiptDTO.</param>
        public TransactionStatementDTOReceiptsInner(MosaicExpiryReceiptDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatementDTOReceiptsInner" /> class
        /// with the <see cref="InflationReceiptDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InflationReceiptDTO.</param>
        public TransactionStatementDTOReceiptsInner(InflationReceiptDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(BalanceChangeReceiptDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(BalanceTransferReceiptDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InflationReceiptDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MosaicExpiryReceiptDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NamespaceExpiryReceiptDTO))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BalanceChangeReceiptDTO, BalanceTransferReceiptDTO, InflationReceiptDTO, MosaicExpiryReceiptDTO, NamespaceExpiryReceiptDTO");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `BalanceTransferReceiptDTO`. If the actual instance is not `BalanceTransferReceiptDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BalanceTransferReceiptDTO</returns>
        public BalanceTransferReceiptDTO GetBalanceTransferReceiptDTO()
        {
            return (BalanceTransferReceiptDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BalanceChangeReceiptDTO`. If the actual instance is not `BalanceChangeReceiptDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BalanceChangeReceiptDTO</returns>
        public BalanceChangeReceiptDTO GetBalanceChangeReceiptDTO()
        {
            return (BalanceChangeReceiptDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NamespaceExpiryReceiptDTO`. If the actual instance is not `NamespaceExpiryReceiptDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NamespaceExpiryReceiptDTO</returns>
        public NamespaceExpiryReceiptDTO GetNamespaceExpiryReceiptDTO()
        {
            return (NamespaceExpiryReceiptDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MosaicExpiryReceiptDTO`. If the actual instance is not `MosaicExpiryReceiptDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MosaicExpiryReceiptDTO</returns>
        public MosaicExpiryReceiptDTO GetMosaicExpiryReceiptDTO()
        {
            return (MosaicExpiryReceiptDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InflationReceiptDTO`. If the actual instance is not `InflationReceiptDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InflationReceiptDTO</returns>
        public InflationReceiptDTO GetInflationReceiptDTO()
        {
            return (InflationReceiptDTO)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionStatementDTOReceiptsInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, TransactionStatementDTOReceiptsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TransactionStatementDTOReceiptsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TransactionStatementDTOReceiptsInner</returns>
        public static TransactionStatementDTOReceiptsInner FromJson(string jsonString)
        {
            TransactionStatementDTOReceiptsInner newTransactionStatementDTOReceiptsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTransactionStatementDTOReceiptsInner;
            }

            try
            {
                newTransactionStatementDTOReceiptsInner = new TransactionStatementDTOReceiptsInner(JsonConvert.DeserializeObject<BalanceChangeReceiptDTO>(jsonString, TransactionStatementDTOReceiptsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionStatementDTOReceiptsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BalanceChangeReceiptDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransactionStatementDTOReceiptsInner = new TransactionStatementDTOReceiptsInner(JsonConvert.DeserializeObject<BalanceTransferReceiptDTO>(jsonString, TransactionStatementDTOReceiptsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionStatementDTOReceiptsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BalanceTransferReceiptDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransactionStatementDTOReceiptsInner = new TransactionStatementDTOReceiptsInner(JsonConvert.DeserializeObject<InflationReceiptDTO>(jsonString, TransactionStatementDTOReceiptsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionStatementDTOReceiptsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InflationReceiptDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransactionStatementDTOReceiptsInner = new TransactionStatementDTOReceiptsInner(JsonConvert.DeserializeObject<MosaicExpiryReceiptDTO>(jsonString, TransactionStatementDTOReceiptsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionStatementDTOReceiptsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MosaicExpiryReceiptDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransactionStatementDTOReceiptsInner = new TransactionStatementDTOReceiptsInner(JsonConvert.DeserializeObject<NamespaceExpiryReceiptDTO>(jsonString, TransactionStatementDTOReceiptsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionStatementDTOReceiptsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NamespaceExpiryReceiptDTO: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionStatementDTOReceiptsInner);
        }

        /// <summary>
        /// Returns true if TransactionStatementDTOReceiptsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionStatementDTOReceiptsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionStatementDTOReceiptsInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for TransactionStatementDTOReceiptsInner
    /// </summary>
    public class TransactionStatementDTOReceiptsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TransactionStatementDTOReceiptsInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return TransactionStatementDTOReceiptsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
