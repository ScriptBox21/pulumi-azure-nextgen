# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetProfileSupportedOptimizationTypesResult',
    'AwaitableGetProfileSupportedOptimizationTypesResult',
    'get_profile_supported_optimization_types',
]

@pulumi.output_type
class GetProfileSupportedOptimizationTypesResult:
    """
    The result of the GetSupportedOptimizationTypes API
    """
    def __init__(__self__, supported_optimization_types=None):
        if supported_optimization_types and not isinstance(supported_optimization_types, list):
            raise TypeError("Expected argument 'supported_optimization_types' to be a list")
        pulumi.set(__self__, "supported_optimization_types", supported_optimization_types)

    @property
    @pulumi.getter(name="supportedOptimizationTypes")
    def supported_optimization_types(self) -> Sequence[str]:
        """
        Supported optimization types for a profile.
        """
        return pulumi.get(self, "supported_optimization_types")


class AwaitableGetProfileSupportedOptimizationTypesResult(GetProfileSupportedOptimizationTypesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProfileSupportedOptimizationTypesResult(
            supported_optimization_types=self.supported_optimization_types)


def get_profile_supported_optimization_types(profile_name: Optional[str] = None,
                                             resource_group_name: Optional[str] = None,
                                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProfileSupportedOptimizationTypesResult:
    """
    Use this data source to access information about an existing resource.

    :param str profile_name: Name of the CDN profile which is unique within the resource group.
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    """
    __args__ = dict()
    __args__['profileName'] = profile_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:cdn/v20200901:getProfileSupportedOptimizationTypes', __args__, opts=opts, typ=GetProfileSupportedOptimizationTypesResult).value

    return AwaitableGetProfileSupportedOptimizationTypesResult(
        supported_optimization_types=__ret__.supported_optimization_types)
