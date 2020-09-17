# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ApplicationPackageResponse',
    'AutoStoragePropertiesResponse',
]

@pulumi.output_type
class ApplicationPackageResponse(dict):
    """
    An application package which represents a particular version of an application.
    """
    def __init__(__self__, *,
                 format: Optional[str] = None,
                 id: Optional[str] = None,
                 last_activation_time: Optional[str] = None,
                 state: Optional[str] = None,
                 storage_url: Optional[str] = None,
                 storage_url_expiry: Optional[str] = None,
                 version: Optional[str] = None):
        """
        An application package which represents a particular version of an application.
        :param str format: The format of the application package, if the package is active.
        :param str id: The ID of the application.
        :param str last_activation_time: The time at which the package was last activated, if the package is active.
        :param str state: The current state of the application package.
        :param str storage_url: The storage URL at which the application package is stored.
        :param str storage_url_expiry: The UTC time at which the storage URL will expire.
        :param str version: The version of the application package. 
        """
        if format is not None:
            pulumi.set(__self__, "format", format)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if last_activation_time is not None:
            pulumi.set(__self__, "last_activation_time", last_activation_time)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if storage_url is not None:
            pulumi.set(__self__, "storage_url", storage_url)
        if storage_url_expiry is not None:
            pulumi.set(__self__, "storage_url_expiry", storage_url_expiry)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def format(self) -> Optional[str]:
        """
        The format of the application package, if the package is active.
        """
        return pulumi.get(self, "format")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ID of the application.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="lastActivationTime")
    def last_activation_time(self) -> Optional[str]:
        """
        The time at which the package was last activated, if the package is active.
        """
        return pulumi.get(self, "last_activation_time")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        """
        The current state of the application package.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="storageUrl")
    def storage_url(self) -> Optional[str]:
        """
        The storage URL at which the application package is stored.
        """
        return pulumi.get(self, "storage_url")

    @property
    @pulumi.getter(name="storageUrlExpiry")
    def storage_url_expiry(self) -> Optional[str]:
        """
        The UTC time at which the storage URL will expire.
        """
        return pulumi.get(self, "storage_url_expiry")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        The version of the application package. 
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AutoStoragePropertiesResponse(dict):
    """
    Contains information about the auto storage account associated with a Batch account.
    """
    def __init__(__self__, *,
                 last_key_sync: str,
                 storage_account_id: str):
        """
        Contains information about the auto storage account associated with a Batch account.
        :param str last_key_sync: The UTC time at which storage keys were last synchronized with the Batch account.
        :param str storage_account_id: The resource ID of the storage account to be used for auto storage account.
        """
        pulumi.set(__self__, "last_key_sync", last_key_sync)
        pulumi.set(__self__, "storage_account_id", storage_account_id)

    @property
    @pulumi.getter(name="lastKeySync")
    def last_key_sync(self) -> str:
        """
        The UTC time at which storage keys were last synchronized with the Batch account.
        """
        return pulumi.get(self, "last_key_sync")

    @property
    @pulumi.getter(name="storageAccountId")
    def storage_account_id(self) -> str:
        """
        The resource ID of the storage account to be used for auto storage account.
        """
        return pulumi.get(self, "storage_account_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

