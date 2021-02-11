// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of a backup which will be performed.
 */
export class WebAppBackupConfigurationSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppBackupConfigurationSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppBackupConfigurationSlot {
        return new WebAppBackupConfigurationSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20201001:WebAppBackupConfigurationSlot';

    /**
     * Returns true if the given object is an instance of WebAppBackupConfigurationSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppBackupConfigurationSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppBackupConfigurationSlot.__pulumiType;
    }

    /**
     * Name of the backup.
     */
    public readonly backupName!: pulumi.Output<string | undefined>;
    /**
     * Schedule for the backup if it is executed periodically.
     */
    public readonly backupSchedule!: pulumi.Output<outputs.web.v20201001.BackupScheduleResponse | undefined>;
    /**
     * Databases included in the backup.
     */
    public readonly databases!: pulumi.Output<outputs.web.v20201001.DatabaseBackupSettingResponse[] | undefined>;
    /**
     * True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * SAS URL to the container.
     */
    public readonly storageAccountUrl!: pulumi.Output<string>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.web.v20201001.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppBackupConfigurationSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppBackupConfigurationSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.slot === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'slot'");
            }
            if ((!args || args.storageAccountUrl === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'storageAccountUrl'");
            }
            inputs["backupName"] = args ? args.backupName : undefined;
            inputs["backupSchedule"] = args ? args.backupSchedule : undefined;
            inputs["databases"] = args ? args.databases : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["storageAccountUrl"] = args ? args.storageAccountUrl : undefined;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["backupName"] = undefined /*out*/;
            inputs["backupSchedule"] = undefined /*out*/;
            inputs["databases"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["storageAccountUrl"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20150801:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20160801:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20180201:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20181101:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20190801:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20200601:WebAppBackupConfigurationSlot" }, { type: "azure-nextgen:web/v20200901:WebAppBackupConfigurationSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppBackupConfigurationSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppBackupConfigurationSlot resource.
 */
export interface WebAppBackupConfigurationSlotArgs {
    /**
     * Name of the backup.
     */
    readonly backupName?: pulumi.Input<string>;
    /**
     * Schedule for the backup if it is executed periodically.
     */
    readonly backupSchedule?: pulumi.Input<inputs.web.v20201001.BackupSchedule>;
    /**
     * Databases included in the backup.
     */
    readonly databases?: pulumi.Input<pulumi.Input<inputs.web.v20201001.DatabaseBackupSetting>[]>;
    /**
     * True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
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
    /**
     * Name of the deployment slot. If a slot is not specified, the API will update the backup configuration for the production slot.
     */
    readonly slot: pulumi.Input<string>;
    /**
     * SAS URL to the container.
     */
    readonly storageAccountUrl: pulumi.Input<string>;
}
