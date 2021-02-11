// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * SSL certificate purchase order.
 * Latest API Version: 2020-09-01.
 */
export class AppServiceCertificateOrder extends pulumi.CustomResource {
    /**
     * Get an existing AppServiceCertificateOrder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AppServiceCertificateOrder {
        return new AppServiceCertificateOrder(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:certificateregistration/latest:AppServiceCertificateOrder';

    /**
     * Returns true if the given object is an instance of AppServiceCertificateOrder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AppServiceCertificateOrder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AppServiceCertificateOrder.__pulumiType;
    }

    /**
     * Reasons why App Service Certificate is not renewable at the current moment.
     */
    public /*out*/ readonly appServiceCertificateNotRenewableReasons!: pulumi.Output<string[]>;
    /**
     * <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
     */
    public readonly autoRenew!: pulumi.Output<boolean | undefined>;
    /**
     * State of the Key Vault secret.
     */
    public readonly certificates!: pulumi.Output<{[key: string]: outputs.certificateregistration.latest.AppServiceCertificateResponse} | undefined>;
    /**
     * Last CSR that was created for this order.
     */
    public readonly csr!: pulumi.Output<string | undefined>;
    /**
     * Certificate distinguished name.
     */
    public readonly distinguishedName!: pulumi.Output<string | undefined>;
    /**
     * Domain verification token.
     */
    public /*out*/ readonly domainVerificationToken!: pulumi.Output<string>;
    /**
     * Certificate expiration time.
     */
    public /*out*/ readonly expirationTime!: pulumi.Output<string>;
    /**
     * Intermediate certificate.
     */
    public /*out*/ readonly intermediate!: pulumi.Output<outputs.certificateregistration.latest.CertificateDetailsResponse>;
    /**
     * <code>true</code> if private key is external; otherwise, <code>false</code>.
     */
    public /*out*/ readonly isPrivateKeyExternal!: pulumi.Output<boolean>;
    /**
     * Certificate key size.
     */
    public readonly keySize!: pulumi.Output<number | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Certificate last issuance time.
     */
    public /*out*/ readonly lastCertificateIssuanceTime!: pulumi.Output<string>;
    /**
     * Resource Location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Time stamp when the certificate would be auto renewed next
     */
    public /*out*/ readonly nextAutoRenewalTimeStamp!: pulumi.Output<string>;
    /**
     * Certificate product type.
     */
    public readonly productType!: pulumi.Output<string>;
    /**
     * Status of certificate order.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Root certificate.
     */
    public /*out*/ readonly root!: pulumi.Output<outputs.certificateregistration.latest.CertificateDetailsResponse>;
    /**
     * Current serial number of the certificate.
     */
    public /*out*/ readonly serialNumber!: pulumi.Output<string>;
    /**
     * Signed certificate.
     */
    public /*out*/ readonly signedCertificate!: pulumi.Output<outputs.certificateregistration.latest.CertificateDetailsResponse>;
    /**
     * Current order status.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.certificateregistration.latest.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Duration in years (must be between 1 and 3).
     */
    public readonly validityInYears!: pulumi.Output<number | undefined>;

    /**
     * Create a AppServiceCertificateOrder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppServiceCertificateOrderArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.certificateOrderName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'certificateOrderName'");
            }
            if ((!args || args.productType === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'productType'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["autoRenew"] = (args ? args.autoRenew : undefined) || true;
            inputs["certificateOrderName"] = args ? args.certificateOrderName : undefined;
            inputs["certificates"] = args ? args.certificates : undefined;
            inputs["csr"] = args ? args.csr : undefined;
            inputs["distinguishedName"] = args ? args.distinguishedName : undefined;
            inputs["keySize"] = (args ? args.keySize : undefined) || 2048;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["productType"] = args ? args.productType : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["validityInYears"] = (args ? args.validityInYears : undefined) || 1;
            inputs["appServiceCertificateNotRenewableReasons"] = undefined /*out*/;
            inputs["domainVerificationToken"] = undefined /*out*/;
            inputs["expirationTime"] = undefined /*out*/;
            inputs["intermediate"] = undefined /*out*/;
            inputs["isPrivateKeyExternal"] = undefined /*out*/;
            inputs["lastCertificateIssuanceTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nextAutoRenewalTimeStamp"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["root"] = undefined /*out*/;
            inputs["serialNumber"] = undefined /*out*/;
            inputs["signedCertificate"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["appServiceCertificateNotRenewableReasons"] = undefined /*out*/;
            inputs["autoRenew"] = undefined /*out*/;
            inputs["certificates"] = undefined /*out*/;
            inputs["csr"] = undefined /*out*/;
            inputs["distinguishedName"] = undefined /*out*/;
            inputs["domainVerificationToken"] = undefined /*out*/;
            inputs["expirationTime"] = undefined /*out*/;
            inputs["intermediate"] = undefined /*out*/;
            inputs["isPrivateKeyExternal"] = undefined /*out*/;
            inputs["keySize"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["lastCertificateIssuanceTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nextAutoRenewalTimeStamp"] = undefined /*out*/;
            inputs["productType"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["root"] = undefined /*out*/;
            inputs["serialNumber"] = undefined /*out*/;
            inputs["signedCertificate"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["validityInYears"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:certificateregistration/v20150801:AppServiceCertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20180201:AppServiceCertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20190801:AppServiceCertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20200601:AppServiceCertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20201001:AppServiceCertificateOrder" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(AppServiceCertificateOrder.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AppServiceCertificateOrder resource.
 */
export interface AppServiceCertificateOrderArgs {
    /**
     * <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
     */
    readonly autoRenew?: pulumi.Input<boolean>;
    /**
     * Name of the certificate order.
     */
    readonly certificateOrderName: pulumi.Input<string>;
    /**
     * State of the Key Vault secret.
     */
    readonly certificates?: pulumi.Input<{[key: string]: pulumi.Input<inputs.certificateregistration.latest.AppServiceCertificate>}>;
    /**
     * Last CSR that was created for this order.
     */
    readonly csr?: pulumi.Input<string>;
    /**
     * Certificate distinguished name.
     */
    readonly distinguishedName?: pulumi.Input<string>;
    /**
     * Certificate key size.
     */
    readonly keySize?: pulumi.Input<number>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Certificate product type.
     */
    readonly productType: pulumi.Input<enums.certificateregistration.latest.CertificateProductType>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Duration in years (must be between 1 and 3).
     */
    readonly validityInYears?: pulumi.Input<number>;
}
