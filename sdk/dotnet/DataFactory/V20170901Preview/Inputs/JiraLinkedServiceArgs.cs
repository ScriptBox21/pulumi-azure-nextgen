// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Jira Service linked service.
    /// </summary>
    public sealed class JiraLinkedServiceArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<ImmutableDictionary<string, object>>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public InputList<ImmutableDictionary<string, object>> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<ImmutableDictionary<string, object>>());
            set => _annotations = value;
        }

        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        [Input("connectVia")]
        public Input<Inputs.IntegrationRuntimeReferenceArgs>? ConnectVia { get; set; }

        /// <summary>
        /// Linked service description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("encryptedCredential")]
        private InputMap<object>? _encryptedCredential;

        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> EncryptedCredential
        {
            get => _encryptedCredential ?? (_encryptedCredential = new InputMap<object>());
            set => _encryptedCredential = value;
        }

        [Input("host", required: true)]
        private InputMap<object>? _host;

        /// <summary>
        /// The IP address or host name of the Jira service. (e.g. jira.example.com)
        /// </summary>
        public InputMap<object> Host
        {
            get => _host ?? (_host = new InputMap<object>());
            set => _host = value;
        }

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// The password corresponding to the user name that you provided in the username field.
        /// </summary>
        [Input("password")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? Password { get; set; }

        [Input("port")]
        private InputMap<object>? _port;

        /// <summary>
        /// The TCP port that the Jira server uses to listen for client connections. The default value is 443 if connecting through HTTPS, or 8080 if connecting through HTTP.
        /// </summary>
        public InputMap<object> Port
        {
            get => _port ?? (_port = new InputMap<object>());
            set => _port = value;
        }

        /// <summary>
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("useEncryptedEndpoints")]
        private InputMap<object>? _useEncryptedEndpoints;

        /// <summary>
        /// Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true.
        /// </summary>
        public InputMap<object> UseEncryptedEndpoints
        {
            get => _useEncryptedEndpoints ?? (_useEncryptedEndpoints = new InputMap<object>());
            set => _useEncryptedEndpoints = value;
        }

        [Input("useHostVerification")]
        private InputMap<object>? _useHostVerification;

        /// <summary>
        /// Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true.
        /// </summary>
        public InputMap<object> UseHostVerification
        {
            get => _useHostVerification ?? (_useHostVerification = new InputMap<object>());
            set => _useHostVerification = value;
        }

        [Input("usePeerVerification")]
        private InputMap<object>? _usePeerVerification;

        /// <summary>
        /// Specifies whether to verify the identity of the server when connecting over SSL. The default value is true.
        /// </summary>
        public InputMap<object> UsePeerVerification
        {
            get => _usePeerVerification ?? (_usePeerVerification = new InputMap<object>());
            set => _usePeerVerification = value;
        }

        [Input("username", required: true)]
        private InputMap<object>? _username;

        /// <summary>
        /// The user name that you use to access Jira Service.
        /// </summary>
        public InputMap<object> Username
        {
            get => _username ?? (_username = new InputMap<object>());
            set => _username = value;
        }

        public JiraLinkedServiceArgs()
        {
        }
    }
}