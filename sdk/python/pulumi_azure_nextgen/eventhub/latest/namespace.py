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

__all__ = ['Namespace']


class Namespace(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 is_auto_inflate_enabled: Optional[pulumi.Input[bool]] = None,
                 kafka_enabled: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 maximum_throughput_units: Optional[pulumi.Input[int]] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Single Namespace item in List or Get Operation

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_auto_inflate_enabled: Value that indicates whether AutoInflate is enabled for eventhub namespace.
        :param pulumi.Input[bool] kafka_enabled: Value that indicates whether Kafka is enabled for eventhub namespace.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[int] maximum_throughput_units: Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true)
        :param pulumi.Input[str] namespace_name: The Namespace name
        :param pulumi.Input[str] resource_group_name: Name of the resource group within the azure subscription.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: Properties of sku resource
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

            __props__['is_auto_inflate_enabled'] = is_auto_inflate_enabled
            __props__['kafka_enabled'] = kafka_enabled
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['maximum_throughput_units'] = maximum_throughput_units
            if namespace_name is None:
                raise TypeError("Missing required property 'namespace_name'")
            __props__['namespace_name'] = namespace_name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['created_at'] = None
            __props__['metric_id'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['service_bus_endpoint'] = None
            __props__['type'] = None
            __props__['updated_at'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:eventhub/v20140901:Namespace"), pulumi.Alias(type_="azure-nextgen:eventhub/v20150801:Namespace"), pulumi.Alias(type_="azure-nextgen:eventhub/v20170401:Namespace"), pulumi.Alias(type_="azure-nextgen:eventhub/v20180101preview:Namespace")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Namespace, __self__).__init__(
            'azure-nextgen:eventhub/latest:Namespace',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Namespace':
        """
        Get an existing Namespace resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Namespace(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The time the Namespace was created.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="isAutoInflateEnabled")
    def is_auto_inflate_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Value that indicates whether AutoInflate is enabled for eventhub namespace.
        """
        return pulumi.get(self, "is_auto_inflate_enabled")

    @property
    @pulumi.getter(name="kafkaEnabled")
    def kafka_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Value that indicates whether Kafka is enabled for eventhub namespace.
        """
        return pulumi.get(self, "kafka_enabled")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maximumThroughputUnits")
    def maximum_throughput_units(self) -> pulumi.Output[Optional[int]]:
        """
        Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true)
        """
        return pulumi.get(self, "maximum_throughput_units")

    @property
    @pulumi.getter(name="metricId")
    def metric_id(self) -> pulumi.Output[str]:
        """
        Identifier for Azure Insights metrics.
        """
        return pulumi.get(self, "metric_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the Namespace.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serviceBusEndpoint")
    def service_bus_endpoint(self) -> pulumi.Output[str]:
        """
        Endpoint you can use to perform Service Bus operations.
        """
        return pulumi.get(self, "service_bus_endpoint")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuResponse']]:
        """
        Properties of sku resource
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

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> pulumi.Output[str]:
        """
        The time the Namespace was updated.
        """
        return pulumi.get(self, "updated_at")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

