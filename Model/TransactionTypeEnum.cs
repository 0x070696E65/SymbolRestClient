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
    /// Type of transaction: * 0x414C (16716 decimal) - AccountKeyLinkTransaction. * 0x4243 (16963 decimal) - VrfKeyLinkTransaction. * 0x4143 (16707 decimal) - VotingKeyLinkTransaction. * 0x424C (16972 decimal) - NodeKeyLinkTransaction. * 0x4141 (16705 decimal) - AggregateCompleteTransaction. * 0x4241 (16961 decimal) - AggregateBondedTransaction. * 0x414D (16717 decimal) - MosaicDefinitionTransaction. * 0x424D (16973 decimal) - MosaicSupplyChangeTransaction. * 0x434D (17229 decimal) - MosaicSupplyRevocationTransaction. * 0x414E (16718 decimal) - NamespaceRegistrationTransaction. * 0x424E (16974 decimal) - AddressAliasTransaction. * 0x434E (17230 decimal) - MosaicAliasTransaction. * 0x4144 (16708 decimal) - AccountMetadataTransaction. * 0x4244 (16964 decimal) - MosaicMetadataTransaction. * 0x4344 (17220 decimal) - NamespaceMetadataTransaction. * 0x4155 (16725 decimal) - MultisigAccountModificationTransaction. * 0x4148 (16712 decimal) - HashLockTransaction. * 0x4152 (16722 decimal) - SecretLockTransaction. * 0x4252 (16978 decimal) - SecretProofTransaction. * 0x4150 (16720 decimal) - AccountAddressRestrictionTransaction. * 0x4250 (16976 decimal) - AccountMosaicRestrictionTransaction. * 0x4350 (17232 decimal) - AccountOperationRestrictionTransaction. * 0x4151 (16721 decimal) - MosaicGlobalRestrictionTransaction. * 0x4251 (16977 decimal) - MosaicAddressRestrictionTransaction. * 0x4154 (16724 decimal) - TransferTransaction. 
    /// </summary>
    /// <value>Type of transaction: * 0x414C (16716 decimal) - AccountKeyLinkTransaction. * 0x4243 (16963 decimal) - VrfKeyLinkTransaction. * 0x4143 (16707 decimal) - VotingKeyLinkTransaction. * 0x424C (16972 decimal) - NodeKeyLinkTransaction. * 0x4141 (16705 decimal) - AggregateCompleteTransaction. * 0x4241 (16961 decimal) - AggregateBondedTransaction. * 0x414D (16717 decimal) - MosaicDefinitionTransaction. * 0x424D (16973 decimal) - MosaicSupplyChangeTransaction. * 0x434D (17229 decimal) - MosaicSupplyRevocationTransaction. * 0x414E (16718 decimal) - NamespaceRegistrationTransaction. * 0x424E (16974 decimal) - AddressAliasTransaction. * 0x434E (17230 decimal) - MosaicAliasTransaction. * 0x4144 (16708 decimal) - AccountMetadataTransaction. * 0x4244 (16964 decimal) - MosaicMetadataTransaction. * 0x4344 (17220 decimal) - NamespaceMetadataTransaction. * 0x4155 (16725 decimal) - MultisigAccountModificationTransaction. * 0x4148 (16712 decimal) - HashLockTransaction. * 0x4152 (16722 decimal) - SecretLockTransaction. * 0x4252 (16978 decimal) - SecretProofTransaction. * 0x4150 (16720 decimal) - AccountAddressRestrictionTransaction. * 0x4250 (16976 decimal) - AccountMosaicRestrictionTransaction. * 0x4350 (17232 decimal) - AccountOperationRestrictionTransaction. * 0x4151 (16721 decimal) - MosaicGlobalRestrictionTransaction. * 0x4251 (16977 decimal) - MosaicAddressRestrictionTransaction. * 0x4154 (16724 decimal) - TransferTransaction. </value>
    public enum TransactionTypeEnum
    {
        /// <summary>
        /// Enum NUMBER_16716 for value: 16716
        /// </summary>
        NUMBER_16716 = 16716,

        /// <summary>
        /// Enum NUMBER_16963 for value: 16963
        /// </summary>
        NUMBER_16963 = 16963,

        /// <summary>
        /// Enum NUMBER_16707 for value: 16707
        /// </summary>
        NUMBER_16707 = 16707,

        /// <summary>
        /// Enum NUMBER_16972 for value: 16972
        /// </summary>
        NUMBER_16972 = 16972,

        /// <summary>
        /// Enum NUMBER_16705 for value: 16705
        /// </summary>
        NUMBER_16705 = 16705,

        /// <summary>
        /// Enum NUMBER_16961 for value: 16961
        /// </summary>
        NUMBER_16961 = 16961,

        /// <summary>
        /// Enum NUMBER_16717 for value: 16717
        /// </summary>
        NUMBER_16717 = 16717,

        /// <summary>
        /// Enum NUMBER_16973 for value: 16973
        /// </summary>
        NUMBER_16973 = 16973,

        /// <summary>
        /// Enum NUMBER_17229 for value: 17229
        /// </summary>
        NUMBER_17229 = 17229,

        /// <summary>
        /// Enum NUMBER_16718 for value: 16718
        /// </summary>
        NUMBER_16718 = 16718,

        /// <summary>
        /// Enum NUMBER_16974 for value: 16974
        /// </summary>
        NUMBER_16974 = 16974,

        /// <summary>
        /// Enum NUMBER_17230 for value: 17230
        /// </summary>
        NUMBER_17230 = 17230,

        /// <summary>
        /// Enum NUMBER_16708 for value: 16708
        /// </summary>
        NUMBER_16708 = 16708,

        /// <summary>
        /// Enum NUMBER_16964 for value: 16964
        /// </summary>
        NUMBER_16964 = 16964,

        /// <summary>
        /// Enum NUMBER_17220 for value: 17220
        /// </summary>
        NUMBER_17220 = 17220,

        /// <summary>
        /// Enum NUMBER_16725 for value: 16725
        /// </summary>
        NUMBER_16725 = 16725,

        /// <summary>
        /// Enum NUMBER_16712 for value: 16712
        /// </summary>
        NUMBER_16712 = 16712,

        /// <summary>
        /// Enum NUMBER_16722 for value: 16722
        /// </summary>
        NUMBER_16722 = 16722,

        /// <summary>
        /// Enum NUMBER_16978 for value: 16978
        /// </summary>
        NUMBER_16978 = 16978,

        /// <summary>
        /// Enum NUMBER_16720 for value: 16720
        /// </summary>
        NUMBER_16720 = 16720,

        /// <summary>
        /// Enum NUMBER_16976 for value: 16976
        /// </summary>
        NUMBER_16976 = 16976,

        /// <summary>
        /// Enum NUMBER_17232 for value: 17232
        /// </summary>
        NUMBER_17232 = 17232,

        /// <summary>
        /// Enum NUMBER_16721 for value: 16721
        /// </summary>
        NUMBER_16721 = 16721,

        /// <summary>
        /// Enum NUMBER_16977 for value: 16977
        /// </summary>
        NUMBER_16977 = 16977,

        /// <summary>
        /// Enum NUMBER_16724 for value: 16724
        /// </summary>
        NUMBER_16724 = 16724

    }

}
