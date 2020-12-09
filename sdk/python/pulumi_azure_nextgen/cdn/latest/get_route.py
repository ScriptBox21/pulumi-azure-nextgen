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
    'GetRouteResult',
    'AwaitableGetRouteResult',
    'get_route',
]

@pulumi.output_type
class GetRouteResult:
    """
    Friendly Routes name mapping to the any Routes or secret related information.
    """
    def __init__(__self__, compression_settings=None, custom_domains=None, deployment_status=None, enabled_state=None, forwarding_protocol=None, https_redirect=None, link_to_default_domain=None, name=None, optimization_type=None, origin_group=None, origin_path=None, patterns_to_match=None, provisioning_state=None, query_string_caching_behavior=None, rule_sets=None, supported_protocols=None, system_data=None, type=None):
        if compression_settings and not isinstance(compression_settings, list):
            raise TypeError("Expected argument 'compression_settings' to be a list")
        pulumi.set(__self__, "compression_settings", compression_settings)
        if custom_domains and not isinstance(custom_domains, list):
            raise TypeError("Expected argument 'custom_domains' to be a list")
        pulumi.set(__self__, "custom_domains", custom_domains)
        if deployment_status and not isinstance(deployment_status, str):
            raise TypeError("Expected argument 'deployment_status' to be a str")
        pulumi.set(__self__, "deployment_status", deployment_status)
        if enabled_state and not isinstance(enabled_state, str):
            raise TypeError("Expected argument 'enabled_state' to be a str")
        pulumi.set(__self__, "enabled_state", enabled_state)
        if forwarding_protocol and not isinstance(forwarding_protocol, str):
            raise TypeError("Expected argument 'forwarding_protocol' to be a str")
        pulumi.set(__self__, "forwarding_protocol", forwarding_protocol)
        if https_redirect and not isinstance(https_redirect, str):
            raise TypeError("Expected argument 'https_redirect' to be a str")
        pulumi.set(__self__, "https_redirect", https_redirect)
        if link_to_default_domain and not isinstance(link_to_default_domain, str):
            raise TypeError("Expected argument 'link_to_default_domain' to be a str")
        pulumi.set(__self__, "link_to_default_domain", link_to_default_domain)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if optimization_type and not isinstance(optimization_type, str):
            raise TypeError("Expected argument 'optimization_type' to be a str")
        pulumi.set(__self__, "optimization_type", optimization_type)
        if origin_group and not isinstance(origin_group, dict):
            raise TypeError("Expected argument 'origin_group' to be a dict")
        pulumi.set(__self__, "origin_group", origin_group)
        if origin_path and not isinstance(origin_path, str):
            raise TypeError("Expected argument 'origin_path' to be a str")
        pulumi.set(__self__, "origin_path", origin_path)
        if patterns_to_match and not isinstance(patterns_to_match, list):
            raise TypeError("Expected argument 'patterns_to_match' to be a list")
        pulumi.set(__self__, "patterns_to_match", patterns_to_match)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if query_string_caching_behavior and not isinstance(query_string_caching_behavior, str):
            raise TypeError("Expected argument 'query_string_caching_behavior' to be a str")
        pulumi.set(__self__, "query_string_caching_behavior", query_string_caching_behavior)
        if rule_sets and not isinstance(rule_sets, list):
            raise TypeError("Expected argument 'rule_sets' to be a list")
        pulumi.set(__self__, "rule_sets", rule_sets)
        if supported_protocols and not isinstance(supported_protocols, list):
            raise TypeError("Expected argument 'supported_protocols' to be a list")
        pulumi.set(__self__, "supported_protocols", supported_protocols)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="compressionSettings")
    def compression_settings(self) -> Optional[Sequence['outputs.CompressionSettingsResponse']]:
        """
        compression settings.
        """
        return pulumi.get(self, "compression_settings")

    @property
    @pulumi.getter(name="customDomains")
    def custom_domains(self) -> Optional[Sequence['outputs.ResourceReferenceResponse']]:
        """
        Domains referenced by this endpoint.
        """
        return pulumi.get(self, "custom_domains")

    @property
    @pulumi.getter(name="deploymentStatus")
    def deployment_status(self) -> str:
        return pulumi.get(self, "deployment_status")

    @property
    @pulumi.getter(name="enabledState")
    def enabled_state(self) -> Optional[str]:
        """
        Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        """
        return pulumi.get(self, "enabled_state")

    @property
    @pulumi.getter(name="forwardingProtocol")
    def forwarding_protocol(self) -> Optional[str]:
        """
        Protocol this rule will use when forwarding traffic to backends.
        """
        return pulumi.get(self, "forwarding_protocol")

    @property
    @pulumi.getter(name="httpsRedirect")
    def https_redirect(self) -> Optional[str]:
        """
        Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
        """
        return pulumi.get(self, "https_redirect")

    @property
    @pulumi.getter(name="linkToDefaultDomain")
    def link_to_default_domain(self) -> Optional[str]:
        """
        whether this route will be linked to the default endpoint domain.
        """
        return pulumi.get(self, "link_to_default_domain")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="optimizationType")
    def optimization_type(self) -> Optional[str]:
        """
        Specifies what scenario the customer wants this AzureFrontDoor endpoint to optimize for, e.g. Download, Media services. With this information, AzureFrontDoor can apply scenario driven optimization.
        """
        return pulumi.get(self, "optimization_type")

    @property
    @pulumi.getter(name="originGroup")
    def origin_group(self) -> 'outputs.ResourceReferenceResponse':
        """
        A reference to the origin group.
        """
        return pulumi.get(self, "origin_group")

    @property
    @pulumi.getter(name="originPath")
    def origin_path(self) -> Optional[str]:
        """
        A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        """
        return pulumi.get(self, "origin_path")

    @property
    @pulumi.getter(name="patternsToMatch")
    def patterns_to_match(self) -> Optional[Sequence[str]]:
        """
        The route patterns of the rule.
        """
        return pulumi.get(self, "patterns_to_match")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning status
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="queryStringCachingBehavior")
    def query_string_caching_behavior(self) -> Optional[str]:
        """
        Defines how AzureFrontDoor caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        """
        return pulumi.get(self, "query_string_caching_behavior")

    @property
    @pulumi.getter(name="ruleSets")
    def rule_sets(self) -> Optional[Sequence['outputs.ResourceReferenceResponse']]:
        """
        rule sets referenced by this endpoint.
        """
        return pulumi.get(self, "rule_sets")

    @property
    @pulumi.getter(name="supportedProtocols")
    def supported_protocols(self) -> Optional[Sequence[str]]:
        """
        List of supported protocols for this route.
        """
        return pulumi.get(self, "supported_protocols")

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


