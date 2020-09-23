# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetRegistryCredentialsResult',
    'AwaitableGetRegistryCredentialsResult',
    'get_registry_credentials',
]

@pulumi.output_type
class GetRegistryCredentialsResult:
    """
    The result of a request to get the administrator login credentials for a container registry.
    """
    def __init__(__self__, password=None, username=None):
        if password and not isinstance(password, str):
            raise TypeError("Expected argument 'password' to be a str")
        pulumi.set(__self__, "password", password)
        if username and not isinstance(username, str):
            raise TypeError("Expected argument 'username' to be a str")
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional[str]:
        """
        The administrator password.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> Optional[str]:
        """
        The administrator username.
        """
        return pulumi.get(self, "username")


class AwaitableGetRegistryCredentialsResult(GetRegistryCredentialsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRegistryCredentialsResult(
            password=self.password,
            username=self.username)


def get_registry_credentials(registry_name: Optional[str] = None,
                             resource_group_name: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRegistryCredentialsResult:
    """
    Use this data source to access information about an existing resource.

    :param str registry_name: The name of the container registry.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    """
    __args__ = dict()
    __args__['registryName'] = registry_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:containerregistry/v20160627preview:getRegistryCredentials', __args__, opts=opts, typ=GetRegistryCredentialsResult).value

    return AwaitableGetRegistryCredentialsResult(
        password=__ret__.password,
        username=__ret__.username)
