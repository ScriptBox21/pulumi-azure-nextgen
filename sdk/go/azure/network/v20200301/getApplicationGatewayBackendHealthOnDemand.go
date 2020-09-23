// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetApplicationGatewayBackendHealthOnDemand(ctx *pulumi.Context, args *GetApplicationGatewayBackendHealthOnDemandArgs, opts ...pulumi.InvokeOption) (*GetApplicationGatewayBackendHealthOnDemandResult, error) {
	var rv GetApplicationGatewayBackendHealthOnDemandResult
	err := ctx.Invoke("azure-nextgen:network/v20200301:getApplicationGatewayBackendHealthOnDemand", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetApplicationGatewayBackendHealthOnDemandArgs struct {
	// The name of the application gateway.
	ApplicationGatewayName string `pulumi:"applicationGatewayName"`
	// Reference to backend pool of application gateway to which probe request will be sent.
	BackendAddressPool *SubResource `pulumi:"backendAddressPool"`
	// Reference to backend http setting of application gateway to be used for test probe.
	BackendHttpSettings *SubResource `pulumi:"backendHttpSettings"`
	// Expands BackendAddressPool and BackendHttpSettings referenced in backend health.
	Expand *string `pulumi:"expand"`
	// Host name to send the probe to.
	Host *string `pulumi:"host"`
	// Criterion for classifying a healthy probe response.
	Match *ApplicationGatewayProbeHealthResponseMatch `pulumi:"match"`
	// Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path>.
	Path *string `pulumi:"path"`
	// Whether the host header should be picked from the backend http settings. Default value is false.
	PickHostNameFromBackendHttpSettings *bool `pulumi:"pickHostNameFromBackendHttpSettings"`
	// The protocol used for the probe.
	Protocol *string `pulumi:"protocol"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
	Timeout *int `pulumi:"timeout"`
}

// Result of on demand test probe.
type GetApplicationGatewayBackendHealthOnDemandResult struct {
	// Reference to an ApplicationGatewayBackendAddressPool resource.
	BackendAddressPool *ApplicationGatewayBackendAddressPoolResponse `pulumi:"backendAddressPool"`
	// Application gateway BackendHealthHttp settings.
	BackendHealthHttpSettings *ApplicationGatewayBackendHealthHttpSettingsResponse `pulumi:"backendHealthHttpSettings"`
}
