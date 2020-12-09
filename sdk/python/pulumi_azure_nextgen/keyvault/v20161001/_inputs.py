# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AccessPolicyEntryArgs',
    'PermissionsArgs',
    'SecretAttributesArgs',
    'SecretPropertiesArgs',
    'SkuArgs',
    'VaultPropertiesArgs',
]

@pulumi.input_type
class AccessPolicyEntryArgs:
    def __init__(__self__, *,
                 object_id: pulumi.Input[str],
                 permissions: pulumi.Input['PermissionsArgs'],
                 tenant_id: pulumi.Input[str],
                 application_id: Optional[pulumi.Input[str]] = None):
        """
        An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.
        :param pulumi.Input[str] object_id: The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies.
        :param pulumi.Input['PermissionsArgs'] permissions: Permissions the identity has for keys, secrets and certificates.
        :param pulumi.Input[str] tenant_id: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        :param pulumi.Input[str] application_id:  Application ID of the client making request on behalf of a principal
        """
        pulumi.set(__self__, "object_id", object_id)
        pulumi.set(__self__, "permissions", permissions)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> pulumi.Input[str]:
        """
        The object ID of a user, service principal or security group in the Azure Active Directory tenant for the vault. The object ID must be unique for the list of access policies.
        """
        return pulumi.get(self, "object_id")

    @object_id.setter
    def object_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "object_id", value)

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Input['PermissionsArgs']:
        """
        Permissions the identity has for keys, secrets and certificates.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: pulumi.Input['PermissionsArgs']):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Input[str]:
        """
        The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "tenant_id", value)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> Optional[pulumi.Input[str]]:
        """
         Application ID of the client making request on behalf of a principal
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "application_id", value)


@pulumi.input_type
class PermissionsArgs:
    def __init__(__self__, *,
                 certificates: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 keys: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 storage: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Permissions the identity has for keys, secrets, certificates and storage.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] certificates: Permissions to certificates
        :param pulumi.Input[Sequence[pulumi.Input[str]]] keys: Permissions to keys
        :param pulumi.Input[Sequence[pulumi.Input[str]]] secrets: Permissions to secrets
        :param pulumi.Input[Sequence[pulumi.Input[str]]] storage: Permissions to storage accounts
        """
        if certificates is not None:
            pulumi.set(__self__, "certificates", certificates)
        if keys is not None:
            pulumi.set(__self__, "keys", keys)
        if secrets is not None:
            pulumi.set(__self__, "secrets", secrets)
        if storage is not None:
            pulumi.set(__self__, "storage", storage)

    @property
    @pulumi.getter
    def certificates(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Permissions to certificates
        """
        return pulumi.get(self, "certificates")

    @certificates.setter
    def certificates(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "certificates", value)

    @property
    @pulumi.getter
    def keys(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Permissions to keys
        """
        return pulumi.get(self, "keys")

    @keys.setter
    def keys(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "keys", value)

    @property
    @pulumi.getter
    def secrets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Permissions to secrets
        """
        return pulumi.get(self, "secrets")

    @secrets.setter
    def secrets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "secrets", value)

    @property
    @pulumi.getter
    def storage(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Permissions to storage accounts
        """
        return pulumi.get(self, "storage")

    @storage.setter
    def storage(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "storage", value)


@pulumi.input_type
class SecretAttributesArgs:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 expires: Optional[pulumi.Input[int]] = None,
                 not_before: Optional[pulumi.Input[int]] = None):
        """
        The secret management attributes.
        :param pulumi.Input[bool] enabled: Determines whether the object is enabled.
        :param pulumi.Input[int] expires: Expiry date in seconds since 1970-01-01T00:00:00Z.
        :param pulumi.Input[int] not_before: Not before date in seconds since 1970-01-01T00:00:00Z.
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if expires is not None:
            pulumi.set(__self__, "expires", expires)
        if not_before is not None:
            pulumi.set(__self__, "not_before", not_before)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Determines whether the object is enabled.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def expires(self) -> Optional[pulumi.Input[int]]:
        """
        Expiry date in seconds since 1970-01-01T00:00:00Z.
        """
        return pulumi.get(self, "expires")

    @expires.setter
    def expires(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "expires", value)

    @property
    @pulumi.getter(name="notBefore")
    def not_before(self) -> Optional[pulumi.Input[int]]:
        """
        Not before date in seconds since 1970-01-01T00:00:00Z.
        """
        return pulumi.get(self, "not_before")

    @not_before.setter
    def not_before(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "not_before", value)


@pulumi.input_type
class SecretPropertiesArgs:
    def __init__(__self__, *,
                 attributes: Optional[pulumi.Input['SecretAttributesArgs']] = None,
                 content_type: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        Properties of the secret
        :param pulumi.Input['SecretAttributesArgs'] attributes: The attributes of the secret.
        :param pulumi.Input[str] content_type: The content type of the secret.
        :param pulumi.Input[str] value: The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        """
        if attributes is not None:
            pulumi.set(__self__, "attributes", attributes)
        if content_type is not None:
            pulumi.set(__self__, "content_type", content_type)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def attributes(self) -> Optional[pulumi.Input['SecretAttributesArgs']]:
        """
        The attributes of the secret.
        """
        return pulumi.get(self, "attributes")

    @attributes.setter
    def attributes(self, value: Optional[pulumi.Input['SecretAttributesArgs']]):
        pulumi.set(self, "attributes", value)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> Optional[pulumi.Input[str]]:
        """
        The content type of the secret.
        """
        return pulumi.get(self, "content_type")

    @content_type.setter
    def content_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "content_type", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 family: pulumi.Input[str],
                 name: pulumi.Input[str]):
        """
        SKU details
        :param pulumi.Input[str] family: SKU family name
        :param pulumi.Input[str] name: SKU name to specify whether the key vault is a standard vault or a premium vault.
        """
        pulumi.set(__self__, "family", family)
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def family(self) -> pulumi.Input[str]:
        """
        SKU family name
        """
        return pulumi.get(self, "family")

    @family.setter
    def family(self, value: pulumi.Input[str]):
        pulumi.set(self, "family", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        SKU name to specify whether the key vault is a standard vault or a premium vault.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class VaultPropertiesArgs:
    def __init__(__self__, *,
                 sku: pulumi.Input['SkuArgs'],
                 tenant_id: pulumi.Input[str],
                 access_policies: Optional[pulumi.Input[Sequence[pulumi.Input['AccessPolicyEntryArgs']]]] = None,
                 create_mode: Optional[pulumi.Input[str]] = None,
                 enable_purge_protection: Optional[pulumi.Input[bool]] = None,
                 enable_soft_delete: Optional[pulumi.Input[bool]] = None,
                 enabled_for_deployment: Optional[pulumi.Input[bool]] = None,
                 enabled_for_disk_encryption: Optional[pulumi.Input[bool]] = None,
                 enabled_for_template_deployment: Optional[pulumi.Input[bool]] = None,
                 vault_uri: Optional[pulumi.Input[str]] = None):
        """
        Properties of the vault
        :param pulumi.Input['SkuArgs'] sku: SKU details
        :param pulumi.Input[str] tenant_id: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        :param pulumi.Input[Sequence[pulumi.Input['AccessPolicyEntryArgs']]] access_policies: An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required.
        :param pulumi.Input[str] create_mode: The vault's create mode to indicate whether the vault need to be recovered or not.
        :param pulumi.Input[bool] enable_purge_protection: Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value.
        :param pulumi.Input[bool] enable_soft_delete: Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality is irreversible - that is, the property does not accept false as its value.
        :param pulumi.Input[bool] enabled_for_deployment: Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault.
        :param pulumi.Input[bool] enabled_for_disk_encryption: Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        :param pulumi.Input[bool] enabled_for_template_deployment: Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        :param pulumi.Input[str] vault_uri: The URI of the vault for performing operations on keys and secrets.
        """
        pulumi.set(__self__, "sku", sku)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if access_policies is not None:
            pulumi.set(__self__, "access_policies", access_policies)
        if create_mode is not None:
            pulumi.set(__self__, "create_mode", create_mode)
        if enable_purge_protection is not None:
            pulumi.set(__self__, "enable_purge_protection", enable_purge_protection)
        if enable_soft_delete is not None:
            pulumi.set(__self__, "enable_soft_delete", enable_soft_delete)
        if enabled_for_deployment is not None:
            pulumi.set(__self__, "enabled_for_deployment", enabled_for_deployment)
        if enabled_for_disk_encryption is not None:
            pulumi.set(__self__, "enabled_for_disk_encryption", enabled_for_disk_encryption)
        if enabled_for_template_deployment is not None:
            pulumi.set(__self__, "enabled_for_template_deployment", enabled_for_template_deployment)
        if vault_uri is not None:
            pulumi.set(__self__, "vault_uri", vault_uri)

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Input['SkuArgs']:
        """
        SKU details
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: pulumi.Input['SkuArgs']):
        pulumi.set(self, "sku", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Input[str]:
        """
        The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "tenant_id", value)

    @property
    @pulumi.getter(name="accessPolicies")
    def access_policies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AccessPolicyEntryArgs']]]]:
        """
        An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required.
        """
        return pulumi.get(self, "access_policies")

    @access_policies.setter
    def access_policies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AccessPolicyEntryArgs']]]]):
        pulumi.set(self, "access_policies", value)

    @property
    @pulumi.getter(name="createMode")
    def create_mode(self) -> Optional[pulumi.Input[str]]:
        """
        The vault's create mode to indicate whether the vault need to be recovered or not.
        """
        return pulumi.get(self, "create_mode")

    @create_mode.setter
    def create_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_mode", value)

    @property
    @pulumi.getter(name="enablePurgeProtection")
    def enable_purge_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value.
        """
        return pulumi.get(self, "enable_purge_protection")

    @enable_purge_protection.setter
    def enable_purge_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_purge_protection", value)

    @property
    @pulumi.getter(name="enableSoftDelete")
    def enable_soft_delete(self) -> Optional[pulumi.Input[bool]]:
        """
        Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality is irreversible - that is, the property does not accept false as its value.
        """
        return pulumi.get(self, "enable_soft_delete")

    @enable_soft_delete.setter
    def enable_soft_delete(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_soft_delete", value)

    @property
    @pulumi.getter(name="enabledForDeployment")
    def enabled_for_deployment(self) -> Optional[pulumi.Input[bool]]:
        """
        Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault.
        """
        return pulumi.get(self, "enabled_for_deployment")

    @enabled_for_deployment.setter
    def enabled_for_deployment(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled_for_deployment", value)

    @property
    @pulumi.getter(name="enabledForDiskEncryption")
    def enabled_for_disk_encryption(self) -> Optional[pulumi.Input[bool]]:
        """
        Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        """
        return pulumi.get(self, "enabled_for_disk_encryption")

    @enabled_for_disk_encryption.setter
    def enabled_for_disk_encryption(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled_for_disk_encryption", value)

    @property
    @pulumi.getter(name="enabledForTemplateDeployment")
    def enabled_for_template_deployment(self) -> Optional[pulumi.Input[bool]]:
        """
        Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        """
        return pulumi.get(self, "enabled_for_template_deployment")

    @enabled_for_template_deployment.setter
    def enabled_for_template_deployment(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled_for_template_deployment", value)

    @property
    @pulumi.getter(name="vaultUri")
    def vault_uri(self) -> Optional[pulumi.Input[str]]:
        """
        The URI of the vault for performing operations on keys and secrets.
        """
        return pulumi.get(self, "vault_uri")

    @vault_uri.setter
    def vault_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vault_uri", value)


