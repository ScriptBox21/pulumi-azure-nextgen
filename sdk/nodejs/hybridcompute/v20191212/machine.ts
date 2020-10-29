// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Describes a hybrid machine.
 */
export class Machine extends pulumi.CustomResource {
    /**
     * Get an existing Machine resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Machine {
        return new Machine(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:hybridcompute/v20191212:Machine';

    /**
     * Returns true if the given object is an instance of Machine.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Machine {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Machine.__pulumiType;
    }

    /**
     * The hybrid machine agent full version.
     */
    public /*out*/ readonly agentVersion!: pulumi.Output<string>;
    /**
     * Public Key that the client provides to be used during initial resource onboarding
     */
    public readonly clientPublicKey!: pulumi.Output<string | undefined>;
    /**
     * Specifies the hybrid machine display name.
     */
    public /*out*/ readonly displayName!: pulumi.Output<string>;
    /**
     * Details about the error state.
     */
    public /*out*/ readonly errorDetails!: pulumi.Output<outputs.hybridcompute.v20191212.ErrorDetailResponse[]>;
    /**
     * Machine Extensions information
     */
    public readonly extensions!: pulumi.Output<outputs.hybridcompute.v20191212.MachineExtensionInstanceViewResponse[] | undefined>;
    public readonly identity!: pulumi.Output<outputs.hybridcompute.v20191212.MachineResponseIdentity | undefined>;
    /**
     * The time of the last status change.
     */
    public /*out*/ readonly lastStatusChange!: pulumi.Output<string>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Metadata pertaining to the geographic location of the resource.
     */
    public readonly locationData!: pulumi.Output<outputs.hybridcompute.v20191212.LocationDataResponse | undefined>;
    /**
     * Specifies the hybrid machine FQDN.
     */
    public /*out*/ readonly machineFqdn!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The Operating System running on the hybrid machine.
     */
    public /*out*/ readonly osName!: pulumi.Output<string>;
    /**
     * Specifies the operating system settings for the hybrid machine.
     */
    public /*out*/ readonly osProfile!: pulumi.Output<outputs.hybridcompute.v20191212.MachinePropertiesResponseOsProfile | undefined>;
    /**
     * The version of Operating System running on the hybrid machine.
     */
    public /*out*/ readonly osVersion!: pulumi.Output<string>;
    /**
     * The provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The status of the hybrid machine agent.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Specifies the hybrid machine unique ID.
     */
    public readonly vmId!: pulumi.Output<string | undefined>;

    /**
     * Create a Machine resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MachineArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["clientPublicKey"] = args ? args.clientPublicKey : undefined;
            inputs["extensions"] = args ? args.extensions : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["locationData"] = args ? args.locationData : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vmId"] = args ? args.vmId : undefined;
            inputs["agentVersion"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["errorDetails"] = undefined /*out*/;
            inputs["lastStatusChange"] = undefined /*out*/;
            inputs["machineFqdn"] = undefined /*out*/;
            inputs["osName"] = undefined /*out*/;
            inputs["osProfile"] = undefined /*out*/;
            inputs["osVersion"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["agentVersion"] = undefined /*out*/;
            inputs["clientPublicKey"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["errorDetails"] = undefined /*out*/;
            inputs["extensions"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["lastStatusChange"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["locationData"] = undefined /*out*/;
            inputs["machineFqdn"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["osName"] = undefined /*out*/;
            inputs["osProfile"] = undefined /*out*/;
            inputs["osVersion"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vmId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:hybridcompute/latest:Machine" }, { type: "azure-nextgen:hybridcompute/v20190318preview:Machine" }, { type: "azure-nextgen:hybridcompute/v20190802preview:Machine" }, { type: "azure-nextgen:hybridcompute/v20200730preview:Machine" }, { type: "azure-nextgen:hybridcompute/v20200802:Machine" }, { type: "azure-nextgen:hybridcompute/v20200815preview:Machine" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Machine.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Machine resource.
 */
export interface MachineArgs {
    /**
     * Public Key that the client provides to be used during initial resource onboarding
     */
    readonly clientPublicKey?: pulumi.Input<string>;
    /**
     * Machine Extensions information
     */
    readonly extensions?: pulumi.Input<pulumi.Input<inputs.hybridcompute.v20191212.MachineExtensionInstanceView>[]>;
    readonly identity?: pulumi.Input<inputs.hybridcompute.v20191212.MachineIdentity>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * Metadata pertaining to the geographic location of the resource.
     */
    readonly locationData?: pulumi.Input<inputs.hybridcompute.v20191212.LocationData>;
    /**
     * The name of the hybrid machine.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the hybrid machine unique ID.
     */
    readonly vmId?: pulumi.Input<string>;
}
