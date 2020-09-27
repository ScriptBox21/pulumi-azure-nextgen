# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetDatabaseAccountSqlDatabaseResult',
    'AwaitableGetDatabaseAccountSqlDatabaseResult',
    'get_database_account_sql_database',
]

@pulumi.output_type
class GetDatabaseAccountSqlDatabaseResult:
    """
    An Azure Cosmos DB SQL database.
    """
    def __init__(__self__, colls=None, etag=None, location=None, name=None, rid=None, tags=None, type=None, users=None):
        if colls and not isinstance(colls, str):
            raise TypeError("Expected argument 'colls' to be a str")
        pulumi.set(__self__, "colls", colls)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if rid and not isinstance(rid, str):
            raise TypeError("Expected argument 'rid' to be a str")
        pulumi.set(__self__, "rid", rid)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if users and not isinstance(users, str):
            raise TypeError("Expected argument 'users' to be a str")
        pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter
    def colls(self) -> Optional[str]:
        """
        A system generated property that specified the addressable path of the collections resource.
        """
        return pulumi.get(self, "colls")

    @property
    @pulumi.getter
    def etag(self) -> Optional[str]:
        """
        A system generated property representing the resource etag required for optimistic concurrency control.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the resource group to which the resource belongs.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the database account.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def rid(self) -> Optional[str]:
        """
        A system generated property. A unique identifier.
        """
        return pulumi.get(self, "rid")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of Azure resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def users(self) -> Optional[str]:
        """
        A system generated property that specifies the addressable path of the users resource.
        """
        return pulumi.get(self, "users")


class AwaitableGetDatabaseAccountSqlDatabaseResult(GetDatabaseAccountSqlDatabaseResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDatabaseAccountSqlDatabaseResult(
            colls=self.colls,
            etag=self.etag,
            location=self.location,
            name=self.name,
            rid=self.rid,
            tags=self.tags,
            type=self.type,
            users=self.users)


def get_database_account_sql_database(account_name: Optional[str] = None,
                                      database_name: Optional[str] = None,
                                      resource_group_name: Optional[str] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDatabaseAccountSqlDatabaseResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: Cosmos DB database account name.
    :param str database_name: Cosmos DB database name.
    :param str resource_group_name: Name of an Azure resource group.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['databaseName'] = database_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:documentdb/v20150401:getDatabaseAccountSqlDatabase', __args__, opts=opts, typ=GetDatabaseAccountSqlDatabaseResult).value

    return AwaitableGetDatabaseAccountSqlDatabaseResult(
        colls=__ret__.colls,
        etag=__ret__.etag,
        location=__ret__.location,
        name=__ret__.name,
        rid=__ret__.rid,
        tags=__ret__.tags,
        type=__ret__.type,
        users=__ret__.users)
