// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Domain service.
 */
export class DomainService extends pulumi.CustomResource {
    /**
     * Get an existing DomainService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DomainService {
        return new DomainService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:aad/latest:DomainService';

    /**
     * Returns true if the given object is an instance of DomainService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DomainService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DomainService.__pulumiType;
    }

    /**
     * Deployment Id
     */
    public /*out*/ readonly deploymentId!: pulumi.Output<string>;
    /**
     * Domain Configuration Type
     */
    public readonly domainConfigurationType!: pulumi.Output<string | undefined>;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    public readonly domainName!: pulumi.Output<string | undefined>;
    /**
     * DomainSecurity Settings
     */
    public readonly domainSecuritySettings!: pulumi.Output<outputs.aad.latest.DomainSecuritySettingsResponse | undefined>;
    /**
     * Resource etag
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    public readonly filteredSync!: pulumi.Output<string | undefined>;
    /**
     * Secure LDAP Settings
     */
    public readonly ldapsSettings!: pulumi.Output<outputs.aad.latest.LdapsSettingsResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Migration Properties
     */
    public readonly migrationProperties!: pulumi.Output<outputs.aad.latest.MigrationPropertiesResponse | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Notification Settings
     */
    public readonly notificationSettings!: pulumi.Output<outputs.aad.latest.NotificationSettingsResponse | undefined>;
    /**
     * the current deployment or provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * List of ReplicaSets
     */
    public readonly replicaSets!: pulumi.Output<outputs.aad.latest.ReplicaSetResponse[] | undefined>;
    /**
     * Resource Forest Settings
     */
    public readonly resourceForestSettings!: pulumi.Output<outputs.aad.latest.ResourceForestSettingsResponse | undefined>;
    /**
     * Sku Type
     */
    public readonly sku!: pulumi.Output<string | undefined>;
    /**
     * SyncOwner ReplicaSet Id
     */
    public /*out*/ readonly syncOwner!: pulumi.Output<string>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure Active Directory Tenant Id
     */
    public /*out*/ readonly tenantId!: pulumi.Output<string>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Data Model Version
     */
    public /*out*/ readonly version!: pulumi.Output<number>;

    /**
     * Create a DomainService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainServiceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.domainServiceName === undefined) {
                throw new Error("Missing required property 'domainServiceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["domainConfigurationType"] = args ? args.domainConfigurationType : undefined;
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["domainSecuritySettings"] = args ? args.domainSecuritySettings : undefined;
            inputs["domainServiceName"] = args ? args.domainServiceName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["filteredSync"] = args ? args.filteredSync : undefined;
            inputs["ldapsSettings"] = args ? args.ldapsSettings : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["migrationProperties"] = args ? args.migrationProperties : undefined;
            inputs["notificationSettings"] = args ? args.notificationSettings : undefined;
            inputs["replicaSets"] = args ? args.replicaSets : undefined;
            inputs["resourceForestSettings"] = args ? args.resourceForestSettings : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["deploymentId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["syncOwner"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        } else {
            inputs["deploymentId"] = undefined /*out*/;
            inputs["domainConfigurationType"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["domainSecuritySettings"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["filteredSync"] = undefined /*out*/;
            inputs["ldapsSettings"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["migrationProperties"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notificationSettings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["replicaSets"] = undefined /*out*/;
            inputs["resourceForestSettings"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["syncOwner"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:aad/v20170101:DomainService" }, { type: "azure-nextgen:aad/v20170601:DomainService" }, { type: "azure-nextgen:aad/v20200101:DomainService" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DomainService.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DomainService resource.
 */
export interface DomainServiceArgs {
    /**
     * Domain Configuration Type
     */
    readonly domainConfigurationType?: pulumi.Input<string>;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    readonly domainName?: pulumi.Input<string>;
    /**
     * DomainSecurity Settings
     */
    readonly domainSecuritySettings?: pulumi.Input<inputs.aad.latest.DomainSecuritySettings>;
    /**
     * The name of the domain service.
     */
    readonly domainServiceName: pulumi.Input<string>;
    /**
     * Resource etag
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    readonly filteredSync?: pulumi.Input<string>;
    /**
     * Secure LDAP Settings
     */
    readonly ldapsSettings?: pulumi.Input<inputs.aad.latest.LdapsSettings>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Migration Properties
     */
    readonly migrationProperties?: pulumi.Input<inputs.aad.latest.MigrationProperties>;
    /**
     * Notification Settings
     */
    readonly notificationSettings?: pulumi.Input<inputs.aad.latest.NotificationSettings>;
    /**
     * List of ReplicaSets
     */
    readonly replicaSets?: pulumi.Input<pulumi.Input<inputs.aad.latest.ReplicaSet>[]>;
    /**
     * Resource Forest Settings
     */
    readonly resourceForestSettings?: pulumi.Input<inputs.aad.latest.ResourceForestSettings>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Sku Type
     */
    readonly sku?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
