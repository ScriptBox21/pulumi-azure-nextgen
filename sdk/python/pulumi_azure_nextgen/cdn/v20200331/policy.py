# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Policy']


class Policy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 custom_rules: Optional[pulumi.Input[pulumi.InputType['CustomRuleListArgs']]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_rules: Optional[pulumi.Input[pulumi.InputType['ManagedRuleSetListArgs']]] = None,
                 policy_name: Optional[pulumi.Input[str]] = None,
                 policy_settings: Optional[pulumi.Input[pulumi.InputType['PolicySettingsArgs']]] = None,
                 rate_limit_rules: Optional[pulumi.Input[pulumi.InputType['RateLimitRuleListArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Defines web application firewall policy for Azure CDN.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CustomRuleListArgs']] custom_rules: Describes custom rules inside the policy.
        :param pulumi.Input[str] etag: Gets a unique read-only string that changes whenever the resource is updated.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[pulumi.InputType['ManagedRuleSetListArgs']] managed_rules: Describes managed rules inside the policy.
        :param pulumi.Input[str] policy_name: The name of the CdnWebApplicationFirewallPolicy.
        :param pulumi.Input[pulumi.InputType['PolicySettingsArgs']] policy_settings: Describes  policySettings for policy
        :param pulumi.Input[pulumi.InputType['RateLimitRuleListArgs']] rate_limit_rules: Describes rate limit rules inside the policy.
        :param pulumi.Input[str] resource_group_name: Name of the Resource group within the Azure subscription.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['custom_rules'] = custom_rules
            __props__['etag'] = etag
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['managed_rules'] = managed_rules
            if policy_name is None:
                raise TypeError("Missing required property 'policy_name'")
            __props__['policy_name'] = policy_name
            __props__['policy_settings'] = policy_settings
            __props__['rate_limit_rules'] = rate_limit_rules
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku is None:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['endpoint_links'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['resource_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:cdn/latest:Policy"), pulumi.Alias(type_="azure-nextgen:cdn/v20190615:Policy"), pulumi.Alias(type_="azure-nextgen:cdn/v20190615preview:Policy"), pulumi.Alias(type_="azure-nextgen:cdn/v20200415:Policy"), pulumi.Alias(type_="azure-nextgen:cdn/v20200901:Policy")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Policy, __self__).__init__(
            'azure-nextgen:cdn/v20200331:Policy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Policy':
        """
        Get an existing Policy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Policy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="customRules")
    def custom_rules(self) -> pulumi.Output[Optional['outputs.CustomRuleListResponse']]:
        """
        Describes custom rules inside the policy.
        """
        return pulumi.get(self, "custom_rules")

    @property
    @pulumi.getter(name="endpointLinks")
    def endpoint_links(self) -> pulumi.Output[Sequence['outputs.CdnEndpointResponse']]:
        """
        Describes Azure CDN endpoints associated with this Web Application Firewall policy.
        """
        return pulumi.get(self, "endpoint_links")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedRules")
    def managed_rules(self) -> pulumi.Output[Optional['outputs.ManagedRuleSetListResponse']]:
        """
        Describes managed rules inside the policy.
        """
        return pulumi.get(self, "managed_rules")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="policySettings")
    def policy_settings(self) -> pulumi.Output[Optional['outputs.PolicySettingsResponse']]:
        """
        Describes  policySettings for policy
        """
        return pulumi.get(self, "policy_settings")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the WebApplicationFirewallPolicy.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="rateLimitRules")
    def rate_limit_rules(self) -> pulumi.Output[Optional['outputs.RateLimitRuleListResponse']]:
        """
        Describes rate limit rules inside the policy.
        """
        return pulumi.get(self, "rate_limit_rules")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> pulumi.Output[str]:
        return pulumi.get(self, "resource_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.SkuResponse']:
        """
        The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

