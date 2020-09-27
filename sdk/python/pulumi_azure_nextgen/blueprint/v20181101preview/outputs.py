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
    'AssignmentLockSettingsResponse',
    'AssignmentStatusResponse',
    'BlueprintStatusResponse',
    'ManagedServiceIdentityResponse',
    'ParameterDefinitionResponse',
    'ParameterValueResponse',
    'ResourceGroupDefinitionResponse',
    'ResourceGroupValueResponse',
    'SecretValueReferenceResponse',
    'UserAssignedIdentityResponse',
    'KeyVaultReferenceResponse',
]

@pulumi.output_type
class AssignmentLockSettingsResponse(dict):
    """
    Defines how resources deployed by a blueprint assignment are locked.
    """
    def __init__(__self__, *,
                 excluded_actions: Optional[Sequence[str]] = None,
                 excluded_principals: Optional[Sequence[str]] = None,
                 mode: Optional[str] = None):
        """
        Defines how resources deployed by a blueprint assignment are locked.
        :param Sequence[str] excluded_actions: List of management operations that are excluded from blueprint locks. Up to 200 actions are permitted. If the lock mode is set to 'AllResourcesReadOnly', then the following actions are automatically appended to 'excludedActions': '*/read', 'Microsoft.Network/virtualNetworks/subnets/join/action' and 'Microsoft.Authorization/locks/delete'. If the lock mode is set to 'AllResourcesDoNotDelete', then the following actions are automatically appended to 'excludedActions': 'Microsoft.Authorization/locks/delete'. Duplicate actions will get removed.
        :param Sequence[str] excluded_principals: List of AAD principals excluded from blueprint locks. Up to 5 principals are permitted.
        :param str mode: Lock mode.
        """
        if excluded_actions is not None:
            pulumi.set(__self__, "excluded_actions", excluded_actions)
        if excluded_principals is not None:
            pulumi.set(__self__, "excluded_principals", excluded_principals)
        if mode is not None:
            pulumi.set(__self__, "mode", mode)

    @property
    @pulumi.getter(name="excludedActions")
    def excluded_actions(self) -> Optional[Sequence[str]]:
        """
        List of management operations that are excluded from blueprint locks. Up to 200 actions are permitted. If the lock mode is set to 'AllResourcesReadOnly', then the following actions are automatically appended to 'excludedActions': '*/read', 'Microsoft.Network/virtualNetworks/subnets/join/action' and 'Microsoft.Authorization/locks/delete'. If the lock mode is set to 'AllResourcesDoNotDelete', then the following actions are automatically appended to 'excludedActions': 'Microsoft.Authorization/locks/delete'. Duplicate actions will get removed.
        """
        return pulumi.get(self, "excluded_actions")

    @property
    @pulumi.getter(name="excludedPrincipals")
    def excluded_principals(self) -> Optional[Sequence[str]]:
        """
        List of AAD principals excluded from blueprint locks. Up to 5 principals are permitted.
        """
        return pulumi.get(self, "excluded_principals")

    @property
    @pulumi.getter
    def mode(self) -> Optional[str]:
        """
        Lock mode.
        """
        return pulumi.get(self, "mode")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AssignmentStatusResponse(dict):
    """
    The status of a blueprint assignment. This field is readonly.
    """
    def __init__(__self__, *,
                 last_modified: str,
                 managed_resources: Sequence[str],
                 time_created: str):
        """
        The status of a blueprint assignment. This field is readonly.
        :param str last_modified: Last modified time of this blueprint definition.
        :param Sequence[str] managed_resources: List of resources that were created by the blueprint assignment.
        :param str time_created: Creation time of this blueprint definition.
        """
        pulumi.set(__self__, "last_modified", last_modified)
        pulumi.set(__self__, "managed_resources", managed_resources)
        pulumi.set(__self__, "time_created", time_created)

    @property
    @pulumi.getter(name="lastModified")
    def last_modified(self) -> str:
        """
        Last modified time of this blueprint definition.
        """
        return pulumi.get(self, "last_modified")

    @property
    @pulumi.getter(name="managedResources")
    def managed_resources(self) -> Sequence[str]:
        """
        List of resources that were created by the blueprint assignment.
        """
        return pulumi.get(self, "managed_resources")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> str:
        """
        Creation time of this blueprint definition.
        """
        return pulumi.get(self, "time_created")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BlueprintStatusResponse(dict):
    """
    The status of the blueprint. This field is readonly.
    """
    def __init__(__self__, *,
                 last_modified: str,
                 time_created: str):
        """
        The status of the blueprint. This field is readonly.
        :param str last_modified: Last modified time of this blueprint definition.
        :param str time_created: Creation time of this blueprint definition.
        """
        pulumi.set(__self__, "last_modified", last_modified)
        pulumi.set(__self__, "time_created", time_created)

    @property
    @pulumi.getter(name="lastModified")
    def last_modified(self) -> str:
        """
        Last modified time of this blueprint definition.
        """
        return pulumi.get(self, "last_modified")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> str:
        """
        Creation time of this blueprint definition.
        """
        return pulumi.get(self, "time_created")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ManagedServiceIdentityResponse(dict):
    """
    Managed identity generic object.
    """
    def __init__(__self__, *,
                 type: str,
                 principal_id: Optional[str] = None,
                 tenant_id: Optional[str] = None,
                 user_assigned_identities: Optional[Mapping[str, 'outputs.UserAssignedIdentityResponse']] = None):
        """
        Managed identity generic object.
        :param str type: Type of the managed identity.
        :param str principal_id: Azure Active Directory principal ID associated with this Identity.
        :param str tenant_id: ID of the Azure Active Directory.
        :param Mapping[str, 'UserAssignedIdentityResponseArgs'] user_assigned_identities: The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity.
        """
        pulumi.set(__self__, "type", type)
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if user_assigned_identities is not None:
            pulumi.set(__self__, "user_assigned_identities", user_assigned_identities)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the managed identity.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[str]:
        """
        Azure Active Directory principal ID associated with this Identity.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[str]:
        """
        ID of the Azure Active Directory.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter(name="userAssignedIdentities")
    def user_assigned_identities(self) -> Optional[Mapping[str, 'outputs.UserAssignedIdentityResponse']]:
        """
        The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity.
        """
        return pulumi.get(self, "user_assigned_identities")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ParameterDefinitionResponse(dict):
    """
    Represent a parameter with constrains and metadata.
    """
    def __init__(__self__, *,
                 type: str,
                 description: Optional[str] = None,
                 display_name: Optional[str] = None,
                 strong_type: Optional[str] = None):
        """
        Represent a parameter with constrains and metadata.
        :param str type: Allowed data types for Resource Manager template parameters.
        :param str description: Description of this parameter/resourceGroup.
        :param str display_name: DisplayName of this parameter/resourceGroup.
        :param str strong_type: StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location.
        """
        pulumi.set(__self__, "type", type)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if strong_type is not None:
            pulumi.set(__self__, "strong_type", strong_type)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Allowed data types for Resource Manager template parameters.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Description of this parameter/resourceGroup.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        DisplayName of this parameter/resourceGroup.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="strongType")
    def strong_type(self) -> Optional[str]:
        """
        StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location.
        """
        return pulumi.get(self, "strong_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ParameterValueResponse(dict):
    """
    Value for the specified parameter. Can be either 'value' or 'reference' but not both.
    """
    def __init__(__self__, *,
                 reference: Optional['outputs.SecretValueReferenceResponse'] = None,
                 value: Optional[Mapping[str, Any]] = None):
        """
        Value for the specified parameter. Can be either 'value' or 'reference' but not both.
        :param 'SecretValueReferenceResponseArgs' reference: Parameter value as reference type.
        :param Mapping[str, Any] value: Parameter value. Any valid JSON value is allowed including objects, arrays, strings, numbers and booleans.
        """
        if reference is not None:
            pulumi.set(__self__, "reference", reference)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def reference(self) -> Optional['outputs.SecretValueReferenceResponse']:
        """
        Parameter value as reference type.
        """
        return pulumi.get(self, "reference")

    @property
    @pulumi.getter
    def value(self) -> Optional[Mapping[str, Any]]:
        """
        Parameter value. Any valid JSON value is allowed including objects, arrays, strings, numbers and booleans.
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ResourceGroupDefinitionResponse(dict):
    """
    Represents an Azure resource group in a blueprint definition.
    """
    def __init__(__self__, *,
                 depends_on: Optional[Sequence[str]] = None,
                 description: Optional[str] = None,
                 display_name: Optional[str] = None,
                 location: Optional[str] = None,
                 name: Optional[str] = None,
                 strong_type: Optional[str] = None,
                 tags: Optional[Mapping[str, str]] = None):
        """
        Represents an Azure resource group in a blueprint definition.
        :param Sequence[str] depends_on: Artifacts which need to be deployed before this resource group.
        :param str description: Description of this parameter/resourceGroup.
        :param str display_name: DisplayName of this parameter/resourceGroup.
        :param str location: Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment.
        :param str name: Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment.
        :param str strong_type: StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location.
        :param Mapping[str, str] tags: Tags to be assigned to this resource group.
        """
        if depends_on is not None:
            pulumi.set(__self__, "depends_on", depends_on)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if strong_type is not None:
            pulumi.set(__self__, "strong_type", strong_type)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="dependsOn")
    def depends_on(self) -> Optional[Sequence[str]]:
        """
        Artifacts which need to be deployed before this resource group.
        """
        return pulumi.get(self, "depends_on")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Description of this parameter/resourceGroup.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        DisplayName of this parameter/resourceGroup.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="strongType")
    def strong_type(self) -> Optional[str]:
        """
        StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location.
        """
        return pulumi.get(self, "strong_type")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Tags to be assigned to this resource group.
        """
        return pulumi.get(self, "tags")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ResourceGroupValueResponse(dict):
    """
    Represents an Azure resource group.
    """
    def __init__(__self__, *,
                 location: Optional[str] = None,
                 name: Optional[str] = None):
        """
        Represents an Azure resource group.
        :param str location: Location of the resource group.
        :param str name: Name of the resource group.
        """
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Location of the resource group.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the resource group.
        """
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SecretValueReferenceResponse(dict):
    """
    Reference to a Key Vault secret.
    """
    def __init__(__self__, *,
                 key_vault: 'outputs.KeyVaultReferenceResponse',
                 secret_name: str,
                 secret_version: Optional[str] = None):
        """
        Reference to a Key Vault secret.
        :param 'KeyVaultReferenceResponseArgs' key_vault: Specifies the reference to a given Azure Key Vault.
        :param str secret_name: Name of the secret.
        :param str secret_version: The version of the secret to use. If left blank, the latest version of the secret is used.
        """
        pulumi.set(__self__, "key_vault", key_vault)
        pulumi.set(__self__, "secret_name", secret_name)
        if secret_version is not None:
            pulumi.set(__self__, "secret_version", secret_version)

    @property
    @pulumi.getter(name="keyVault")
    def key_vault(self) -> 'outputs.KeyVaultReferenceResponse':
        """
        Specifies the reference to a given Azure Key Vault.
        """
        return pulumi.get(self, "key_vault")

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> str:
        """
        Name of the secret.
        """
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter(name="secretVersion")
    def secret_version(self) -> Optional[str]:
        """
        The version of the secret to use. If left blank, the latest version of the secret is used.
        """
        return pulumi.get(self, "secret_version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class UserAssignedIdentityResponse(dict):
    """
    User-assigned managed identity.
    """
    def __init__(__self__, *,
                 client_id: Optional[str] = None,
                 principal_id: Optional[str] = None):
        """
        User-assigned managed identity.
        :param str client_id: Client App Id associated with this identity.
        :param str principal_id: Azure Active Directory principal ID associated with this Identity.
        """
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[str]:
        """
        Client App Id associated with this identity.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[str]:
        """
        Azure Active Directory principal ID associated with this Identity.
        """
        return pulumi.get(self, "principal_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KeyVaultReferenceResponse(dict):
    """
    Specifies the link to a Key Vault.
    """
    def __init__(__self__, *,
                 id: str):
        """
        Specifies the link to a Key Vault.
        :param str id: Azure resource ID of the Key Vault.
        """
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Azure resource ID of the Key Vault.
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


