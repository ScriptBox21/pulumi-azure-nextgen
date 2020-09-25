# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetImageUploadUrlForDataResult',
    'AwaitableGetImageUploadUrlForDataResult',
    'get_image_upload_url_for_data',
]

@pulumi.output_type
class GetImageUploadUrlForDataResult:
    """
    The image definition.
    """
    def __init__(__self__, content_url=None, image_exists=None, relative_path=None):
        if content_url and not isinstance(content_url, str):
            raise TypeError("Expected argument 'content_url' to be a str")
        pulumi.set(__self__, "content_url", content_url)
        if image_exists and not isinstance(image_exists, bool):
            raise TypeError("Expected argument 'image_exists' to be a bool")
        pulumi.set(__self__, "image_exists", image_exists)
        if relative_path and not isinstance(relative_path, str):
            raise TypeError("Expected argument 'relative_path' to be a str")
        pulumi.set(__self__, "relative_path", relative_path)

    @property
    @pulumi.getter(name="contentUrl")
    def content_url(self) -> Optional[str]:
        """
        Content URL for the image blob.
        """
        return pulumi.get(self, "content_url")

    @property
    @pulumi.getter(name="imageExists")
    def image_exists(self) -> Optional[bool]:
        """
        Whether image exists already.
        """
        return pulumi.get(self, "image_exists")

    @property
    @pulumi.getter(name="relativePath")
    def relative_path(self) -> Optional[str]:
        """
        Relative path of the image.
        """
        return pulumi.get(self, "relative_path")


class AwaitableGetImageUploadUrlForDataResult(GetImageUploadUrlForDataResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetImageUploadUrlForDataResult(
            content_url=self.content_url,
            image_exists=self.image_exists,
            relative_path=self.relative_path)


def get_image_upload_url_for_data(entity_type: Optional[str] = None,
                                  entity_type_name: Optional[str] = None,
                                  hub_name: Optional[str] = None,
                                  relative_path: Optional[str] = None,
                                  resource_group_name: Optional[str] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetImageUploadUrlForDataResult:
    """
    Use this data source to access information about an existing resource.

    :param str entity_type: Type of entity. Can be Profile or Interaction.
    :param str entity_type_name: Name of the entity type.
    :param str hub_name: The name of the hub.
    :param str relative_path: Relative path of the image.
    :param str resource_group_name: The name of the resource group.
    """
    __args__ = dict()
    __args__['entityType'] = entity_type
    __args__['entityTypeName'] = entity_type_name
    __args__['hubName'] = hub_name
    __args__['relativePath'] = relative_path
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:customerinsights/latest:getImageUploadUrlForData', __args__, opts=opts, typ=GetImageUploadUrlForDataResult).value

    return AwaitableGetImageUploadUrlForDataResult(
        content_url=__ret__.content_url,
        image_exists=__ret__.image_exists,
        relative_path=__ret__.relative_path)