// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getEntity";
export * from "./getHierarchySetting";
export * from "./getManagementGroup";
export * from "./getManagementGroupSubscription";
export * from "./hierarchySetting";
export * from "./managementGroup";
export * from "./managementGroupSubscription";

// Import resources to register:
import { HierarchySetting } from "./hierarchySetting";
import { ManagementGroup } from "./managementGroup";
import { ManagementGroupSubscription } from "./managementGroupSubscription";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:management/latest:HierarchySetting":
                return new HierarchySetting(name, <any>undefined, { urn })
            case "azure-nextgen:management/latest:ManagementGroup":
                return new ManagementGroup(name, <any>undefined, { urn })
            case "azure-nextgen:management/latest:ManagementGroupSubscription":
                return new ManagementGroupSubscription(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "management/latest", _module)
