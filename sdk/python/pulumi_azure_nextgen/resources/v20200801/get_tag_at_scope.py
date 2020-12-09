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
    'GetTagAtScopeResult',
    'AwaitableGetTagAtScopeResult',
    'get_tag_at_scope',
]

@pulumi.output_type
class GetTagAtScopeResult:
    """
    Wrapper resource for tags API requests and responses.
    """
    def __init__(__self__, name=None, properties=None, type=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the tags wrapper resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.TagsResponse':
        """
        The set of tags.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the tags wrapper resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetTagAtScopeResult(GetTagAtScopeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetTagAtScopeResult(
            name=self.name,
            properties=self.properties,
            type=self.type)


def get_tag_at_scope(scope: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetTagAtScopeResult:
    """
    Use this data source to access information about an existing resource.

    :param str scope: The resource scope.
    """
    __args__ = dict()
    __args__['scope'] = scope
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:resources/v20200801:getTagAtScope', __args__, opts=opts, typ=GetTagAtScopeResult).value

    return AwaitableGetTagAtScopeResult(
        name=__ret__.name,
        properties=__ret__.properties,
        type=__ret__.type)
