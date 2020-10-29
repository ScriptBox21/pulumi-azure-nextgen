// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190123preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupApplication(ctx *pulumi.Context, args *LookupApplicationArgs, opts ...pulumi.InvokeOption) (*LookupApplicationResult, error) {
	var rv LookupApplicationResult
	err := ctx.Invoke("azure-nextgen:desktopvirtualization/v20190123preview:getApplication", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupApplicationArgs struct {
	// The name of the application group
	ApplicationGroupName string `pulumi:"applicationGroupName"`
	// The name of the application within the specified application group
	ApplicationName string `pulumi:"applicationName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Schema for Application properties.
type LookupApplicationResult struct {
	// Command Line Arguments for Application.
	CommandLineArguments *string `pulumi:"commandLineArguments"`
	// Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.
	CommandLineSetting string `pulumi:"commandLineSetting"`
	// Description of Application.
	Description *string `pulumi:"description"`
	// Specifies a path for the executable file for the application.
	FilePath *string `pulumi:"filePath"`
	// Friendly name of Application.
	FriendlyName *string `pulumi:"friendlyName"`
	// the icon a 64 bit string as a byte array.
	IconContent string `pulumi:"iconContent"`
	// Hash of the icon.
	IconHash string `pulumi:"iconHash"`
	// Index of the icon.
	IconIndex *int `pulumi:"iconIndex"`
	// Path to icon.
	IconPath *string `pulumi:"iconPath"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Specifies whether to show the RemoteApp program in the RD Web Access server.
	ShowInPortal *bool `pulumi:"showInPortal"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
