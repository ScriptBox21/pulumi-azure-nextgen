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
    'GetServiceUnitResult',
    'AwaitableGetServiceUnitResult',
    'get_service_unit',
]

@pulumi.output_type
class GetServiceUnitResult:
    """
    Represents the response of a service unit resource.
    """
    def __init__(__self__, artifacts=None, deployment_mode=None, location=None, name=None, tags=None, target_resource_group=None, type=None):
        if artifacts and not isinstance(artifacts, dict):
            raise TypeError("Expected argument 'artifacts' to be a dict")
        pulumi.set(__self__, "artifacts", artifacts)
        if deployment_mode and not isinstance(deployment_mode, str):
            raise TypeError("Expected argument 'deployment_mode' to be a str")
        pulumi.set(__self__, "deployment_mode", deployment_mode)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if target_resource_group and not isinstance(target_resource_group, str):
            raise TypeError("Expected argument 'target_resource_group' to be a str")
        pulumi.set(__self__, "target_resource_group", target_resource_group)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def artifacts(self) -> Optional['outputs.ServiceUnitArtifactsResponse']:
        """
        The artifacts for the service unit.
        """
        return pulumi.get(self, "artifacts")

    @property
    @pulumi.getter(name="deploymentMode")
    def deployment_mode(self) -> str:
        """
        Describes the type of ARM deployment to be performed on the resource.
        """
        return pulumi.get(self, "deployment_mode")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="targetResourceGroup")
    def target_resource_group(self) -> str:
        """
        The Azure Resource Group to which the resources in the service unit belong to or should be deployed to.
        """
        return pulumi.get(self, "target_resource_group")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetServiceUnitResult(GetServiceUnitResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceUnitResult(
            artifacts=self.artifacts,
            deployment_mode=self.deployment_mode,
            location=self.location,
            name=self.name,
            tags=self.tags,
            target_resource_group=self.target_resource_group,
            type=self.type)


def get_service_unit(resource_group_name: Optional[str] = None,
                     service_name: Optional[str] = None,
                     service_topology_name: Optional[str] = None,
                     service_unit_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetServiceUnitResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str service_name: The name of the service resource.
    :param str service_topology_name: The name of the service topology .
    :param str service_unit_name: The name of the service unit resource.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    __args__['serviceTopologyName'] = service_topology_name
    __args__['serviceUnitName'] = service_unit_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:deploymentmanager/v20191101preview:getServiceUnit', __args__, opts=opts, typ=GetServiceUnitResult).value

    return AwaitableGetServiceUnitResult(
        artifacts=__ret__.artifacts,
        deployment_mode=__ret__.deployment_mode,
        location=__ret__.location,
        name=__ret__.name,
        tags=__ret__.tags,
        target_resource_group=__ret__.target_resource_group,
        type=__ret__.type)
