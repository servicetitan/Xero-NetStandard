/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Employee
    /// </summary>
    [DataContract]
    public partial class Employee :  IEquatable<Employee>, IValidatableObject
    {
        /// <summary>
        /// Current status of an employee – see contact status types
        /// </summary>
        /// <value>Current status of an employee – see contact status types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 2,

            /// <summary>
            /// Enum GDPRREQUEST for value: GDPRREQUEST
            /// </summary>
            [EnumMember(Value = "GDPRREQUEST")]
            GDPRREQUEST = 3,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 4

        }

        /// <summary>
        /// Current status of an employee – see contact status types
        /// </summary>
        /// <value>Current status of an employee – see contact status types</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// The Xero identifier for an employee e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>The Xero identifier for an employee e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// First name of an employee (max length &#x3D; 255)
        /// </summary>
        /// <value>First name of an employee (max length &#x3D; 255)</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of an employee (max length &#x3D; 255)
        /// </summary>
        /// <value>Last name of an employee (max length &#x3D; 255)</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [DataMember(Name="ExternalLink", EmitDefaultValue=false)]
        public ExternalLink ExternalLink { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDateUTC
        /// </summary>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employee {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as Employee);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="input">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ExternalLink == input.ExternalLink ||
                    (this.ExternalLink != null &&
                    this.ExternalLink.Equals(input.ExternalLink))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.ExternalLink != null)
                    hashCode = hashCode * 59 + this.ExternalLink.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 255.", new [] { "LastName" });
            }

            yield break;
        }
    }

}
