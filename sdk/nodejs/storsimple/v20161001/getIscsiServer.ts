// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getIscsiServer(args: GetIscsiServerArgs, opts?: pulumi.InvokeOptions): Promise<GetIscsiServerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storsimple/v20161001:getIscsiServer", {
        "deviceName": args.deviceName,
        "iscsiServerName": args.iscsiServerName,
        "managerName": args.managerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetIscsiServerArgs {
    /**
     * The device name.
     */
    readonly deviceName: string;
    /**
     * The iSCSI server name.
     */
    readonly iscsiServerName: string;
    /**
     * The manager name
     */
    readonly managerName: string;
    /**
     * The resource group name
     */
    readonly resourceGroupName: string;
}

/**
 * The iSCSI server.
 */
export interface GetIscsiServerResult {
    /**
     * The backup policy id.
     */
    readonly backupScheduleGroupId: string;
    /**
     * The chap id.
     */
    readonly chapId?: string;
    /**
     * The description.
     */
    readonly description?: string;
    /**
     * The name.
     */
    readonly name: string;
    /**
     * The reverse chap id.
     */
    readonly reverseChapId?: string;
    /**
     * The storage domain id.
     */
    readonly storageDomainId: string;
    /**
     * The type.
     */
    readonly type: string;
}