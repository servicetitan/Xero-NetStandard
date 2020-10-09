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
    /// Report
    /// </summary>
    [DataContract]
    public partial class Report :  IEquatable<Report>, IValidatableObject
    {
        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportTypeEnum
        {
            /// <summary>
            /// Enum AgedPayablesByContact for value: AgedPayablesByContact
            /// </summary>
            [EnumMember(Value = "AgedPayablesByContact")]
            AgedPayablesByContact = 1

        }

        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [DataMember(Name="ReportType", EmitDefaultValue=false)]
        public ReportTypeEnum ReportType { get; set; }
        
        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [DataMember(Name="ReportID", EmitDefaultValue=false)]
        public string ReportID { get; set; }

        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [DataMember(Name="ReportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [DataMember(Name="ReportTitle", EmitDefaultValue=false)]
        public string ReportTitle { get; set; }

        /// <summary>
        /// Date of report
        /// </summary>
        /// <value>Date of report</value>
        [DataMember(Name="ReportDate", EmitDefaultValue=false)]
        public string ReportDate { get; set; }

        /// <summary>
        /// Updated Date
        /// </summary>
        /// <value>Updated Date</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="Contacts", EmitDefaultValue=false)]
        public List<TenNinetyNineContact> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Report {\n");
            sb.Append("  ReportID: ").Append(ReportID).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  ReportTitle: ").Append(ReportTitle).Append("\n");
            sb.Append("  ReportDate: ").Append(ReportDate).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as Report);
        }

        /// <summary>
        /// Returns true if Report instances are equal
        /// </summary>
        /// <param name="input">Instance of Report to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Report input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportID == input.ReportID ||
                    (this.ReportID != null &&
                    this.ReportID.Equals(input.ReportID))
                ) && 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    this.ReportType.Equals(input.ReportType)
                ) && 
                (
                    this.ReportTitle == input.ReportTitle ||
                    (this.ReportTitle != null &&
                    this.ReportTitle.Equals(input.ReportTitle))
                ) && 
                (
                    this.ReportDate == input.ReportDate ||
                    (this.ReportDate != null &&
                    this.ReportDate.Equals(input.ReportDate))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
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
                if (this.ReportID != null)
                    hashCode = hashCode * 59 + this.ReportID.GetHashCode();
                if (this.ReportName != null)
                    hashCode = hashCode * 59 + this.ReportName.GetHashCode();
                hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.ReportTitle != null)
                    hashCode = hashCode * 59 + this.ReportTitle.GetHashCode();
                if (this.ReportDate != null)
                    hashCode = hashCode * 59 + this.ReportDate.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
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
