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

__all__ = ['P2sVpnGateway']


class P2sVpnGateway(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 gateway_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 p2_s_vpn_server_configuration: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_hub: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 vpn_client_address_pool: Optional[pulumi.Input[pulumi.InputType['AddressSpaceArgs']]] = None,
                 vpn_gateway_scale_unit: Optional[pulumi.Input[int]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        P2SVpnGateway Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] gateway_name: The name of the gateway.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] p2_s_vpn_server_configuration: The P2SVpnServerConfiguration to which the p2sVpnGateway is attached to.
        :param pulumi.Input[str] resource_group_name: The resource group name of the P2SVpnGateway.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] virtual_hub: The VirtualHub to which the gateway belongs
        :param pulumi.Input[pulumi.InputType['AddressSpaceArgs']] vpn_client_address_pool: The reference of the address space resource which represents Address space for P2S VpnClient.
        :param pulumi.Input[int] vpn_gateway_scale_unit: The scale unit for this p2s vpn gateway.
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

            if gateway_name is None:
                raise TypeError("Missing required property 'gateway_name'")
            __props__['gateway_name'] = gateway_name
            __props__['id'] = id
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['p2_s_vpn_server_configuration'] = p2_s_vpn_server_configuration
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['virtual_hub'] = virtual_hub
            __props__['vpn_client_address_pool'] = vpn_client_address_pool
            __props__['vpn_gateway_scale_unit'] = vpn_gateway_scale_unit
            __props__['etag'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
            __props__['vpn_client_connection_health'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180801:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181001:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181201:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190201:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190401:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190601:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190701:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190801:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190901:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191101:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191201:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200301:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200401:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200501:P2sVpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200601:P2sVpnGateway")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(P2sVpnGateway, __self__).__init__(
            'azure-nextgen:network/v20181101:P2sVpnGateway',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'P2sVpnGateway':
        """
        Get an existing P2sVpnGateway resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return P2sVpnGateway(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="p2SVpnServerConfiguration")
    def p2_s_vpn_server_configuration(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The P2SVpnServerConfiguration to which the p2sVpnGateway is attached to.
        """
        return pulumi.get(self, "p2_s_vpn_server_configuration")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

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
    @pulumi.getter(name="virtualHub")
    def virtual_hub(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The VirtualHub to which the gateway belongs
        """
        return pulumi.get(self, "virtual_hub")

    @property
    @pulumi.getter(name="vpnClientAddressPool")
    def vpn_client_address_pool(self) -> pulumi.Output[Optional['outputs.AddressSpaceResponse']]:
        """
        The reference of the address space resource which represents Address space for P2S VpnClient.
        """
        return pulumi.get(self, "vpn_client_address_pool")

    @property
    @pulumi.getter(name="vpnClientConnectionHealth")
    def vpn_client_connection_health(self) -> pulumi.Output['outputs.VpnClientConnectionHealthResponse']:
        """
        All P2S VPN clients' connection health status.
        """
        return pulumi.get(self, "vpn_client_connection_health")

    @property
    @pulumi.getter(name="vpnGatewayScaleUnit")
    def vpn_gateway_scale_unit(self) -> pulumi.Output[Optional[int]]:
        """
        The scale unit for this p2s vpn gateway.
        """
        return pulumi.get(self, "vpn_gateway_scale_unit")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

