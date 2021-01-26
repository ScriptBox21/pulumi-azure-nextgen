// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getPolicyAssignment";
export * from "./getPolicyDefinition";
export * from "./getPolicyDefinitionAtManagementGroup";
export * from "./getPolicySetDefinition";
export * from "./getPolicySetDefinitionAtManagementGroup";
export * from "./policyAssignment";
export * from "./policyDefinition";
export * from "./policyDefinitionAtManagementGroup";
export * from "./policySetDefinition";
export * from "./policySetDefinitionAtManagementGroup";

// Export enums:
export * from "../../types/enums/authorization/v20200901";

// Import resources to register:
import { PolicyAssignment } from "./policyAssignment";
import { PolicyDefinition } from "./policyDefinition";
import { PolicyDefinitionAtManagementGroup } from "./policyDefinitionAtManagementGroup";
import { PolicySetDefinition } from "./policySetDefinition";
import { PolicySetDefinitionAtManagementGroup } from "./policySetDefinitionAtManagementGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:authorization/v20200901:PolicyAssignment":
                return new PolicyAssignment(name, <any>undefined, { urn })
            case "azure-nextgen:authorization/v20200901:PolicyDefinition":
                return new PolicyDefinition(name, <any>undefined, { urn })
            case "azure-nextgen:authorization/v20200901:PolicyDefinitionAtManagementGroup":
                return new PolicyDefinitionAtManagementGroup(name, <any>undefined, { urn })
            case "azure-nextgen:authorization/v20200901:PolicySetDefinition":
                return new PolicySetDefinition(name, <any>undefined, { urn })
            case "azure-nextgen:authorization/v20200901:PolicySetDefinitionAtManagementGroup":
                return new PolicySetDefinitionAtManagementGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "authorization/v20200901", _module)
