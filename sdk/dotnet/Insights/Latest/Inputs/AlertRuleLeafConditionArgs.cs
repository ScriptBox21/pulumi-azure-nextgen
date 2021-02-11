// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.Latest.Inputs
{

    /// <summary>
    /// An Activity Log Alert rule condition that is met by comparing the field and value of an Activity Log event.
    /// This condition must contain 'field' and either 'equals' or 'containsAny'.
    /// </summary>
    public sealed class AlertRuleLeafConditionArgs : Pulumi.ResourceArgs
    {
        [Input("containsAny")]
        private InputList<string>? _containsAny;

        /// <summary>
        /// The value of the event's field will be compared to the values in this array (case-insensitive) to determine if the condition is met.
        /// </summary>
        public InputList<string> ContainsAny
        {
            get => _containsAny ?? (_containsAny = new InputList<string>());
            set => _containsAny = value;
        }

        /// <summary>
        /// The value of the event's field will be compared to this value (case-insensitive) to determine if the condition is met.
        /// </summary>
        [Input("equals")]
        public Input<string>? Equals { get; set; }

        /// <summary>
        /// The name of the Activity Log event's field that this condition will examine.
        /// The possible values for this field are (case-insensitive): 'resourceId', 'category', 'caller', 'level', 'operationName', 'resourceGroup', 'resourceProvider', 'status', 'subStatus', 'resourceType', or anything beginning with 'properties'.
        /// </summary>
        [Input("field")]
        public Input<string>? Field { get; set; }

        public AlertRuleLeafConditionArgs()
        {
        }
    }
}
