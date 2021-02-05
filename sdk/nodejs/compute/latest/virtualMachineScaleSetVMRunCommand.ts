// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a Virtual Machine run command.
 * Latest API Version: 2020-12-01.
 */
export class VirtualMachineScaleSetVMRunCommand extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineScaleSetVMRunCommand resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineScaleSetVMRunCommand {
        return new VirtualMachineScaleSetVMRunCommand(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:compute/latest:VirtualMachineScaleSetVMRunCommand';

    /**
     * Returns true if the given object is an instance of VirtualMachineScaleSetVMRunCommand.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineScaleSetVMRunCommand {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineScaleSetVMRunCommand.__pulumiType;
    }

    /**
     * Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
     */
    public readonly asyncExecution!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the Azure storage blob where script error stream will be uploaded.
     */
    public readonly errorBlobUri!: pulumi.Output<string | undefined>;
    /**
     * The virtual machine run command instance view.
     */
    public /*out*/ readonly instanceView!: pulumi.Output<outputs.compute.latest.VirtualMachineRunCommandInstanceViewResponse>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Specifies the Azure storage blob where script output stream will be uploaded.
     */
    public readonly outputBlobUri!: pulumi.Output<string | undefined>;
    /**
     * The parameters used by the script.
     */
    public readonly parameters!: pulumi.Output<outputs.compute.latest.RunCommandInputParameterResponse[] | undefined>;
    /**
     * The parameters used by the script.
     */
    public readonly protectedParameters!: pulumi.Output<outputs.compute.latest.RunCommandInputParameterResponse[] | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Specifies the user account password on the VM when executing the run command.
     */
    public readonly runAsPassword!: pulumi.Output<string | undefined>;
    /**
     * Specifies the user account on the VM when executing the run command.
     */
    public readonly runAsUser!: pulumi.Output<string | undefined>;
    /**
     * The source of the run command script.
     */
    public readonly source!: pulumi.Output<outputs.compute.latest.VirtualMachineRunCommandScriptSourceResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The timeout in seconds to execute the run command.
     */
    public readonly timeoutInSeconds!: pulumi.Output<number | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a VirtualMachineScaleSetVMRunCommand resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineScaleSetVMRunCommandArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.instanceId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.runCommandName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'runCommandName'");
            }
            if ((!args || args.vmScaleSetName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'vmScaleSetName'");
            }
            inputs["asyncExecution"] = (args ? args.asyncExecution : undefined) || false;
            inputs["errorBlobUri"] = args ? args.errorBlobUri : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["outputBlobUri"] = args ? args.outputBlobUri : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["protectedParameters"] = args ? args.protectedParameters : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["runAsPassword"] = args ? args.runAsPassword : undefined;
            inputs["runAsUser"] = args ? args.runAsUser : undefined;
            inputs["runCommandName"] = args ? args.runCommandName : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["timeoutInSeconds"] = args ? args.timeoutInSeconds : undefined;
            inputs["vmScaleSetName"] = args ? args.vmScaleSetName : undefined;
            inputs["instanceView"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["asyncExecution"] = undefined /*out*/;
            inputs["errorBlobUri"] = undefined /*out*/;
            inputs["instanceView"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["outputBlobUri"] = undefined /*out*/;
            inputs["parameters"] = undefined /*out*/;
            inputs["protectedParameters"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["runAsPassword"] = undefined /*out*/;
            inputs["runAsUser"] = undefined /*out*/;
            inputs["source"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timeoutInSeconds"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:compute/v20200601:VirtualMachineScaleSetVMRunCommand" }, { type: "azure-nextgen:compute/v20201201:VirtualMachineScaleSetVMRunCommand" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualMachineScaleSetVMRunCommand.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualMachineScaleSetVMRunCommand resource.
 */
export interface VirtualMachineScaleSetVMRunCommandArgs {
    /**
     * Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
     */
    readonly asyncExecution?: pulumi.Input<boolean>;
    /**
     * Specifies the Azure storage blob where script error stream will be uploaded.
     */
    readonly errorBlobUri?: pulumi.Input<string>;
    /**
     * The instance ID of the virtual machine.
     */
    readonly instanceId: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies the Azure storage blob where script output stream will be uploaded.
     */
    readonly outputBlobUri?: pulumi.Input<string>;
    /**
     * The parameters used by the script.
     */
    readonly parameters?: pulumi.Input<pulumi.Input<inputs.compute.latest.RunCommandInputParameter>[]>;
    /**
     * The parameters used by the script.
     */
    readonly protectedParameters?: pulumi.Input<pulumi.Input<inputs.compute.latest.RunCommandInputParameter>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the user account password on the VM when executing the run command.
     */
    readonly runAsPassword?: pulumi.Input<string>;
    /**
     * Specifies the user account on the VM when executing the run command.
     */
    readonly runAsUser?: pulumi.Input<string>;
    /**
     * The name of the virtual machine run command.
     */
    readonly runCommandName: pulumi.Input<string>;
    /**
     * The source of the run command script.
     */
    readonly source?: pulumi.Input<inputs.compute.latest.VirtualMachineRunCommandScriptSource>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The timeout in seconds to execute the run command.
     */
    readonly timeoutInSeconds?: pulumi.Input<number>;
    /**
     * The name of the VM scale set.
     */
    readonly vmScaleSetName: pulumi.Input<string>;
}
