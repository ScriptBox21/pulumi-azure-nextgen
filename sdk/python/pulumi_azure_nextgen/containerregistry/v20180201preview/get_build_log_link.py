# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetBuildLogLinkResult',
    'AwaitableGetBuildLogLinkResult',
    'get_build_log_link',
]

@pulumi.output_type
class GetBuildLogLinkResult:
    """
    The result of get log link operation.
    """
    def __init__(__self__, log_link=None):
        if log_link and not isinstance(log_link, str):
            raise TypeError("Expected argument 'log_link' to be a str")
        pulumi.set(__self__, "log_link", log_link)

    @property
    @pulumi.getter(name="logLink")
    def log_link(self) -> Optional[str]:
        """
        The link to logs for a azure container registry build.
        """
        return pulumi.get(self, "log_link")


class AwaitableGetBuildLogLinkResult(GetBuildLogLinkResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBuildLogLinkResult(
            log_link=self.log_link)


def get_build_log_link(build_id: Optional[str] = None,
                       registry_name: Optional[str] = None,
                       resource_group_name: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetBuildLogLinkResult:
    """
    Use this data source to access information about an existing resource.

    :param str build_id: The build ID.
    :param str registry_name: The name of the container registry.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    """
    __args__ = dict()
    __args__['buildId'] = build_id
    __args__['registryName'] = registry_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:containerregistry/v20180201preview:getBuildLogLink', __args__, opts=opts, typ=GetBuildLogLinkResult).value

    return AwaitableGetBuildLogLinkResult(
        log_link=__ret__.log_link)