class AwaitableGetRouteResult(GetRouteResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRouteResult(
            compression_settings=self.compression_settings,
            custom_domains=self.custom_domains,
            deployment_status=self.deployment_status,
            enabled_state=self.enabled_state,
            forwarding_protocol=self.forwarding_protocol,
            https_redirect=self.https_redirect,
            link_to_default_domain=self.link_to_default_domain,
            name=self.name,
            optimization_type=self.optimization_type,
            origin_group=self.origin_group,
            origin_path=self.origin_path,
            patterns_to_match=self.patterns_to_match,
            provisioning_state=self.provisioning_state,
            query_string_caching_behavior=self.query_string_caching_behavior,
            rule_sets=self.rule_sets,
            supported_protocols=self.supported_protocols,
            system_data=self.system_data,
            type=self.type)


def get_route(endpoint_name: Optional[str] = None,
              profile_name: Optional[str] = None,
              resource_group_name: Optional[str] = None,
              route_name: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRouteResult:
    """
    Use this data source to access information about an existing resource.

    :param str endpoint_name: Name of the endpoint under the profile which is unique globally.
    :param str profile_name: Name of the CDN profile which is unique within the resource group.
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    :param str route_name: Name of the routing rule.
    """
    __args__ = dict()
    __args__['endpointName'] = endpoint_name
    __args__['profileName'] = profile_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['routeName'] = route_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:cdn/latest:getRoute', __args__, opts=opts, typ=GetRouteResult).value

    return AwaitableGetRouteResult(
        compression_settings=__ret__.compression_settings,
        custom_domains=__ret__.custom_domains,
        deployment_status=__ret__.deployment_status,
        enabled_state=__ret__.enabled_state,
        forwarding_protocol=__ret__.forwarding_protocol,
        https_redirect=__ret__.https_redirect,
        link_to_default_domain=__ret__.link_to_default_domain,
        name=__ret__.name,
        optimization_type=__ret__.optimization_type,
        origin_group=__ret__.origin_group,
        origin_path=__ret__.origin_path,
        patterns_to_match=__ret__.patterns_to_match,
        provisioning_state=__ret__.provisioning_state,
        query_string_caching_behavior=__ret__.query_string_caching_behavior,
        rule_sets=__ret__.rule_sets,
        supported_protocols=__ret__.supported_protocols,
        system_data=__ret__.system_data,
        type=__ret__.type)
