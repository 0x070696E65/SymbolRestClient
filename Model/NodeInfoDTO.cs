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
    /// NodeInfoDTO
    /// </summary>
    [DataContract(Name = "NodeInfoDTO")]
    public partial class NodeInfoDTO : IEquatable<NodeInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfoDTO" /> class.
        /// </summary>
        /// <param name="version">Version of the application. (required).</param>
        /// <param name="publicKey">Public key. (required).</param>
        /// <param name="networkGenerationHashSeed">networkGenerationHashSeed (required).</param>
        /// <param name="roles">A number that defines the different roles the node provides. Possible roles are: * 1 - Peer node. * 2 - Api node. * 4 - Voting node. * 64 - IPv4 compatible node * 128 - IPv6 compatible node.  The values are bitwise added together, Examples: 1 &#x3D; Just Peer. 2 &#x3D; Just Api. 3 &#x3D; Peer and Api node. 7 &#x3D; Peer, Api and Voting node. 65 &#x3D; IPv4 and Peer node.  (required).</param>
        /// <param name="port">Port used for the communication. (required).</param>
        /// <param name="networkIdentifier">networkIdentifier (required).</param>
        /// <param name="friendlyName">Node friendly name. (required).</param>
        /// <param name="host">Node IP address. (required).</param>
        /// <param name="nodePublicKey">Public key..</param>
        public NodeInfoDTO(int version = default(int), string publicKey = default(string), string networkGenerationHashSeed = default(string), int roles = default(int), int port = default(int), int networkIdentifier = default(int), string friendlyName = default(string), string host = default(string), string nodePublicKey = default(string))
        {
            this._Version = version;
            // to ensure "publicKey" is required (not null)
            if (publicKey == null)
            {
                throw new ArgumentNullException("publicKey is a required property for NodeInfoDTO and cannot be null");
            }
            this.PublicKey = publicKey;
            // to ensure "networkGenerationHashSeed" is required (not null)
            if (networkGenerationHashSeed == null)
            {
                throw new ArgumentNullException("networkGenerationHashSeed is a required property for NodeInfoDTO and cannot be null");
            }
            this.NetworkGenerationHashSeed = networkGenerationHashSeed;
            this.Roles = roles;
            this.Port = port;
            this.NetworkIdentifier = networkIdentifier;
            // to ensure "friendlyName" is required (not null)
            if (friendlyName == null)
            {
                throw new ArgumentNullException("friendlyName is a required property for NodeInfoDTO and cannot be null");
            }
            this.FriendlyName = friendlyName;
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for NodeInfoDTO and cannot be null");
            }
            this.Host = host;
            this.NodePublicKey = nodePublicKey;
        }

        /// <summary>
        /// Version of the application.
        /// </summary>
        /// <value>Version of the application.</value>
        /// <example>0</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Public key.
        /// </summary>
        /// <value>Public key.</value>
        /// <example>&quot;AC1A6E1D8DE5B17D2C6B1293F1CAD3829EEACF38D09311BB3C8E5A880092DE26&quot;</example>
        [DataMember(Name = "publicKey", IsRequired = true, EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets NetworkGenerationHashSeed
        /// </summary>
        /// <example>&quot;C8FC3FB54FDDFBCE0E8C71224990124E4EEC5AD5D30E592EDFA9524669A23810&quot;</example>
        [DataMember(Name = "networkGenerationHashSeed", IsRequired = true, EmitDefaultValue = true)]
        public string NetworkGenerationHashSeed { get; set; }

        /// <summary>
        /// A number that defines the different roles the node provides. Possible roles are: * 1 - Peer node. * 2 - Api node. * 4 - Voting node. * 64 - IPv4 compatible node * 128 - IPv6 compatible node.  The values are bitwise added together, Examples: 1 &#x3D; Just Peer. 2 &#x3D; Just Api. 3 &#x3D; Peer and Api node. 7 &#x3D; Peer, Api and Voting node. 65 &#x3D; IPv4 and Peer node. 
        /// </summary>
        /// <value>A number that defines the different roles the node provides. Possible roles are: * 1 - Peer node. * 2 - Api node. * 4 - Voting node. * 64 - IPv4 compatible node * 128 - IPv6 compatible node.  The values are bitwise added together, Examples: 1 &#x3D; Just Peer. 2 &#x3D; Just Api. 3 &#x3D; Peer and Api node. 7 &#x3D; Peer, Api and Voting node. 65 &#x3D; IPv4 and Peer node. </value>
        /// <example>7</example>
        [DataMember(Name = "roles", IsRequired = true, EmitDefaultValue = true)]
        public int Roles { get; set; }

        /// <summary>
        /// Port used for the communication.
        /// </summary>
        /// <value>Port used for the communication.</value>
        /// <example>7900</example>
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        /// <example>144</example>
        [DataMember(Name = "networkIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public int NetworkIdentifier { get; set; }

        /// <summary>
        /// Node friendly name.
        /// </summary>
        /// <value>Node friendly name.</value>
        /// <example>&quot;api-node-0&quot;</example>
        [DataMember(Name = "friendlyName", IsRequired = true, EmitDefaultValue = true)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Node IP address.
        /// </summary>
        /// <value>Node IP address.</value>
        /// <example>&quot;127.0.0.1&quot;</example>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Public key.
        /// </summary>
        /// <value>Public key.</value>
        /// <example>&quot;AC1A6E1D8DE5B17D2C6B1293F1CAD3829EEACF38D09311BB3C8E5A880092DE26&quot;</example>
        [DataMember(Name = "nodePublicKey", EmitDefaultValue = false)]
        public string NodePublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeInfoDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  NetworkGenerationHashSeed: ").Append(NetworkGenerationHashSeed).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  NodePublicKey: ").Append(NodePublicKey).Append("\n");
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
            return this.Equals(input as NodeInfoDTO);
        }

        /// <summary>
        /// Returns true if NodeInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeInfoDTO input)
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
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.NetworkGenerationHashSeed == input.NetworkGenerationHashSeed ||
                    (this.NetworkGenerationHashSeed != null &&
                    this.NetworkGenerationHashSeed.Equals(input.NetworkGenerationHashSeed))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles.Equals(input.Roles)
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.NetworkIdentifier == input.NetworkIdentifier ||
                    this.NetworkIdentifier.Equals(input.NetworkIdentifier)
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.NodePublicKey == input.NodePublicKey ||
                    (this.NodePublicKey != null &&
                    this.NodePublicKey.Equals(input.NodePublicKey))
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
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
                }
                if (this.NetworkGenerationHashSeed != null)
                {
                    hashCode = (hashCode * 59) + this.NetworkGenerationHashSeed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                hashCode = (hashCode * 59) + this.Port.GetHashCode();
                hashCode = (hashCode * 59) + this.NetworkIdentifier.GetHashCode();
                if (this.FriendlyName != null)
                {
                    hashCode = (hashCode * 59) + this.FriendlyName.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                if (this.NodePublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.NodePublicKey.GetHashCode();
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
