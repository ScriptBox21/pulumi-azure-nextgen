// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ImportExport.V20161101.Inputs
{

    /// <summary>
    /// Specifies the job properties
    /// </summary>
    public sealed class JobDetailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Default value is false. Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        [Input("backupDriveManifest")]
        public Input<bool>? BackupDriveManifest { get; set; }

        /// <summary>
        /// Indicates whether a request has been submitted to cancel the job.
        /// </summary>
        [Input("cancelRequested")]
        public Input<bool>? CancelRequested { get; set; }

        /// <summary>
        /// Contains information about the package being shipped by the customer to the Microsoft data center. 
        /// </summary>
        [Input("deliveryPackage")]
        public Input<Inputs.PackageInfomationArgs>? DeliveryPackage { get; set; }

        /// <summary>
        /// The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.
        /// </summary>
        [Input("diagnosticsPath")]
        public Input<string>? DiagnosticsPath { get; set; }

        [Input("driveList")]
        private InputList<Inputs.DriveStatusArgs>? _driveList;

        /// <summary>
        /// List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified for export jobs.
        /// </summary>
        public InputList<Inputs.DriveStatusArgs> DriveList
        {
            get => _driveList ?? (_driveList = new InputList<Inputs.DriveStatusArgs>());
            set => _driveList = value;
        }

        /// <summary>
        /// A property containing information about the blobs to be exported for an export job. This property is included for export jobs only.
        /// </summary>
        [Input("export")]
        public Input<Inputs.ExportArgs>? Export { get; set; }

        /// <summary>
        /// A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive space. If all blobs were exported successfully, then this element is not included in the response.
        /// </summary>
        [Input("incompleteBlobListUri")]
        public Input<string>? IncompleteBlobListUri { get; set; }

        /// <summary>
        /// The type of job
        /// </summary>
        [Input("jobType")]
        public Input<string>? JobType { get; set; }

        /// <summary>
        /// Default value is Error. Indicates whether error logging or verbose logging will be enabled.
        /// </summary>
        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        /// <summary>
        /// Overall percentage completed for the job.
        /// </summary>
        [Input("percentComplete")]
        public Input<int>? PercentComplete { get; set; }

        /// <summary>
        /// Specifies the provisioning state of the job.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// Specifies the return address information for the job. 
        /// </summary>
        [Input("returnAddress")]
        public Input<Inputs.ReturnAddressArgs>? ReturnAddress { get; set; }

        /// <summary>
        /// Contains information about the package being shipped from the Microsoft data center to the customer to return the drives. The format is the same as the deliveryPackage property above. This property is not included if the drives have not yet been returned. 
        /// </summary>
        [Input("returnPackage")]
        public Input<Inputs.PackageInfomationArgs>? ReturnPackage { get; set; }

        /// <summary>
        /// Specifies the return carrier and customer's account with the carrier. 
        /// </summary>
        [Input("returnShipping")]
        public Input<Inputs.ReturnShippingArgs>? ReturnShipping { get; set; }

        /// <summary>
        /// Contains information about the Microsoft datacenter to which the drives should be shipped. 
        /// </summary>
        [Input("shippingInformation")]
        public Input<Inputs.ShippingInformationArgs>? ShippingInformation { get; set; }

        /// <summary>
        /// Current state of the job.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The resource identifier of the storage account where data will be imported to or exported from.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        public JobDetailsArgs()
        {
        }
    }
}