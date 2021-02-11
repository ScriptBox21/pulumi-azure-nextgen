// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * User credentials used for publishing activity.
 */
export class WebAppDeployment extends pulumi.CustomResource {
    /**
     * Get an existing WebAppDeployment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppDeployment {
        return new WebAppDeployment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20180201:WebAppDeployment';

    /**
     * Returns true if the given object is an instance of WebAppDeployment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppDeployment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppDeployment.__pulumiType;
    }

    /**
     * True if deployment is currently active, false if completed and null if not started.
     */
    public readonly active!: pulumi.Output<boolean | undefined>;
    /**
     * Who authored the deployment.
     */
    public readonly author!: pulumi.Output<string | undefined>;
    /**
     * Author email.
     */
    public readonly authorEmail!: pulumi.Output<string | undefined>;
    /**
     * Who performed the deployment.
     */
    public readonly deployer!: pulumi.Output<string | undefined>;
    /**
     * Details on deployment.
     */
    public readonly details!: pulumi.Output<string | undefined>;
    /**
     * End time.
     */
    public readonly endTime!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Details about deployment status.
     */
    public readonly message!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Start time.
     */
    public readonly startTime!: pulumi.Output<string | undefined>;
    /**
     * Deployment status.
     */
    public readonly status!: pulumi.Output<number | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppDeployment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppDeploymentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.id === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'id'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["active"] = args ? args.active : undefined;
            inputs["author"] = args ? args.author : undefined;
            inputs["authorEmail"] = args ? args.authorEmail : undefined;
            inputs["deployer"] = args ? args.deployer : undefined;
            inputs["details"] = args ? args.details : undefined;
            inputs["endTime"] = args ? args.endTime : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["startTime"] = args ? args.startTime : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["active"] = undefined /*out*/;
            inputs["author"] = undefined /*out*/;
            inputs["authorEmail"] = undefined /*out*/;
            inputs["deployer"] = undefined /*out*/;
            inputs["details"] = undefined /*out*/;
            inputs["endTime"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["message"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppDeployment" }, { type: "azure-nextgen:web/v20150801:WebAppDeployment" }, { type: "azure-nextgen:web/v20160801:WebAppDeployment" }, { type: "azure-nextgen:web/v20181101:WebAppDeployment" }, { type: "azure-nextgen:web/v20190801:WebAppDeployment" }, { type: "azure-nextgen:web/v20200601:WebAppDeployment" }, { type: "azure-nextgen:web/v20200901:WebAppDeployment" }, { type: "azure-nextgen:web/v20201001:WebAppDeployment" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppDeployment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppDeployment resource.
 */
export interface WebAppDeploymentArgs {
    /**
     * True if deployment is currently active, false if completed and null if not started.
     */
    readonly active?: pulumi.Input<boolean>;
    /**
     * Who authored the deployment.
     */
    readonly author?: pulumi.Input<string>;
    /**
     * Author email.
     */
    readonly authorEmail?: pulumi.Input<string>;
    /**
     * Who performed the deployment.
     */
    readonly deployer?: pulumi.Input<string>;
    /**
     * Details on deployment.
     */
    readonly details?: pulumi.Input<string>;
    /**
     * End time.
     */
    readonly endTime?: pulumi.Input<string>;
    /**
     * ID of an existing deployment.
     */
    readonly id: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Details about deployment status.
     */
    readonly message?: pulumi.Input<string>;
    /**
     * Name of the app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Start time.
     */
    readonly startTime?: pulumi.Input<string>;
    /**
     * Deployment status.
     */
    readonly status?: pulumi.Input<number>;
}
