// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupP2sVpnServerConfiguration(ctx *pulumi.Context, args *LookupP2sVpnServerConfigurationArgs, opts ...pulumi.InvokeOption) (*LookupP2sVpnServerConfigurationResult, error) {
	var rv LookupP2sVpnServerConfigurationResult
	err := ctx.Invoke("azure-nextgen:network/v20181101:getP2sVpnServerConfiguration", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupP2sVpnServerConfigurationArgs struct {
	// The name of the P2SVpnServerConfiguration.
	P2SVpnServerConfigurationName string `pulumi:"p2SVpnServerConfigurationName"`
	// The resource group name of the P2SVpnServerConfiguration.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the VirtualWan.
	VirtualWanName string `pulumi:"virtualWanName"`
}

// P2SVpnServerConfiguration Resource.
type LookupP2sVpnServerConfigurationResult struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// The name of the P2SVpnServerConfiguration that is unique within a VirtualWan in a resource group. This name can be used to access the resource along with Paren VirtualWan resource name.
	Name           *string               `pulumi:"name"`
	P2SVpnGateways []SubResourceResponse `pulumi:"p2SVpnGateways"`
	// Radius client root certificate of P2SVpnServerConfiguration.
	P2SVpnServerConfigRadiusClientRootCertificates []P2SVpnServerConfigRadiusClientRootCertificateResponse `pulumi:"p2SVpnServerConfigRadiusClientRootCertificates"`
	// Radius Server root certificate of P2SVpnServerConfiguration.
	P2SVpnServerConfigRadiusServerRootCertificates []P2SVpnServerConfigRadiusServerRootCertificateResponse `pulumi:"p2SVpnServerConfigRadiusServerRootCertificates"`
	// VPN client revoked certificate of P2SVpnServerConfiguration.
	P2SVpnServerConfigVpnClientRevokedCertificates []P2SVpnServerConfigVpnClientRevokedCertificateResponse `pulumi:"p2SVpnServerConfigVpnClientRevokedCertificates"`
	// VPN client root certificate of P2SVpnServerConfiguration.
	P2SVpnServerConfigVpnClientRootCertificates []P2SVpnServerConfigVpnClientRootCertificateResponse `pulumi:"p2SVpnServerConfigVpnClientRootCertificates"`
	// The provisioning state of the P2SVpnServerConfiguration resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState string `pulumi:"provisioningState"`
	// The radius server address property of the P2SVpnServerConfiguration resource for point to site client connection.
	RadiusServerAddress *string `pulumi:"radiusServerAddress"`
	// The radius secret property of the P2SVpnServerConfiguration resource for point to site client connection.
	RadiusServerSecret *string `pulumi:"radiusServerSecret"`
	// VpnClientIpsecPolicies for P2SVpnServerConfiguration.
	VpnClientIpsecPolicies []IpsecPolicyResponse `pulumi:"vpnClientIpsecPolicies"`
	// vpnProtocols for the P2SVpnServerConfiguration.
	VpnProtocols []string `pulumi:"vpnProtocols"`
}