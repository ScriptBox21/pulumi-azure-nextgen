// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getContainerGroup(args: GetContainerGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerGroupResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerinstance/latest:getContainerGroup", {
        "containerGroupName": args.containerGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContainerGroupArgs {
    /**
     * The name of the container group.
     */
    readonly containerGroupName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A container group.
 */
export interface GetContainerGroupResult {
    /**
     * The containers within the container group.
     */
    readonly containers: outputs.containerinstance.latest.ContainerResponse[];
    /**
     * The diagnostic information for a container group.
     */
    readonly diagnostics?: outputs.containerinstance.latest.ContainerGroupDiagnosticsResponse;
    /**
     * The DNS config information for a container group.
     */
    readonly dnsConfig?: outputs.containerinstance.latest.DnsConfigurationResponse;
    /**
     * The encryption properties for a container group.
     */
    readonly encryptionProperties?: outputs.containerinstance.latest.EncryptionPropertiesResponse;
    /**
     * The identity of the container group, if configured.
     */
    readonly identity?: outputs.containerinstance.latest.ContainerGroupIdentityResponse;
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials?: outputs.containerinstance.latest.ImageRegistryCredentialResponse[];
    /**
     * The init containers for a container group.
     */
    readonly initContainers?: outputs.containerinstance.latest.InitContainerDefinitionResponse[];
    /**
     * The instance view of the container group. Only valid in response.
     */
    readonly instanceView: outputs.containerinstance.latest.ContainerGroupResponseInstanceView;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress?: outputs.containerinstance.latest.IpAddressResponse;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The network profile information for a container group.
     */
    readonly networkProfile?: outputs.containerinstance.latest.ContainerGroupNetworkProfileResponse;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: string;
    /**
     * The provisioning state of the container group. This only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Restart policy for all containers within the container group. 
     * - `Always` Always restart
     * - `OnFailure` Restart on failure
     * - `Never` Never restart
     */
    readonly restartPolicy?: string;
    /**
     * The SKU for a container group.
     */
    readonly sku?: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes?: outputs.containerinstance.latest.VolumeResponse[];
}