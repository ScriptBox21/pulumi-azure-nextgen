// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    public static class ListCustomApiWsdlInterfaces
    {
        public static Task<ListCustomApiWsdlInterfacesResult> InvokeAsync(ListCustomApiWsdlInterfacesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListCustomApiWsdlInterfacesResult>("azure-nextgen:web/latest:listCustomApiWsdlInterfaces", args ?? new ListCustomApiWsdlInterfacesArgs(), options.WithVersion());
    }


    public sealed class ListCustomApiWsdlInterfacesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The WSDL content
        /// </summary>
        [Input("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The WSDL import method
        /// </summary>
        [Input("importMethod")]
        public string? ImportMethod { get; set; }

        /// <summary>
        /// The location
        /// </summary>
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// The service with name and endpoint names
        /// </summary>
        [Input("service")]
        public Inputs.WsdlServiceArgs? Service { get; set; }

        /// <summary>
        /// The WSDL URL
        /// </summary>
        [Input("url")]
        public string? Url { get; set; }

        public ListCustomApiWsdlInterfacesArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListCustomApiWsdlInterfacesResult
    {
        /// <summary>
        /// Collection of WSDL interfaces
        /// </summary>
        public readonly ImmutableArray<Outputs.WsdlServiceResponse> Value;

        [OutputConstructor]
        private ListCustomApiWsdlInterfacesResult(ImmutableArray<Outputs.WsdlServiceResponse> value)
        {
            Value = value;
        }
    }
}