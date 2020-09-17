# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ListSiteMetadataSlotResult',
    'AwaitableListSiteMetadataSlotResult',
    'list_site_metadata_slot',
]

@pulumi.output_type
class ListSiteMetadataSlotResult:
    """
    String dictionary resource
    """
    def __init__(__self__, kind=None, location=None, name=None, tags=None, type=None):
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableListSiteMetadataSlotResult(ListSiteMetadataSlotResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListSiteMetadataSlotResult(
            kind=self.kind,
            location=self.location,
            name=self.name,
            tags=self.tags,
            type=self.type)


def list_site_metadata_slot(name: Optional[str] = None,
                            resource_group_name: Optional[str] = None,
                            slot: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListSiteMetadataSlotResult:
    """
    Use this data source to access information about an existing resource.

    :param str name: Name of web app
    :param str resource_group_name: Name of resource group
    :param str slot: Name of web app slot. If not specified then will default to production slot.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['slot'] = slot
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:web/v20150801:listSiteMetadataSlot', __args__, opts=opts, typ=ListSiteMetadataSlotResult).value

    return AwaitableListSiteMetadataSlotResult(
        kind=__ret__.kind,
        location=__ret__.location,
        name=__ret__.name,
        tags=__ret__.tags,
        type=__ret__.type)