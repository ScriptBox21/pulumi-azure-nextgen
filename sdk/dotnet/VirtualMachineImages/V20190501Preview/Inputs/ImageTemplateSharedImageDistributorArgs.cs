// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VirtualMachineImages.V20190501Preview.Inputs
{

    /// <summary>
    /// Distribute via Shared Image Gallery.
    /// </summary>
    public sealed class ImageTemplateSharedImageDistributorArgs : Pulumi.ResourceArgs
    {
        [Input("artifactTags")]
        private InputMap<string>? _artifactTags;

        /// <summary>
        /// Tags that will be applied to the artifact once it has been created/updated by the distributor.
        /// </summary>
        public InputMap<string> ArtifactTags
        {
            get => _artifactTags ?? (_artifactTags = new InputMap<string>());
            set => _artifactTags = value;
        }

        /// <summary>
        /// Resource Id of the Shared Image Gallery image
        /// </summary>
        [Input("galleryImageId", required: true)]
        public Input<string> GalleryImageId { get; set; } = null!;

        [Input("replicationRegions", required: true)]
        private InputList<string>? _replicationRegions;

        /// <summary>
        /// A list of regions that the image will be replicated to
        /// </summary>
        public InputList<string> ReplicationRegions
        {
            get => _replicationRegions ?? (_replicationRegions = new InputList<string>());
            set => _replicationRegions = value;
        }

        /// <summary>
        /// The name to be used for the associated RunOutput.
        /// </summary>
        [Input("runOutputName", required: true)]
        public Input<string> RunOutputName { get; set; } = null!;

        /// <summary>
        /// Type of distribution.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ImageTemplateSharedImageDistributorArgs()
        {
        }
    }
}