// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20151031

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupConnectionType(ctx *pulumi.Context, args *LookupConnectionTypeArgs, opts ...pulumi.InvokeOption) (*LookupConnectionTypeResult, error) {
	var rv LookupConnectionTypeResult
	err := ctx.Invoke("azure-nextgen:automation/v20151031:getConnectionType", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupConnectionTypeArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// The name of connection type.
	ConnectionTypeName string `pulumi:"connectionTypeName"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Definition of the connection type.
type LookupConnectionTypeResult struct {
	// Gets the creation time.
	CreationTime string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets the field definitions of the connection type.
	FieldDefinitions map[string]FieldDefinitionResponse `pulumi:"fieldDefinitions"`
	// Gets or sets a Boolean value to indicate if the connection type is global.
	IsGlobal *bool `pulumi:"isGlobal"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// Gets the name of the connection type.
	Name string `pulumi:"name"`
	// Resource type
	Type string `pulumi:"type"`
}