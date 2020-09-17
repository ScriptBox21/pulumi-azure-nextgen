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

__all__ = ['ObjectReplicationPolicy']


class ObjectReplicationPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 destination_account: Optional[pulumi.Input[str]] = None,
                 object_replication_policy_id: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ObjectReplicationPolicyRuleArgs']]]]] = None,
                 source_account: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The replication policy between two storage accounts. Multiple rules can be defined in one policy.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        :param pulumi.Input[str] destination_account: Required. Destination account name.
        :param pulumi.Input[str] object_replication_policy_id: The ID of object replication policy or 'default' if the policy ID is unknown.
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ObjectReplicationPolicyRuleArgs']]]] rules: The storage account object replication rules.
        :param pulumi.Input[str] source_account: Required. Source account name.
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

            if account_name is None:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            if destination_account is None:
                raise TypeError("Missing required property 'destination_account'")
            __props__['destination_account'] = destination_account
            if object_replication_policy_id is None:
                raise TypeError("Missing required property 'object_replication_policy_id'")
            __props__['object_replication_policy_id'] = object_replication_policy_id
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['rules'] = rules
            if source_account is None:
                raise TypeError("Missing required property 'source_account'")
            __props__['source_account'] = source_account
            __props__['enabled_time'] = None
            __props__['name'] = None
            __props__['policy_id'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:storage/latest:ObjectReplicationPolicy"), pulumi.Alias(type_="azure-nextgen:storage/v20190601:ObjectReplicationPolicy")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(ObjectReplicationPolicy, __self__).__init__(
            'azure-nextgen:storage/v20200801preview:ObjectReplicationPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ObjectReplicationPolicy':
        """
        Get an existing ObjectReplicationPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return ObjectReplicationPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="destinationAccount")
    def destination_account(self) -> pulumi.Output[str]:
        """
        Required. Destination account name.
        """
        return pulumi.get(self, "destination_account")

    @property
    @pulumi.getter(name="enabledTime")
    def enabled_time(self) -> pulumi.Output[str]:
        """
        Indicates when the policy is enabled on the source account.
        """
        return pulumi.get(self, "enabled_time")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Output[str]:
        """
        A unique id for object replication policy.
        """
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Output[Optional[Sequence['outputs.ObjectReplicationPolicyRuleResponse']]]:
        """
        The storage account object replication rules.
        """
        return pulumi.get(self, "rules")

    @property
    @pulumi.getter(name="sourceAccount")
    def source_account(self) -> pulumi.Output[str]:
        """
        Required. Source account name.
        """
        return pulumi.get(self, "source_account")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
