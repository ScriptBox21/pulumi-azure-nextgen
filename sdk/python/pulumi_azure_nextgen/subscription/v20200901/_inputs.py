# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'PutAliasRequestPropertiesArgs',
]

@pulumi.input_type
class PutAliasRequestPropertiesArgs:
    def __init__(__self__, *,
                 billing_scope: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 reseller_id: Optional[pulumi.Input[str]] = None,
                 subscription_id: Optional[pulumi.Input[str]] = None,
                 workload: Optional[pulumi.Input[str]] = None):
        """
        Put subscription properties.
        :param pulumi.Input[str] billing_scope: Determines whether subscription is fieldLed, partnerLed or LegacyEA
        :param pulumi.Input[str] display_name: The friendly name of the subscription.
        :param pulumi.Input[str] reseller_id: Reseller ID, basically MPN Id
        :param pulumi.Input[str] subscription_id: This parameter can be used to create alias for existing subscription Id
        :param pulumi.Input[str] workload: The workload type of the subscription. It can be either Production or DevTest.
        """
        if billing_scope is not None:
            pulumi.set(__self__, "billing_scope", billing_scope)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if reseller_id is not None:
            pulumi.set(__self__, "reseller_id", reseller_id)
        if subscription_id is not None:
            pulumi.set(__self__, "subscription_id", subscription_id)
        if workload is not None:
            pulumi.set(__self__, "workload", workload)

    @property
    @pulumi.getter(name="billingScope")
    def billing_scope(self) -> Optional[pulumi.Input[str]]:
        """
        Determines whether subscription is fieldLed, partnerLed or LegacyEA
        """
        return pulumi.get(self, "billing_scope")

    @billing_scope.setter
    def billing_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "billing_scope", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        The friendly name of the subscription.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="resellerId")
    def reseller_id(self) -> Optional[pulumi.Input[str]]:
        """
        Reseller ID, basically MPN Id
        """
        return pulumi.get(self, "reseller_id")

    @reseller_id.setter
    def reseller_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "reseller_id", value)

    @property
    @pulumi.getter(name="subscriptionId")
    def subscription_id(self) -> Optional[pulumi.Input[str]]:
        """
        This parameter can be used to create alias for existing subscription Id
        """
        return pulumi.get(self, "subscription_id")

    @subscription_id.setter
    def subscription_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subscription_id", value)

    @property
    @pulumi.getter
    def workload(self) -> Optional[pulumi.Input[str]]:
        """
        The workload type of the subscription. It can be either Production or DevTest.
        """
        return pulumi.get(self, "workload")

    @workload.setter
    def workload(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "workload", value)


