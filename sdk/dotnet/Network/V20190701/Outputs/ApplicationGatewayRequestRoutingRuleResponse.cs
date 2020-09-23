// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayRequestRoutingRuleResponse
    {
        /// <summary>
        /// Backend address pool resource of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BackendAddressPool;
        /// <summary>
        /// Backend http settings resource of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BackendHttpSettings;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Http listener resource of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? HttpListener;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the request routing rule that is unique within an Application Gateway.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Priority of the request routing rule.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// The provisioning state of the request routing rule resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Redirect configuration resource of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RedirectConfiguration;
        /// <summary>
        /// Rewrite Rule Set resource in Basic rule of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RewriteRuleSet;
        /// <summary>
        /// Rule type.
        /// </summary>
        public readonly string? RuleType;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// URL path map resource of the application gateway.
        /// </summary>
        public readonly Outputs.SubResourceResponse? UrlPathMap;

        [OutputConstructor]
        private ApplicationGatewayRequestRoutingRuleResponse(
            Outputs.SubResourceResponse? backendAddressPool,

            Outputs.SubResourceResponse? backendHttpSettings,

            string? etag,

            Outputs.SubResourceResponse? httpListener,

            string? id,

            string? name,

            int? priority,

            string provisioningState,

            Outputs.SubResourceResponse? redirectConfiguration,

            Outputs.SubResourceResponse? rewriteRuleSet,

            string? ruleType,

            string? type,

            Outputs.SubResourceResponse? urlPathMap)
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            Etag = etag;
            HttpListener = httpListener;
            Id = id;
            Name = name;
            Priority = priority;
            ProvisioningState = provisioningState;
            RedirectConfiguration = redirectConfiguration;
            RewriteRuleSet = rewriteRuleSet;
            RuleType = ruleType;
            Type = type;
            UrlPathMap = urlPathMap;
        }
    }
}
