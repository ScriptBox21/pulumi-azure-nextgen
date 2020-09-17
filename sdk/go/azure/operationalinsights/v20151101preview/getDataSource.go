// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20151101preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDataSource(ctx *pulumi.Context, args *LookupDataSourceArgs, opts ...pulumi.InvokeOption) (*LookupDataSourceResult, error) {
	var rv LookupDataSourceResult
	err := ctx.Invoke("azure-nextgen:operationalinsights/v20151101preview:getDataSource", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDataSourceArgs struct {
	// Name of the datasource
	DataSourceName string `pulumi:"dataSourceName"`
	// The name of the resource group to get. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the Log Analytics Workspace that contains the datasource.
	WorkspaceName string `pulumi:"workspaceName"`
}

// Datasources under OMS Workspace.
type LookupDataSourceResult struct {
	// The ETag of the data source.
	ETag *string `pulumi:"eTag"`
	// The kind of the DataSource.
	Kind string `pulumi:"kind"`
	// Resource name.
	Name string `pulumi:"name"`
	// The data source properties in raw json format, each kind of data source have it's own schema.
	Properties map[string]interface{} `pulumi:"properties"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
}