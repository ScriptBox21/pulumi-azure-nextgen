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

__all__ = ['PolicyAssignment']


class PolicyAssignment(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_assignment_name: Optional[pulumi.Input[str]] = None,
                 properties: Optional[pulumi.Input[pulumi.InputType['PolicyAssignmentPropertiesArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Policy assignment.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] policy_assignment_name: Policy assignment name.
        :param pulumi.Input[pulumi.InputType['PolicyAssignmentPropertiesArgs']] properties: Gets or sets the policy assignment properties.
        :param pulumi.Input[str] scope: Scope.
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

            if policy_assignment_name is None:
                raise TypeError("Missing required property 'policy_assignment_name'")
            __props__['policy_assignment_name'] = policy_assignment_name
            __props__['properties'] = properties
            if scope is None:
                raise TypeError("Missing required property 'scope'")
            __props__['scope'] = scope
            __props__['name'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:authorization/latest:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20151001preview:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20160401:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20161201:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20170601preview:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20180301:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20180501:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20190101:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20190601:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20190901:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20200301:PolicyAssignment"), pulumi.Alias(type_="azure-nextgen:authorization/v20200901:PolicyAssignment")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(PolicyAssignment, __self__).__init__(
            'azure-nextgen:authorization/v20151101:PolicyAssignment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PolicyAssignment':
        """
        Get an existing PolicyAssignment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return PolicyAssignment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Gets or sets the policy assignment name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output['outputs.PolicyAssignmentPropertiesResponse']:
        """
        Gets or sets the policy assignment properties.
        """
        return pulumi.get(self, "properties")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

