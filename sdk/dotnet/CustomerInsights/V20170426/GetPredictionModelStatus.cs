// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426
{
    public static class GetPredictionModelStatus
    {
        public static Task<GetPredictionModelStatusResult> InvokeAsync(GetPredictionModelStatusArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPredictionModelStatusResult>("azure-nextgen:customerinsights/v20170426:getPredictionModelStatus", args ?? new GetPredictionModelStatusArgs(), options.WithVersion());
    }


    public sealed class GetPredictionModelStatusArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the hub.
        /// </summary>
        [Input("hubName", required: true)]
        public string HubName { get; set; } = null!;

        /// <summary>
        /// The name of the Prediction.
        /// </summary>
        [Input("predictionName", required: true)]
        public string PredictionName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPredictionModelStatusArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPredictionModelStatusResult
    {
        /// <summary>
        /// The model status message.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Version of the model.
        /// </summary>
        public readonly string ModelVersion;
        /// <summary>
        /// The prediction GUID ID.
        /// </summary>
        public readonly string PredictionGuidId;
        /// <summary>
        /// The prediction name.
        /// </summary>
        public readonly string PredictionName;
        /// <summary>
        /// The signals used.
        /// </summary>
        public readonly int SignalsUsed;
        /// <summary>
        /// Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The hub name.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Count of the test set.
        /// </summary>
        public readonly int TestSetCount;
        /// <summary>
        /// The training accuracy.
        /// </summary>
        public readonly int TrainingAccuracy;
        /// <summary>
        /// Count of the training set.
        /// </summary>
        public readonly int TrainingSetCount;
        /// <summary>
        /// Count of the validation set.
        /// </summary>
        public readonly int ValidationSetCount;

        [OutputConstructor]
        private GetPredictionModelStatusResult(
            string message,

            string modelVersion,

            string predictionGuidId,

            string predictionName,

            int signalsUsed,

            string status,

            string tenantId,

            int testSetCount,

            int trainingAccuracy,

            int trainingSetCount,

            int validationSetCount)
        {
            Message = message;
            ModelVersion = modelVersion;
            PredictionGuidId = predictionGuidId;
            PredictionName = predictionName;
            SignalsUsed = signalsUsed;
            Status = status;
            TenantId = tenantId;
            TestSetCount = testSetCount;
            TrainingAccuracy = trainingAccuracy;
            TrainingSetCount = trainingSetCount;
            ValidationSetCount = validationSetCount;
        }
    }
}
