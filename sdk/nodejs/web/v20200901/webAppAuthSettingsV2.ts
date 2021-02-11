// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export class WebAppAuthSettingsV2 extends pulumi.CustomResource {
    /**
     * Get an existing WebAppAuthSettingsV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppAuthSettingsV2 {
        return new WebAppAuthSettingsV2(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200901:WebAppAuthSettingsV2';

    /**
     * Returns true if the given object is an instance of WebAppAuthSettingsV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppAuthSettingsV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppAuthSettingsV2.__pulumiType;
    }

    public readonly globalValidation!: pulumi.Output<outputs.web.v20200901.GlobalValidationResponse | undefined>;
    public readonly httpSettings!: pulumi.Output<outputs.web.v20200901.HttpSettingsResponse | undefined>;
    public readonly identityProviders!: pulumi.Output<outputs.web.v20200901.IdentityProvidersResponse | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    public readonly login!: pulumi.Output<outputs.web.v20200901.LoginResponse | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly platform!: pulumi.Output<outputs.web.v20200901.AuthPlatformResponse | undefined>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.web.v20200901.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppAuthSettingsV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppAuthSettingsV2Args, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["globalValidation"] = args ? args.globalValidation : undefined;
            inputs["httpSettings"] = args ? args.httpSettings : undefined;
            inputs["identityProviders"] = args ? args.identityProviders : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["login"] = args ? args.login : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["platform"] = args ? args.platform : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["globalValidation"] = undefined /*out*/;
            inputs["httpSettings"] = undefined /*out*/;
            inputs["identityProviders"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["login"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["platform"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppAuthSettingsV2" }, { type: "azure-nextgen:web/v20200601:WebAppAuthSettingsV2" }, { type: "azure-nextgen:web/v20201001:WebAppAuthSettingsV2" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppAuthSettingsV2.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppAuthSettingsV2 resource.
 */
export interface WebAppAuthSettingsV2Args {
    readonly globalValidation?: pulumi.Input<inputs.web.v20200901.GlobalValidation>;
    readonly httpSettings?: pulumi.Input<inputs.web.v20200901.HttpSettings>;
    readonly identityProviders?: pulumi.Input<inputs.web.v20200901.IdentityProviders>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    readonly login?: pulumi.Input<inputs.web.v20200901.Login>;
    /**
     * Name of web app.
     */
    readonly name: pulumi.Input<string>;
    readonly platform?: pulumi.Input<inputs.web.v20200901.AuthPlatform>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
