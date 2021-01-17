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
    'GetWorkspaceResult',
    'AwaitableGetWorkspaceResult',
    'get_workspace',
]

@pulumi.output_type
class GetWorkspaceResult:
    """
    A workspace
    """
    def __init__(__self__, adla_resource_id=None, connectivity_endpoints=None, default_data_lake_storage=None, encryption=None, extra_properties=None, id=None, identity=None, location=None, managed_resource_group_name=None, managed_virtual_network=None, managed_virtual_network_settings=None, name=None, private_endpoint_connections=None, provisioning_state=None, purview_configuration=None, sql_administrator_login=None, sql_administrator_login_password=None, tags=None, type=None, virtual_network_profile=None, workspace_repository_configuration=None, workspace_uid=None):
        if adla_resource_id and not isinstance(adla_resource_id, str):
            raise TypeError("Expected argument 'adla_resource_id' to be a str")
        pulumi.set(__self__, "adla_resource_id", adla_resource_id)
        if connectivity_endpoints and not isinstance(connectivity_endpoints, dict):
            raise TypeError("Expected argument 'connectivity_endpoints' to be a dict")
        pulumi.set(__self__, "connectivity_endpoints", connectivity_endpoints)
        if default_data_lake_storage and not isinstance(default_data_lake_storage, dict):
            raise TypeError("Expected argument 'default_data_lake_storage' to be a dict")
        pulumi.set(__self__, "default_data_lake_storage", default_data_lake_storage)
        if encryption and not isinstance(encryption, dict):
            raise TypeError("Expected argument 'encryption' to be a dict")
        pulumi.set(__self__, "encryption", encryption)
        if extra_properties and not isinstance(extra_properties, dict):
            raise TypeError("Expected argument 'extra_properties' to be a dict")
        pulumi.set(__self__, "extra_properties", extra_properties)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if managed_resource_group_name and not isinstance(managed_resource_group_name, str):
            raise TypeError("Expected argument 'managed_resource_group_name' to be a str")
        pulumi.set(__self__, "managed_resource_group_name", managed_resource_group_name)
        if managed_virtual_network and not isinstance(managed_virtual_network, str):
            raise TypeError("Expected argument 'managed_virtual_network' to be a str")
        pulumi.set(__self__, "managed_virtual_network", managed_virtual_network)
        if managed_virtual_network_settings and not isinstance(managed_virtual_network_settings, dict):
            raise TypeError("Expected argument 'managed_virtual_network_settings' to be a dict")
        pulumi.set(__self__, "managed_virtual_network_settings", managed_virtual_network_settings)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if private_endpoint_connections and not isinstance(private_endpoint_connections, list):
            raise TypeError("Expected argument 'private_endpoint_connections' to be a list")
        pulumi.set(__self__, "private_endpoint_connections", private_endpoint_connections)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if purview_configuration and not isinstance(purview_configuration, dict):
            raise TypeError("Expected argument 'purview_configuration' to be a dict")
        pulumi.set(__self__, "purview_configuration", purview_configuration)
        if sql_administrator_login and not isinstance(sql_administrator_login, str):
            raise TypeError("Expected argument 'sql_administrator_login' to be a str")
        pulumi.set(__self__, "sql_administrator_login", sql_administrator_login)
        if sql_administrator_login_password and not isinstance(sql_administrator_login_password, str):
            raise TypeError("Expected argument 'sql_administrator_login_password' to be a str")
        pulumi.set(__self__, "sql_administrator_login_password", sql_administrator_login_password)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_network_profile and not isinstance(virtual_network_profile, dict):
            raise TypeError("Expected argument 'virtual_network_profile' to be a dict")
        pulumi.set(__self__, "virtual_network_profile", virtual_network_profile)
        if workspace_repository_configuration and not isinstance(workspace_repository_configuration, dict):
            raise TypeError("Expected argument 'workspace_repository_configuration' to be a dict")
        pulumi.set(__self__, "workspace_repository_configuration", workspace_repository_configuration)
        if workspace_uid and not isinstance(workspace_uid, str):
            raise TypeError("Expected argument 'workspace_uid' to be a str")
        pulumi.set(__self__, "workspace_uid", workspace_uid)

    @property
    @pulumi.getter(name="adlaResourceId")
    def adla_resource_id(self) -> str:
        """
        The ADLA resource ID.
        """
        return pulumi.get(self, "adla_resource_id")

    @property
    @pulumi.getter(name="connectivityEndpoints")
    def connectivity_endpoints(self) -> Optional[Mapping[str, str]]:
        """
        Connectivity endpoints
        """
        return pulumi.get(self, "connectivity_endpoints")

    @property
    @pulumi.getter(name="defaultDataLakeStorage")
    def default_data_lake_storage(self) -> Optional['outputs.DataLakeStorageAccountDetailsResponse']:
        """
        Workspace default data lake storage account details
        """
        return pulumi.get(self, "default_data_lake_storage")

    @property
    @pulumi.getter
    def encryption(self) -> Optional['outputs.EncryptionDetailsResponse']:
        """
        The encryption details of the workspace
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="extraProperties")
    def extra_properties(self) -> Mapping[str, Any]:
        """
        Workspace level configs and feature flags
        """
        return pulumi.get(self, "extra_properties")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def identity(self) -> Optional['outputs.ManagedIdentityResponse']:
        """
        Identity of the workspace
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedResourceGroupName")
    def managed_resource_group_name(self) -> Optional[str]:
        """
        Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
        """
        return pulumi.get(self, "managed_resource_group_name")

    @property
    @pulumi.getter(name="managedVirtualNetwork")
    def managed_virtual_network(self) -> Optional[str]:
        """
        Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
        """
        return pulumi.get(self, "managed_virtual_network")

    @property
    @pulumi.getter(name="managedVirtualNetworkSettings")
    def managed_virtual_network_settings(self) -> Optional['outputs.ManagedVirtualNetworkSettingsResponse']:
        """
        Managed Virtual Network Settings
        """
        return pulumi.get(self, "managed_virtual_network_settings")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> Optional[Sequence['outputs.PrivateEndpointConnectionResponse']]:
        """
        Private endpoint connections to the workspace
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Resource provisioning state
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="purviewConfiguration")
    def purview_configuration(self) -> Optional['outputs.PurviewConfigurationResponse']:
        """
        Purview Configuration
        """
        return pulumi.get(self, "purview_configuration")

    @property
    @pulumi.getter(name="sqlAdministratorLogin")
    def sql_administrator_login(self) -> Optional[str]:
        """
        Login for workspace SQL active directory administrator
        """
        return pulumi.get(self, "sql_administrator_login")

    @property
    @pulumi.getter(name="sqlAdministratorLoginPassword")
    def sql_administrator_login_password(self) -> Optional[str]:
        """
        SQL administrator login password
        """
        return pulumi.get(self, "sql_administrator_login_password")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkProfile")
    def virtual_network_profile(self) -> Optional['outputs.VirtualNetworkProfileResponse']:
        """
        Virtual Network profile
        """
        return pulumi.get(self, "virtual_network_profile")

    @property
    @pulumi.getter(name="workspaceRepositoryConfiguration")
    def workspace_repository_configuration(self) -> Optional['outputs.WorkspaceRepositoryConfigurationResponse']:
        """
        Git integration settings
        """
        return pulumi.get(self, "workspace_repository_configuration")

    @property
    @pulumi.getter(name="workspaceUID")
    def workspace_uid(self) -> str:
        """
        The workspace unique identifier
        """
        return pulumi.get(self, "workspace_uid")


class AwaitableGetWorkspaceResult(GetWorkspaceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWorkspaceResult(
            adla_resource_id=self.adla_resource_id,
            connectivity_endpoints=self.connectivity_endpoints,
            default_data_lake_storage=self.default_data_lake_storage,
            encryption=self.encryption,
            extra_properties=self.extra_properties,
            id=self.id,
            identity=self.identity,
            location=self.location,
            managed_resource_group_name=self.managed_resource_group_name,
            managed_virtual_network=self.managed_virtual_network,
            managed_virtual_network_settings=self.managed_virtual_network_settings,
            name=self.name,
            private_endpoint_connections=self.private_endpoint_connections,
            provisioning_state=self.provisioning_state,
            purview_configuration=self.purview_configuration,
            sql_administrator_login=self.sql_administrator_login,
            sql_administrator_login_password=self.sql_administrator_login_password,
            tags=self.tags,
            type=self.type,
            virtual_network_profile=self.virtual_network_profile,
            workspace_repository_configuration=self.workspace_repository_configuration,
            workspace_uid=self.workspace_uid)


def get_workspace(resource_group_name: Optional[str] = None,
                  workspace_name: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWorkspaceResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str workspace_name: The name of the workspace
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['workspaceName'] = workspace_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:synapse/v20190601preview:getWorkspace', __args__, opts=opts, typ=GetWorkspaceResult).value

    return AwaitableGetWorkspaceResult(
        adla_resource_id=__ret__.adla_resource_id,
        connectivity_endpoints=__ret__.connectivity_endpoints,
        default_data_lake_storage=__ret__.default_data_lake_storage,
        encryption=__ret__.encryption,
        extra_properties=__ret__.extra_properties,
        id=__ret__.id,
        identity=__ret__.identity,
        location=__ret__.location,
        managed_resource_group_name=__ret__.managed_resource_group_name,
        managed_virtual_network=__ret__.managed_virtual_network,
        managed_virtual_network_settings=__ret__.managed_virtual_network_settings,
        name=__ret__.name,
        private_endpoint_connections=__ret__.private_endpoint_connections,
        provisioning_state=__ret__.provisioning_state,
        purview_configuration=__ret__.purview_configuration,
        sql_administrator_login=__ret__.sql_administrator_login,
        sql_administrator_login_password=__ret__.sql_administrator_login_password,
        tags=__ret__.tags,
        type=__ret__.type,
        virtual_network_profile=__ret__.virtual_network_profile,
        workspace_repository_configuration=__ret__.workspace_repository_configuration,
        workspace_uid=__ret__.workspace_uid)
