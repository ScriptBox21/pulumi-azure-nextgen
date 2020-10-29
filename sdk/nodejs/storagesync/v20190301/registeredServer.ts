// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Registered Server resource.
 */
export class RegisteredServer extends pulumi.CustomResource {
    /**
     * Get an existing RegisteredServer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RegisteredServer {
        return new RegisteredServer(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:storagesync/v20190301:RegisteredServer';

    /**
     * Returns true if the given object is an instance of RegisteredServer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RegisteredServer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RegisteredServer.__pulumiType;
    }

    /**
     * Registered Server Agent Version
     */
    public readonly agentVersion!: pulumi.Output<string | undefined>;
    /**
     * Registered Server clusterId
     */
    public readonly clusterId!: pulumi.Output<string | undefined>;
    /**
     * Registered Server clusterName
     */
    public readonly clusterName!: pulumi.Output<string | undefined>;
    /**
     * Resource discoveryEndpointUri
     */
    public /*out*/ readonly discoveryEndpointUri!: pulumi.Output<string | undefined>;
    /**
     * Friendly Name
     */
    public readonly friendlyName!: pulumi.Output<string | undefined>;
    /**
     * Registered Server last heart beat
     */
    public readonly lastHeartBeat!: pulumi.Output<string | undefined>;
    /**
     * Resource Last Operation Name
     */
    public /*out*/ readonly lastOperationName!: pulumi.Output<string | undefined>;
    /**
     * Registered Server lastWorkflowId
     */
    public /*out*/ readonly lastWorkflowId!: pulumi.Output<string | undefined>;
    /**
     * Management Endpoint Uri
     */
    public /*out*/ readonly managementEndpointUri!: pulumi.Output<string | undefined>;
    /**
     * Monitoring Configuration
     */
    public /*out*/ readonly monitoringConfiguration!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Registered Server Provisioning State
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public /*out*/ readonly resourceLocation!: pulumi.Output<string | undefined>;
    /**
     * Registered Server Certificate
     */
    public readonly serverCertificate!: pulumi.Output<string | undefined>;
    /**
     * Registered Server serverId
     */
    public readonly serverId!: pulumi.Output<string | undefined>;
    /**
     * Registered Server Management Error Code
     */
    public /*out*/ readonly serverManagementErrorCode!: pulumi.Output<number | undefined>;
    /**
     * Registered Server OS Version
     */
    public readonly serverOSVersion!: pulumi.Output<string | undefined>;
    /**
     * Registered Server serverRole
     */
    public readonly serverRole!: pulumi.Output<string | undefined>;
    /**
     * Service Location
     */
    public /*out*/ readonly serviceLocation!: pulumi.Output<string | undefined>;
    /**
     * Registered Server storageSyncServiceUid
     */
    public /*out*/ readonly storageSyncServiceUid!: pulumi.Output<string | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a RegisteredServer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RegisteredServerArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serverId === undefined) {
                throw new Error("Missing required property 'serverId'");
            }
            if (!args || args.storageSyncServiceName === undefined) {
                throw new Error("Missing required property 'storageSyncServiceName'");
            }
            inputs["agentVersion"] = args ? args.agentVersion : undefined;
            inputs["clusterId"] = args ? args.clusterId : undefined;
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["friendlyName"] = args ? args.friendlyName : undefined;
            inputs["lastHeartBeat"] = args ? args.lastHeartBeat : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serverCertificate"] = args ? args.serverCertificate : undefined;
            inputs["serverId"] = args ? args.serverId : undefined;
            inputs["serverOSVersion"] = args ? args.serverOSVersion : undefined;
            inputs["serverRole"] = args ? args.serverRole : undefined;
            inputs["storageSyncServiceName"] = args ? args.storageSyncServiceName : undefined;
            inputs["discoveryEndpointUri"] = undefined /*out*/;
            inputs["lastOperationName"] = undefined /*out*/;
            inputs["lastWorkflowId"] = undefined /*out*/;
            inputs["managementEndpointUri"] = undefined /*out*/;
            inputs["monitoringConfiguration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceLocation"] = undefined /*out*/;
            inputs["serverManagementErrorCode"] = undefined /*out*/;
            inputs["serviceLocation"] = undefined /*out*/;
            inputs["storageSyncServiceUid"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["agentVersion"] = undefined /*out*/;
            inputs["clusterId"] = undefined /*out*/;
            inputs["clusterName"] = undefined /*out*/;
            inputs["discoveryEndpointUri"] = undefined /*out*/;
            inputs["friendlyName"] = undefined /*out*/;
            inputs["lastHeartBeat"] = undefined /*out*/;
            inputs["lastOperationName"] = undefined /*out*/;
            inputs["lastWorkflowId"] = undefined /*out*/;
            inputs["managementEndpointUri"] = undefined /*out*/;
            inputs["monitoringConfiguration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceLocation"] = undefined /*out*/;
            inputs["serverCertificate"] = undefined /*out*/;
            inputs["serverId"] = undefined /*out*/;
            inputs["serverManagementErrorCode"] = undefined /*out*/;
            inputs["serverOSVersion"] = undefined /*out*/;
            inputs["serverRole"] = undefined /*out*/;
            inputs["serviceLocation"] = undefined /*out*/;
            inputs["storageSyncServiceUid"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:storagesync/latest:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20170605preview:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20180402:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20180701:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20181001:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20190201:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20190601:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20191001:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20200301:RegisteredServer" }, { type: "azure-nextgen:storagesync/v20200901:RegisteredServer" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(RegisteredServer.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RegisteredServer resource.
 */
export interface RegisteredServerArgs {
    /**
     * Registered Server Agent Version
     */
    readonly agentVersion?: pulumi.Input<string>;
    /**
     * Registered Server clusterId
     */
    readonly clusterId?: pulumi.Input<string>;
    /**
     * Registered Server clusterName
     */
    readonly clusterName?: pulumi.Input<string>;
    /**
     * Friendly Name
     */
    readonly friendlyName?: pulumi.Input<string>;
    /**
     * Registered Server last heart beat
     */
    readonly lastHeartBeat?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Registered Server Certificate
     */
    readonly serverCertificate?: pulumi.Input<string>;
    /**
     * Registered Server serverId
     */
    readonly serverId: pulumi.Input<string>;
    /**
     * Registered Server OS Version
     */
    readonly serverOSVersion?: pulumi.Input<string>;
    /**
     * Registered Server serverRole
     */
    readonly serverRole?: pulumi.Input<string>;
    /**
     * Name of Storage Sync Service resource.
     */
    readonly storageSyncServiceName: pulumi.Input<string>;
}
