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
    /// MarketDataSubscriptionResponse
    /// </summary>
    [DataContract]
        public partial class MarketDataSubscriptionResponse :  IEquatable<MarketDataSubscriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// ConflictWithExisting, DowngradeNotAllowed, IncompatibleCMEMarketDataSubscriptionPlans, IncorrectPaymentMethod, InsufficientFunds, PaymentProviderError, PlanDiscontinued, SingleTrialOnly, Success, UnknownError
        /// </summary>
        /// <value>ConflictWithExisting, DowngradeNotAllowed, IncompatibleCMEMarketDataSubscriptionPlans, IncorrectPaymentMethod, InsufficientFunds, PaymentProviderError, PlanDiscontinued, SingleTrialOnly, Success, UnknownError</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ErrorCodeEnum
        {
            /// <summary>
            /// Enum ConflictWithExisting for value: ConflictWithExisting
            /// </summary>
            [EnumMember(Value = "ConflictWithExisting")]
            ConflictWithExisting = 1,
            /// <summary>
            /// Enum DowngradeNotAllowed for value: DowngradeNotAllowed
            /// </summary>
            [EnumMember(Value = "DowngradeNotAllowed")]
            DowngradeNotAllowed = 2,
            /// <summary>
            /// Enum IncompatibleCMEMarketDataSubscriptionPlans for value: IncompatibleCMEMarketDataSubscriptionPlans
            /// </summary>
            [EnumMember(Value = "IncompatibleCMEMarketDataSubscriptionPlans")]
            IncompatibleCMEMarketDataSubscriptionPlans = 3,
            /// <summary>
            /// Enum IncorrectPaymentMethod for value: IncorrectPaymentMethod
            /// </summary>
            [EnumMember(Value = "IncorrectPaymentMethod")]
            IncorrectPaymentMethod = 4,
            /// <summary>
            /// Enum InsufficientFunds for value: InsufficientFunds
            /// </summary>
            [EnumMember(Value = "InsufficientFunds")]
            InsufficientFunds = 5,
            /// <summary>
            /// Enum PaymentProviderError for value: PaymentProviderError
            /// </summary>
            [EnumMember(Value = "PaymentProviderError")]
            PaymentProviderError = 6,
            /// <summary>
            /// Enum PlanDiscontinued for value: PlanDiscontinued
            /// </summary>
            [EnumMember(Value = "PlanDiscontinued")]
            PlanDiscontinued = 7,
            /// <summary>
            /// Enum SingleTrialOnly for value: SingleTrialOnly
            /// </summary>
            [EnumMember(Value = "SingleTrialOnly")]
            SingleTrialOnly = 8,
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 9,
            /// <summary>
            /// Enum UnknownError for value: UnknownError
            /// </summary>
            [EnumMember(Value = "UnknownError")]
            UnknownError = 10        }
        /// <summary>
        /// ConflictWithExisting, DowngradeNotAllowed, IncompatibleCMEMarketDataSubscriptionPlans, IncorrectPaymentMethod, InsufficientFunds, PaymentProviderError, PlanDiscontinued, SingleTrialOnly, Success, UnknownError
        /// </summary>
        /// <value>ConflictWithExisting, DowngradeNotAllowed, IncompatibleCMEMarketDataSubscriptionPlans, IncorrectPaymentMethod, InsufficientFunds, PaymentProviderError, PlanDiscontinued, SingleTrialOnly, Success, UnknownError</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="errorText">Non-empty if the request failed.</param>
        /// <param name="errorCode">ConflictWithExisting, DowngradeNotAllowed, IncompatibleCMEMarketDataSubscriptionPlans, IncorrectPaymentMethod, InsufficientFunds, PaymentProviderError, PlanDiscontinued, SingleTrialOnly, Success, UnknownError.</param>
        /// <param name="marketDataSubscription">marketDataSubscription.</param>
        public MarketDataSubscriptionResponse(string errorText = default(string), ErrorCodeEnum? errorCode = default(ErrorCodeEnum?), MarketDataSubscription marketDataSubscription = default(MarketDataSubscription))
        {
            this.ErrorText = errorText;
            this.ErrorCode = errorCode;
            this.MarketDataSubscription = marketDataSubscription;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }


        /// <summary>
        /// Gets or Sets MarketDataSubscription
        /// </summary>
        [DataMember(Name="marketDataSubscription", EmitDefaultValue=false)]
        public MarketDataSubscription MarketDataSubscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketDataSubscriptionResponse {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  MarketDataSubscription: ").Append(MarketDataSubscription).Append("\n");
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
            return this.Equals(input as MarketDataSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if MarketDataSubscriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketDataSubscriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketDataSubscriptionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.MarketDataSubscription == input.MarketDataSubscription ||
                    (this.MarketDataSubscription != null &&
                    this.MarketDataSubscription.Equals(input.MarketDataSubscription))
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
                if (this.ErrorText != null)
                    hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.MarketDataSubscription != null)
                    hashCode = hashCode * 59 + this.MarketDataSubscription.GetHashCode();
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
