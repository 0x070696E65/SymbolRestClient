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
    /// TransactionInfoDTOMeta
    /// </summary>
    [JsonConverter(typeof(TransactionInfoDTOMetaJsonConverter))]
    [DataContract(Name = "TransactionInfoDTO_meta")]
    public partial class TransactionInfoDTOMeta : AbstractOpenAPISchema, IEquatable<TransactionInfoDTOMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfoDTOMeta" /> class
        /// with the <see cref="TransactionMetaDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TransactionMetaDTO.</param>
        public TransactionInfoDTOMeta(TransactionMetaDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfoDTOMeta" /> class
        /// with the <see cref="EmbeddedTransactionMetaDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EmbeddedTransactionMetaDTO.</param>
        public TransactionInfoDTOMeta(EmbeddedTransactionMetaDTO actualInstance)
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
                if (value.GetType() == typeof(EmbeddedTransactionMetaDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TransactionMetaDTO))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: EmbeddedTransactionMetaDTO, TransactionMetaDTO");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `TransactionMetaDTO`. If the actual instance is not `TransactionMetaDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TransactionMetaDTO</returns>
        public TransactionMetaDTO GetTransactionMetaDTO()
        {
            return (TransactionMetaDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EmbeddedTransactionMetaDTO`. If the actual instance is not `EmbeddedTransactionMetaDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EmbeddedTransactionMetaDTO</returns>
        public EmbeddedTransactionMetaDTO GetEmbeddedTransactionMetaDTO()
        {
            return (EmbeddedTransactionMetaDTO)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionInfoDTOMeta {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, TransactionInfoDTOMeta.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TransactionInfoDTOMeta
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TransactionInfoDTOMeta</returns>
        public static TransactionInfoDTOMeta FromJson(string jsonString)
        {
            TransactionInfoDTOMeta newTransactionInfoDTOMeta = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTransactionInfoDTOMeta;
            }

            try
            {
                newTransactionInfoDTOMeta = new TransactionInfoDTOMeta(JsonConvert.DeserializeObject<EmbeddedTransactionMetaDTO>(jsonString, TransactionInfoDTOMeta.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionInfoDTOMeta;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EmbeddedTransactionMetaDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransactionInfoDTOMeta = new TransactionInfoDTOMeta(JsonConvert.DeserializeObject<TransactionMetaDTO>(jsonString, TransactionInfoDTOMeta.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransactionInfoDTOMeta;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TransactionMetaDTO: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as TransactionInfoDTOMeta);
        }

        /// <summary>
        /// Returns true if TransactionInfoDTOMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInfoDTOMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInfoDTOMeta input)
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
    /// Custom JSON converter for TransactionInfoDTOMeta
    /// </summary>
    public class TransactionInfoDTOMetaJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TransactionInfoDTOMeta).GetMethod("ToJson").Invoke(value, null)));
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
                return TransactionInfoDTOMeta.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
