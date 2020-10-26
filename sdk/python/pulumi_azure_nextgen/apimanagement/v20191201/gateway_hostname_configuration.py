# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['GatewayHostnameConfiguration']


class GatewayHostnameConfiguration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificate_id: Optional[pulumi.Input[str]] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 hc_id: Optional[pulumi.Input[str]] = None,
                 hostname: Optional[pulumi.Input[str]] = None,
                 negotiate_client_certificate: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 service_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Gateway hostname configuration details.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] certificate_id: Identifier of Certificate entity that will be used for TLS connection establishment
        :param pulumi.Input[str] gateway_id: Gateway entity identifier. Must be unique in the current API Management service instance. Must not have value 'managed'
        :param pulumi.Input[str] hc_id: Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity.
        :param pulumi.Input[str] hostname: Hostname value. Supports valid domain name, partial or full wildcard
        :param pulumi.Input[bool] negotiate_client_certificate: Determines whether gateway requests client certificate
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] service_name: The name of the API Management service.
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

            __props__['certificate_id'] = certificate_id
            if gateway_id is None:
                raise TypeError("Missing required property 'gateway_id'")
            __props__['gateway_id'] = gateway_id
            if hc_id is None:
                raise TypeError("Missing required property 'hc_id'")
            __props__['hc_id'] = hc_id
            __props__['hostname'] = hostname
            __props__['negotiate_client_certificate'] = negotiate_client_certificate
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if service_name is None:
                raise TypeError("Missing required property 'service_name'")
            __props__['service_name'] = service_name
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:apimanagement/latest:GatewayHostnameConfiguration"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20191201preview:GatewayHostnameConfiguration"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20200601preview:GatewayHostnameConfiguration")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(GatewayHostnameConfiguration, __self__).__init__(
            'azure-nextgen:apimanagement/v20191201:GatewayHostnameConfiguration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'GatewayHostnameConfiguration':
        """
        Get an existing GatewayHostnameConfiguration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return GatewayHostnameConfiguration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> pulumi.Output[Optional[str]]:
        """
        Identifier of Certificate entity that will be used for TLS connection establishment
        """
        return pulumi.get(self, "certificate_id")

    @property
    @pulumi.getter
    def hostname(self) -> pulumi.Output[Optional[str]]:
        """
        Hostname value. Supports valid domain name, partial or full wildcard
        """
        return pulumi.get(self, "hostname")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="negotiateClientCertificate")
    def negotiate_client_certificate(self) -> pulumi.Output[Optional[bool]]:
        """
        Determines whether gateway requests client certificate
        """
        return pulumi.get(self, "negotiate_client_certificate")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type for API Management resource.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

