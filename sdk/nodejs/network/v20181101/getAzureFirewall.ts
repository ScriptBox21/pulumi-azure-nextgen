// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getAzureFirewall(args: GetAzureFirewallArgs, opts?: pulumi.InvokeOptions): Promise<GetAzureFirewallResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20181101:getAzureFirewall", {
        "azureFirewallName": args.azureFirewallName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAzureFirewallArgs {
    /**
     * The name of the Azure Firewall.
     */
    readonly azureFirewallName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Azure Firewall resource
 */
export interface GetAzureFirewallResult {
    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    readonly applicationRuleCollections?: outputs.network.v20181101.AzureFirewallApplicationRuleCollectionResponse[];
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    readonly ipConfigurations?: outputs.network.v20181101.AzureFirewallIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    readonly natRuleCollections?: outputs.network.v20181101.AzureFirewallNatRuleCollectionResponse[];
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    readonly networkRuleCollections?: outputs.network.v20181101.AzureFirewallNetworkRuleCollectionResponse[];
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
