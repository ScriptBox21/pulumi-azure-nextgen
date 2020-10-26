// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getApiManagementService(args: GetApiManagementServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetApiManagementServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20200601preview:getApiManagementService", {
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetApiManagementServiceArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
}

/**
 * A single API Management service resource in List or Get response.
 */
export interface GetApiManagementServiceResult {
    /**
     * Additional datacenter locations of the API Management service.
     */
    readonly additionalLocations?: outputs.apimanagement.v20200601preview.AdditionalLocationResponse[];
    /**
     * Control Plane Apis version constraint for the API Management service.
     */
    readonly apiVersionConstraint?: outputs.apimanagement.v20200601preview.ApiVersionConstraintResponse;
    /**
     * List of Certificates that need to be installed in the API Management service. Max supported certificates that can be installed is 10.
     */
    readonly certificates?: outputs.apimanagement.v20200601preview.CertificateConfigurationResponse[];
    /**
     * Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly createdAtUtc: string;
    /**
     * Custom properties of the API Management service.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API Management service.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be used to disable just TLS 1.1 for communications with backends.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for communications with backends.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be used to enable HTTP2 protocol on an API Management service.</br>Not specifying any of these properties on PATCH operation will reset omitted properties' values to their defaults. For all the settings except Http2 the default value is `True` if the service was created on or before April 1st 2018 and `False` otherwise. Http2 setting's default value is `False`.</br></br>You can disable any of next ciphers by using settings `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example, `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default value is `true` for them.  Note: next ciphers can't be disabled since they are required by Azure CloudService internal components: TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384
     */
    readonly customProperties?: {[key: string]: string};
    /**
     * DEveloper Portal endpoint URL of the API Management service.
     */
    readonly developerPortalUrl: string;
    /**
     * Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in master region.
     */
    readonly disableGateway?: boolean;
    /**
     * Property only meant to be used for Consumption SKU Service. This enforces a client certificate to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the policy on the gateway.
     */
    readonly enableClientCertificate?: boolean;
    /**
     * ETag of the resource.
     */
    readonly etag: string;
    /**
     * Gateway URL of the API Management service in the Default Region.
     */
    readonly gatewayRegionalUrl: string;
    /**
     * Gateway URL of the API Management service.
     */
    readonly gatewayUrl: string;
    /**
     * Custom hostname configuration of the API Management service.
     */
    readonly hostnameConfigurations?: outputs.apimanagement.v20200601preview.HostnameConfigurationResponse[];
    /**
     * Managed service identity of the Api Management service.
     */
    readonly identity?: outputs.apimanagement.v20200601preview.ApiManagementServiceIdentityResponse;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Management API endpoint URL of the API Management service.
     */
    readonly managementApiUrl: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Email address from which the notification will be sent.
     */
    readonly notificationSenderEmail?: string;
    /**
     * Publisher portal endpoint Url of the API Management service.
     */
    readonly portalUrl: string;
    /**
     * Private Static Load Balanced IP addresses of the API Management service in Primary region which is deployed in an Internal Virtual Network. Available only for Basic, Standard, Premium and Isolated SKU.
     */
    readonly privateIPAddresses: string[];
    /**
     * The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
     */
    readonly provisioningState: string;
    /**
     * Public Static Load Balanced IP addresses of the API Management service in Primary region. Available only for Basic, Standard, Premium and Isolated SKU.
     */
    readonly publicIPAddresses: string[];
    /**
     * Publisher email.
     */
    readonly publisherEmail: string;
    /**
     * Publisher name.
     */
    readonly publisherName: string;
    /**
     * Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True all other properties will be ignored.
     */
    readonly restore?: boolean;
    /**
     * SCM endpoint URL of the API Management service.
     */
    readonly scmUrl: string;
    /**
     * SKU properties of the API Management service.
     */
    readonly sku: outputs.apimanagement.v20200601preview.ApiManagementServiceSkuPropertiesResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The provisioning state of the API Management service, which is targeted by the long running operation started on the service.
     */
    readonly targetProvisioningState: string;
    /**
     * Resource type for API Management resource is set to Microsoft.ApiManagement.
     */
    readonly type: string;
    /**
     * Virtual network configuration of the API Management service.
     */
    readonly virtualNetworkConfiguration?: outputs.apimanagement.v20200601preview.VirtualNetworkConfigurationResponse;
    /**
     * The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
     */
    readonly virtualNetworkType?: string;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    readonly zones?: string[];
}
