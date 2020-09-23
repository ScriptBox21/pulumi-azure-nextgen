# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetGlobalUserPersonalPreferencesResult',
    'AwaitableGetGlobalUserPersonalPreferencesResult',
    'get_global_user_personal_preferences',
]

@pulumi.output_type
class GetGlobalUserPersonalPreferencesResult:
    """
    Represents the PersonalPreferences for the user
    """
    def __init__(__self__, favorite_lab_resource_ids=None):
        if favorite_lab_resource_ids and not isinstance(favorite_lab_resource_ids, list):
            raise TypeError("Expected argument 'favorite_lab_resource_ids' to be a list")
        pulumi.set(__self__, "favorite_lab_resource_ids", favorite_lab_resource_ids)

    @property
    @pulumi.getter(name="favoriteLabResourceIds")
    def favorite_lab_resource_ids(self) -> Optional[Sequence[str]]:
        """
        Array of favorite lab resource ids
        """
        return pulumi.get(self, "favorite_lab_resource_ids")


class AwaitableGetGlobalUserPersonalPreferencesResult(GetGlobalUserPersonalPreferencesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGlobalUserPersonalPreferencesResult(
            favorite_lab_resource_ids=self.favorite_lab_resource_ids)


def get_global_user_personal_preferences(add_remove: Optional[str] = None,
                                         lab_account_resource_id: Optional[str] = None,
                                         lab_resource_id: Optional[str] = None,
                                         user_name: Optional[str] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGlobalUserPersonalPreferencesResult:
    """
    Use this data source to access information about an existing resource.

    :param str add_remove: Enum indicating if user is adding or removing a favorite lab
    :param str lab_account_resource_id: Resource Id of the lab account
    :param str lab_resource_id: Resource Id of the lab to add/remove from the favorites list
    :param str user_name: The name of the user.
    """
    __args__ = dict()
    __args__['addRemove'] = add_remove
    __args__['labAccountResourceId'] = lab_account_resource_id
    __args__['labResourceId'] = lab_resource_id
    __args__['userName'] = user_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:labservices/v20181015:getGlobalUserPersonalPreferences', __args__, opts=opts, typ=GetGlobalUserPersonalPreferencesResult).value

    return AwaitableGetGlobalUserPersonalPreferencesResult(
        favorite_lab_resource_ids=__ret__.favorite_lab_resource_ids)
