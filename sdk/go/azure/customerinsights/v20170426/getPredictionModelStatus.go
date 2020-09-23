// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170426

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetPredictionModelStatus(ctx *pulumi.Context, args *GetPredictionModelStatusArgs, opts ...pulumi.InvokeOption) (*GetPredictionModelStatusResult, error) {
	var rv GetPredictionModelStatusResult
	err := ctx.Invoke("azure-nextgen:customerinsights/v20170426:getPredictionModelStatus", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetPredictionModelStatusArgs struct {
	// The name of the hub.
	HubName string `pulumi:"hubName"`
	// The name of the Prediction.
	PredictionName string `pulumi:"predictionName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The prediction model status.
type GetPredictionModelStatusResult struct {
	// The model status message.
	Message string `pulumi:"message"`
	// Version of the model.
	ModelVersion string `pulumi:"modelVersion"`
	// The prediction GUID ID.
	PredictionGuidId string `pulumi:"predictionGuidId"`
	// The prediction name.
	PredictionName string `pulumi:"predictionName"`
	// The signals used.
	SignalsUsed int `pulumi:"signalsUsed"`
	// Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API.
	Status string `pulumi:"status"`
	// The hub name.
	TenantId string `pulumi:"tenantId"`
	// Count of the test set.
	TestSetCount int `pulumi:"testSetCount"`
	// The training accuracy.
	TrainingAccuracy int `pulumi:"trainingAccuracy"`
	// Count of the training set.
	TrainingSetCount int `pulumi:"trainingSetCount"`
	// Count of the validation set.
	ValidationSetCount int `pulumi:"validationSetCount"`
}
