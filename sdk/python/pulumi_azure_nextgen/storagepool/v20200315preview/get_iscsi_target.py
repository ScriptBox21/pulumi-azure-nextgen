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
    'GetIscsiTargetResult',
    'AwaitableGetIscsiTargetResult',
    'get_iscsi_target',
]

@pulumi.output_type
class GetIscsiTargetResult:
    """
    Response for iSCSI target requests.
    """
    def __init__(__self__, id=None, name=None, provisioning_state=None, status=None, target_iqn=None, tpgs=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if target_iqn and not isinstance(target_iqn, str):
            raise TypeError("Expected argument 'target_iqn' to be a str")
        pulumi.set(__self__, "target_iqn", target_iqn)
        if tpgs and not isinstance(tpgs, list):
            raise TypeError("Expected argument 'tpgs' to be a list")
        pulumi.set(__self__, "tpgs", tpgs)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        State of the operation on the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Operational status of the iSCSI target.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="targetIqn")
    def target_iqn(self) -> str:
        """
        iSCSI target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        """
        return pulumi.get(self, "target_iqn")

    @property
    @pulumi.getter
    def tpgs(self) -> Sequence['outputs.TargetPortalGroupResponse']:
        """
        List of iSCSI target portal groups. Can have 1 portal group at most.
        """
        return pulumi.get(self, "tpgs")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        """
        return pulumi.get(self, "type")


class AwaitableGetIscsiTargetResult(GetIscsiTargetResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIscsiTargetResult(
            id=self.id,
            name=self.name,
            provisioning_state=self.provisioning_state,
            status=self.status,
            target_iqn=self.target_iqn,
            tpgs=self.tpgs,
            type=self.type)


def get_iscsi_target(disk_pool_name: Optional[str] = None,
                     iscsi_target_name: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIscsiTargetResult:
    """
    Use this data source to access information about an existing resource.

    :param str disk_pool_name: The name of the Disk pool.
    :param str iscsi_target_name: The name of the iSCSI target.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['diskPoolName'] = disk_pool_name
    __args__['iscsiTargetName'] = iscsi_target_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:storagepool/v20200315preview:getIscsiTarget', __args__, opts=opts, typ=GetIscsiTargetResult).value

    return AwaitableGetIscsiTargetResult(
        id=__ret__.id,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        status=__ret__.status,
        target_iqn=__ret__.target_iqn,
        tpgs=__ret__.tpgs,
        type=__ret__.type)
