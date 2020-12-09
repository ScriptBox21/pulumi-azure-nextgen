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
    'GetWebAppVnetConnectionResult',
    'AwaitableGetWebAppVnetConnectionResult',
    'get_web_app_vnet_connection',
]

@pulumi.output_type
class GetWebAppVnetConnectionResult:
    """
    Virtual Network information contract.
    """
    def __init__(__self__, cert_blob=None, cert_thumbprint=None, dns_servers=None, is_swift=None, kind=None, name=None, resync_required=None, routes=None, system_data=None, type=None, vnet_resource_id=None):
        if cert_blob and not isinstance(cert_blob, str):
            raise TypeError("Expected argument 'cert_blob' to be a str")
        pulumi.set(__self__, "cert_blob", cert_blob)
        if cert_thumbprint and not isinstance(cert_thumbprint, str):
            raise TypeError("Expected argument 'cert_thumbprint' to be a str")
        pulumi.set(__self__, "cert_thumbprint", cert_thumbprint)
        if dns_servers and not isinstance(dns_servers, str):
            raise TypeError("Expected argument 'dns_servers' to be a str")
        pulumi.set(__self__, "dns_servers", dns_servers)
        if is_swift and not isinstance(is_swift, bool):
            raise TypeError("Expected argument 'is_swift' to be a bool")
        pulumi.set(__self__, "is_swift", is_swift)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if resync_required and not isinstance(resync_required, bool):
            raise TypeError("Expected argument 'resync_required' to be a bool")
        pulumi.set(__self__, "resync_required", resync_required)
        if routes and not isinstance(routes, list):
            raise TypeError("Expected argument 'routes' to be a list")
        pulumi.set(__self__, "routes", routes)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vnet_resource_id and not isinstance(vnet_resource_id, str):
            raise TypeError("Expected argument 'vnet_resource_id' to be a str")
        pulumi.set(__self__, "vnet_resource_id", vnet_resource_id)

    @property
    @pulumi.getter(name="certBlob")
    def cert_blob(self) -> Optional[str]:
        """
        A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        Point-To-Site VPN connection.
        """
        return pulumi.get(self, "cert_blob")

    @property
    @pulumi.getter(name="certThumbprint")
    def cert_thumbprint(self) -> str:
        """
        The client certificate thumbprint.
        """
        return pulumi.get(self, "cert_thumbprint")

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> Optional[str]:
        """
        DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
        """
        return pulumi.get(self, "dns_servers")

    @property
    @pulumi.getter(name="isSwift")
    def is_swift(self) -> Optional[bool]:
        """
        Flag that is used to denote if this is VNET injection
        """
        return pulumi.get(self, "is_swift")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resyncRequired")
    def resync_required(self) -> bool:
        """
        <code>true</code> if a resync is required; otherwise, <code>false</code>.
        """
        return pulumi.get(self, "resync_required")

    @property
    @pulumi.getter
    def routes(self) -> Sequence['outputs.VnetRouteResponse']:
        """
        The routes that this Virtual Network connection uses.
        """
        return pulumi.get(self, "routes")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vnetResourceId")
    def vnet_resource_id(self) -> Optional[str]:
        """
        The Virtual Network's resource ID.
        """
        return pulumi.get(self, "vnet_resource_id")


class AwaitableGetWebAppVnetConnectionResult(GetWebAppVnetConnectionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWebAppVnetConnectionResult(
            cert_blob=self.cert_blob,
            cert_thumbprint=self.cert_thumbprint,
            dns_servers=self.dns_servers,
            is_swift=self.is_swift,
            kind=self.kind,
            name=self.name,
            resync_required=self.resync_required,
            routes=self.routes,
            system_data=self.system_data,
            type=self.type,
            vnet_resource_id=self.vnet_resource_id)


def get_web_app_vnet_connection(name: Optional[str] = None,
                                resource_group_name: Optional[str] = None,
                                vnet_name: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWebAppVnetConnectionResult:
    """
    Use this data source to access information about an existing resource.

    :param str name: Name of the app.
    :param str resource_group_name: Name of the resource group to which the resource belongs.
    :param str vnet_name: Name of the virtual network.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['vnetName'] = vnet_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:web/v20200901:getWebAppVnetConnection', __args__, opts=opts, typ=GetWebAppVnetConnectionResult).value

    return AwaitableGetWebAppVnetConnectionResult(
        cert_blob=__ret__.cert_blob,
        cert_thumbprint=__ret__.cert_thumbprint,
        dns_servers=__ret__.dns_servers,
        is_swift=__ret__.is_swift,
        kind=__ret__.kind,
        name=__ret__.name,
        resync_required=__ret__.resync_required,
        routes=__ret__.routes,
        system_data=__ret__.system_data,
        type=__ret__.type,
        vnet_resource_id=__ret__.vnet_resource_id)
