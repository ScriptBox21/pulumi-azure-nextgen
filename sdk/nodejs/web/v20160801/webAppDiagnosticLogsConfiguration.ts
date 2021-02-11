// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Configuration of App Service site logs.
 */
export class WebAppDiagnosticLogsConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing WebAppDiagnosticLogsConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppDiagnosticLogsConfiguration {
        return new WebAppDiagnosticLogsConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20160801:WebAppDiagnosticLogsConfiguration';

    /**
     * Returns true if the given object is an instance of WebAppDiagnosticLogsConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppDiagnosticLogsConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppDiagnosticLogsConfiguration.__pulumiType;
    }

    /**
     * Application logs configuration.
     */
    public readonly applicationLogs!: pulumi.Output<outputs.web.v20160801.ApplicationLogsConfigResponse | undefined>;
    /**
     * Detailed error messages configuration.
     */
    public readonly detailedErrorMessages!: pulumi.Output<outputs.web.v20160801.EnabledConfigResponse | undefined>;
    /**
     * Failed requests tracing configuration.
     */
    public readonly failedRequestsTracing!: pulumi.Output<outputs.web.v20160801.EnabledConfigResponse | undefined>;
    /**
     * HTTP logs configuration.
     */
    public readonly httpLogs!: pulumi.Output<outputs.web.v20160801.HttpLogsConfigResponse | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppDiagnosticLogsConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppDiagnosticLogsConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["applicationLogs"] = args ? args.applicationLogs : undefined;
            inputs["detailedErrorMessages"] = args ? args.detailedErrorMessages : undefined;
            inputs["failedRequestsTracing"] = args ? args.failedRequestsTracing : undefined;
            inputs["httpLogs"] = args ? args.httpLogs : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["applicationLogs"] = undefined /*out*/;
            inputs["detailedErrorMessages"] = undefined /*out*/;
            inputs["failedRequestsTracing"] = undefined /*out*/;
            inputs["httpLogs"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20150801:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20180201:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20181101:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20190801:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20200601:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20200901:WebAppDiagnosticLogsConfiguration" }, { type: "azure-nextgen:web/v20201001:WebAppDiagnosticLogsConfiguration" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppDiagnosticLogsConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppDiagnosticLogsConfiguration resource.
 */
export interface WebAppDiagnosticLogsConfigurationArgs {
    /**
     * Application logs configuration.
     */
    readonly applicationLogs?: pulumi.Input<inputs.web.v20160801.ApplicationLogsConfig>;
    /**
     * Detailed error messages configuration.
     */
    readonly detailedErrorMessages?: pulumi.Input<inputs.web.v20160801.EnabledConfig>;
    /**
     * Failed requests tracing configuration.
     */
    readonly failedRequestsTracing?: pulumi.Input<inputs.web.v20160801.EnabledConfig>;
    /**
     * HTTP logs configuration.
     */
    readonly httpLogs?: pulumi.Input<inputs.web.v20160801.HttpLogsConfig>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of the app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
