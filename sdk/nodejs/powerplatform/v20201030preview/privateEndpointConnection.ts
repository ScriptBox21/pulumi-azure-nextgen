// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * A private endpoint connection
 */
export class PrivateEndpointConnection extends pulumi.CustomResource {
    /**
     * Get an existing PrivateEndpointConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrivateEndpointConnection {
        return new PrivateEndpointConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:powerplatform/v20201030preview:PrivateEndpointConnection';

    /**
     * Returns true if the given object is an instance of PrivateEndpointConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PrivateEndpointConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PrivateEndpointConnection.__pulumiType;
    }

    /**
     * Region where the EnterprisePolicy is located.
     */
    public /*out*/ readonly location!: pulumi.Output<string>;
    /**
     * Name of the EnterprisePolicy.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The resource of private end point.
     */
    public /*out*/ readonly privateEndpoint!: pulumi.Output<outputs.powerplatform.v20201030preview.PrivateEndpointResponse | undefined>;
    /**
     * A collection of information about the state of the connection between service consumer and provider.
     */
    public readonly privateLinkServiceConnectionState!: pulumi.Output<outputs.powerplatform.v20201030preview.PrivateLinkServiceConnectionStateResponse>;
    /**
     * The provisioning state of the private endpoint connection resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PrivateEndpointConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PrivateEndpointConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.enterprisePolicyName === undefined) {
                throw new Error("Missing required property 'enterprisePolicyName'");
            }
            if (!args || args.privateEndpointConnectionName === undefined) {
                throw new Error("Missing required property 'privateEndpointConnectionName'");
            }
            if (!args || args.privateLinkServiceConnectionState === undefined) {
                throw new Error("Missing required property 'privateLinkServiceConnectionState'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["enterprisePolicyName"] = args ? args.enterprisePolicyName : undefined;
            inputs["privateEndpointConnectionName"] = args ? args.privateEndpointConnectionName : undefined;
            inputs["privateLinkServiceConnectionState"] = args ? args.privateLinkServiceConnectionState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["privateLinkServiceConnectionState"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(PrivateEndpointConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PrivateEndpointConnection resource.
 */
export interface PrivateEndpointConnectionArgs {
    /**
     * EnterprisePolicy for the Microsoft Azure subscription.
     */
    readonly enterprisePolicyName: pulumi.Input<string>;
    /**
     * The name of the private endpoint connection.
     */
    readonly privateEndpointConnectionName: pulumi.Input<string>;
    /**
     * A collection of information about the state of the connection between service consumer and provider.
     */
    readonly privateLinkServiceConnectionState: pulumi.Input<inputs.powerplatform.v20201030preview.PrivateLinkServiceConnectionState>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
