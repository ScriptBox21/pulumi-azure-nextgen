// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupOrder(ctx *pulumi.Context, args *LookupOrderArgs, opts ...pulumi.InvokeOption) (*LookupOrderResult, error) {
	var rv LookupOrderResult
	err := ctx.Invoke("azure-nextgen:databoxedge/v20200901preview:getOrder", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupOrderArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The order details.
type LookupOrderResult struct {
	// The contact details.
	ContactInformation ContactDetailsResponse `pulumi:"contactInformation"`
	// Current status of the order.
	CurrentStatus OrderStatusResponse `pulumi:"currentStatus"`
	// Tracking information for the package delivered to the customer whether it has an original or a replacement device.
	DeliveryTrackingInfo []TrackingInfoResponse `pulumi:"deliveryTrackingInfo"`
	// The path ID that uniquely identifies the object.
	Id string `pulumi:"id"`
	// The object name.
	Name string `pulumi:"name"`
	// List of status changes in the order.
	OrderHistory []OrderStatusResponse `pulumi:"orderHistory"`
	// Tracking information for the package returned from the customer whether it has an original or a replacement device.
	ReturnTrackingInfo []TrackingInfoResponse `pulumi:"returnTrackingInfo"`
	// Serial number of the device.
	SerialNumber string `pulumi:"serialNumber"`
	// ShipmentType of the order
	ShipmentType *string `pulumi:"shipmentType"`
	// The shipping address.
	ShippingAddress *AddressResponse `pulumi:"shippingAddress"`
	// The hierarchical type of the object.
	Type string `pulumi:"type"`
}
