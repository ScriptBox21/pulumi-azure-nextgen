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

__all__ = ['SnapshotPolicy']


class SnapshotPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 daily_schedule: Optional[pulumi.Input[pulumi.InputType['DailyScheduleArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 hourly_schedule: Optional[pulumi.Input[pulumi.InputType['HourlyScheduleArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 monthly_schedule: Optional[pulumi.Input[pulumi.InputType['MonthlyScheduleArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 snapshot_policy_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 weekly_schedule: Optional[pulumi.Input[pulumi.InputType['WeeklyScheduleArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Snapshot policy information

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the NetApp account
        :param pulumi.Input[pulumi.InputType['DailyScheduleArgs']] daily_schedule: Schedule for daily snapshots
        :param pulumi.Input[bool] enabled: The property to decide policy is enabled or not
        :param pulumi.Input[pulumi.InputType['HourlyScheduleArgs']] hourly_schedule: Schedule for hourly snapshots
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[pulumi.InputType['MonthlyScheduleArgs']] monthly_schedule: Schedule for monthly snapshots
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] snapshot_policy_name: The name of the snapshot policy target
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[pulumi.InputType['WeeklyScheduleArgs']] weekly_schedule: Schedule for weekly snapshots
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

            if account_name is None and not opts.urn:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            __props__['daily_schedule'] = daily_schedule
            __props__['enabled'] = enabled
            __props__['hourly_schedule'] = hourly_schedule
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['monthly_schedule'] = monthly_schedule
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if snapshot_policy_name is None and not opts.urn:
                raise TypeError("Missing required property 'snapshot_policy_name'")
            __props__['snapshot_policy_name'] = snapshot_policy_name
            __props__['tags'] = tags
            __props__['weekly_schedule'] = weekly_schedule
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:netapp/latest:SnapshotPolicy"), pulumi.Alias(type_="azure-nextgen:netapp/v20200501:SnapshotPolicy"), pulumi.Alias(type_="azure-nextgen:netapp/v20200701:SnapshotPolicy"), pulumi.Alias(type_="azure-nextgen:netapp/v20200801:SnapshotPolicy"), pulumi.Alias(type_="azure-nextgen:netapp/v20200901:SnapshotPolicy"), pulumi.Alias(type_="azure-nextgen:netapp/v20201101:SnapshotPolicy")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(SnapshotPolicy, __self__).__init__(
            'azure-nextgen:netapp/v20200601:SnapshotPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'SnapshotPolicy':
        """
        Get an existing SnapshotPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return SnapshotPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dailySchedule")
    def daily_schedule(self) -> pulumi.Output[Optional['outputs.DailyScheduleResponse']]:
        """
        Schedule for daily snapshots
        """
        return pulumi.get(self, "daily_schedule")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        The property to decide policy is enabled or not
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="hourlySchedule")
    def hourly_schedule(self) -> pulumi.Output[Optional['outputs.HourlyScheduleResponse']]:
        """
        Schedule for hourly snapshots
        """
        return pulumi.get(self, "hourly_schedule")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="monthlySchedule")
    def monthly_schedule(self) -> pulumi.Output[Optional['outputs.MonthlyScheduleResponse']]:
        """
        Schedule for monthly snapshots
        """
        return pulumi.get(self, "monthly_schedule")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Snapshot policy name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Azure lifecycle management
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="weeklySchedule")
    def weekly_schedule(self) -> pulumi.Output[Optional['outputs.WeeklyScheduleResponse']]:
        """
        Schedule for weekly snapshots
        """
        return pulumi.get(self, "weekly_schedule")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

