# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetVirtualNetworkGatewayVpnclientConnectionHealthResult',
    'AwaitableGetVirtualNetworkGatewayVpnclientConnectionHealthResult',
    'get_virtual_network_gateway_vpnclient_connection_health',
]

@pulumi.output_type
class GetVirtualNetworkGatewayVpnclientConnectionHealthResult:
    """
    List of virtual network gateway vpn client connection health.
    """
    def __init__(__self__, value=None):
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[Sequence['outputs.VpnClientConnectionHealthDetailResponseResult']]:
        """
        List of vpn client connection health.
        """
        return pulumi.get(self, "value")


class AwaitableGetVirtualNetworkGatewayVpnclientConnectionHealthResult(GetVirtualNetworkGatewayVpnclientConnectionHealthResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVirtualNetworkGatewayVpnclientConnectionHealthResult(
            value=self.value)


def get_virtual_network_gateway_vpnclient_connection_health(resource_group_name: Optional[str] = None,
                                                            virtual_network_gateway_name: Optional[str] = None,
                                                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVirtualNetworkGatewayVpnclientConnectionHealthResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the resource group.
    :param str virtual_network_gateway_name: The name of the virtual network gateway.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['virtualNetworkGatewayName'] = virtual_network_gateway_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:network/v20200501:getVirtualNetworkGatewayVpnclientConnectionHealth', __args__, opts=opts, typ=GetVirtualNetworkGatewayVpnclientConnectionHealthResult).value

    return AwaitableGetVirtualNetworkGatewayVpnclientConnectionHealthResult(
        value=__ret__.value)
