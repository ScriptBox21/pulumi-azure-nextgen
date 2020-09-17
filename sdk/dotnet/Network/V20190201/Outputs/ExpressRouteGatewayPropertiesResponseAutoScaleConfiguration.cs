// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190201.Outputs
{

    [OutputType]
    public sealed class ExpressRouteGatewayPropertiesResponseAutoScaleConfiguration
    {
        /// <summary>
        /// Minimum and maximum number of scale units to deploy.
        /// </summary>
        public readonly Outputs.ExpressRouteGatewayPropertiesResponseBounds? Bounds;

        [OutputConstructor]
        private ExpressRouteGatewayPropertiesResponseAutoScaleConfiguration(Outputs.ExpressRouteGatewayPropertiesResponseBounds? bounds)
        {
            Bounds = bounds;
        }
    }
}