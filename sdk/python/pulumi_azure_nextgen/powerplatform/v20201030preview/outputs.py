# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'EnterprisePolicyIdentityResponse',
    'KeyVaultPropertiesResponse',
    'PrivateEndpointResponse',
    'PrivateLinkServiceConnectionStateResponse',
    'PropertiesResponseEncryption',
    'PropertiesResponseLockbox',
    'KeyPropertiesResponse',
    'SystemDataResponse',
]

@pulumi.output_type
class EnterprisePolicyIdentityResponse(dict):
    """
    The identity of the EnterprisePolicy.
    """
    def __init__(__self__, *,
                 system_assigned_identity_principal_id: str,
                 tenant_id: str,
                 type: Optional[str] = None):
        """
        The identity of the EnterprisePolicy.
        :param str system_assigned_identity_principal_id: The principal id of EnterprisePolicy identity.
        :param str tenant_id: The tenant id associated with the EnterprisePolicy.
        :param str type: The type of identity used for the EnterprisePolicy. Currently, the only supported type is 'SystemAssigned', which implicitly creates an identity.
        """
        pulumi.set(__self__, "system_assigned_identity_principal_id", system_assigned_identity_principal_id)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="systemAssignedIdentityPrincipalId")
    def system_assigned_identity_principal_id(self) -> str:
        """
        The principal id of EnterprisePolicy identity.
        """
        return pulumi.get(self, "system_assigned_identity_principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The tenant id associated with the EnterprisePolicy.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The type of identity used for the EnterprisePolicy. Currently, the only supported type is 'SystemAssigned', which implicitly creates an identity.
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KeyVaultPropertiesResponse(dict):
    """
    Settings concerning key vault encryption for a configuration store.
    """
    def __init__(__self__, *,
                 status: str,
                 id: Optional[str] = None,
                 key: Optional['outputs.KeyPropertiesResponse'] = None):
        """
        Settings concerning key vault encryption for a configuration store.
        :param str status: The state of onboarding, which only appears in the response.
        :param str id: Uri of KeyVault
        :param 'KeyPropertiesResponseArgs' key: Identity of the secret that includes name and version.
        """
        pulumi.set(__self__, "status", status)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if key is not None:
            pulumi.set(__self__, "key", key)

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The state of onboarding, which only appears in the response.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Uri of KeyVault
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def key(self) -> Optional['outputs.KeyPropertiesResponse']:
        """
        Identity of the secret that includes name and version.
        """
        return pulumi.get(self, "key")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateEndpointResponse(dict):
    """
    The Private Endpoint resource.
    """
    def __init__(__self__, *,
                 id: str):
        """
        The Private Endpoint resource.
        :param str id: The ARM identifier for Private Endpoint
        """
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ARM identifier for Private Endpoint
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateLinkServiceConnectionStateResponse(dict):
    """
    A collection of information about the state of the connection between service consumer and provider.
    """
    def __init__(__self__, *,
                 actions_required: Optional[str] = None,
                 description: Optional[str] = None,
                 status: Optional[str] = None):
        """
        A collection of information about the state of the connection between service consumer and provider.
        :param str actions_required: A message indicating if changes on the service provider require any updates on the consumer.
        :param str description: The reason for approval/rejection of the connection.
        :param str status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        """
        if actions_required is not None:
            pulumi.set(__self__, "actions_required", actions_required)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="actionsRequired")
    def actions_required(self) -> Optional[str]:
        """
        A message indicating if changes on the service provider require any updates on the consumer.
        """
        return pulumi.get(self, "actions_required")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The reason for approval/rejection of the connection.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PropertiesResponseEncryption(dict):
    """
    The encryption settings for a configuration store.
    """
    def __init__(__self__, *,
                 key_vault_properties: Optional['outputs.KeyVaultPropertiesResponse'] = None):
        """
        The encryption settings for a configuration store.
        :param 'KeyVaultPropertiesResponseArgs' key_vault_properties: Key vault properties.
        """
        if key_vault_properties is not None:
            pulumi.set(__self__, "key_vault_properties", key_vault_properties)

    @property
    @pulumi.getter(name="keyVaultProperties")
    def key_vault_properties(self) -> Optional['outputs.KeyVaultPropertiesResponse']:
        """
        Key vault properties.
        """
        return pulumi.get(self, "key_vault_properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PropertiesResponseLockbox(dict):
    """
    Settings concerning lockbox.
    """
    def __init__(__self__, *,
                 status: str):
        """
        Settings concerning lockbox.
        :param str status: lockbox configuration
        """
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        lockbox configuration
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KeyPropertiesResponse(dict):
    """
    Url and version of the KeyVault Secret
    """
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 version: Optional[str] = None):
        """
        Url and version of the KeyVault Secret
        :param str name: The identifier of the key vault key used to encrypt data.
        :param str version: The version of the identity which will be used to access key vault.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The identifier of the key vault key used to encrypt data.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        The version of the identity which will be used to access key vault.
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SystemDataResponse(dict):
    """
    Metadata pertaining to creation and last modification of the resource.
    """
    def __init__(__self__, *,
                 created_at: Optional[str] = None,
                 created_by: Optional[str] = None,
                 created_by_type: Optional[str] = None,
                 last_modified_at: Optional[str] = None,
                 last_modified_by: Optional[str] = None,
                 last_modified_by_type: Optional[str] = None):
        """
        Metadata pertaining to creation and last modification of the resource.
        :param str created_at: The timestamp of resource creation (UTC).
        :param str created_by: The identity that created the resource.
        :param str created_by_type: The type of identity that created the resource.
        :param str last_modified_at: The type of identity that last modified the resource.
        :param str last_modified_by: The identity that last modified the resource.
        :param str last_modified_by_type: The type of identity that last modified the resource.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if created_by_type is not None:
            pulumi.set(__self__, "created_by_type", created_by_type)
        if last_modified_at is not None:
            pulumi.set(__self__, "last_modified_at", last_modified_at)
        if last_modified_by is not None:
            pulumi.set(__self__, "last_modified_by", last_modified_by)
        if last_modified_by_type is not None:
            pulumi.set(__self__, "last_modified_by_type", last_modified_by_type)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[str]:
        """
        The timestamp of resource creation (UTC).
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[str]:
        """
        The identity that created the resource.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdByType")
    def created_by_type(self) -> Optional[str]:
        """
        The type of identity that created the resource.
        """
        return pulumi.get(self, "created_by_type")

    @property
    @pulumi.getter(name="lastModifiedAt")
    def last_modified_at(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_at")

    @property
    @pulumi.getter(name="lastModifiedBy")
    def last_modified_by(self) -> Optional[str]:
        """
        The identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by")

    @property
    @pulumi.getter(name="lastModifiedByType")
    def last_modified_by_type(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


