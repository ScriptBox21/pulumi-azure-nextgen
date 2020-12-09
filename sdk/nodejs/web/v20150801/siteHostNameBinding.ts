// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A host name binding object
 */
export class SiteHostNameBinding extends pulumi.CustomResource {
    /**
     * Get an existing SiteHostNameBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteHostNameBinding {
        return new SiteHostNameBinding(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20150801:SiteHostNameBinding';

    /**
     * Returns true if the given object is an instance of SiteHostNameBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteHostNameBinding {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteHostNameBinding.__pulumiType;
    }

    /**
     * Azure resource name
     */
    public readonly azureResourceName!: pulumi.Output<string | undefined>;
    /**
     * Azure resource type
     */
    public readonly azureResourceType!: pulumi.Output<string | undefined>;
    /**
     * Custom DNS record type
     */
    public readonly customHostNameDnsRecordType!: pulumi.Output<string | undefined>;
    /**
     * Fully qualified ARM domain resource URI
     */
    public readonly domainId!: pulumi.Output<string | undefined>;
    /**
     * Host name type
     */
    public readonly hostNameType!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Web app name
     */
    public readonly siteName!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteHostNameBinding resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SiteHostNameBindingArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.hostName === undefined) {
                throw new Error("Missing required property 'hostName'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["azureResourceName"] = args ? args.azureResourceName : undefined;
            inputs["azureResourceType"] = args ? args.azureResourceType : undefined;
            inputs["customHostNameDnsRecordType"] = args ? args.customHostNameDnsRecordType : undefined;
            inputs["domainId"] = args ? args.domainId : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["hostNameType"] = args ? args.hostNameType : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["siteName"] = args ? args.siteName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
        } else {
            inputs["azureResourceName"] = undefined /*out*/;
            inputs["azureResourceType"] = undefined /*out*/;
            inputs["customHostNameDnsRecordType"] = undefined /*out*/;
            inputs["domainId"] = undefined /*out*/;
            inputs["hostNameType"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["siteName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20160801:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20180201:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20181101:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20190801:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20200601:SiteHostNameBinding" }, { type: "azure-nextgen:web/v20200901:SiteHostNameBinding" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SiteHostNameBinding.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteHostNameBinding resource.
 */
export interface SiteHostNameBindingArgs {
    /**
     * Azure resource name
     */
    readonly azureResourceName?: pulumi.Input<string>;
    /**
     * Azure resource type
     */
    readonly azureResourceType?: pulumi.Input<string>;
    /**
     * Custom DNS record type
     */
    readonly customHostNameDnsRecordType?: pulumi.Input<string>;
    /**
     * Fully qualified ARM domain resource URI
     */
    readonly domainId?: pulumi.Input<string>;
    /**
     * Name of host
     */
    readonly hostName: pulumi.Input<string>;
    /**
     * Host name type
     */
    readonly hostNameType?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Web app name
     */
    readonly siteName?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
}
