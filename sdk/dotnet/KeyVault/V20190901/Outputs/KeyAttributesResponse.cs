// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.KeyVault.V20190901.Outputs
{

    [OutputType]
    public sealed class KeyAttributesResponse
    {
        /// <summary>
        /// Creation time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        public readonly int Created;
        /// <summary>
        /// Determines whether or not the object is enabled.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Expiry date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        public readonly int? Expires;
        /// <summary>
        /// Not before date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        public readonly int? NotBefore;
        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        public readonly string RecoveryLevel;
        /// <summary>
        /// Last updated time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        public readonly int Updated;

        [OutputConstructor]
        private KeyAttributesResponse(
            int created,

            bool? enabled,

            int? expires,

            int? notBefore,

            string recoveryLevel,

            int updated)
        {
            Created = created;
            Enabled = enabled;
            Expires = expires;
            NotBefore = notBefore;
            RecoveryLevel = recoveryLevel;
            Updated = updated;
        }
    }
}
