// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * An Application Insights web test definition.
 */
export class WebTest extends pulumi.CustomResource {
    /**
     * Get an existing WebTest resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebTest {
        return new WebTest(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/latest:WebTest';

    /**
     * Returns true if the given object is an instance of WebTest.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebTest {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebTest.__pulumiType;
    }

    /**
     * An XML configuration specification for a WebTest.
     */
    public readonly configuration!: pulumi.Output<outputs.insights.latest.WebTestPropertiesResponseConfiguration | undefined>;
    /**
     * Purpose/user defined descriptive test for this WebTest.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Is the test actively being monitored.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Interval in seconds between test runs for this WebTest. Default value is 300.
     */
    public readonly frequency!: pulumi.Output<number | undefined>;
    /**
     * The kind of web test that this web test watches. Choices are ping and multistep.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * A list of where to physically run the tests from to give global coverage for accessibility of your application.
     */
    public readonly locations!: pulumi.Output<outputs.insights.latest.WebTestGeolocationResponse[]>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Allow for retries should this WebTest fail.
     */
    public readonly retryEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Unique ID of this WebTest. This is typically the same value as the Name field.
     */
    public readonly syntheticMonitorId!: pulumi.Output<string>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Seconds until this WebTest will timeout and fail. Default value is 30.
     */
    public readonly timeout!: pulumi.Output<number | undefined>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The kind of web test this is, valid choices are ping and multistep.
     */
    public readonly webTestKind!: pulumi.Output<string>;
    /**
     * User defined name if this WebTest.
     */
    public readonly webTestName!: pulumi.Output<string>;

    /**
     * Create a WebTest resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebTestArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.locations === undefined) {
                throw new Error("Missing required property 'locations'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.syntheticMonitorId === undefined) {
                throw new Error("Missing required property 'syntheticMonitorId'");
            }
            if (!args || args.webTestKind === undefined) {
                throw new Error("Missing required property 'webTestKind'");
            }
            if (!args || args.webTestName === undefined) {
                throw new Error("Missing required property 'webTestName'");
            }
            inputs["configuration"] = args ? args.configuration : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["frequency"] = args ? args.frequency : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["locations"] = args ? args.locations : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["retryEnabled"] = args ? args.retryEnabled : undefined;
            inputs["syntheticMonitorId"] = args ? args.syntheticMonitorId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["timeout"] = args ? args.timeout : undefined;
            inputs["webTestKind"] = args ? args.webTestKind : undefined;
            inputs["webTestName"] = args ? args.webTestName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["configuration"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["frequency"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["locations"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["retryEnabled"] = undefined /*out*/;
            inputs["syntheticMonitorId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timeout"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["webTestKind"] = undefined /*out*/;
            inputs["webTestName"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/v20150501:WebTest" }, { type: "azure-nextgen:insights/v20201005preview:WebTest" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebTest.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebTest resource.
 */
export interface WebTestArgs {
    /**
     * An XML configuration specification for a WebTest.
     */
    readonly configuration?: pulumi.Input<inputs.insights.latest.WebTestPropertiesConfiguration>;
    /**
     * Purpose/user defined descriptive test for this WebTest.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Is the test actively being monitored.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Interval in seconds between test runs for this WebTest. Default value is 300.
     */
    readonly frequency?: pulumi.Input<number>;
    /**
     * The kind of web test that this web test watches. Choices are ping and multistep.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * A list of where to physically run the tests from to give global coverage for accessibility of your application.
     */
    readonly locations: pulumi.Input<pulumi.Input<inputs.insights.latest.WebTestGeolocation>[]>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Allow for retries should this WebTest fail.
     */
    readonly retryEnabled?: pulumi.Input<boolean>;
    /**
     * Unique ID of this WebTest. This is typically the same value as the Name field.
     */
    readonly syntheticMonitorId: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Seconds until this WebTest will timeout and fail. Default value is 30.
     */
    readonly timeout?: pulumi.Input<number>;
    /**
     * The kind of web test this is, valid choices are ping and multistep.
     */
    readonly webTestKind: pulumi.Input<string>;
    /**
     * User defined name if this WebTest.
     */
    readonly webTestName: pulumi.Input<string>;
}
