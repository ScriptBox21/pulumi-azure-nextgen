# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = ['PolicyDefinition']


class PolicyDefinition(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[Any] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[Any] = None,
                 policy_definition_name: Optional[pulumi.Input[str]] = None,
                 policy_rule: Optional[Any] = None,
                 policy_type: Optional[pulumi.Input[Union[str, 'PolicyType']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The policy definition.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The policy definition description.
        :param pulumi.Input[str] display_name: The display name of the policy definition.
        :param Any metadata: The policy definition metadata.
        :param pulumi.Input[str] mode: The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        :param Any parameters: Required if a parameter is used in policy rule.
        :param pulumi.Input[str] policy_definition_name: The name of the policy definition to create.
        :param Any policy_rule: The policy rule.
        :param pulumi.Input[Union[str, 'PolicyType']] policy_type: The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
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

            __props__['description'] = description
            __props__['display_name'] = display_name
            __props__['metadata'] = metadata
            __props__['mode'] = mode
            __props__['parameters'] = parameters
            __props__['policy_definition_name'] = policy_definition_name
            __props__['policy_rule'] = policy_rule
            __props__['policy_type'] = policy_type
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:authorization:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/latest:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20151001preview:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20160401:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20161201:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20180301:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20180501:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20190601:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20190901:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20200301:PolicyDefinition"), pulumi.Alias(type_="azure-nextgen:authorization/v20200901:PolicyDefinition")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(PolicyDefinition, __self__).__init__(
            'azure-nextgen:authorization/v20190101:PolicyDefinition',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PolicyDefinition':
        """
        Get an existing PolicyDefinition resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return PolicyDefinition(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The policy definition description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[Optional[str]]:
        """
        The display name of the policy definition.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Optional[Any]]:
        """
        The policy definition metadata.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Output[Optional[str]]:
        """
        The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the policy definition.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional[Any]]:
        """
        Required if a parameter is used in policy rule.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="policyRule")
    def policy_rule(self) -> pulumi.Output[Optional[Any]]:
        """
        The policy rule.
        """
        return pulumi.get(self, "policy_rule")

    @property
    @pulumi.getter(name="policyType")
    def policy_type(self) -> pulumi.Output[Optional[str]]:
        """
        The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        """
        return pulumi.get(self, "policy_type")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource (Microsoft.Authorization/policyDefinitions).
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

