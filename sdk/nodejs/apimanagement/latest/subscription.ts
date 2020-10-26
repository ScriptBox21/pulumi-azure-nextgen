// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Subscription details.
 */
export class Subscription extends pulumi.CustomResource {
    /**
     * Get an existing Subscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Subscription {
        return new Subscription(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:apimanagement/latest:Subscription';

    /**
     * Returns true if the given object is an instance of Subscription.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Subscription {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Subscription.__pulumiType;
    }

    /**
     * Determines whether tracing is enabled
     */
    public readonly allowTracing!: pulumi.Output<boolean | undefined>;
    /**
     * Subscription creation date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly createdDate!: pulumi.Output<string>;
    /**
     * The name of the subscription, or null if the subscription has no name.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * Date when subscription was cancelled or expired. The setting is for audit purposes only and the subscription is not automatically cancelled. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly endDate!: pulumi.Output<string | undefined>;
    /**
     * Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly expirationDate!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Upcoming subscription expiration notification date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly notificationDate!: pulumi.Output<string | undefined>;
    /**
     * The user resource identifier of the subscription owner. The value is a valid relative URL in the format of /users/{userId} where {userId} is a user identifier.
     */
    public readonly ownerId!: pulumi.Output<string | undefined>;
    /**
     * Subscription primary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
     */
    public readonly primaryKey!: pulumi.Output<string | undefined>;
    /**
     * Scope like /products/{productId} or /apis or /apis/{apiId}.
     */
    public readonly scope!: pulumi.Output<string>;
    /**
     * Subscription secondary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
     */
    public readonly secondaryKey!: pulumi.Output<string | undefined>;
    /**
     * Subscription activation date. The setting is for audit purposes only and the subscription is not automatically activated. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly startDate!: pulumi.Output<string | undefined>;
    /**
     * Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
     */
    public readonly state!: pulumi.Output<string>;
    /**
     * Optional subscription comment added by an administrator when the state is changed to the 'rejected'.
     */
    public /*out*/ readonly stateComment!: pulumi.Output<string | undefined>;
    /**
     * Resource type for API Management resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Subscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubscriptionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.displayName === undefined) {
                throw new Error("Missing required property 'displayName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.scope === undefined) {
                throw new Error("Missing required property 'scope'");
            }
            if (!args || args.serviceName === undefined) {
                throw new Error("Missing required property 'serviceName'");
            }
            if (!args || args.sid === undefined) {
                throw new Error("Missing required property 'sid'");
            }
            inputs["allowTracing"] = args ? args.allowTracing : undefined;
            inputs["appType"] = args ? args.appType : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["notify"] = args ? args.notify : undefined;
            inputs["ownerId"] = args ? args.ownerId : undefined;
            inputs["primaryKey"] = args ? args.primaryKey : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scope"] = args ? args.scope : undefined;
            inputs["secondaryKey"] = args ? args.secondaryKey : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["sid"] = args ? args.sid : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["createdDate"] = undefined /*out*/;
            inputs["endDate"] = undefined /*out*/;
            inputs["expirationDate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notificationDate"] = undefined /*out*/;
            inputs["startDate"] = undefined /*out*/;
            inputs["stateComment"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["allowTracing"] = undefined /*out*/;
            inputs["createdDate"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["endDate"] = undefined /*out*/;
            inputs["expirationDate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notificationDate"] = undefined /*out*/;
            inputs["ownerId"] = undefined /*out*/;
            inputs["primaryKey"] = undefined /*out*/;
            inputs["scope"] = undefined /*out*/;
            inputs["secondaryKey"] = undefined /*out*/;
            inputs["startDate"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["stateComment"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:apimanagement/v20160707:Subscription" }, { type: "azure-nextgen:apimanagement/v20161010:Subscription" }, { type: "azure-nextgen:apimanagement/v20170301:Subscription" }, { type: "azure-nextgen:apimanagement/v20180101:Subscription" }, { type: "azure-nextgen:apimanagement/v20180601preview:Subscription" }, { type: "azure-nextgen:apimanagement/v20190101:Subscription" }, { type: "azure-nextgen:apimanagement/v20191201:Subscription" }, { type: "azure-nextgen:apimanagement/v20191201preview:Subscription" }, { type: "azure-nextgen:apimanagement/v20200601preview:Subscription" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Subscription.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Subscription resource.
 */
export interface SubscriptionArgs {
    /**
     * Determines whether tracing can be enabled
     */
    readonly allowTracing?: pulumi.Input<boolean>;
    /**
     * Determines the type of application which send the create user request. Default is legacy publisher portal.
     */
    readonly appType?: pulumi.Input<string>;
    /**
     * Subscription name.
     */
    readonly displayName: pulumi.Input<string>;
    /**
     * Notify change in Subscription State. 
     *  - If false, do not send any email notification for change of state of subscription 
     *  - If true, send email notification of change of state of subscription 
     */
    readonly notify?: pulumi.Input<boolean>;
    /**
     * User (user id path) for whom subscription is being created in form /users/{userId}
     */
    readonly ownerId?: pulumi.Input<string>;
    /**
     * Primary subscription key. If not specified during request key will be generated automatically.
     */
    readonly primaryKey?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Scope like /products/{productId} or /apis or /apis/{apiId}.
     */
    readonly scope: pulumi.Input<string>;
    /**
     * Secondary subscription key. If not specified during request key will be generated automatically.
     */
    readonly secondaryKey?: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
    /**
     * Subscription entity Identifier. The entity represents the association between a user and a product in API Management.
     */
    readonly sid: pulumi.Input<string>;
    /**
     * Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
     */
    readonly state?: pulumi.Input<string>;
}
