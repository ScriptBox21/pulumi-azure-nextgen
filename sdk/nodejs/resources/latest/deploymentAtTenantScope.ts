// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Deployment information.
 * Latest API Version: 2020-10-01.
 *
 * @deprecated The 'latest' version is deprecated. Please migrate to the resource in the top-level module: 'azure-nextgen:resources:DeploymentAtTenantScope'.
 */
export class DeploymentAtTenantScope extends pulumi.CustomResource {
    /**
     * Get an existing DeploymentAtTenantScope resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DeploymentAtTenantScope {
        pulumi.log.warn("DeploymentAtTenantScope is deprecated: The 'latest' version is deprecated. Please migrate to the resource in the top-level module: 'azure-nextgen:resources:DeploymentAtTenantScope'.")
        return new DeploymentAtTenantScope(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:resources/latest:DeploymentAtTenantScope';

    /**
     * Returns true if the given object is an instance of DeploymentAtTenantScope.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DeploymentAtTenantScope {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DeploymentAtTenantScope.__pulumiType;
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
    public readonly properties!: pulumi.Output<outputs.resources.latest.DeploymentPropertiesExtendedResponse>;
    /**
     * Deployment tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the deployment.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DeploymentAtTenantScope resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated The 'latest' version is deprecated. Please migrate to the resource in the top-level module: 'azure-nextgen:resources:DeploymentAtTenantScope'. */
    constructor(name: string, args: DeploymentAtTenantScopeArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("DeploymentAtTenantScope is deprecated: The 'latest' version is deprecated. Please migrate to the resource in the top-level module: 'azure-nextgen:resources:DeploymentAtTenantScope'.")
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.properties === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'properties'");
            }
            inputs["deploymentName"] = args ? args.deploymentName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:resources:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20190701:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20190801:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20191001:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20200601:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20200801:DeploymentAtTenantScope" }, { type: "azure-nextgen:resources/v20201001:DeploymentAtTenantScope" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DeploymentAtTenantScope.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DeploymentAtTenantScope resource.
 */
export interface DeploymentAtTenantScopeArgs {
    /**
     * The name of the deployment.
     */
    readonly deploymentName?: pulumi.Input<string>;
    /**
     * The location to store the deployment data.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The deployment properties.
     */
    readonly properties: pulumi.Input<inputs.resources.latest.DeploymentProperties>;
    /**
     * Deployment tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
