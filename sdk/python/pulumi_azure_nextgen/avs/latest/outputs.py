# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'CircuitResponse',
    'EndpointsResponse',
    'IdentitySourceResponse',
    'ManagementClusterResponse',
    'SkuResponse',
]

@pulumi.output_type
class CircuitResponse(dict):
    """
    An ExpressRoute Circuit
    """
    def __init__(__self__, *,
                 express_route_id: str,
                 express_route_private_peering_id: str,
                 primary_subnet: str,
                 secondary_subnet: str):
        """
        An ExpressRoute Circuit
        :param str express_route_id: Identifier of the ExpressRoute Circuit (Microsoft Colo only)
        :param str express_route_private_peering_id: ExpressRoute Circuit private peering identifier
        :param str primary_subnet: CIDR of primary subnet
        :param str secondary_subnet: CIDR of secondary subnet
        """
        pulumi.set(__self__, "express_route_id", express_route_id)
        pulumi.set(__self__, "express_route_private_peering_id", express_route_private_peering_id)
        pulumi.set(__self__, "primary_subnet", primary_subnet)
        pulumi.set(__self__, "secondary_subnet", secondary_subnet)

    @property
    @pulumi.getter(name="expressRouteID")
    def express_route_id(self) -> str:
        """
        Identifier of the ExpressRoute Circuit (Microsoft Colo only)
        """
        return pulumi.get(self, "express_route_id")

    @property
    @pulumi.getter(name="expressRoutePrivatePeeringID")
    def express_route_private_peering_id(self) -> str:
        """
        ExpressRoute Circuit private peering identifier
        """
        return pulumi.get(self, "express_route_private_peering_id")

    @property
    @pulumi.getter(name="primarySubnet")
    def primary_subnet(self) -> str:
        """
        CIDR of primary subnet
        """
        return pulumi.get(self, "primary_subnet")

    @property
    @pulumi.getter(name="secondarySubnet")
    def secondary_subnet(self) -> str:
        """
        CIDR of secondary subnet
        """
        return pulumi.get(self, "secondary_subnet")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class EndpointsResponse(dict):
    """
    Endpoint addresses
    """
    def __init__(__self__, *,
                 hcx_cloud_manager: str,
                 nsxt_manager: str,
                 vcsa: str):
        """
        Endpoint addresses
        :param str hcx_cloud_manager: Endpoint for the HCX Cloud Manager
        :param str nsxt_manager: Endpoint for the NSX-T Data Center manager
        :param str vcsa: Endpoint for Virtual Center Server Appliance
        """
        pulumi.set(__self__, "hcx_cloud_manager", hcx_cloud_manager)
        pulumi.set(__self__, "nsxt_manager", nsxt_manager)
        pulumi.set(__self__, "vcsa", vcsa)

    @property
    @pulumi.getter(name="hcxCloudManager")
    def hcx_cloud_manager(self) -> str:
        """
        Endpoint for the HCX Cloud Manager
        """
        return pulumi.get(self, "hcx_cloud_manager")

    @property
    @pulumi.getter(name="nsxtManager")
    def nsxt_manager(self) -> str:
        """
        Endpoint for the NSX-T Data Center manager
        """
        return pulumi.get(self, "nsxt_manager")

    @property
    @pulumi.getter
    def vcsa(self) -> str:
        """
        Endpoint for Virtual Center Server Appliance
        """
        return pulumi.get(self, "vcsa")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IdentitySourceResponse(dict):
    """
    vCenter Single Sign On Identity Source
    """
    def __init__(__self__, *,
                 alias: Optional[str] = None,
                 base_group_dn: Optional[str] = None,
                 base_user_dn: Optional[str] = None,
                 domain: Optional[str] = None,
                 name: Optional[str] = None,
                 password: Optional[str] = None,
                 primary_server: Optional[str] = None,
                 secondary_server: Optional[str] = None,
                 ssl: Optional[str] = None,
                 username: Optional[str] = None):
        """
        vCenter Single Sign On Identity Source
        :param str alias: The domain's NetBIOS name
        :param str base_group_dn: The base distinguished name for groups
        :param str base_user_dn: The base distinguished name for users
        :param str domain: The domain's dns name
        :param str name: The name of the identity source
        :param str password: The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups.
        :param str primary_server: Primary server URL
        :param str secondary_server: Secondary server URL
        :param str ssl: Protect LDAP communication using SSL certificate (LDAPS)
        :param str username: The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group
        """
        if alias is not None:
            pulumi.set(__self__, "alias", alias)
        if base_group_dn is not None:
            pulumi.set(__self__, "base_group_dn", base_group_dn)
        if base_user_dn is not None:
            pulumi.set(__self__, "base_user_dn", base_user_dn)
        if domain is not None:
            pulumi.set(__self__, "domain", domain)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if primary_server is not None:
            pulumi.set(__self__, "primary_server", primary_server)
        if secondary_server is not None:
            pulumi.set(__self__, "secondary_server", secondary_server)
        if ssl is not None:
            pulumi.set(__self__, "ssl", ssl)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def alias(self) -> Optional[str]:
        """
        The domain's NetBIOS name
        """
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter(name="baseGroupDN")
    def base_group_dn(self) -> Optional[str]:
        """
        The base distinguished name for groups
        """
        return pulumi.get(self, "base_group_dn")

    @property
    @pulumi.getter(name="baseUserDN")
    def base_user_dn(self) -> Optional[str]:
        """
        The base distinguished name for users
        """
        return pulumi.get(self, "base_user_dn")

    @property
    @pulumi.getter
    def domain(self) -> Optional[str]:
        """
        The domain's dns name
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the identity source
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> Optional[str]:
        """
        The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="primaryServer")
    def primary_server(self) -> Optional[str]:
        """
        Primary server URL
        """
        return pulumi.get(self, "primary_server")

    @property
    @pulumi.getter(name="secondaryServer")
    def secondary_server(self) -> Optional[str]:
        """
        Secondary server URL
        """
        return pulumi.get(self, "secondary_server")

    @property
    @pulumi.getter
    def ssl(self) -> Optional[str]:
        """
        Protect LDAP communication using SSL certificate (LDAPS)
        """
        return pulumi.get(self, "ssl")

    @property
    @pulumi.getter
    def username(self) -> Optional[str]:
        """
        The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group
        """
        return pulumi.get(self, "username")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ManagementClusterResponse(dict):
    """
    The properties of a default cluster
    """
    def __init__(__self__, *,
                 cluster_id: int,
                 cluster_size: int,
                 hosts: Sequence[str]):
        """
        The properties of a default cluster
        :param int cluster_id: The identity
        :param int cluster_size: The cluster size
        :param Sequence[str] hosts: The hosts
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "cluster_size", cluster_size)
        pulumi.set(__self__, "hosts", hosts)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> int:
        """
        The identity
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="clusterSize")
    def cluster_size(self) -> int:
        """
        The cluster size
        """
        return pulumi.get(self, "cluster_size")

    @property
    @pulumi.getter
    def hosts(self) -> Sequence[str]:
        """
        The hosts
        """
        return pulumi.get(self, "hosts")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    """
    The resource model definition representing SKU
    """
    def __init__(__self__, *,
                 name: str):
        """
        The resource model definition representing SKU
        :param str name: The name of the SKU.
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the SKU.
        """
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

