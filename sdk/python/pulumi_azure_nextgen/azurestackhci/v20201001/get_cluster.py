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
    'GetClusterResult',
    'AwaitableGetClusterResult',
    'get_cluster',
]

@pulumi.output_type
class GetClusterResult:
    """
    Cluster details.
    """
    def __init__(__self__, aad_client_id=None, aad_tenant_id=None, billing_model=None, cloud_id=None, last_billing_timestamp=None, last_sync_timestamp=None, location=None, name=None, provisioning_state=None, registration_timestamp=None, reported_properties=None, status=None, tags=None, trial_days_remaining=None, type=None):
        if aad_client_id and not isinstance(aad_client_id, str):
            raise TypeError("Expected argument 'aad_client_id' to be a str")
        pulumi.set(__self__, "aad_client_id", aad_client_id)
        if aad_tenant_id and not isinstance(aad_tenant_id, str):
            raise TypeError("Expected argument 'aad_tenant_id' to be a str")
        pulumi.set(__self__, "aad_tenant_id", aad_tenant_id)
        if billing_model and not isinstance(billing_model, str):
            raise TypeError("Expected argument 'billing_model' to be a str")
        pulumi.set(__self__, "billing_model", billing_model)
        if cloud_id and not isinstance(cloud_id, str):
            raise TypeError("Expected argument 'cloud_id' to be a str")
        pulumi.set(__self__, "cloud_id", cloud_id)
        if last_billing_timestamp and not isinstance(last_billing_timestamp, str):
            raise TypeError("Expected argument 'last_billing_timestamp' to be a str")
        pulumi.set(__self__, "last_billing_timestamp", last_billing_timestamp)
        if last_sync_timestamp and not isinstance(last_sync_timestamp, str):
            raise TypeError("Expected argument 'last_sync_timestamp' to be a str")
        pulumi.set(__self__, "last_sync_timestamp", last_sync_timestamp)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if registration_timestamp and not isinstance(registration_timestamp, str):
            raise TypeError("Expected argument 'registration_timestamp' to be a str")
        pulumi.set(__self__, "registration_timestamp", registration_timestamp)
        if reported_properties and not isinstance(reported_properties, dict):
            raise TypeError("Expected argument 'reported_properties' to be a dict")
        pulumi.set(__self__, "reported_properties", reported_properties)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if trial_days_remaining and not isinstance(trial_days_remaining, float):
            raise TypeError("Expected argument 'trial_days_remaining' to be a float")
        pulumi.set(__self__, "trial_days_remaining", trial_days_remaining)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="aadClientId")
    def aad_client_id(self) -> str:
        """
        App id of cluster AAD identity.
        """
        return pulumi.get(self, "aad_client_id")

    @property
    @pulumi.getter(name="aadTenantId")
    def aad_tenant_id(self) -> str:
        """
        Tenant id of cluster AAD identity.
        """
        return pulumi.get(self, "aad_tenant_id")

    @property
    @pulumi.getter(name="billingModel")
    def billing_model(self) -> str:
        """
        Type of billing applied to the resource.
        """
        return pulumi.get(self, "billing_model")

    @property
    @pulumi.getter(name="cloudId")
    def cloud_id(self) -> str:
        """
        Unique, immutable resource id.
        """
        return pulumi.get(self, "cloud_id")

    @property
    @pulumi.getter(name="lastBillingTimestamp")
    def last_billing_timestamp(self) -> str:
        """
        Most recent billing meter timestamp.
        """
        return pulumi.get(self, "last_billing_timestamp")

    @property
    @pulumi.getter(name="lastSyncTimestamp")
    def last_sync_timestamp(self) -> str:
        """
        Most recent cluster sync timestamp.
        """
        return pulumi.get(self, "last_sync_timestamp")

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
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="registrationTimestamp")
    def registration_timestamp(self) -> str:
        """
        First cluster sync timestamp.
        """
        return pulumi.get(self, "registration_timestamp")

    @property
    @pulumi.getter(name="reportedProperties")
    def reported_properties(self) -> Optional['outputs.ClusterReportedPropertiesResponse']:
        """
        Properties reported by cluster agent.
        """
        return pulumi.get(self, "reported_properties")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the cluster agent.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="trialDaysRemaining")
    def trial_days_remaining(self) -> float:
        """
        Number of days remaining in the trial period.
        """
        return pulumi.get(self, "trial_days_remaining")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        """
        return pulumi.get(self, "type")


class AwaitableGetClusterResult(GetClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetClusterResult(
            aad_client_id=self.aad_client_id,
            aad_tenant_id=self.aad_tenant_id,
            billing_model=self.billing_model,
            cloud_id=self.cloud_id,
            last_billing_timestamp=self.last_billing_timestamp,
            last_sync_timestamp=self.last_sync_timestamp,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            registration_timestamp=self.registration_timestamp,
            reported_properties=self.reported_properties,
            status=self.status,
            tags=self.tags,
            trial_days_remaining=self.trial_days_remaining,
            type=self.type)


def get_cluster(cluster_name: Optional[str] = None,
                resource_group_name: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetClusterResult:
    """
    Use this data source to access information about an existing resource.

    :param str cluster_name: The name of the cluster.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['clusterName'] = cluster_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:azurestackhci/v20201001:getCluster', __args__, opts=opts, typ=GetClusterResult).value

    return AwaitableGetClusterResult(
        aad_client_id=__ret__.aad_client_id,
        aad_tenant_id=__ret__.aad_tenant_id,
        billing_model=__ret__.billing_model,
        cloud_id=__ret__.cloud_id,
        last_billing_timestamp=__ret__.last_billing_timestamp,
        last_sync_timestamp=__ret__.last_sync_timestamp,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        registration_timestamp=__ret__.registration_timestamp,
        reported_properties=__ret__.reported_properties,
        status=__ret__.status,
        tags=__ret__.tags,
        trial_days_remaining=__ret__.trial_days_remaining,
        type=__ret__.type)
