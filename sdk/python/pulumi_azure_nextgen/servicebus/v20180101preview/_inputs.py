# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ConnectionStateArgs',
    'EncryptionArgs',
    'KeyVaultPropertiesArgs',
    'PrivateEndpointArgs',
    'SBSkuArgs',
]

@pulumi.input_type
class ConnectionStateArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        ConnectionState information.
        :param pulumi.Input[str] description: Description of the connection state.
        :param pulumi.Input[str] status: Status of the connection.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the connection state.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of the connection.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class EncryptionArgs:
    def __init__(__self__, *,
                 key_source: Optional[pulumi.Input[str]] = None,
                 key_vault_properties: Optional[pulumi.Input['KeyVaultPropertiesArgs']] = None):
        """
        Properties to configure Encryption
        :param pulumi.Input[str] key_source: Enumerates the possible value of keySource for Encryption
        :param pulumi.Input['KeyVaultPropertiesArgs'] key_vault_properties: Properties of KeyVault
        """
        if key_source is not None:
            pulumi.set(__self__, "key_source", key_source)
        if key_vault_properties is not None:
            pulumi.set(__self__, "key_vault_properties", key_vault_properties)

    @property
    @pulumi.getter(name="keySource")
    def key_source(self) -> Optional[pulumi.Input[str]]:
        """
        Enumerates the possible value of keySource for Encryption
        """
        return pulumi.get(self, "key_source")

    @key_source.setter
    def key_source(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_source", value)

    @property
    @pulumi.getter(name="keyVaultProperties")
    def key_vault_properties(self) -> Optional[pulumi.Input['KeyVaultPropertiesArgs']]:
        """
        Properties of KeyVault
        """
        return pulumi.get(self, "key_vault_properties")

    @key_vault_properties.setter
    def key_vault_properties(self, value: Optional[pulumi.Input['KeyVaultPropertiesArgs']]):
        pulumi.set(self, "key_vault_properties", value)


@pulumi.input_type
class KeyVaultPropertiesArgs:
    def __init__(__self__, *,
                 key_name: Optional[pulumi.Input[str]] = None,
                 key_vault_uri: Optional[pulumi.Input[str]] = None):
        """
        Properties to configure keyVault Properties
        :param pulumi.Input[str] key_name: Name of the Key from KeyVault
        :param pulumi.Input[str] key_vault_uri: Uri of KeyVault
        """
        if key_name is not None:
            pulumi.set(__self__, "key_name", key_name)
        if key_vault_uri is not None:
            pulumi.set(__self__, "key_vault_uri", key_vault_uri)

    @property
    @pulumi.getter(name="keyName")
    def key_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Key from KeyVault
        """
        return pulumi.get(self, "key_name")

    @key_name.setter
    def key_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_name", value)

    @property
    @pulumi.getter(name="keyVaultUri")
    def key_vault_uri(self) -> Optional[pulumi.Input[str]]:
        """
        Uri of KeyVault
        """
        return pulumi.get(self, "key_vault_uri")

    @key_vault_uri.setter
    def key_vault_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_vault_uri", value)


@pulumi.input_type
class PrivateEndpointArgs:
    def __init__(__self__, *,
                 id: Optional[pulumi.Input[str]] = None):
        """
        PrivateEndpoint information.
        :param pulumi.Input[str] id: The ARM identifier for Private Endpoint.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ARM identifier for Private Endpoint.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class SBSkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 capacity: Optional[pulumi.Input[int]] = None,
                 tier: Optional[pulumi.Input[str]] = None):
        """
        SKU of the namespace.
        :param pulumi.Input[str] name: Name of this SKU.
        :param pulumi.Input[int] capacity: The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4.
        :param pulumi.Input[str] tier: The billing tier of this particular SKU.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Name of this SKU.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[pulumi.Input[int]]:
        """
        The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4.
        """
        return pulumi.get(self, "capacity")

    @capacity.setter
    def capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "capacity", value)

    @property
    @pulumi.getter
    def tier(self) -> Optional[pulumi.Input[str]]:
        """
        The billing tier of this particular SKU.
        """
        return pulumi.get(self, "tier")

    @tier.setter
    def tier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tier", value)

