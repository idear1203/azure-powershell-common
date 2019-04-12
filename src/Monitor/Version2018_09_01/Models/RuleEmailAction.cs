// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the action to send email when the rule condition is
    /// evaluated. The discriminator is always RuleEmailAction in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.RuleEmailAction")]
    public partial class RuleEmailAction : RuleAction
    {
        /// <summary>
        /// Initializes a new instance of the RuleEmailAction class.
        /// </summary>
        public RuleEmailAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleEmailAction class.
        /// </summary>
        /// <param name="sendToServiceOwners">Whether the administrators
        /// (service and co-administrators) of the service should be notified
        /// when the alert is activated.</param>
        /// <param name="customEmails">the list of administrator's custom email
        /// addresses to notify of the activation of the alert.</param>
        public RuleEmailAction(bool? sendToServiceOwners = default(bool?), IList<string> customEmails = default(IList<string>))
        {
            SendToServiceOwners = sendToServiceOwners;
            CustomEmails = customEmails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the administrators (service and
        /// co-administrators) of the service should be notified when the alert
        /// is activated.
        /// </summary>
        [JsonProperty(PropertyName = "sendToServiceOwners")]
        public bool? SendToServiceOwners { get; set; }

        /// <summary>
        /// Gets or sets the list of administrator's custom email addresses to
        /// notify of the activation of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "customEmails")]
        public IList<string> CustomEmails { get; set; }

    }
}
