// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupLiveEvent(ctx *pulumi.Context, args *LookupLiveEventArgs, opts ...pulumi.InvokeOption) (*LookupLiveEventResult, error) {
	var rv LookupLiveEventResult
	err := ctx.Invoke("azure-nextgen:media/latest:getLiveEvent", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupLiveEventArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The name of the live event, maximum length is 32.
	LiveEventName string `pulumi:"liveEventName"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The live event.
type LookupLiveEventResult struct {
	// The creation time for the live event
	Created string `pulumi:"created"`
	// Live event cross site access policies.
	CrossSiteAccessPolicies *CrossSiteAccessPoliciesResponse `pulumi:"crossSiteAccessPolicies"`
	// A description for the live event.
	Description *string `pulumi:"description"`
	// Encoding settings for the live event. It configures whether a live encoder is used for the live event and settings for the live encoder if it is used.
	Encoding *LiveEventEncodingResponse `pulumi:"encoding"`
	// When useStaticHostname is set to true, the hostnamePrefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center.
	HostnamePrefix *string `pulumi:"hostnamePrefix"`
	// Live event input settings. It defines how the live event receives input from a contribution encoder.
	Input LiveEventInputResponse `pulumi:"input"`
	// The last modified time of the live event.
	LastModified string `pulumi:"lastModified"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Live event preview settings. Preview allows live event producers to preview the live streaming content without creating any live output.
	Preview *LiveEventPreviewResponse `pulumi:"preview"`
	// The provisioning state of the live event.
	ProvisioningState string `pulumi:"provisioningState"`
	// The resource state of the live event. See https://go.microsoft.com/fwlink/?linkid=2139012 for more information.
	ResourceState string `pulumi:"resourceState"`
	// The options to use for the LiveEvent. This value is specified at creation time and cannot be updated. The valid values for the array entry values are 'Default' and 'LowLatency'.
	StreamOptions []string `pulumi:"streamOptions"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Live transcription settings for the live event. See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature.
	Transcriptions []LiveEventTranscriptionResponse `pulumi:"transcriptions"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type string `pulumi:"type"`
	// Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. This value can only be updated if the live event is in Standby state
	UseStaticHostname *bool `pulumi:"useStaticHostname"`
}
