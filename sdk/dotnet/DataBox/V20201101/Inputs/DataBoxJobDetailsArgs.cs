// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20201101.Inputs
{

    /// <summary>
    /// Databox Job Details
    /// </summary>
    public sealed class DataBoxJobDetailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Contact details for notification and shipping.
        /// </summary>
        [Input("contactDetails", required: true)]
        public Input<Inputs.ContactDetailsArgs> ContactDetails { get; set; } = null!;

        [Input("dataExportDetails")]
        private InputList<Inputs.DataExportDetailsArgs>? _dataExportDetails;

        /// <summary>
        /// Details of the data to be exported from azure.
        /// </summary>
        public InputList<Inputs.DataExportDetailsArgs> DataExportDetails
        {
            get => _dataExportDetails ?? (_dataExportDetails = new InputList<Inputs.DataExportDetailsArgs>());
            set => _dataExportDetails = value;
        }

        [Input("dataImportDetails")]
        private InputList<Inputs.DataImportDetailsArgs>? _dataImportDetails;

        /// <summary>
        /// Details of the data to be imported into azure.
        /// </summary>
        public InputList<Inputs.DataImportDetailsArgs> DataImportDetails
        {
            get => _dataImportDetails ?? (_dataImportDetails = new InputList<Inputs.DataImportDetailsArgs>());
            set => _dataImportDetails = value;
        }

        /// <summary>
        /// Set Device password for unlocking Databox. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Input("devicePassword")]
        public Input<string>? DevicePassword { get; set; }

        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Input("expectedDataSizeInTeraBytes")]
        public Input<int>? ExpectedDataSizeInTeraBytes { get; set; }

        /// <summary>
        /// Indicates the type of job details.
        /// Expected value is 'DataBox'.
        /// </summary>
        [Input("jobDetailsType", required: true)]
        public Input<string> JobDetailsType { get; set; } = null!;

        /// <summary>
        /// Details about which key encryption type is being used.
        /// </summary>
        [Input("keyEncryptionKey")]
        public Input<Inputs.KeyEncryptionKeyArgs>? KeyEncryptionKey { get; set; }

        /// <summary>
        /// Preferences for the order.
        /// </summary>
        [Input("preferences")]
        public Input<Inputs.PreferencesArgs>? Preferences { get; set; }

        /// <summary>
        /// Shipping address of the customer.
        /// </summary>
        [Input("shippingAddress")]
        public Input<Inputs.ShippingAddressArgs>? ShippingAddress { get; set; }

        public DataBoxJobDetailsArgs()
        {
        }
    }
}
