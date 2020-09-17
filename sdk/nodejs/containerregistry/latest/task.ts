// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * The task that has the ARM resource and task properties.
 * The task will have all information to schedule a run against it.
 */
export class Task extends pulumi.CustomResource {
    /**
     * Get an existing Task resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Task {
        return new Task(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:containerregistry/latest:Task';

    /**
     * Returns true if the given object is an instance of Task.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Task {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Task.__pulumiType;
    }

    /**
     * The machine configuration of the run agent.
     */
    public readonly agentConfiguration!: pulumi.Output<outputs.containerregistry.latest.AgentPropertiesResponse | undefined>;
    /**
     * The creation date of task.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * The properties that describes a set of credentials that will be used when this run is invoked.
     */
    public readonly credentials!: pulumi.Output<outputs.containerregistry.latest.CredentialsResponse | undefined>;
    /**
     * Identity for the resource.
     */
    public readonly identity!: pulumi.Output<outputs.containerregistry.latest.IdentityPropertiesResponse | undefined>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The platform properties against which the run has to happen.
     */
    public readonly platform!: pulumi.Output<outputs.containerregistry.latest.PlatformPropertiesResponse>;
    /**
     * The provisioning state of the task.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The current status of task.
     */
    public readonly status!: pulumi.Output<string | undefined>;
    /**
     * The properties of a task step.
     */
    public readonly step!: pulumi.Output<outputs.containerregistry.latest.DockerBuildStepResponse | outputs.containerregistry.latest.EncodedTaskStepResponse | outputs.containerregistry.latest.FileTaskStepResponse>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Run timeout in seconds.
     */
    public readonly timeout!: pulumi.Output<number | undefined>;
    /**
     * The properties that describe all triggers for the task.
     */
    public readonly trigger!: pulumi.Output<outputs.containerregistry.latest.TriggerPropertiesResponse | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Task resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TaskArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.platform === undefined) {
                throw new Error("Missing required property 'platform'");
            }
            if (!args || args.registryName === undefined) {
                throw new Error("Missing required property 'registryName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.step === undefined) {
                throw new Error("Missing required property 'step'");
            }
            if (!args || args.taskName === undefined) {
                throw new Error("Missing required property 'taskName'");
            }
            inputs["agentConfiguration"] = args ? args.agentConfiguration : undefined;
            inputs["credentials"] = args ? args.credentials : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["platform"] = args ? args.platform : undefined;
            inputs["registryName"] = args ? args.registryName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["step"] = args ? args.step : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["taskName"] = args ? args.taskName : undefined;
            inputs["timeout"] = args ? args.timeout : undefined;
            inputs["trigger"] = args ? args.trigger : undefined;
            inputs["creationDate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["agentConfiguration"] = undefined /*out*/;
            inputs["creationDate"] = undefined /*out*/;
            inputs["credentials"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["platform"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["step"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timeout"] = undefined /*out*/;
            inputs["trigger"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:containerregistry/v20180901:Task" }, { type: "azure-nextgen:containerregistry/v20190401:Task" }, { type: "azure-nextgen:containerregistry/v20190601preview:Task" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Task.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Task resource.
 */
export interface TaskArgs {
    /**
     * The machine configuration of the run agent.
     */
    readonly agentConfiguration?: pulumi.Input<inputs.containerregistry.latest.AgentProperties>;
    /**
     * The properties that describes a set of credentials that will be used when this run is invoked.
     */
    readonly credentials?: pulumi.Input<inputs.containerregistry.latest.Credentials>;
    /**
     * Identity for the resource.
     */
    readonly identity?: pulumi.Input<inputs.containerregistry.latest.IdentityProperties>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The platform properties against which the run has to happen.
     */
    readonly platform: pulumi.Input<inputs.containerregistry.latest.PlatformProperties>;
    /**
     * The name of the container registry.
     */
    readonly registryName: pulumi.Input<string>;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The current status of task.
     */
    readonly status?: pulumi.Input<string>;
    /**
     * The properties of a task step.
     */
    readonly step: pulumi.Input<inputs.containerregistry.latest.TaskStepProperties>;
    /**
     * The tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the container registry task.
     */
    readonly taskName: pulumi.Input<string>;
    /**
     * Run timeout in seconds.
     */
    readonly timeout?: pulumi.Input<number>;
    /**
     * The properties that describe all triggers for the task.
     */
    readonly trigger?: pulumi.Input<inputs.containerregistry.latest.TriggerProperties>;
}