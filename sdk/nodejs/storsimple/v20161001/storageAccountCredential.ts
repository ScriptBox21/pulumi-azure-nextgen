// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * The storage account credential
 */
export class StorageAccountCredential extends pulumi.CustomResource {
    /**
     * Get an existing StorageAccountCredential resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StorageAccountCredential {
        return new StorageAccountCredential(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:storsimple/v20161001:StorageAccountCredential';

    /**
     * Returns true if the given object is an instance of StorageAccountCredential.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StorageAccountCredential {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StorageAccountCredential.__pulumiType;
    }

    /**
     * The details of the storage account password
     */
    public readonly accessKey!: pulumi.Output<outputs.storsimple.v20161001.AsymmetricEncryptedSecretResponse | undefined>;
    /**
     * The cloud service provider
     */
    public readonly cloudType!: pulumi.Output<string>;
    /**
     * SSL needs to be enabled or not
     */
    public readonly enableSSL!: pulumi.Output<string>;
    /**
     * The storage endpoint
     */
    public readonly endPoint!: pulumi.Output<string>;
    /**
     * The storage account's geo location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The storage account login
     */
    public readonly login!: pulumi.Output<string>;
    /**
     * The name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a StorageAccountCredential resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StorageAccountCredentialArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.cloudType === undefined) {
                throw new Error("Missing required property 'cloudType'");
            }
            if (!args || args.credentialName === undefined) {
                throw new Error("Missing required property 'credentialName'");
            }
            if (!args || args.enableSSL === undefined) {
                throw new Error("Missing required property 'enableSSL'");
            }
            if (!args || args.endPoint === undefined) {
                throw new Error("Missing required property 'endPoint'");
            }
            if (!args || args.login === undefined) {
                throw new Error("Missing required property 'login'");
            }
            if (!args || args.managerName === undefined) {
                throw new Error("Missing required property 'managerName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accessKey"] = args ? args.accessKey : undefined;
            inputs["cloudType"] = args ? args.cloudType : undefined;
            inputs["credentialName"] = args ? args.credentialName : undefined;
            inputs["enableSSL"] = args ? args.enableSSL : undefined;
            inputs["endPoint"] = args ? args.endPoint : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["login"] = args ? args.login : undefined;
            inputs["managerName"] = args ? args.managerName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["accessKey"] = undefined /*out*/;
            inputs["cloudType"] = undefined /*out*/;
            inputs["enableSSL"] = undefined /*out*/;
            inputs["endPoint"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["login"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:storsimple/latest:StorageAccountCredential" }, { type: "azure-nextgen:storsimple/v20170601:StorageAccountCredential" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(StorageAccountCredential.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StorageAccountCredential resource.
 */
export interface StorageAccountCredentialArgs {
    /**
     * The details of the storage account password
     */
    readonly accessKey?: pulumi.Input<inputs.storsimple.v20161001.AsymmetricEncryptedSecret>;
    /**
     * The cloud service provider
     */
    readonly cloudType: pulumi.Input<string>;
    /**
     * The credential name.
     */
    readonly credentialName: pulumi.Input<string>;
    /**
     * SSL needs to be enabled or not
     */
    readonly enableSSL: pulumi.Input<string>;
    /**
     * The storage endpoint
     */
    readonly endPoint: pulumi.Input<string>;
    /**
     * The storage account's geo location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The storage account login
     */
    readonly login: pulumi.Input<string>;
    /**
     * The manager name
     */
    readonly managerName: pulumi.Input<string>;
    /**
     * The resource group name
     */
    readonly resourceGroupName: pulumi.Input<string>;
}