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
    'GetCustomDomainResult',
    'AwaitableGetCustomDomainResult',
    'get_custom_domain',
]

@pulumi.output_type
class GetCustomDomainResult:
    """
    Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    """
    def __init__(__self__, custom_https_provisioning_state=None, custom_https_provisioning_substate=None, host_name=None, name=None, provisioning_state=None, resource_state=None, system_data=None, type=None, validation_data=None):
        if custom_https_provisioning_state and not isinstance(custom_https_provisioning_state, str):
            raise TypeError("Expected argument 'custom_https_provisioning_state' to be a str")
        pulumi.set(__self__, "custom_https_provisioning_state", custom_https_provisioning_state)
        if custom_https_provisioning_substate and not isinstance(custom_https_provisioning_substate, str):
            raise TypeError("Expected argument 'custom_https_provisioning_substate' to be a str")
        pulumi.set(__self__, "custom_https_provisioning_substate", custom_https_provisioning_substate)
        if host_name and not isinstance(host_name, str):
            raise TypeError("Expected argument 'host_name' to be a str")
        pulumi.set(__self__, "host_name", host_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_state and not isinstance(resource_state, str):
            raise TypeError("Expected argument 'resource_state' to be a str")
        pulumi.set(__self__, "resource_state", resource_state)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if validation_data and not isinstance(validation_data, str):
            raise TypeError("Expected argument 'validation_data' to be a str")
        pulumi.set(__self__, "validation_data", validation_data)

    @property
    @pulumi.getter(name="customHttpsProvisioningState")
    def custom_https_provisioning_state(self) -> str:
        """
        Provisioning status of Custom Https of the custom domain.
        """
        return pulumi.get(self, "custom_https_provisioning_state")

    @property
    @pulumi.getter(name="customHttpsProvisioningSubstate")
    def custom_https_provisioning_substate(self) -> str:
        """
        Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        """
        return pulumi.get(self, "custom_https_provisioning_substate")

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> str:
        """
        The host name of the custom domain. Must be a domain name.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning status of the custom domain.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> str:
        """
        Resource status of the custom domain.
        """
        return pulumi.get(self, "resource_state")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        Read only system data
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="validationData")
    def validation_data(self) -> Optional[str]:
        """
        Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
        """
        return pulumi.get(self, "validation_data")


class AwaitableGetCustomDomainResult(GetCustomDomainResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCustomDomainResult(
            custom_https_provisioning_state=self.custom_https_provisioning_state,
            custom_https_provisioning_substate=self.custom_https_provisioning_substate,
            host_name=self.host_name,
            name=self.name,
            provisioning_state=self.provisioning_state,
            resource_state=self.resource_state,
            system_data=self.system_data,
            type=self.type,
            validation_data=self.validation_data)


def get_custom_domain(custom_domain_name: Optional[str] = None,
                      endpoint_name: Optional[str] = None,
                      profile_name: Optional[str] = None,
                      resource_group_name: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCustomDomainResult:
    """
    Use this data source to access information about an existing resource.

    :param str custom_domain_name: Name of the custom domain within an endpoint.
    :param str endpoint_name: Name of the endpoint under the profile which is unique globally.
    :param str profile_name: Name of the CDN profile which is unique within the resource group.
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    """
    __args__ = dict()
    __args__['customDomainName'] = custom_domain_name
    __args__['endpointName'] = endpoint_name
    __args__['profileName'] = profile_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:cdn/v20200901:getCustomDomain', __args__, opts=opts, typ=GetCustomDomainResult).value

    return AwaitableGetCustomDomainResult(
        custom_https_provisioning_state=__ret__.custom_https_provisioning_state,
        custom_https_provisioning_substate=__ret__.custom_https_provisioning_substate,
        host_name=__ret__.host_name,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        resource_state=__ret__.resource_state,
        system_data=__ret__.system_data,
        type=__ret__.type,
        validation_data=__ret__.validation_data)
