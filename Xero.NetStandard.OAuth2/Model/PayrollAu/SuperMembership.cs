/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// SuperMembership
    /// </summary>
    [DataContract]
    public partial class SuperMembership :  IEquatable<SuperMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuperMembership" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SuperMembership() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for Super membership
        /// </summary>
        /// <value>Xero unique identifier for Super membership</value>
        [DataMember(Name="SuperMembershipID", EmitDefaultValue=false)]
        public Guid? SuperMembershipID { get; set; }

        /// <summary>
        /// Xero identifier for super fund
        /// </summary>
        /// <value>Xero identifier for super fund</value>
        [DataMember(Name="SuperFundID", EmitDefaultValue=false)]
        public Guid? SuperFundID { get; set; }

        /// <summary>
        /// The memberhsip number assigned to the employee by the super fund.
        /// </summary>
        /// <value>The memberhsip number assigned to the employee by the super fund.</value>
        [DataMember(Name="EmployeeNumber", EmitDefaultValue=false)]
        public decimal? EmployeeNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperMembership {\n");
            sb.Append("  SuperMembershipID: ").Append(SuperMembershipID).Append("\n");
            sb.Append("  SuperFundID: ").Append(SuperFundID).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
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
            return this.Equals(input as SuperMembership);
        }

        /// <summary>
        /// Returns true if SuperMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuperMembershipID == input.SuperMembershipID ||
                    (this.SuperMembershipID != null &&
                    this.SuperMembershipID.Equals(input.SuperMembershipID))
                ) && 
                (
                    this.SuperFundID == input.SuperFundID ||
                    (this.SuperFundID != null &&
                    this.SuperFundID.Equals(input.SuperFundID))
                ) && 
                (
                    this.EmployeeNumber == input.EmployeeNumber ||
                    this.EmployeeNumber.Equals(input.EmployeeNumber)
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
                if (this.SuperMembershipID != null)
                    hashCode = hashCode * 59 + this.SuperMembershipID.GetHashCode();
                if (this.SuperFundID != null)
                    hashCode = hashCode * 59 + this.SuperFundID.GetHashCode();
                hashCode = hashCode * 59 + this.EmployeeNumber.GetHashCode();
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
