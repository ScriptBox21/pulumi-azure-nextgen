# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetDomainOwnershipIdentifierResult',
    'AwaitableGetDomainOwnershipIdentifierResult',
    'get_domain_ownership_identifier',
]

@pulumi.output_type
class GetDomainOwnershipIdentifierResult:
    """
    Domain ownership Identifier.
    """
    def __init__(__self__, kind=None, name=None, ownership_id=None, type=None):
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if ownership_id and not isinstance(ownership_id, str):
            raise TypeError("Expected argument 'ownership_id' to be a str")
        pulumi.set(__self__, "ownership_id", ownership_id)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownershipId")
    def ownership_id(self) -> Optional[str]:
        """
        Ownership Id.
        """
        return pulumi.get(self, "ownership_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetDomainOwnershipIdentifierResult(GetDomainOwnershipIdentifierResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDomainOwnershipIdentifierResult(
            kind=self.kind,
            name=self.name,
            ownership_id=self.ownership_id,
            type=self.type)


def get_domain_ownership_identifier(domain_name: Optional[str] = None,
                                    name: Optional[str] = None,
                                    resource_group_name: Optional[str] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDomainOwnershipIdentifierResult:
    """
    Use this data source to access information about an existing resource.

    :param str domain_name: Name of domain.
    :param str name: Name of identifier.
    :param str resource_group_name: Name of the resource group to which the resource belongs.
    """
    __args__ = dict()
    __args__['domainName'] = domain_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:domainregistration/v20190801:getDomainOwnershipIdentifier', __args__, opts=opts, typ=GetDomainOwnershipIdentifierResult).value

    return AwaitableGetDomainOwnershipIdentifierResult(
        kind=__ret__.kind,
        name=__ret__.name,
        ownership_id=__ret__.ownership_id,
        type=__ret__.type)