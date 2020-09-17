# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'DeepCreatedOriginResponse',
    'SkuResponse',
]

@pulumi.output_type
class DeepCreatedOriginResponse(dict):
    """
    Deep created origins within a CDN endpoint.
    """
    def __init__(__self__, *,
                 host_name: str,
                 name: str,
                 http_port: Optional[int] = None,
                 https_port: Optional[int] = None):
        """
        Deep created origins within a CDN endpoint.
        :param str host_name: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        :param str name: Origin name
        :param int http_port: The value of the HTTP port. Must be between 1 and 65535
        :param int https_port: The value of the HTTPS port. Must be between 1 and 65535
        """
        pulumi.set(__self__, "host_name", host_name)
        pulumi.set(__self__, "name", name)
        if http_port is not None:
            pulumi.set(__self__, "http_port", http_port)
        if https_port is not None:
            pulumi.set(__self__, "https_port", https_port)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> str:
        """
        The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Origin name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="httpPort")
    def http_port(self) -> Optional[int]:
        """
        The value of the HTTP port. Must be between 1 and 65535
        """
        return pulumi.get(self, "http_port")

    @property
    @pulumi.getter(name="httpsPort")
    def https_port(self) -> Optional[int]:
        """
        The value of the HTTPS port. Must be between 1 and 65535
        """
        return pulumi.get(self, "https_port")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    """
    The SKU (pricing tier) of the CDN profile.
    """
    def __init__(__self__, *,
                 name: Optional[str] = None):
        """
        The SKU (pricing tier) of the CDN profile.
        :param str name: Name of the pricing tier
        """
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the pricing tier
        """
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

