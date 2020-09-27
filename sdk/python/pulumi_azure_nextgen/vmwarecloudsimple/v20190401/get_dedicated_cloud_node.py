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
    'GetDedicatedCloudNodeResult',
    'AwaitableGetDedicatedCloudNodeResult',
    'get_dedicated_cloud_node',
]

@pulumi.output_type
class GetDedicatedCloudNodeResult:
    """
    Dedicated cloud node model
    """
    def __init__(__self__, availability_zone_id=None, availability_zone_name=None, cloud_rack_name=None, location=None, name=None, nodes_count=None, placement_group_id=None, placement_group_name=None, private_cloud_id=None, private_cloud_name=None, provisioning_state=None, purchase_id=None, sku=None, status=None, tags=None, type=None, vmware_cluster_name=None):
        if availability_zone_id and not isinstance(availability_zone_id, str):
            raise TypeError("Expected argument 'availability_zone_id' to be a str")
        pulumi.set(__self__, "availability_zone_id", availability_zone_id)
        if availability_zone_name and not isinstance(availability_zone_name, str):
            raise TypeError("Expected argument 'availability_zone_name' to be a str")
        pulumi.set(__self__, "availability_zone_name", availability_zone_name)
        if cloud_rack_name and not isinstance(cloud_rack_name, str):
            raise TypeError("Expected argument 'cloud_rack_name' to be a str")
        pulumi.set(__self__, "cloud_rack_name", cloud_rack_name)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if nodes_count and not isinstance(nodes_count, int):
            raise TypeError("Expected argument 'nodes_count' to be a int")
        pulumi.set(__self__, "nodes_count", nodes_count)
        if placement_group_id and not isinstance(placement_group_id, str):
            raise TypeError("Expected argument 'placement_group_id' to be a str")
        pulumi.set(__self__, "placement_group_id", placement_group_id)
        if placement_group_name and not isinstance(placement_group_name, str):
            raise TypeError("Expected argument 'placement_group_name' to be a str")
        pulumi.set(__self__, "placement_group_name", placement_group_name)
        if private_cloud_id and not isinstance(private_cloud_id, str):
            raise TypeError("Expected argument 'private_cloud_id' to be a str")
        pulumi.set(__self__, "private_cloud_id", private_cloud_id)
        if private_cloud_name and not isinstance(private_cloud_name, str):
            raise TypeError("Expected argument 'private_cloud_name' to be a str")
        pulumi.set(__self__, "private_cloud_name", private_cloud_name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if purchase_id and not isinstance(purchase_id, str):
            raise TypeError("Expected argument 'purchase_id' to be a str")
        pulumi.set(__self__, "purchase_id", purchase_id)
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        pulumi.set(__self__, "sku", sku)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vmware_cluster_name and not isinstance(vmware_cluster_name, str):
            raise TypeError("Expected argument 'vmware_cluster_name' to be a str")
        pulumi.set(__self__, "vmware_cluster_name", vmware_cluster_name)

    @property
    @pulumi.getter(name="availabilityZoneId")
    def availability_zone_id(self) -> str:
        """
        Availability Zone id, e.g. "az1"
        """
        return pulumi.get(self, "availability_zone_id")

    @property
    @pulumi.getter(name="availabilityZoneName")
    def availability_zone_name(self) -> str:
        """
        Availability Zone name, e.g. "Availability Zone 1"
        """
        return pulumi.get(self, "availability_zone_name")

    @property
    @pulumi.getter(name="cloudRackName")
    def cloud_rack_name(self) -> str:
        """
        VMWare Cloud Rack Name
        """
        return pulumi.get(self, "cloud_rack_name")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Azure region
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        SKU's name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nodesCount")
    def nodes_count(self) -> int:
        """
        count of nodes to create
        """
        return pulumi.get(self, "nodes_count")

    @property
    @pulumi.getter(name="placementGroupId")
    def placement_group_id(self) -> str:
        """
        Placement Group id, e.g. "n1"
        """
        return pulumi.get(self, "placement_group_id")

    @property
    @pulumi.getter(name="placementGroupName")
    def placement_group_name(self) -> str:
        """
        Placement Name, e.g. "Placement Group 1"
        """
        return pulumi.get(self, "placement_group_name")

    @property
    @pulumi.getter(name="privateCloudId")
    def private_cloud_id(self) -> str:
        """
        Private Cloud Id
        """
        return pulumi.get(self, "private_cloud_id")

    @property
    @pulumi.getter(name="privateCloudName")
    def private_cloud_name(self) -> str:
        """
        Resource Pool Name
        """
        return pulumi.get(self, "private_cloud_name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning status of the resource
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="purchaseId")
    def purchase_id(self) -> str:
        """
        purchase id
        """
        return pulumi.get(self, "purchase_id")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.SkuResponse']:
        """
        Dedicated Cloud Nodes SKU
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Node status, indicates is private cloud set up on this node or not
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Dedicated Cloud Nodes tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        {resourceProviderNamespace}/{resourceType}
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vmwareClusterName")
    def vmware_cluster_name(self) -> str:
        """
        VMWare Cluster Name
        """
        return pulumi.get(self, "vmware_cluster_name")


class AwaitableGetDedicatedCloudNodeResult(GetDedicatedCloudNodeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDedicatedCloudNodeResult(
            availability_zone_id=self.availability_zone_id,
            availability_zone_name=self.availability_zone_name,
            cloud_rack_name=self.cloud_rack_name,
            location=self.location,
            name=self.name,
            nodes_count=self.nodes_count,
            placement_group_id=self.placement_group_id,
            placement_group_name=self.placement_group_name,
            private_cloud_id=self.private_cloud_id,
            private_cloud_name=self.private_cloud_name,
            provisioning_state=self.provisioning_state,
            purchase_id=self.purchase_id,
            sku=self.sku,
            status=self.status,
            tags=self.tags,
            type=self.type,
            vmware_cluster_name=self.vmware_cluster_name)


def get_dedicated_cloud_node(dedicated_cloud_node_name: Optional[str] = None,
                             resource_group_name: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDedicatedCloudNodeResult:
    """
    Use this data source to access information about an existing resource.

    :param str dedicated_cloud_node_name: dedicated cloud node name
    :param str resource_group_name: The name of the resource group
    """
    __args__ = dict()
    __args__['dedicatedCloudNodeName'] = dedicated_cloud_node_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:vmwarecloudsimple/v20190401:getDedicatedCloudNode', __args__, opts=opts, typ=GetDedicatedCloudNodeResult).value

    return AwaitableGetDedicatedCloudNodeResult(
        availability_zone_id=__ret__.availability_zone_id,
        availability_zone_name=__ret__.availability_zone_name,
        cloud_rack_name=__ret__.cloud_rack_name,
        location=__ret__.location,
        name=__ret__.name,
        nodes_count=__ret__.nodes_count,
        placement_group_id=__ret__.placement_group_id,
        placement_group_name=__ret__.placement_group_name,
        private_cloud_id=__ret__.private_cloud_id,
        private_cloud_name=__ret__.private_cloud_name,
        provisioning_state=__ret__.provisioning_state,
        purchase_id=__ret__.purchase_id,
        sku=__ret__.sku,
        status=__ret__.status,
        tags=__ret__.tags,
        type=__ret__.type,
        vmware_cluster_name=__ret__.vmware_cluster_name)
