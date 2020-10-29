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
    'GetArtifactSourceResult',
    'AwaitableGetArtifactSourceResult',
    'get_artifact_source',
]

@pulumi.output_type
class GetArtifactSourceResult:
    """
    The resource that defines the source location where the artifacts are located.
    """
    def __init__(__self__, artifact_root=None, authentication=None, location=None, name=None, source_type=None, tags=None, type=None):
        if artifact_root and not isinstance(artifact_root, str):
            raise TypeError("Expected argument 'artifact_root' to be a str")
        pulumi.set(__self__, "artifact_root", artifact_root)
        if authentication and not isinstance(authentication, dict):
            raise TypeError("Expected argument 'authentication' to be a dict")
        pulumi.set(__self__, "authentication", authentication)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if source_type and not isinstance(source_type, str):
            raise TypeError("Expected argument 'source_type' to be a str")
        pulumi.set(__self__, "source_type", source_type)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="artifactRoot")
    def artifact_root(self) -> Optional[str]:
        """
        The path from the location that the 'authentication' property [say, a SAS URI to the blob container] refers to, to the location of the artifacts. This can be used to differentiate different versions of the artifacts. Or, different types of artifacts like binaries or templates. The location referenced by the authentication property concatenated with this optional artifactRoot path forms the artifact source location where the artifacts are expected to be found.
        """
        return pulumi.get(self, "artifact_root")

    @property
    @pulumi.getter
    def authentication(self) -> 'outputs.SasAuthenticationResponse':
        """
        The authentication method to use to access the artifact source.
        """
        return pulumi.get(self, "authentication")

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
    @pulumi.getter(name="sourceType")
    def source_type(self) -> str:
        """
        The type of artifact source used.
        """
        return pulumi.get(self, "source_type")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetArtifactSourceResult(GetArtifactSourceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetArtifactSourceResult(
            artifact_root=self.artifact_root,
            authentication=self.authentication,
            location=self.location,
            name=self.name,
            source_type=self.source_type,
            tags=self.tags,
            type=self.type)


def get_artifact_source(artifact_source_name: Optional[str] = None,
                        resource_group_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetArtifactSourceResult:
    """
    Use this data source to access information about an existing resource.

    :param str artifact_source_name: The name of the artifact source.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['artifactSourceName'] = artifact_source_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:deploymentmanager/v20180901preview:getArtifactSource', __args__, opts=opts, typ=GetArtifactSourceResult).value

    return AwaitableGetArtifactSourceResult(
        artifact_root=__ret__.artifact_root,
        authentication=__ret__.authentication,
        location=__ret__.location,
        name=__ret__.name,
        source_type=__ret__.source_type,
        tags=__ret__.tags,
        type=__ret__.type)
