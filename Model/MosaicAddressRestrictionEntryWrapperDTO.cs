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
    /// MosaicAddressRestrictionEntryWrapperDTO
    /// </summary>
    [DataContract(Name = "MosaicAddressRestrictionEntryWrapperDTO")]
    public partial class MosaicAddressRestrictionEntryWrapperDTO : IEquatable<MosaicAddressRestrictionEntryWrapperDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name = "entryType", IsRequired = true, EmitDefaultValue = true)]
        public MosaicRestrictionEntryTypeEnum EntryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAddressRestrictionEntryWrapperDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicAddressRestrictionEntryWrapperDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAddressRestrictionEntryWrapperDTO" /> class.
        /// </summary>
        /// <param name="version">The version of the state (required).</param>
        /// <param name="compositeHash">compositeHash (required).</param>
        /// <param name="entryType">entryType (required).</param>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="targetAddress">Address encoded using a 32-character set. (required).</param>
        /// <param name="restrictions">restrictions (required).</param>
        public MosaicAddressRestrictionEntryWrapperDTO(int version = default(int), string compositeHash = default(string), MosaicRestrictionEntryTypeEnum entryType = default(MosaicRestrictionEntryTypeEnum), string mosaicId = default(string), string targetAddress = default(string), List<MosaicAddressRestrictionEntryDTO> restrictions = default(List<MosaicAddressRestrictionEntryDTO>))
        {
            this._Version = version;
            // to ensure "compositeHash" is required (not null)
            if (compositeHash == null)
            {
                throw new ArgumentNullException("compositeHash is a required property for MosaicAddressRestrictionEntryWrapperDTO and cannot be null");
            }
            this.CompositeHash = compositeHash;
            this.EntryType = entryType;
            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new ArgumentNullException("mosaicId is a required property for MosaicAddressRestrictionEntryWrapperDTO and cannot be null");
            }
            this.MosaicId = mosaicId;
            // to ensure "targetAddress" is required (not null)
            if (targetAddress == null)
            {
                throw new ArgumentNullException("targetAddress is a required property for MosaicAddressRestrictionEntryWrapperDTO and cannot be null");
            }
            this.TargetAddress = targetAddress;
            // to ensure "restrictions" is required (not null)
            if (restrictions == null)
            {
                throw new ArgumentNullException("restrictions is a required property for MosaicAddressRestrictionEntryWrapperDTO and cannot be null");
            }
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// The version of the state
        /// </summary>
        /// <value>The version of the state</value>
        /// <example>1</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets CompositeHash
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "compositeHash", IsRequired = true, EmitDefaultValue = true)]
        public string CompositeHash { get; set; }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        /// <example>&quot;0DC67FBE1CAD29E3&quot;</example>
        [DataMember(Name = "mosaicId", IsRequired = true, EmitDefaultValue = true)]
        public string MosaicId { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        /// <example>&quot;TADP6C2GVEG654OP5LZI32P2GYJSCMEGQBYB7QY&quot;</example>
        [DataMember(Name = "targetAddress", IsRequired = true, EmitDefaultValue = true)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name = "restrictions", IsRequired = true, EmitDefaultValue = true)]
        public List<MosaicAddressRestrictionEntryDTO> Restrictions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MosaicAddressRestrictionEntryWrapperDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  CompositeHash: ").Append(CompositeHash).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
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
            return this.Equals(input as MosaicAddressRestrictionEntryWrapperDTO);
        }

        /// <summary>
        /// Returns true if MosaicAddressRestrictionEntryWrapperDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicAddressRestrictionEntryWrapperDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicAddressRestrictionEntryWrapperDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.CompositeHash == input.CompositeHash ||
                    (this.CompositeHash != null &&
                    this.CompositeHash.Equals(input.CompositeHash))
                ) && 
                (
                    this.EntryType == input.EntryType ||
                    this.EntryType.Equals(input.EntryType)
                ) && 
                (
                    this.MosaicId == input.MosaicId ||
                    (this.MosaicId != null &&
                    this.MosaicId.Equals(input.MosaicId))
                ) && 
                (
                    this.TargetAddress == input.TargetAddress ||
                    (this.TargetAddress != null &&
                    this.TargetAddress.Equals(input.TargetAddress))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    this.Restrictions != null &&
                    input.Restrictions != null &&
                    this.Restrictions.SequenceEqual(input.Restrictions)
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
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.CompositeHash != null)
                {
                    hashCode = (hashCode * 59) + this.CompositeHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EntryType.GetHashCode();
                if (this.MosaicId != null)
                {
                    hashCode = (hashCode * 59) + this.MosaicId.GetHashCode();
                }
                if (this.TargetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAddress.GetHashCode();
                }
                if (this.Restrictions != null)
                {
                    hashCode = (hashCode * 59) + this.Restrictions.GetHashCode();
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
