/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.2.13
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// See Asset Status Codes.
    /// </summary>
    /// <value>See Asset Status Codes.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AssetStatusQueryParam
    {
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 1,

        /// <summary>
        /// Enum REGISTERED for value: REGISTERED
        /// </summary>
        [EnumMember(Value = "REGISTERED")]
        REGISTERED = 2,

        /// <summary>
        /// Enum DISPOSED for value: DISPOSED
        /// </summary>
        [EnumMember(Value = "DISPOSED")]
        DISPOSED = 3

    }

}
