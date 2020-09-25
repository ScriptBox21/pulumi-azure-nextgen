// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180401

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetVirtualNetworkGatewayLearnedRoutes(ctx *pulumi.Context, args *GetVirtualNetworkGatewayLearnedRoutesArgs, opts ...pulumi.InvokeOption) (*GetVirtualNetworkGatewayLearnedRoutesResult, error) {
	var rv GetVirtualNetworkGatewayLearnedRoutesResult
	err := ctx.Invoke("azure-nextgen:network/v20180401:getVirtualNetworkGatewayLearnedRoutes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetVirtualNetworkGatewayLearnedRoutesArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the virtual network gateway.
	VirtualNetworkGatewayName string `pulumi:"virtualNetworkGatewayName"`
}

// List of virtual network gateway routes
type GetVirtualNetworkGatewayLearnedRoutesResult struct {
	// List of gateway routes
	Value []GatewayRouteResponse `pulumi:"value"`
}