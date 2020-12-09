// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Inputs
{

    /// <summary>
    /// The IIS handler mappings used to define which handler processes HTTP requests with certain extension. 
    /// For example, it is used to configure php-cgi.exe process to handle all HTTP requests with *.php extension.
    /// </summary>
    public sealed class HandlerMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Command-line arguments to be passed to the script processor.
        /// </summary>
        [Input("arguments")]
        public Input<string>? Arguments { get; set; }

        /// <summary>
        /// Requests with this extension will be handled using the specified FastCGI application.
        /// </summary>
        [Input("extension")]
        public Input<string>? Extension { get; set; }

        /// <summary>
        /// The absolute path to the FastCGI application.
        /// </summary>
        [Input("scriptProcessor")]
        public Input<string>? ScriptProcessor { get; set; }

        public HandlerMappingArgs()
        {
        }
    }
}
