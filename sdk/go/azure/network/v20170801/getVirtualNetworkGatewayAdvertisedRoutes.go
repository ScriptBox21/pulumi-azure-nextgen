// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetVirtualNetworkGatewayAdvertisedRoutes(ctx *pulumi.Context, args *GetVirtualNetworkGatewayAdvertisedRoutesArgs, opts ...pulumi.InvokeOption) (*GetVirtualNetworkGatewayAdvertisedRoutesResult, error) {
	var rv GetVirtualNetworkGatewayAdvertisedRoutesResult
	err := ctx.Invoke("azure-nextgen:network/v20170801:getVirtualNetworkGatewayAdvertisedRoutes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetVirtualNetworkGatewayAdvertisedRoutesArgs struct {
	// The IP address of the peer
	Peer string `pulumi:"peer"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the virtual network gateway.
	VirtualNetworkGatewayName string `pulumi:"virtualNetworkGatewayName"`
}

// List of virtual network gateway routes
type GetVirtualNetworkGatewayAdvertisedRoutesResult struct {
	// List of gateway routes
	Value []GatewayRouteResponse `pulumi:"value"`
}
