# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = ['WebAppRelayServiceConnectionSlot']


class WebAppRelayServiceConnectionSlot(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 biztalk_uri: Optional[pulumi.Input[str]] = None,
                 entity_connection_string: Optional[pulumi.Input[str]] = None,
                 entity_name: Optional[pulumi.Input[str]] = None,
                 hostname: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 resource_connection_string: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Hybrid Connection for an App Service app.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] kind: Kind of resource.
        :param pulumi.Input[str] name: Name of the app.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[str] slot: Name of the deployment slot. If a slot is not specified, the API will create or update a hybrid connection for the production slot.
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

            __props__['biztalk_uri'] = biztalk_uri
            __props__['entity_connection_string'] = entity_connection_string
            if entity_name is None:
                raise TypeError("Missing required property 'entity_name'")
            __props__['entity_name'] = entity_name
            __props__['hostname'] = hostname
            __props__['kind'] = kind
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['port'] = port
            __props__['resource_connection_string'] = resource_connection_string
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['resource_type'] = resource_type
            if slot is None:
                raise TypeError("Missing required property 'slot'")
            __props__['slot'] = slot
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/v20150801:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20160801:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20180201:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20181101:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20190801:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200601:WebAppRelayServiceConnectionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200901:WebAppRelayServiceConnectionSlot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WebAppRelayServiceConnectionSlot, __self__).__init__(
            'azure-nextgen:web/latest:WebAppRelayServiceConnectionSlot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WebAppRelayServiceConnectionSlot':
        """
        Get an existing WebAppRelayServiceConnectionSlot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return WebAppRelayServiceConnectionSlot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="biztalkUri")
    def biztalk_uri(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "biztalk_uri")

    @property
    @pulumi.getter(name="entityConnectionString")
    def entity_connection_string(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "entity_connection_string")

    @property
    @pulumi.getter(name="entityName")
    def entity_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "entity_name")

    @property
    @pulumi.getter
    def hostname(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "hostname")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="resourceConnectionString")
    def resource_connection_string(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "resource_connection_string")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "resource_type")

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
        Resource type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

