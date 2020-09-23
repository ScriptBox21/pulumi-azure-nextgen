# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['Origin']


class Origin(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 host_name: Optional[pulumi.Input[str]] = None,
                 http_port: Optional[pulumi.Input[int]] = None,
                 https_port: Optional[pulumi.Input[int]] = None,
                 origin_name: Optional[pulumi.Input[str]] = None,
                 profile_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] endpoint_name: Name of the endpoint within the CDN profile.
        :param pulumi.Input[str] host_name: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        :param pulumi.Input[int] http_port: The value of the HTTP port. Must be between 1 and 65535.
        :param pulumi.Input[int] https_port: The value of the HTTPS port. Must be between 1 and 65535.
        :param pulumi.Input[str] origin_name: Name of the origin, an arbitrary value but it needs to be unique under endpoint
        :param pulumi.Input[str] profile_name: Name of the CDN profile within the resource group.
        :param pulumi.Input[str] resource_group_name: Name of the resource group within the Azure subscription.
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

            if endpoint_name is None:
                raise TypeError("Missing required property 'endpoint_name'")
            __props__['endpoint_name'] = endpoint_name
            if host_name is None:
                raise TypeError("Missing required property 'host_name'")
            __props__['host_name'] = host_name
            __props__['http_port'] = http_port
            __props__['https_port'] = https_port
            if origin_name is None:
                raise TypeError("Missing required property 'origin_name'")
            __props__['origin_name'] = origin_name
            if profile_name is None:
                raise TypeError("Missing required property 'profile_name'")
            __props__['profile_name'] = profile_name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['resource_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:cdn/latest:Origin"), pulumi.Alias(type_="azure-nextgen:cdn/v20160402:Origin"), pulumi.Alias(type_="azure-nextgen:cdn/v20191231:Origin"), pulumi.Alias(type_="azure-nextgen:cdn/v20200331:Origin"), pulumi.Alias(type_="azure-nextgen:cdn/v20200415:Origin")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Origin, __self__).__init__(
            'azure-nextgen:cdn/v20150601:Origin',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Origin':
        """
        Get an existing Origin resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Origin(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Output[str]:
        """
        The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter(name="httpPort")
    def http_port(self) -> pulumi.Output[Optional[int]]:
        """
        The value of the HTTP port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "http_port")

    @property
    @pulumi.getter(name="httpsPort")
    def https_port(self) -> pulumi.Output[Optional[int]]:
        """
        The value of the https port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "https_port")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning status of the origin.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> pulumi.Output[str]:
        """
        Resource status of the origin.
        """
        return pulumi.get(self, "resource_state")

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

