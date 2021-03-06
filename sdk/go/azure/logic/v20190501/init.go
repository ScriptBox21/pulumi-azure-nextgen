// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190501

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
	case "azure-nextgen:logic/v20190501:IntegrationAccount":
		r, err = NewIntegrationAccount(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountAgreement":
		r, err = NewIntegrationAccountAgreement(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountAssembly":
		r, err = NewIntegrationAccountAssembly(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountBatchConfiguration":
		r, err = NewIntegrationAccountBatchConfiguration(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountCertificate":
		r, err = NewIntegrationAccountCertificate(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountMap":
		r, err = NewIntegrationAccountMap(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountPartner":
		r, err = NewIntegrationAccountPartner(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountSchema":
		r, err = NewIntegrationAccountSchema(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationAccountSession":
		r, err = NewIntegrationAccountSession(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationServiceEnvironment":
		r, err = NewIntegrationServiceEnvironment(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:IntegrationServiceEnvironmentManagedApi":
		r, err = NewIntegrationServiceEnvironmentManagedApi(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:logic/v20190501:Workflow":
		r, err = NewWorkflow(ctx, name, nil, pulumi.URN_(urn))
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
		"logic/v20190501",
		&module{version},
	)
}
