// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * EventGrid Topic
 */
export class Topic extends pulumi.CustomResource {
    /**
     * Get an existing Topic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Topic {
        return new Topic(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:eventgrid/v20200401preview:Topic';

    /**
     * Returns true if the given object is an instance of Topic.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Topic {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Topic.__pulumiType;
    }

    /**
     * Endpoint for the topic.
     */
    public /*out*/ readonly endpoint!: pulumi.Output<string>;
    /**
     * Identity information for the resource.
     */
    public readonly identity!: pulumi.Output<outputs.eventgrid.v20200401preview.IdentityInfoResponse | undefined>;
    /**
     * This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled.
     */
    public readonly inboundIpRules!: pulumi.Output<outputs.eventgrid.v20200401preview.InboundIpRuleResponse[] | undefined>;
    /**
     * This determines the format that Event Grid should expect for incoming events published to the topic.
     */
    public readonly inputSchema!: pulumi.Output<string | undefined>;
    /**
     * This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map various properties of a source schema to various required properties of the EventGridEvent schema.
     */
    public readonly inputSchemaMapping!: pulumi.Output<outputs.eventgrid.v20200401preview.JsonInputSchemaMappingResponse | undefined>;
    /**
     * Location of the resource.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Metric resource id for the topic.
     */
    public /*out*/ readonly metricResourceId!: pulumi.Output<string>;
    /**
     * Name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly privateEndpointConnections!: pulumi.Output<outputs.eventgrid.v20200401preview.PrivateEndpointConnectionResponse[] | undefined>;
    /**
     * Provisioning state of the topic.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * This determines if traffic is allowed over public network. By default it is enabled. 
     * You can further restrict to specific IPs by configuring <seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules" />
     */
    public readonly publicNetworkAccess!: pulumi.Output<string | undefined>;
    /**
     * The Sku pricing tier for the topic.
     */
    public readonly sku!: pulumi.Output<outputs.eventgrid.v20200401preview.ResourceSkuResponse | undefined>;
    /**
     * Tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Type of the resource
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Topic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TopicArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.topicName === undefined) {
                throw new Error("Missing required property 'topicName'");
            }
            inputs["identity"] = args ? args.identity : undefined;
            inputs["inboundIpRules"] = args ? args.inboundIpRules : undefined;
            inputs["inputSchema"] = args ? args.inputSchema : undefined;
            inputs["inputSchemaMapping"] = args ? args.inputSchemaMapping : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["privateEndpointConnections"] = args ? args.privateEndpointConnections : undefined;
            inputs["publicNetworkAccess"] = args ? args.publicNetworkAccess : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["topicName"] = args ? args.topicName : undefined;
            inputs["endpoint"] = undefined /*out*/;
            inputs["metricResourceId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["endpoint"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["inboundIpRules"] = undefined /*out*/;
            inputs["inputSchema"] = undefined /*out*/;
            inputs["inputSchemaMapping"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["metricResourceId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpointConnections"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicNetworkAccess"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:eventgrid/latest:Topic" }, { type: "azure-nextgen:eventgrid/v20170615preview:Topic" }, { type: "azure-nextgen:eventgrid/v20170915preview:Topic" }, { type: "azure-nextgen:eventgrid/v20180101:Topic" }, { type: "azure-nextgen:eventgrid/v20180501preview:Topic" }, { type: "azure-nextgen:eventgrid/v20180915preview:Topic" }, { type: "azure-nextgen:eventgrid/v20190101:Topic" }, { type: "azure-nextgen:eventgrid/v20190201preview:Topic" }, { type: "azure-nextgen:eventgrid/v20190601:Topic" }, { type: "azure-nextgen:eventgrid/v20200101preview:Topic" }, { type: "azure-nextgen:eventgrid/v20200601:Topic" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Topic.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Topic resource.
 */
export interface TopicArgs {
    /**
     * Identity information for the resource.
     */
    readonly identity?: pulumi.Input<inputs.eventgrid.v20200401preview.IdentityInfo>;
    /**
     * This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled.
     */
    readonly inboundIpRules?: pulumi.Input<pulumi.Input<inputs.eventgrid.v20200401preview.InboundIpRule>[]>;
    /**
     * This determines the format that Event Grid should expect for incoming events published to the topic.
     */
    readonly inputSchema?: pulumi.Input<string>;
    /**
     * This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map various properties of a source schema to various required properties of the EventGridEvent schema.
     */
    readonly inputSchemaMapping?: pulumi.Input<inputs.eventgrid.v20200401preview.JsonInputSchemaMapping>;
    /**
     * Location of the resource.
     */
    readonly location: pulumi.Input<string>;
    readonly privateEndpointConnections?: pulumi.Input<pulumi.Input<inputs.eventgrid.v20200401preview.PrivateEndpointConnection>[]>;
    /**
     * This determines if traffic is allowed over public network. By default it is enabled. 
     * You can further restrict to specific IPs by configuring <seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules" />
     */
    readonly publicNetworkAccess?: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The Sku pricing tier for the topic.
     */
    readonly sku?: pulumi.Input<inputs.eventgrid.v20200401preview.ResourceSku>;
    /**
     * Tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the topic.
     */
    readonly topicName: pulumi.Input<string>;
}