# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetWorkspaceAadAdminResult',
    'AwaitableGetWorkspaceAadAdminResult',
    'get_workspace_aad_admin',
]

@pulumi.output_type
class GetWorkspaceAadAdminResult:
    """
    Workspace active directory administrator
    """
    def __init__(__self__, administrator_type=None, login=None, name=None, sid=None, tenant_id=None, type=None):
        if administrator_type and not isinstance(administrator_type, str):
            raise TypeError("Expected argument 'administrator_type' to be a str")
        pulumi.set(__self__, "administrator_type", administrator_type)
        if login and not isinstance(login, str):
            raise TypeError("Expected argument 'login' to be a str")
        pulumi.set(__self__, "login", login)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if sid and not isinstance(sid, str):
            raise TypeError("Expected argument 'sid' to be a str")
        pulumi.set(__self__, "sid", sid)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="administratorType")
    def administrator_type(self) -> Optional[str]:
        """
        Workspace active directory administrator type
        """
        return pulumi.get(self, "administrator_type")

    @property
    @pulumi.getter
    def login(self) -> Optional[str]:
        """
        Login of the workspace active directory administrator
        """
        return pulumi.get(self, "login")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def sid(self) -> Optional[str]:
        """
        Object ID of the workspace active directory administrator
        """
        return pulumi.get(self, "sid")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[str]:
        """
        Tenant ID of the workspace active directory administrator
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetWorkspaceAadAdminResult(GetWorkspaceAadAdminResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWorkspaceAadAdminResult(
            administrator_type=self.administrator_type,
            login=self.login,
            name=self.name,
            sid=self.sid,
            tenant_id=self.tenant_id,
            type=self.type)


def get_workspace_aad_admin(resource_group_name: Optional[str] = None,
                            workspace_name: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWorkspaceAadAdminResult:
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
    __ret__ = pulumi.runtime.invoke('azure-nextgen:synapse/v20190601preview:getWorkspaceAadAdmin', __args__, opts=opts, typ=GetWorkspaceAadAdminResult).value

    return AwaitableGetWorkspaceAadAdminResult(
        administrator_type=__ret__.administrator_type,
        login=__ret__.login,
        name=__ret__.name,
        sid=__ret__.sid,
        tenant_id=__ret__.tenant_id,
        type=__ret__.type)
