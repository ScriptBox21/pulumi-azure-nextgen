// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupConnectionMonitor(ctx *pulumi.Context, args *LookupConnectionMonitorArgs, opts ...pulumi.InvokeOption) (*LookupConnectionMonitorResult, error) {
	var rv LookupConnectionMonitorResult
	err := ctx.Invoke("azure-nextgen:network/v20190901:getConnectionMonitor", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupConnectionMonitorArgs struct {
	// The name of the connection monitor.
	ConnectionMonitorName string `pulumi:"connectionMonitorName"`
	// The name of the Network Watcher resource.
	NetworkWatcherName string `pulumi:"networkWatcherName"`
	// The name of the resource group containing Network Watcher.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Information about the connection monitor.
type LookupConnectionMonitorResult struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart *bool `pulumi:"autoStart"`
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationResponse `pulumi:"destination"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Connection monitor location.
	Location *string `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds *int `pulumi:"monitoringIntervalInSeconds"`
	// The monitoring status of the connection monitor.
	MonitoringStatus *string `pulumi:"monitoringStatus"`
	// Name of the connection monitor.
	Name string `pulumi:"name"`
	// The provisioning state of the connection monitor.
	ProvisioningState string `pulumi:"provisioningState"`
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceResponse `pulumi:"source"`
	// The date and time when the connection monitor was started.
	StartTime *string `pulumi:"startTime"`
	// Connection monitor tags.
	Tags map[string]string `pulumi:"tags"`
	// Connection monitor type.
	Type string `pulumi:"type"`
}
