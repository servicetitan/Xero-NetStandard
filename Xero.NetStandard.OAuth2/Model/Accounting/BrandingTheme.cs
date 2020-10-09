/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.3
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// BrandingTheme
    /// </summary>
    [DataContract]
    public partial class BrandingTheme :  IEquatable<BrandingTheme>, IValidatableObject
    {
        /// <summary>
        /// Always INVOICE
        /// </summary>
        /// <value>Always INVOICE</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum INVOICE for value: INVOICE
            /// </summary>
            [EnumMember(Value = "INVOICE")]
            INVOICE = 1

        }

        /// <summary>
        /// Always INVOICE
        /// </summary>
        /// <value>Always INVOICE</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="BrandingThemeID", EmitDefaultValue=false)]
        public Guid? BrandingThemeID { get; set; }

        /// <summary>
        /// Name of branding theme
        /// </summary>
        /// <value>Name of branding theme</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The location of the image file used as the logo on this branding theme
        /// </summary>
        /// <value>The location of the image file used as the logo on this branding theme</value>
        [DataMember(Name="LogoUrl", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Integer – ranked order of branding theme. The default branding theme has a value of 0
        /// </summary>
        /// <value>Integer – ranked order of branding theme. The default branding theme has a value of 0</value>
        [DataMember(Name="SortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// UTC timestamp of creation date of branding theme
        /// </summary>
        /// <value>UTC timestamp of creation date of branding theme</value>
        [DataMember(Name="CreatedDateUTC", EmitDefaultValue=false)]
        public DateTime? CreatedDateUTC { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandingTheme {\n");
            sb.Append("  BrandingThemeID: ").Append(BrandingThemeID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  CreatedDateUTC: ").Append(CreatedDateUTC).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BrandingTheme);
        }

        /// <summary>
        /// Returns true if BrandingTheme instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandingTheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandingTheme input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrandingThemeID == input.BrandingThemeID ||
                    (this.BrandingThemeID != null &&
                    this.BrandingThemeID.Equals(input.BrandingThemeID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
                ) && 
                (
                    this.CreatedDateUTC == input.CreatedDateUTC ||
                    (this.CreatedDateUTC != null &&
                    this.CreatedDateUTC.Equals(input.CreatedDateUTC))
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
                if (this.BrandingThemeID != null)
                    hashCode = hashCode * 59 + this.BrandingThemeID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.CreatedDateUTC != null)
                    hashCode = hashCode * 59 + this.CreatedDateUTC.GetHashCode();
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
