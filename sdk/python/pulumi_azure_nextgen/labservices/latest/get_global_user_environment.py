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
    'GetGlobalUserEnvironmentResult',
    'AwaitableGetGlobalUserEnvironmentResult',
    'get_global_user_environment',
]

@pulumi.output_type
class GetGlobalUserEnvironmentResult:
    """
    Represents the environments details
    """
    def __init__(__self__, environment=None):
        if environment and not isinstance(environment, dict):
            raise TypeError("Expected argument 'environment' to be a dict")
        pulumi.set(__self__, "environment", environment)

    @property
    @pulumi.getter
    def environment(self) -> 'outputs.EnvironmentDetailsResponseResult':
        """
        Details of the environment
        """
        return pulumi.get(self, "environment")


class AwaitableGetGlobalUserEnvironmentResult(GetGlobalUserEnvironmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGlobalUserEnvironmentResult(
            environment=self.environment)


def get_global_user_environment(environment_id: Optional[str] = None,
                                expand: Optional[str] = None,
                                user_name: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGlobalUserEnvironmentResult:
    """
    Use this data source to access information about an existing resource.

    :param str environment_id: The resourceId of the environment
    :param str expand: Specify the $expand query. Example: 'properties($expand=environment)'
    :param str user_name: The name of the user.
    """
    __args__ = dict()
    __args__['environmentId'] = environment_id
    __args__['expand'] = expand
    __args__['userName'] = user_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:labservices/latest:getGlobalUserEnvironment', __args__, opts=opts, typ=GetGlobalUserEnvironmentResult).value

    return AwaitableGetGlobalUserEnvironmentResult(
        environment=__ret__.environment)
