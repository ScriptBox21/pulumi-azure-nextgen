# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = ['MultipleActivationKey']


class MultipleActivationKey(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 agreement_number: Optional[pulumi.Input[str]] = None,
                 installed_server_number: Optional[pulumi.Input[int]] = None,
                 is_eligible: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 multiple_activation_key_name: Optional[pulumi.Input[str]] = None,
                 os_type: Optional[pulumi.Input[Union[str, 'OsType']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 support_type: Optional[pulumi.Input[Union[str, 'SupportType']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        MAK key details.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] agreement_number: Agreement number under which the key is requested.
        :param pulumi.Input[int] installed_server_number: Number of activations/servers using the MAK key.
        :param pulumi.Input[bool] is_eligible: <code> true </code> if user has eligible on-premises Windows physical or virtual machines, and that the requested key will only be used in their organization; <code> false </code> otherwise.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[str] multiple_activation_key_name: The name of the MAK key.
        :param pulumi.Input[Union[str, 'OsType']] os_type: Type of OS for which the key is requested.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[Union[str, 'SupportType']] support_type: Type of support
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

            __props__['agreement_number'] = agreement_number
            __props__['installed_server_number'] = installed_server_number
            __props__['is_eligible'] = is_eligible
            __props__['location'] = location
            __props__['multiple_activation_key_name'] = multiple_activation_key_name
            __props__['os_type'] = os_type
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if support_type is None:
                support_type = 'SupplementalServicing'
            __props__['support_type'] = support_type
            __props__['tags'] = tags
            __props__['expiration_date'] = None
            __props__['multiple_activation_key'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:windowsesu:MultipleActivationKey")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(MultipleActivationKey, __self__).__init__(
            'azure-nextgen:windowsesu/v20190916preview:MultipleActivationKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'MultipleActivationKey':
        """
        Get an existing MultipleActivationKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return MultipleActivationKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="agreementNumber")
    def agreement_number(self) -> pulumi.Output[Optional[str]]:
        """
        Agreement number under which the key is requested.
        """
        return pulumi.get(self, "agreement_number")

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> pulumi.Output[str]:
        """
        End of support of security updates activated by the MAK key.
        """
        return pulumi.get(self, "expiration_date")

    @property
    @pulumi.getter(name="installedServerNumber")
    def installed_server_number(self) -> pulumi.Output[Optional[int]]:
        """
        Number of activations/servers using the MAK key.
        """
        return pulumi.get(self, "installed_server_number")

    @property
    @pulumi.getter(name="isEligible")
    def is_eligible(self) -> pulumi.Output[Optional[bool]]:
        """
        <code> true </code> if user has eligible on-premises Windows physical or virtual machines, and that the requested key will only be used in their organization; <code> false </code> otherwise.
        """
        return pulumi.get(self, "is_eligible")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="multipleActivationKey")
    def multiple_activation_key(self) -> pulumi.Output[str]:
        """
        MAK 5x5 key.
        """
        return pulumi.get(self, "multiple_activation_key")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="osType")
    def os_type(self) -> pulumi.Output[Optional[str]]:
        """
        Type of OS for which the key is requested.
        """
        return pulumi.get(self, "os_type")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="supportType")
    def support_type(self) -> pulumi.Output[Optional[str]]:
        """
        Type of support
        """
        return pulumi.get(self, "support_type")

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
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

