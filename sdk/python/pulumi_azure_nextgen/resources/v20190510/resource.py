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

__all__ = ['Resource']


class Resource(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['IdentityArgs']]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_by: Optional[pulumi.Input[str]] = None,
                 parent_resource_path: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[pulumi.InputType['PlanArgs']]] = None,
                 properties: Optional[Any] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_name_: Optional[pulumi.Input[str]] = None,
                 resource_provider_namespace: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Resource information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['IdentityArgs']] identity: The identity of the resource.
        :param pulumi.Input[str] kind: The kind of the resource.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[str] managed_by: ID of the resource that manages this resource.
        :param pulumi.Input[str] parent_resource_path: The parent resource identity.
        :param pulumi.Input[pulumi.InputType['PlanArgs']] plan: The plan of the resource.
        :param Any properties: The resource properties.
        :param pulumi.Input[str] resource_group_name: The name of the resource group for the resource. The name is case insensitive.
        :param pulumi.Input[str] resource_name_: The name of the resource to create.
        :param pulumi.Input[str] resource_provider_namespace: The namespace of the resource provider.
        :param pulumi.Input[str] resource_type: The resource type of the resource to create.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: The SKU of the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
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

            __props__['identity'] = identity
            __props__['kind'] = kind
            __props__['location'] = location
            __props__['managed_by'] = managed_by
            if parent_resource_path is None:
                raise TypeError("Missing required property 'parent_resource_path'")
            __props__['parent_resource_path'] = parent_resource_path
            __props__['plan'] = plan
            __props__['properties'] = properties
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if resource_name_ is None:
                raise TypeError("Missing required property 'resource_name_'")
            __props__['resource_name'] = resource_name_
            if resource_provider_namespace is None:
                raise TypeError("Missing required property 'resource_provider_namespace'")
            __props__['resource_provider_namespace'] = resource_provider_namespace
            if resource_type is None:
                raise TypeError("Missing required property 'resource_type'")
            __props__['resource_type'] = resource_type
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:resources/latest:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20151101:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20160201:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20160701:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20160901:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20170510:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20180201:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20180501:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20190301:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20190501:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20190701:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20190801:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20191001:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20200601:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20200801:Resource"), pulumi.Alias(type_="azure-nextgen:resources/v20201001:Resource")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Resource, __self__).__init__(
            'azure-nextgen:resources/v20190510:Resource',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Resource':
        """
        Get an existing Resource resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Resource(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.IdentityResponse']]:
        """
        The identity of the resource.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        The kind of the resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedBy")
    def managed_by(self) -> pulumi.Output[Optional[str]]:
        """
        ID of the resource that manages this resource.
        """
        return pulumi.get(self, "managed_by")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def plan(self) -> pulumi.Output[Optional['outputs.PlanResponse']]:
        """
        The plan of the resource.
        """
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output[Any]:
        """
        The resource properties.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuResponse']]:
        """
        The SKU of the resource.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

