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
    /// Generic Mosaic Restriction
    /// </summary>
    [JsonConverter(typeof(MosaicRestrictionDTOJsonConverter))]
    [DataContract(Name = "MosaicRestrictionDTO")]
    public partial class MosaicRestrictionDTO : AbstractOpenAPISchema, IEquatable<MosaicRestrictionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicRestrictionDTO" /> class
        /// with the <see cref="MosaicAddressRestrictionDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MosaicAddressRestrictionDTO.</param>
        public MosaicRestrictionDTO(MosaicAddressRestrictionDTO actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicRestrictionDTO" /> class
        /// with the <see cref="MosaicGlobalRestrictionDTO" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MosaicGlobalRestrictionDTO.</param>
        public MosaicRestrictionDTO(MosaicGlobalRestrictionDTO actualInstance)
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
                if (value.GetType() == typeof(MosaicAddressRestrictionDTO))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MosaicGlobalRestrictionDTO))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: MosaicAddressRestrictionDTO, MosaicGlobalRestrictionDTO");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `MosaicAddressRestrictionDTO`. If the actual instance is not `MosaicAddressRestrictionDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MosaicAddressRestrictionDTO</returns>
        public MosaicAddressRestrictionDTO GetMosaicAddressRestrictionDTO()
        {
            return (MosaicAddressRestrictionDTO)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MosaicGlobalRestrictionDTO`. If the actual instance is not `MosaicGlobalRestrictionDTO`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MosaicGlobalRestrictionDTO</returns>
        public MosaicGlobalRestrictionDTO GetMosaicGlobalRestrictionDTO()
        {
            return (MosaicGlobalRestrictionDTO)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicRestrictionDTO {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, MosaicRestrictionDTO.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of MosaicRestrictionDTO
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of MosaicRestrictionDTO</returns>
        public static MosaicRestrictionDTO FromJson(string jsonString)
        {
            MosaicRestrictionDTO newMosaicRestrictionDTO = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newMosaicRestrictionDTO;
            }

            try
            {
                newMosaicRestrictionDTO = new MosaicRestrictionDTO(JsonConvert.DeserializeObject<MosaicAddressRestrictionDTO>(jsonString, MosaicRestrictionDTO.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newMosaicRestrictionDTO;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MosaicAddressRestrictionDTO: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newMosaicRestrictionDTO = new MosaicRestrictionDTO(JsonConvert.DeserializeObject<MosaicGlobalRestrictionDTO>(jsonString, MosaicRestrictionDTO.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newMosaicRestrictionDTO;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MosaicGlobalRestrictionDTO: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as MosaicRestrictionDTO);
        }

        /// <summary>
        /// Returns true if MosaicRestrictionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicRestrictionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicRestrictionDTO input)
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
    /// Custom JSON converter for MosaicRestrictionDTO
    /// </summary>
    public class MosaicRestrictionDTOJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(MosaicRestrictionDTO).GetMethod("ToJson").Invoke(value, null)));
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
                return MosaicRestrictionDTO.FromJson(JObject.Load(reader).ToString(Formatting.None));
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