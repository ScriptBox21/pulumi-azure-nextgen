// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Inputs
{

    public sealed class LoginArgs : Pulumi.ResourceArgs
    {
        [Input("allowedExternalRedirectUrls")]
        private InputList<string>? _allowedExternalRedirectUrls;
        public InputList<string> AllowedExternalRedirectUrls
        {
            get => _allowedExternalRedirectUrls ?? (_allowedExternalRedirectUrls = new InputList<string>());
            set => _allowedExternalRedirectUrls = value;
        }

        [Input("cookieExpiration")]
        public Input<Inputs.CookieExpirationArgs>? CookieExpiration { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("nonce")]
        public Input<Inputs.NonceArgs>? Nonce { get; set; }

        [Input("preserveUrlFragmentsForLogins")]
        public Input<bool>? PreserveUrlFragmentsForLogins { get; set; }

        [Input("routes")]
        public Input<Inputs.LoginRoutesArgs>? Routes { get; set; }

        [Input("tokenStore")]
        public Input<Inputs.TokenStoreArgs>? TokenStore { get; set; }

        public LoginArgs()
        {
        }
    }
}
