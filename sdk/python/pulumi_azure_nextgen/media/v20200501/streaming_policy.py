# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['StreamingPolicy']


class StreamingPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 common_encryption_cbcs: Optional[pulumi.Input[pulumi.InputType['CommonEncryptionCbcsArgs']]] = None,
                 common_encryption_cenc: Optional[pulumi.Input[pulumi.InputType['CommonEncryptionCencArgs']]] = None,
                 default_content_key_policy_name: Optional[pulumi.Input[str]] = None,
                 envelope_encryption: Optional[pulumi.Input[pulumi.InputType['EnvelopeEncryptionArgs']]] = None,
                 no_encryption: Optional[pulumi.Input[pulumi.InputType['NoEncryptionArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 streaming_policy_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A Streaming Policy resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The Media Services account name.
        :param pulumi.Input[pulumi.InputType['CommonEncryptionCbcsArgs']] common_encryption_cbcs: Configuration of CommonEncryptionCbcs
        :param pulumi.Input[pulumi.InputType['CommonEncryptionCencArgs']] common_encryption_cenc: Configuration of CommonEncryptionCenc
        :param pulumi.Input[str] default_content_key_policy_name: Default ContentKey used by current Streaming Policy
        :param pulumi.Input[pulumi.InputType['EnvelopeEncryptionArgs']] envelope_encryption: Configuration of EnvelopeEncryption
        :param pulumi.Input[pulumi.InputType['NoEncryptionArgs']] no_encryption: Configurations of NoEncryption
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the Azure subscription.
        :param pulumi.Input[str] streaming_policy_name: The Streaming Policy name.
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

            if account_name is None and not opts.urn:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            __props__['common_encryption_cbcs'] = common_encryption_cbcs
            __props__['common_encryption_cenc'] = common_encryption_cenc
            __props__['default_content_key_policy_name'] = default_content_key_policy_name
            __props__['envelope_encryption'] = envelope_encryption
            __props__['no_encryption'] = no_encryption
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if streaming_policy_name is None and not opts.urn:
                raise TypeError("Missing required property 'streaming_policy_name'")
            __props__['streaming_policy_name'] = streaming_policy_name
            __props__['created'] = None
            __props__['name'] = None
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:media/latest:StreamingPolicy"), pulumi.Alias(type_="azure-nextgen:media/v20180330preview:StreamingPolicy"), pulumi.Alias(type_="azure-nextgen:media/v20180601preview:StreamingPolicy"), pulumi.Alias(type_="azure-nextgen:media/v20180701:StreamingPolicy")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(StreamingPolicy, __self__).__init__(
            'azure-nextgen:media/v20200501:StreamingPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'StreamingPolicy':
        """
        Get an existing StreamingPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return StreamingPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="commonEncryptionCbcs")
    def common_encryption_cbcs(self) -> pulumi.Output[Optional['outputs.CommonEncryptionCbcsResponse']]:
        """
        Configuration of CommonEncryptionCbcs
        """
        return pulumi.get(self, "common_encryption_cbcs")

    @property
    @pulumi.getter(name="commonEncryptionCenc")
    def common_encryption_cenc(self) -> pulumi.Output[Optional['outputs.CommonEncryptionCencResponse']]:
        """
        Configuration of CommonEncryptionCenc
        """
        return pulumi.get(self, "common_encryption_cenc")

    @property
    @pulumi.getter
    def created(self) -> pulumi.Output[str]:
        """
        Creation time of Streaming Policy
        """
        return pulumi.get(self, "created")

    @property
    @pulumi.getter(name="defaultContentKeyPolicyName")
    def default_content_key_policy_name(self) -> pulumi.Output[Optional[str]]:
        """
        Default ContentKey used by current Streaming Policy
        """
        return pulumi.get(self, "default_content_key_policy_name")

    @property
    @pulumi.getter(name="envelopeEncryption")
    def envelope_encryption(self) -> pulumi.Output[Optional['outputs.EnvelopeEncryptionResponse']]:
        """
        Configuration of EnvelopeEncryption
        """
        return pulumi.get(self, "envelope_encryption")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="noEncryption")
    def no_encryption(self) -> pulumi.Output[Optional['outputs.NoEncryptionResponse']]:
        """
        Configurations of NoEncryption
        """
        return pulumi.get(self, "no_encryption")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

