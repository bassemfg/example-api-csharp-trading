/* 
 * Tradovate API
 *
 * Tradovate API provides an access to the complete set of robust Tradovate functionality.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Tradovate.Services.Client.SwaggerDateConverter;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// ContactInfo
    /// </summary>
    [DataContract]
        public partial class ContactInfo :  IEquatable<ContactInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfo" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="streetAddress1">streetAddress1 (required).</param>
        /// <param name="streetAddress2">streetAddress2.</param>
        /// <param name="city">city (required).</param>
        /// <param name="state">state.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="country">country (required).</param>
        /// <param name="phone">phone (required).</param>
        /// <param name="mailingIsDifferent">mailingIsDifferent.</param>
        /// <param name="mailingStreetAddress1">mailingStreetAddress1.</param>
        /// <param name="mailingStreetAddress2">mailingStreetAddress2.</param>
        /// <param name="mailingCity">mailingCity.</param>
        /// <param name="mailingState">mailingState.</param>
        /// <param name="mailingPostCode">mailingPostCode.</param>
        /// <param name="mailingCountry">mailingCountry.</param>
        public ContactInfo(long? id = default(long?), long? userId = default(long?), string firstName = default(string), string lastName = default(string), string streetAddress1 = default(string), string streetAddress2 = default(string), string city = default(string), string state = default(string), string postCode = default(string), string country = default(string), string phone = default(string), bool? mailingIsDifferent = default(bool?), string mailingStreetAddress1 = default(string), string mailingStreetAddress2 = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingPostCode = default(string), string mailingCountry = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "streetAddress1" is required (not null)
            if (streetAddress1 == null)
            {
                throw new InvalidDataException("streetAddress1 is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.StreetAddress1 = streetAddress1;
            }
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.City = city;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for ContactInfo and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            this.Id = id;
            this.StreetAddress2 = streetAddress2;
            this.State = state;
            this.PostCode = postCode;
            this.MailingIsDifferent = mailingIsDifferent;
            this.MailingStreetAddress1 = mailingStreetAddress1;
            this.MailingStreetAddress2 = mailingStreetAddress2;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingPostCode = mailingPostCode;
            this.MailingCountry = mailingCountry;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress1
        /// </summary>
        [DataMember(Name="streetAddress1", EmitDefaultValue=false)]
        public string StreetAddress1 { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress2
        /// </summary>
        [DataMember(Name="streetAddress2", EmitDefaultValue=false)]
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets MailingIsDifferent
        /// </summary>
        [DataMember(Name="mailingIsDifferent", EmitDefaultValue=false)]
        public bool? MailingIsDifferent { get; set; }

        /// <summary>
        /// Gets or Sets MailingStreetAddress1
        /// </summary>
        [DataMember(Name="mailingStreetAddress1", EmitDefaultValue=false)]
        public string MailingStreetAddress1 { get; set; }

        /// <summary>
        /// Gets or Sets MailingStreetAddress2
        /// </summary>
        [DataMember(Name="mailingStreetAddress2", EmitDefaultValue=false)]
        public string MailingStreetAddress2 { get; set; }

        /// <summary>
        /// Gets or Sets MailingCity
        /// </summary>
        [DataMember(Name="mailingCity", EmitDefaultValue=false)]
        public string MailingCity { get; set; }

        /// <summary>
        /// Gets or Sets MailingState
        /// </summary>
        [DataMember(Name="mailingState", EmitDefaultValue=false)]
        public string MailingState { get; set; }

        /// <summary>
        /// Gets or Sets MailingPostCode
        /// </summary>
        [DataMember(Name="mailingPostCode", EmitDefaultValue=false)]
        public string MailingPostCode { get; set; }

        /// <summary>
        /// Gets or Sets MailingCountry
        /// </summary>
        [DataMember(Name="mailingCountry", EmitDefaultValue=false)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  StreetAddress1: ").Append(StreetAddress1).Append("\n");
            sb.Append("  StreetAddress2: ").Append(StreetAddress2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  MailingIsDifferent: ").Append(MailingIsDifferent).Append("\n");
            sb.Append("  MailingStreetAddress1: ").Append(MailingStreetAddress1).Append("\n");
            sb.Append("  MailingStreetAddress2: ").Append(MailingStreetAddress2).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingPostCode: ").Append(MailingPostCode).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
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
            return this.Equals(input as ContactInfo);
        }

        /// <summary>
        /// Returns true if ContactInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.StreetAddress1 == input.StreetAddress1 ||
                    (this.StreetAddress1 != null &&
                    this.StreetAddress1.Equals(input.StreetAddress1))
                ) && 
                (
                    this.StreetAddress2 == input.StreetAddress2 ||
                    (this.StreetAddress2 != null &&
                    this.StreetAddress2.Equals(input.StreetAddress2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.MailingIsDifferent == input.MailingIsDifferent ||
                    (this.MailingIsDifferent != null &&
                    this.MailingIsDifferent.Equals(input.MailingIsDifferent))
                ) && 
                (
                    this.MailingStreetAddress1 == input.MailingStreetAddress1 ||
                    (this.MailingStreetAddress1 != null &&
                    this.MailingStreetAddress1.Equals(input.MailingStreetAddress1))
                ) && 
                (
                    this.MailingStreetAddress2 == input.MailingStreetAddress2 ||
                    (this.MailingStreetAddress2 != null &&
                    this.MailingStreetAddress2.Equals(input.MailingStreetAddress2))
                ) && 
                (
                    this.MailingCity == input.MailingCity ||
                    (this.MailingCity != null &&
                    this.MailingCity.Equals(input.MailingCity))
                ) && 
                (
                    this.MailingState == input.MailingState ||
                    (this.MailingState != null &&
                    this.MailingState.Equals(input.MailingState))
                ) && 
                (
                    this.MailingPostCode == input.MailingPostCode ||
                    (this.MailingPostCode != null &&
                    this.MailingPostCode.Equals(input.MailingPostCode))
                ) && 
                (
                    this.MailingCountry == input.MailingCountry ||
                    (this.MailingCountry != null &&
                    this.MailingCountry.Equals(input.MailingCountry))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.StreetAddress1 != null)
                    hashCode = hashCode * 59 + this.StreetAddress1.GetHashCode();
                if (this.StreetAddress2 != null)
                    hashCode = hashCode * 59 + this.StreetAddress2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.MailingIsDifferent != null)
                    hashCode = hashCode * 59 + this.MailingIsDifferent.GetHashCode();
                if (this.MailingStreetAddress1 != null)
                    hashCode = hashCode * 59 + this.MailingStreetAddress1.GetHashCode();
                if (this.MailingStreetAddress2 != null)
                    hashCode = hashCode * 59 + this.MailingStreetAddress2.GetHashCode();
                if (this.MailingCity != null)
                    hashCode = hashCode * 59 + this.MailingCity.GetHashCode();
                if (this.MailingState != null)
                    hashCode = hashCode * 59 + this.MailingState.GetHashCode();
                if (this.MailingPostCode != null)
                    hashCode = hashCode * 59 + this.MailingPostCode.GetHashCode();
                if (this.MailingCountry != null)
                    hashCode = hashCode * 59 + this.MailingCountry.GetHashCode();
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
