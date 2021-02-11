// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getWebAppDomainOwnershipIdentifier(args: GetWebAppDomainOwnershipIdentifierArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppDomainOwnershipIdentifierResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20201001:getWebAppDomainOwnershipIdentifier", {
        "domainOwnershipIdentifierName": args.domainOwnershipIdentifierName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetWebAppDomainOwnershipIdentifierArgs {
    /**
     * Name of domain ownership identifier.
     */
    readonly domainOwnershipIdentifierName: string;
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * A domain specific resource identifier.
 */
export interface GetWebAppDomainOwnershipIdentifierResult {
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.web.v20201001.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * String representation of the identity.
     */
    readonly value?: string;
}
