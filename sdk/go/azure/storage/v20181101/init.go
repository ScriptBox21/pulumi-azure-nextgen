// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-nextgen/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-nextgen:storage/v20181101:BlobContainer":
		r, err = NewBlobContainer(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:storage/v20181101:BlobContainerImmutabilityPolicy":
		r, err = NewBlobContainerImmutabilityPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:storage/v20181101:BlobServiceProperties":
		r, err = NewBlobServiceProperties(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:storage/v20181101:ManagementPolicy":
		r, err = NewManagementPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:storage/v20181101:StorageAccount":
		r, err = NewStorageAccount(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"azure-nextgen",
		"storage/v20181101",
		&module{version},
	)
}
