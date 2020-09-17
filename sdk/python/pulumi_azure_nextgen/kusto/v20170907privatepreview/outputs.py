# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AzureSkuResponse',
    'DatabasePrincipalResponseResult',
    'DatabaseStatisticsResponse',
    'TrustedExternalTenantResponse',
]

@pulumi.output_type
class AzureSkuResponse(dict):
    def __init__(__self__, *,
                 name: str,
                 tier: str,
                 capacity: Optional[int] = None):
        """
        :param str name: SKU name.
        :param str tier: SKU tier.
        :param int capacity: SKU capacity.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "tier", tier)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        SKU name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tier(self) -> str:
        """
        SKU tier.
        """
        return pulumi.get(self, "tier")

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        SKU capacity.
        """
        return pulumi.get(self, "capacity")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DatabasePrincipalResponseResult(dict):
    def __init__(__self__, *,
                 name: str,
                 role: str,
                 type: str,
                 app_id: Optional[str] = None,
                 email: Optional[str] = None,
                 fqn: Optional[str] = None):
        """
        :param str name: Database principal name.
        :param str role: Database principal role.
        :param str type: Database principal type.
        :param str app_id: Application id - relevant only for application principal type.
        :param str email: Database principal email if exists.
        :param str fqn: Database principal fully qualified name.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "role", role)
        pulumi.set(__self__, "type", type)
        if app_id is not None:
            pulumi.set(__self__, "app_id", app_id)
        if email is not None:
            pulumi.set(__self__, "email", email)
        if fqn is not None:
            pulumi.set(__self__, "fqn", fqn)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Database principal name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def role(self) -> str:
        """
        Database principal role.
        """
        return pulumi.get(self, "role")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Database principal type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="appId")
    def app_id(self) -> Optional[str]:
        """
        Application id - relevant only for application principal type.
        """
        return pulumi.get(self, "app_id")

    @property
    @pulumi.getter
    def email(self) -> Optional[str]:
        """
        Database principal email if exists.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter
    def fqn(self) -> Optional[str]:
        """
        Database principal fully qualified name.
        """
        return pulumi.get(self, "fqn")


@pulumi.output_type
class DatabaseStatisticsResponse(dict):
    def __init__(__self__, *,
                 size: Optional[float] = None):
        """
        :param float size: The database size - the total size of compressed data and index in bytes.
        """
        if size is not None:
            pulumi.set(__self__, "size", size)

    @property
    @pulumi.getter
    def size(self) -> Optional[float]:
        """
        The database size - the total size of compressed data and index in bytes.
        """
        return pulumi.get(self, "size")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TrustedExternalTenantResponse(dict):
    def __init__(__self__, *,
                 value: Optional[str] = None):
        """
        :param str value: GUID representing an external tenant.
        """
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        GUID representing an external tenant.
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

