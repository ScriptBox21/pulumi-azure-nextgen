# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetDatabaseResult',
    'AwaitableGetDatabaseResult',
    'get_database',
]

@pulumi.output_type
class GetDatabaseResult:
    """
    Represents a Database.
    """
    def __init__(__self__, charset=None, collation=None, name=None, type=None):
        if charset and not isinstance(charset, str):
            raise TypeError("Expected argument 'charset' to be a str")
        pulumi.set(__self__, "charset", charset)
        if collation and not isinstance(collation, str):
            raise TypeError("Expected argument 'collation' to be a str")
        pulumi.set(__self__, "collation", collation)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def charset(self) -> Optional[str]:
        """
        The charset of the database.
        """
        return pulumi.get(self, "charset")

    @property
    @pulumi.getter
    def collation(self) -> Optional[str]:
        """
        The collation of the database.
        """
        return pulumi.get(self, "collation")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetDatabaseResult(GetDatabaseResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDatabaseResult(
            charset=self.charset,
            collation=self.collation,
            name=self.name,
            type=self.type)


def get_database(database_name: Optional[str] = None,
                 resource_group_name: Optional[str] = None,
                 server_name: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDatabaseResult:
    """
    Use this data source to access information about an existing resource.

    :param str database_name: The name of the database.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str server_name: The name of the server.
    """
    __args__ = dict()
    __args__['databaseName'] = database_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['serverName'] = server_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:dbformysql/v20200701privatepreview:getDatabase', __args__, opts=opts, typ=GetDatabaseResult).value

    return AwaitableGetDatabaseResult(
        charset=__ret__.charset,
        collation=__ret__.collation,
        name=__ret__.name,
        type=__ret__.type)
