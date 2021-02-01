// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StoragePool.V20200315Preview.Outputs
{

    [OutputType]
    public sealed class TargetPortalGroupResponse
    {
        /// <summary>
        /// Access Control List (ACL) for an iSCSI target portal group.
        /// </summary>
        public readonly ImmutableArray<Outputs.AclResponse> Acls;
        /// <summary>
        /// Attributes of an iSCSI target portal group.
        /// </summary>
        public readonly Outputs.AttributesResponse Attributes;
        /// <summary>
        /// List of private IPv4 addresses to connect to the iSCSI target.
        /// </summary>
        public readonly ImmutableArray<string> Endpoints;
        /// <summary>
        /// List of LUNs to be exposed through iSCSI target portal group.
        /// </summary>
        public readonly ImmutableArray<Outputs.IscsiLunResponse> Luns;
        /// <summary>
        /// The port used by iSCSI target portal group.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The tag associated with the iSCSI target portal group.
        /// </summary>
        public readonly int Tag;

        [OutputConstructor]
        private TargetPortalGroupResponse(
            ImmutableArray<Outputs.AclResponse> acls,

            Outputs.AttributesResponse attributes,

            ImmutableArray<string> endpoints,

            ImmutableArray<Outputs.IscsiLunResponse> luns,

            int port,

            int tag)
        {
            Acls = acls;
            Attributes = attributes;
            Endpoints = endpoints;
            Luns = luns;
            Port = port;
            Tag = tag;
        }
    }
}
