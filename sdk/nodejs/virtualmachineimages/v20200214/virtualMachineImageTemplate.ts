// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Image template is an ARM resource managed by Microsoft.VirtualMachineImages provider
 */
export class VirtualMachineImageTemplate extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineImageTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineImageTemplate {
        return new VirtualMachineImageTemplate(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:virtualmachineimages/v20200214:VirtualMachineImageTemplate';

    /**
     * Returns true if the given object is an instance of VirtualMachineImageTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineImageTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineImageTemplate.__pulumiType;
    }

    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    public readonly buildTimeoutInMinutes!: pulumi.Output<number | undefined>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    public readonly customize!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateFileCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplatePowerShellCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateRestartCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateShellCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateWindowsUpdateCustomizerResponse[] | undefined>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    public readonly distribute!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateManagedImageDistributorResponse | outputs.virtualmachineimages.v20200214.ImageTemplateSharedImageDistributorResponse | outputs.virtualmachineimages.v20200214.ImageTemplateVhdDistributorResponse[]>;
    /**
     * The identity of the image template, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateIdentityResponse>;
    /**
     * State of 'run' that is currently executing or was last executed.
     */
    public /*out*/ readonly lastRunStatus!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateLastRunStatusResponse>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning error, if any
     */
    public /*out*/ readonly provisioningError!: pulumi.Output<outputs.virtualmachineimages.v20200214.ProvisioningErrorResponse>;
    /**
     * Provisioning state of the resource
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    public readonly source!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateManagedImageSourceResponse | outputs.virtualmachineimages.v20200214.ImageTemplatePlatformImageSourceResponse | outputs.virtualmachineimages.v20200214.ImageTemplateSharedImageVersionSourceResponse>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Describes how virtual machine is set up to build images
     */
    public readonly vmProfile!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateVmProfileResponse | undefined>;

    /**
     * Create a VirtualMachineImageTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineImageTemplateArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.distribute === undefined) {
                throw new Error("Missing required property 'distribute'");
            }
            if (!args || args.identity === undefined) {
                throw new Error("Missing required property 'identity'");
            }
            if (!args || args.imageTemplateName === undefined) {
                throw new Error("Missing required property 'imageTemplateName'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.source === undefined) {
                throw new Error("Missing required property 'source'");
            }
            inputs["buildTimeoutInMinutes"] = args ? args.buildTimeoutInMinutes : undefined;
            inputs["customize"] = args ? args.customize : undefined;
            inputs["distribute"] = args ? args.distribute : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["imageTemplateName"] = args ? args.imageTemplateName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vmProfile"] = args ? args.vmProfile : undefined;
            inputs["lastRunStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningError"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["buildTimeoutInMinutes"] = undefined /*out*/;
            inputs["customize"] = undefined /*out*/;
            inputs["distribute"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["lastRunStatus"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningError"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["source"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vmProfile"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:virtualmachineimages/latest:VirtualMachineImageTemplate" }, { type: "azure-nextgen:virtualmachineimages/v20180201preview:VirtualMachineImageTemplate" }, { type: "azure-nextgen:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate" }, { type: "azure-nextgen:virtualmachineimages/v20190501preview:VirtualMachineImageTemplate" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualMachineImageTemplate.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualMachineImageTemplate resource.
 */
export interface VirtualMachineImageTemplateArgs {
    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    readonly buildTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    readonly customize?: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateFileCustomizer | inputs.virtualmachineimages.v20200214.ImageTemplatePowerShellCustomizer | inputs.virtualmachineimages.v20200214.ImageTemplateRestartCustomizer | inputs.virtualmachineimages.v20200214.ImageTemplateShellCustomizer | inputs.virtualmachineimages.v20200214.ImageTemplateWindowsUpdateCustomizer>[]>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    readonly distribute: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateManagedImageDistributor | inputs.virtualmachineimages.v20200214.ImageTemplateSharedImageDistributor | inputs.virtualmachineimages.v20200214.ImageTemplateVhdDistributor>[]>;
    /**
     * The identity of the image template, if configured.
     */
    readonly identity: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateIdentity>;
    /**
     * The name of the image Template
     */
    readonly imageTemplateName: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    readonly source: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateManagedImageSource | inputs.virtualmachineimages.v20200214.ImageTemplatePlatformImageSource | inputs.virtualmachineimages.v20200214.ImageTemplateSharedImageVersionSource>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Describes how virtual machine is set up to build images
     */
    readonly vmProfile?: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateVmProfile>;
}