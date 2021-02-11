// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Hybrid Connection contract. This is used to configure a Hybrid Connection.
 */
export class WebAppHybridConnection extends pulumi.CustomResource {
    /**
     * Get an existing WebAppHybridConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppHybridConnection {
        return new WebAppHybridConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20180201:WebAppHybridConnection';

    /**
     * Returns true if the given object is an instance of WebAppHybridConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppHybridConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppHybridConnection.__pulumiType;
    }

    /**
     * The hostname of the endpoint.
     */
    public readonly hostname!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The port of the endpoint.
     */
    public readonly port!: pulumi.Output<number | undefined>;
    /**
     * The ARM URI to the Service Bus relay.
     */
    public readonly relayArmUri!: pulumi.Output<string | undefined>;
    /**
     * The name of the Service Bus relay.
     */
    public readonly relayName!: pulumi.Output<string | undefined>;
    /**
     * The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus.
     */
    public readonly sendKeyName!: pulumi.Output<string | undefined>;
    /**
     * The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
     * normally, use the POST /listKeys API instead.
     */
    public readonly sendKeyValue!: pulumi.Output<string | undefined>;
    /**
     * The name of the Service Bus namespace.
     */
    public readonly serviceBusNamespace!: pulumi.Output<string | undefined>;
    /**
     * The suffix for the service bus endpoint. By default this is .servicebus.windows.net
     */
    public readonly serviceBusSuffix!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppHybridConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppHybridConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.namespaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if ((!args || args.relayName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'relayName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["hostname"] = args ? args.hostname : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["port"] = args ? args.port : undefined;
            inputs["relayArmUri"] = args ? args.relayArmUri : undefined;
            inputs["relayName"] = args ? args.relayName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sendKeyName"] = args ? args.sendKeyName : undefined;
            inputs["sendKeyValue"] = args ? args.sendKeyValue : undefined;
            inputs["serviceBusNamespace"] = args ? args.serviceBusNamespace : undefined;
            inputs["serviceBusSuffix"] = args ? args.serviceBusSuffix : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["hostname"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["port"] = undefined /*out*/;
            inputs["relayArmUri"] = undefined /*out*/;
            inputs["relayName"] = undefined /*out*/;
            inputs["sendKeyName"] = undefined /*out*/;
            inputs["sendKeyValue"] = undefined /*out*/;
            inputs["serviceBusNamespace"] = undefined /*out*/;
            inputs["serviceBusSuffix"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20160801:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20181101:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20190801:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20200601:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20200901:WebAppHybridConnection" }, { type: "azure-nextgen:web/v20201001:WebAppHybridConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppHybridConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppHybridConnection resource.
 */
export interface WebAppHybridConnectionArgs {
    /**
     * The hostname of the endpoint.
     */
    readonly hostname?: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * The name of the web app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The namespace for this hybrid connection.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * The port of the endpoint.
     */
    readonly port?: pulumi.Input<number>;
    /**
     * The ARM URI to the Service Bus relay.
     */
    readonly relayArmUri?: pulumi.Input<string>;
    /**
     * The name of the Service Bus relay.
     */
    readonly relayName: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus.
     */
    readonly sendKeyName?: pulumi.Input<string>;
    /**
     * The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
     * normally, use the POST /listKeys API instead.
     */
    readonly sendKeyValue?: pulumi.Input<string>;
    /**
     * The name of the Service Bus namespace.
     */
    readonly serviceBusNamespace?: pulumi.Input<string>;
    /**
     * The suffix for the service bus endpoint. By default this is .servicebus.windows.net
     */
    readonly serviceBusSuffix?: pulumi.Input<string>;
}
