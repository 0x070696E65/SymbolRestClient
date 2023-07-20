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
    /// BmTreeSignature
    /// </summary>
    [DataContract(Name = "BmTreeSignature")]
    public partial class BmTreeSignature : IEquatable<BmTreeSignature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BmTreeSignature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BmTreeSignature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BmTreeSignature" /> class.
        /// </summary>
        /// <param name="root">root (required).</param>
        /// <param name="bottom">bottom (required).</param>
        public BmTreeSignature(ParentPublicKeySignaturePair root = default(ParentPublicKeySignaturePair), ParentPublicKeySignaturePair bottom = default(ParentPublicKeySignaturePair))
        {
            // to ensure "root" is required (not null)
            if (root == null)
            {
                throw new ArgumentNullException("root is a required property for BmTreeSignature and cannot be null");
            }
            this.Root = root;
            // to ensure "bottom" is required (not null)
            if (bottom == null)
            {
                throw new ArgumentNullException("bottom is a required property for BmTreeSignature and cannot be null");
            }
            this.Bottom = bottom;
        }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", IsRequired = true, EmitDefaultValue = true)]
        public ParentPublicKeySignaturePair Root { get; set; }

        /// <summary>
        /// Gets or Sets Bottom
        /// </summary>
        [DataMember(Name = "bottom", IsRequired = true, EmitDefaultValue = true)]
        public ParentPublicKeySignaturePair Bottom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BmTreeSignature {\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
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
            return this.Equals(input as BmTreeSignature);
        }

        /// <summary>
        /// Returns true if BmTreeSignature instances are equal
        /// </summary>
        /// <param name="input">Instance of BmTreeSignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BmTreeSignature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.Bottom == input.Bottom ||
                    (this.Bottom != null &&
                    this.Bottom.Equals(input.Bottom))
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
                if (this.Root != null)
                {
                    hashCode = (hashCode * 59) + this.Root.GetHashCode();
                }
                if (this.Bottom != null)
                {
                    hashCode = (hashCode * 59) + this.Bottom.GetHashCode();
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