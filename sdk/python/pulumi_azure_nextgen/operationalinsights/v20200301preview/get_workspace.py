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
    'GetWorkspaceResult',
    'AwaitableGetWorkspaceResult',
    'get_workspace',
]

@pulumi.output_type
class GetWorkspaceResult:
    """
    The top level Workspace resource container.
    """
    def __init__(__self__, customer_id=None, e_tag=None, location=None, name=None, private_link_scoped_resources=None, provisioning_state=None, public_network_access_for_ingestion=None, public_network_access_for_query=None, retention_in_days=None, sku=None, tags=None, type=None, workspace_capping=None):
        if customer_id and not isinstance(customer_id, str):
            raise TypeError("Expected argument 'customer_id' to be a str")
        pulumi.set(__self__, "customer_id", customer_id)
        if e_tag and not isinstance(e_tag, str):
            raise TypeError("Expected argument 'e_tag' to be a str")
        pulumi.set(__self__, "e_tag", e_tag)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if private_link_scoped_resources and not isinstance(private_link_scoped_resources, list):
            raise TypeError("Expected argument 'private_link_scoped_resources' to be a list")
        pulumi.set(__self__, "private_link_scoped_resources", private_link_scoped_resources)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if public_network_access_for_ingestion and not isinstance(public_network_access_for_ingestion, str):
            raise TypeError("Expected argument 'public_network_access_for_ingestion' to be a str")
        pulumi.set(__self__, "public_network_access_for_ingestion", public_network_access_for_ingestion)
        if public_network_access_for_query and not isinstance(public_network_access_for_query, str):
            raise TypeError("Expected argument 'public_network_access_for_query' to be a str")
        pulumi.set(__self__, "public_network_access_for_query", public_network_access_for_query)
        if retention_in_days and not isinstance(retention_in_days, int):
            raise TypeError("Expected argument 'retention_in_days' to be a int")
        pulumi.set(__self__, "retention_in_days", retention_in_days)
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        pulumi.set(__self__, "sku", sku)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if workspace_capping and not isinstance(workspace_capping, dict):
            raise TypeError("Expected argument 'workspace_capping' to be a dict")
        pulumi.set(__self__, "workspace_capping", workspace_capping)

    @property
    @pulumi.getter(name="customerId")
    def customer_id(self) -> str:
        """
        This is a read-only property. Represents the ID associated with the workspace.
        """
        return pulumi.get(self, "customer_id")

    @property
    @pulumi.getter(name="eTag")
    def e_tag(self) -> Optional[str]:
        """
        The ETag of the workspace.
        """
        return pulumi.get(self, "e_tag")

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
    @pulumi.getter(name="privateLinkScopedResources")
    def private_link_scoped_resources(self) -> Sequence['outputs.PrivateLinkScopedResourceResponse']:
        """
        List of linked private link scope resources.
        """
        return pulumi.get(self, "private_link_scoped_resources")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        The provisioning state of the workspace.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicNetworkAccessForIngestion")
    def public_network_access_for_ingestion(self) -> Optional[str]:
        """
        The network access type for accessing Log Analytics ingestion.
        """
        return pulumi.get(self, "public_network_access_for_ingestion")

    @property
    @pulumi.getter(name="publicNetworkAccessForQuery")
    def public_network_access_for_query(self) -> Optional[str]:
        """
        The network access type for accessing Log Analytics query.
        """
        return pulumi.get(self, "public_network_access_for_query")

    @property
    @pulumi.getter(name="retentionInDays")
    def retention_in_days(self) -> Optional[int]:
        """
        The workspace data retention in days. -1 means Unlimited retention for the Unlimited Sku. 730 days is the maximum allowed for all other Skus. 
        """
        return pulumi.get(self, "retention_in_days")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.WorkspaceSkuResponse']:
        """
        The SKU of the workspace.
        """
        return pulumi.get(self, "sku")

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

    @property
    @pulumi.getter(name="workspaceCapping")
    def workspace_capping(self) -> Optional['outputs.WorkspaceCappingResponse']:
        """
        The daily volume cap for ingestion.
        """
        return pulumi.get(self, "workspace_capping")


class AwaitableGetWorkspaceResult(GetWorkspaceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWorkspaceResult(
            customer_id=self.customer_id,
            e_tag=self.e_tag,
            location=self.location,
            name=self.name,
            private_link_scoped_resources=self.private_link_scoped_resources,
            provisioning_state=self.provisioning_state,
            public_network_access_for_ingestion=self.public_network_access_for_ingestion,
            public_network_access_for_query=self.public_network_access_for_query,
            retention_in_days=self.retention_in_days,
            sku=self.sku,
            tags=self.tags,
            type=self.type,
            workspace_capping=self.workspace_capping)


def get_workspace(resource_group_name: Optional[str] = None,
                  workspace_name: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWorkspaceResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str workspace_name: The name of the workspace.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['workspaceName'] = workspace_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:operationalinsights/v20200301preview:getWorkspace', __args__, opts=opts, typ=GetWorkspaceResult).value

    return AwaitableGetWorkspaceResult(
        customer_id=__ret__.customer_id,
        e_tag=__ret__.e_tag,
        location=__ret__.location,
        name=__ret__.name,
        private_link_scoped_resources=__ret__.private_link_scoped_resources,
        provisioning_state=__ret__.provisioning_state,
        public_network_access_for_ingestion=__ret__.public_network_access_for_ingestion,
        public_network_access_for_query=__ret__.public_network_access_for_query,
        retention_in_days=__ret__.retention_in_days,
        sku=__ret__.sku,
        tags=__ret__.tags,
        type=__ret__.type,
        workspace_capping=__ret__.workspace_capping)
