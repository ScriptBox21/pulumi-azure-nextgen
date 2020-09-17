// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Diagnostic details.
 */
export class Diagnostic extends pulumi.CustomResource {
    /**
     * Get an existing Diagnostic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Diagnostic {
        return new Diagnostic(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:apimanagement/latest:Diagnostic';

    /**
     * Returns true if the given object is an instance of Diagnostic.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Diagnostic {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Diagnostic.__pulumiType;
    }

    /**
     * Specifies for what type of messages sampling settings should not apply.
     */
    public readonly alwaysLog!: pulumi.Output<string | undefined>;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Backend
     */
    public readonly backend!: pulumi.Output<outputs.apimanagement.latest.PipelineDiagnosticSettingsResponse | undefined>;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
     */
    public readonly frontend!: pulumi.Output<outputs.apimanagement.latest.PipelineDiagnosticSettingsResponse | undefined>;
    /**
     * Sets correlation protocol to use for Application Insights diagnostics.
     */
    public readonly httpCorrelationProtocol!: pulumi.Output<string | undefined>;
    /**
     * Log the ClientIP. Default is false.
     */
    public readonly logClientIp!: pulumi.Output<boolean | undefined>;
    /**
     * Resource Id of a target logger.
     */
    public readonly loggerId!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Sampling settings for Diagnostic.
     */
    public readonly sampling!: pulumi.Output<outputs.apimanagement.latest.SamplingSettingsResponse | undefined>;
    /**
     * Resource type for API Management resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The verbosity level applied to traces emitted by trace policies.
     */
    public readonly verbosity!: pulumi.Output<string | undefined>;

    /**
     * Create a Diagnostic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiagnosticArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.diagnosticId === undefined) {
                throw new Error("Missing required property 'diagnosticId'");
            }
            if (!args || args.loggerId === undefined) {
                throw new Error("Missing required property 'loggerId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serviceName === undefined) {
                throw new Error("Missing required property 'serviceName'");
            }
            inputs["alwaysLog"] = args ? args.alwaysLog : undefined;
            inputs["backend"] = args ? args.backend : undefined;
            inputs["diagnosticId"] = args ? args.diagnosticId : undefined;
            inputs["frontend"] = args ? args.frontend : undefined;
            inputs["httpCorrelationProtocol"] = args ? args.httpCorrelationProtocol : undefined;
            inputs["logClientIp"] = args ? args.logClientIp : undefined;
            inputs["loggerId"] = args ? args.loggerId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sampling"] = args ? args.sampling : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["verbosity"] = args ? args.verbosity : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["alwaysLog"] = undefined /*out*/;
            inputs["backend"] = undefined /*out*/;
            inputs["frontend"] = undefined /*out*/;
            inputs["httpCorrelationProtocol"] = undefined /*out*/;
            inputs["logClientIp"] = undefined /*out*/;
            inputs["loggerId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["sampling"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["verbosity"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:apimanagement/v20170301:Diagnostic" }, { type: "azure-nextgen:apimanagement/v20180101:Diagnostic" }, { type: "azure-nextgen:apimanagement/v20180601preview:Diagnostic" }, { type: "azure-nextgen:apimanagement/v20190101:Diagnostic" }, { type: "azure-nextgen:apimanagement/v20191201:Diagnostic" }, { type: "azure-nextgen:apimanagement/v20191201preview:Diagnostic" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Diagnostic.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Diagnostic resource.
 */
export interface DiagnosticArgs {
    /**
     * Specifies for what type of messages sampling settings should not apply.
     */
    readonly alwaysLog?: pulumi.Input<string>;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Backend
     */
    readonly backend?: pulumi.Input<inputs.apimanagement.latest.PipelineDiagnosticSettings>;
    /**
     * Diagnostic identifier. Must be unique in the current API Management service instance.
     */
    readonly diagnosticId: pulumi.Input<string>;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
     */
    readonly frontend?: pulumi.Input<inputs.apimanagement.latest.PipelineDiagnosticSettings>;
    /**
     * Sets correlation protocol to use for Application Insights diagnostics.
     */
    readonly httpCorrelationProtocol?: pulumi.Input<string>;
    /**
     * Log the ClientIP. Default is false.
     */
    readonly logClientIp?: pulumi.Input<boolean>;
    /**
     * Resource Id of a target logger.
     */
    readonly loggerId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Sampling settings for Diagnostic.
     */
    readonly sampling?: pulumi.Input<inputs.apimanagement.latest.SamplingSettings>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
    /**
     * The verbosity level applied to traces emitted by trace policies.
     */
    readonly verbosity?: pulumi.Input<string>;
}