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
    /// ManualJournal
    /// </summary>
    [DataContract]
    public partial class ManualJournal :  IEquatable<ManualJournal>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// See Manual Journal Status Codes
        /// </summary>
        /// <value>See Manual Journal Status Codes</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,

            /// <summary>
            /// Enum POSTED for value: POSTED
            /// </summary>
            [EnumMember(Value = "POSTED")]
            POSTED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 4,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 5

        }

        /// <summary>
        /// See Manual Journal Status Codes
        /// </summary>
        /// <value>See Manual Journal Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualJournal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ManualJournal() 
        {  
          JournalLines = new List<ManualJournalLine>();  
          Warnings = new List<ValidationError>();  
          ValidationErrors = new List<ValidationError>();  
          Attachments = new List<Attachment>(); 
        }
        
        /// <summary>
        /// Description of journal being posted
        /// </summary>
        /// <value>Description of journal being posted</value>
        [DataMember(Name="Narration", EmitDefaultValue=false)]
        public string Narration { get; set; }

        /// <summary>
        /// See JournalLines
        /// </summary>
        /// <value>See JournalLines</value>
        [DataMember(Name="JournalLines", EmitDefaultValue=false)]
        public List<ManualJournalLine> JournalLines { get; set; }

        /// <summary>
        /// Date journal was posted – YYYY-MM-DD
        /// </summary>
        /// <value>Date journal was posted – YYYY-MM-DD</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Url link to a source document – shown as “Go to [appName]” in the Xero app
        /// </summary>
        /// <value>Url link to a source document – shown as “Go to [appName]” in the Xero app</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Boolean – default is true if not specified
        /// </summary>
        /// <value>Boolean – default is true if not specified</value>
        [DataMember(Name="ShowOnCashBasisReports", EmitDefaultValue=false)]
        public bool? ShowOnCashBasisReports { get; set; }

        /// <summary>
        /// Boolean to indicate if a manual journal has an attachment
        /// </summary>
        /// <value>Boolean to indicate if a manual journal has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// The Xero identifier for a Manual Journal
        /// </summary>
        /// <value>The Xero identifier for a Manual Journal</value>
        [DataMember(Name="ManualJournalID", EmitDefaultValue=false)]
        public Guid? ManualJournalID { get; set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Displays array of warning messages from the API
        /// </summary>
        /// <value>Displays array of warning messages from the API</value>
        [DataMember(Name="Warnings", EmitDefaultValue=false)]
        public List<ValidationError> Warnings { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Displays array of attachments from the API
        /// </summary>
        /// <value>Displays array of attachments from the API</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualJournal {\n");
            sb.Append("  Narration: ").Append(Narration).Append("\n");
            sb.Append("  JournalLines: ").Append(JournalLines).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ShowOnCashBasisReports: ").Append(ShowOnCashBasisReports).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  ManualJournalID: ").Append(ManualJournalID).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as ManualJournal);
        }

        /// <summary>
        /// Returns true if ManualJournal instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualJournal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualJournal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Narration == input.Narration ||
                    (this.Narration != null &&
                    this.Narration.Equals(input.Narration))
                ) && 
                (
                    this.JournalLines == input.JournalLines ||
                    this.JournalLines != null &&
                    input.JournalLines != null &&
                    this.JournalLines.SequenceEqual(input.JournalLines)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ShowOnCashBasisReports == input.ShowOnCashBasisReports ||
                    this.ShowOnCashBasisReports.Equals(input.ShowOnCashBasisReports)
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.ManualJournalID == input.ManualJournalID ||
                    (this.ManualJournalID != null &&
                    this.ManualJournalID.Equals(input.ManualJournalID))
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Narration != null)
                    hashCode = hashCode * 59 + this.Narration.GetHashCode();
                if (this.JournalLines != null)
                    hashCode = hashCode * 59 + this.JournalLines.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.ShowOnCashBasisReports.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.ManualJournalID != null)
                    hashCode = hashCode * 59 + this.ManualJournalID.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
