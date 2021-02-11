# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['WebAppBackupConfigurationSlot']


class WebAppBackupConfigurationSlot(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_name: Optional[pulumi.Input[str]] = None,
                 backup_schedule: Optional[pulumi.Input[pulumi.InputType['BackupScheduleArgs']]] = None,
                 databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DatabaseBackupSettingArgs']]]]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 storage_account_url: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Description of a backup which will be performed.
        Latest API Version: 2020-09-01.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backup_name: Name of the backup.
        :param pulumi.Input[pulumi.InputType['BackupScheduleArgs']] backup_schedule: Schedule for the backup if it is executed periodically.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DatabaseBackupSettingArgs']]]] databases: Databases included in the backup.
        :param pulumi.Input[bool] enabled: True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
        :param pulumi.Input[str] kind: Kind of resource.
        :param pulumi.Input[str] name: Name of the app.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[str] slot: Name of the deployment slot. If a slot is not specified, the API will update the backup configuration for the production slot.
        :param pulumi.Input[str] storage_account_url: SAS URL to the container.
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

            __props__['backup_name'] = backup_name
            __props__['backup_schedule'] = backup_schedule
            __props__['databases'] = databases
            __props__['enabled'] = enabled
            __props__['kind'] = kind
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if slot is None and not opts.urn:
                raise TypeError("Missing required property 'slot'")
            __props__['slot'] = slot
            if storage_account_url is None and not opts.urn:
                raise TypeError("Missing required property 'storage_account_url'")
            __props__['storage_account_url'] = storage_account_url
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/v20150801:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20160801:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20180201:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20181101:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20190801:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200601:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200901:WebAppBackupConfigurationSlot"), pulumi.Alias(type_="azure-nextgen:web/v20201001:WebAppBackupConfigurationSlot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WebAppBackupConfigurationSlot, __self__).__init__(
            'azure-nextgen:web/latest:WebAppBackupConfigurationSlot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WebAppBackupConfigurationSlot':
        """
        Get an existing WebAppBackupConfigurationSlot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return WebAppBackupConfigurationSlot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupName")
    def backup_name(self) -> pulumi.Output[Optional[str]]:
        """
        Name of the backup.
        """
        return pulumi.get(self, "backup_name")

    @property
    @pulumi.getter(name="backupSchedule")
    def backup_schedule(self) -> pulumi.Output[Optional['outputs.BackupScheduleResponse']]:
        """
        Schedule for the backup if it is executed periodically.
        """
        return pulumi.get(self, "backup_schedule")

    @property
    @pulumi.getter
    def databases(self) -> pulumi.Output[Optional[Sequence['outputs.DatabaseBackupSettingResponse']]]:
        """
        Databases included in the backup.
        """
        return pulumi.get(self, "databases")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="storageAccountUrl")
    def storage_account_url(self) -> pulumi.Output[str]:
        """
        SAS URL to the container.
        """
        return pulumi.get(self, "storage_account_url")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

