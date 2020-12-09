// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Deployment information.
 */
export class Deployment extends pulumi.CustomResource {
    /**
     * Get an existing Deployment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Deployment {
        return new Deployment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:resources/v20190501:Deployment';

    /**
     * Returns true if the given object is an instance of Deployment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Deployment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Deployment.__pulumiType;
    }

    /**
     * the location of the deployment.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the deployment.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Deployment properties.
     */
    public readonly properties!: pulumi.Output<outputs.resources.v20190501.DeploymentPropertiesExtendedResponse>;
    /**
     * The type of the deployment.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Deployment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeploymentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.deploymentName === undefined) {
                throw new Error("Missing required property 'deploymentName'");
            }
            if (!args || args.properties === undefined) {
                throw new Error("Missing required property 'properties'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["deploymentName"] = args ? args.deploymentName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:resources/latest:Deployment" }, { type: "azure-nextgen:resources/v20151101:Deployment" }, { type: "azure-nextgen:resources/v20160201:Deployment" }, { type: "azure-nextgen:resources/v20160701:Deployment" }, { type: "azure-nextgen:resources/v20160901:Deployment" }, { type: "azure-nextgen:resources/v20170510:Deployment" }, { type: "azure-nextgen:resources/v20180201:Deployment" }, { type: "azure-nextgen:resources/v20180501:Deployment" }, { type: "azure-nextgen:resources/v20190301:Deployment" }, { type: "azure-nextgen:resources/v20190510:Deployment" }, { type: "azure-nextgen:resources/v20190701:Deployment" }, { type: "azure-nextgen:resources/v20190801:Deployment" }, { type: "azure-nextgen:resources/v20191001:Deployment" }, { type: "azure-nextgen:resources/v20200601:Deployment" }, { type: "azure-nextgen:resources/v20200801:Deployment" }, { type: "azure-nextgen:resources/v20201001:Deployment" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Deployment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Deployment resource.
 */
export interface DeploymentArgs {
    /**
     * The name of the deployment.
     */
    readonly deploymentName: pulumi.Input<string>;
    /**
     * The location to store the deployment data.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The deployment properties.
     */
    readonly properties: pulumi.Input<inputs.resources.v20190501.DeploymentProperties>;
    /**
     * The name of the resource group to deploy the resources to. The name is case insensitive. The resource group must already exist.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
