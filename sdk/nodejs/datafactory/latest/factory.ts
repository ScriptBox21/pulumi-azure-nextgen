// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Factory resource type.
 */
export class Factory extends pulumi.CustomResource {
    /**
     * Get an existing Factory resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Factory {
        return new Factory(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:datafactory/latest:Factory';

    /**
     * Returns true if the given object is an instance of Factory.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Factory {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Factory.__pulumiType;
    }

    /**
     * Time the factory was created in ISO8601 format.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Etag identifies change in the resource.
     */
    public /*out*/ readonly eTag!: pulumi.Output<string>;
    /**
     * Properties to enable Customer Managed Key for the factory.
     */
    public readonly encryption!: pulumi.Output<outputs.datafactory.latest.EncryptionConfigurationResponse | undefined>;
    /**
     * List of parameters for factory.
     */
    public readonly globalParameters!: pulumi.Output<{[key: string]: outputs.datafactory.latest.GlobalParameterSpecificationResponse} | undefined>;
    /**
     * Managed service identity of the factory.
     */
    public readonly identity!: pulumi.Output<outputs.datafactory.latest.FactoryIdentityResponse | undefined>;
    /**
     * The resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Factory provisioning state, example Succeeded.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Whether or not public network access is allowed for the data factory.
     */
    public readonly publicNetworkAccess!: pulumi.Output<string | undefined>;
    /**
     * Git repo information of the factory.
     */
    public readonly repoConfiguration!: pulumi.Output<outputs.datafactory.latest.FactoryGitHubConfigurationResponse | outputs.datafactory.latest.FactoryVSTSConfigurationResponse | undefined>;
    /**
     * The resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Version of the factory.
     */
    public /*out*/ readonly version!: pulumi.Output<string>;

    /**
     * Create a Factory resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FactoryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.factoryName === undefined) {
                throw new Error("Missing required property 'factoryName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["encryption"] = args ? args.encryption : undefined;
            inputs["factoryName"] = args ? args.factoryName : undefined;
            inputs["globalParameters"] = args ? args.globalParameters : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["publicNetworkAccess"] = args ? args.publicNetworkAccess : undefined;
            inputs["repoConfiguration"] = args ? args.repoConfiguration : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["eTag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        } else {
            inputs["createTime"] = undefined /*out*/;
            inputs["eTag"] = undefined /*out*/;
            inputs["encryption"] = undefined /*out*/;
            inputs["globalParameters"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicNetworkAccess"] = undefined /*out*/;
            inputs["repoConfiguration"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:datafactory/v20170901preview:Factory" }, { type: "azure-nextgen:datafactory/v20180601:Factory" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Factory.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Factory resource.
 */
export interface FactoryArgs {
    /**
     * Properties to enable Customer Managed Key for the factory.
     */
    readonly encryption?: pulumi.Input<inputs.datafactory.latest.EncryptionConfiguration>;
    /**
     * The factory name.
     */
    readonly factoryName: pulumi.Input<string>;
    /**
     * List of parameters for factory.
     */
    readonly globalParameters?: pulumi.Input<{[key: string]: pulumi.Input<inputs.datafactory.latest.GlobalParameterSpecification>}>;
    /**
     * Managed service identity of the factory.
     */
    readonly identity?: pulumi.Input<inputs.datafactory.latest.FactoryIdentity>;
    /**
     * The resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Whether or not public network access is allowed for the data factory.
     */
    readonly publicNetworkAccess?: pulumi.Input<string>;
    /**
     * Git repo information of the factory.
     */
    readonly repoConfiguration?: pulumi.Input<inputs.datafactory.latest.FactoryGitHubConfiguration | inputs.datafactory.latest.FactoryVSTSConfiguration>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
