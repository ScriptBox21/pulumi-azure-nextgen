// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./cluster";
export * from "./dataExport";
export * from "./dataSource";
export * from "./getCluster";
export * from "./getDataExport";
export * from "./getDataSource";
export * from "./getLinkedService";
export * from "./getLinkedStorageAccount";
export * from "./getSavedSearch";
export * from "./getStorageInsightConfig";
export * from "./getWorkspace";
export * from "./linkedService";
export * from "./linkedStorageAccount";
export * from "./listWorkspaceKeys";
export * from "./savedSearch";
export * from "./storageInsightConfig";
export * from "./workspace";

// Export enums:
export * from "../../types/enums/operationalinsights/latest";

// Import resources to register:
import { Cluster } from "./cluster";
import { DataExport } from "./dataExport";
import { DataSource } from "./dataSource";
import { LinkedService } from "./linkedService";
import { LinkedStorageAccount } from "./linkedStorageAccount";
import { SavedSearch } from "./savedSearch";
import { StorageInsightConfig } from "./storageInsightConfig";
import { Workspace } from "./workspace";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:operationalinsights/latest:Cluster":
                return new Cluster(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:DataExport":
                return new DataExport(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:DataSource":
                return new DataSource(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:LinkedService":
                return new LinkedService(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:LinkedStorageAccount":
                return new LinkedStorageAccount(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:SavedSearch":
                return new SavedSearch(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:StorageInsightConfig":
                return new StorageInsightConfig(name, <any>undefined, { urn })
            case "azure-nextgen:operationalinsights/latest:Workspace":
                return new Workspace(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "operationalinsights/latest", _module)
