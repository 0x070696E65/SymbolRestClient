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
    /// NetworkConfigurationDTO
    /// </summary>
    [DataContract(Name = "NetworkConfigurationDTO")]
    public partial class NetworkConfigurationDTO : IEquatable<NetworkConfigurationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfigurationDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetworkConfigurationDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfigurationDTO" /> class.
        /// </summary>
        /// <param name="network">network (required).</param>
        /// <param name="chain">chain (required).</param>
        /// <param name="plugins">plugins (required).</param>
        public NetworkConfigurationDTO(NetworkPropertiesDTO network = default(NetworkPropertiesDTO), ChainPropertiesDTO chain = default(ChainPropertiesDTO), PluginsPropertiesDTO plugins = default(PluginsPropertiesDTO))
        {
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for NetworkConfigurationDTO and cannot be null");
            }
            this.Network = network;
            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new ArgumentNullException("chain is a required property for NetworkConfigurationDTO and cannot be null");
            }
            this.Chain = chain;
            // to ensure "plugins" is required (not null)
            if (plugins == null)
            {
                throw new ArgumentNullException("plugins is a required property for NetworkConfigurationDTO and cannot be null");
            }
            this.Plugins = plugins;
        }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public NetworkPropertiesDTO Network { get; set; }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainPropertiesDTO Chain { get; set; }

        /// <summary>
        /// Gets or Sets Plugins
        /// </summary>
        [DataMember(Name = "plugins", IsRequired = true, EmitDefaultValue = true)]
        public PluginsPropertiesDTO Plugins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkConfigurationDTO {\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Plugins: ").Append(Plugins).Append("\n");
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
            return this.Equals(input as NetworkConfigurationDTO);
        }

        /// <summary>
        /// Returns true if NetworkConfigurationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkConfigurationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkConfigurationDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Plugins == input.Plugins ||
                    (this.Plugins != null &&
                    this.Plugins.Equals(input.Plugins))
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
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                }
                if (this.Plugins != null)
                {
                    hashCode = (hashCode * 59) + this.Plugins.GetHashCode();
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