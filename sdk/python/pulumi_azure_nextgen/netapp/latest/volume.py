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

__all__ = ['Volume']


class Volume(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 backup_id: Optional[pulumi.Input[str]] = None,
                 creation_token: Optional[pulumi.Input[str]] = None,
                 data_protection: Optional[pulumi.Input[pulumi.InputType['VolumePropertiesDataProtectionArgs']]] = None,
                 encryption_key_source: Optional[pulumi.Input[str]] = None,
                 export_policy: Optional[pulumi.Input[pulumi.InputType['VolumePropertiesExportPolicyArgs']]] = None,
                 is_restoring: Optional[pulumi.Input[bool]] = None,
                 kerberos_enabled: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 pool_name: Optional[pulumi.Input[str]] = None,
                 protocol_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 security_style: Optional[pulumi.Input[Union[str, 'SecurityStyle']]] = None,
                 service_level: Optional[pulumi.Input[Union[str, 'ServiceLevel']]] = None,
                 smb_continuously_available: Optional[pulumi.Input[bool]] = None,
                 smb_encryption: Optional[pulumi.Input[bool]] = None,
                 snapshot_directory_visible: Optional[pulumi.Input[bool]] = None,
                 snapshot_id: Optional[pulumi.Input[str]] = None,
                 subnet_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 throughput_mibps: Optional[pulumi.Input[float]] = None,
                 usage_threshold: Optional[pulumi.Input[float]] = None,
                 volume_name: Optional[pulumi.Input[str]] = None,
                 volume_type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Volume resource
        Latest API Version: 2020-11-01.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the NetApp account
        :param pulumi.Input[str] backup_id: UUID v4 or resource identifier used to identify the Backup.
        :param pulumi.Input[str] creation_token: A unique file path for the volume. Used when creating mount targets
        :param pulumi.Input[pulumi.InputType['VolumePropertiesDataProtectionArgs']] data_protection: DataProtection type volumes include an object containing details of the replication
        :param pulumi.Input[str] encryption_key_source: Encryption Key Source. Possible values are: 'Microsoft.NetApp'
        :param pulumi.Input[pulumi.InputType['VolumePropertiesExportPolicyArgs']] export_policy: Set of export policy rules
        :param pulumi.Input[bool] is_restoring: Restoring
        :param pulumi.Input[bool] kerberos_enabled: Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[str] pool_name: The name of the capacity pool
        :param pulumi.Input[Sequence[pulumi.Input[str]]] protocol_types: Set of protocol types, default NFSv3, CIFS fro SMB protocol
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Union[str, 'SecurityStyle']] security_style: The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol
        :param pulumi.Input[Union[str, 'ServiceLevel']] service_level: The service level of the file system
        :param pulumi.Input[bool] smb_continuously_available: Enables continuously available share property for smb volume. Only applicable for SMB volume
        :param pulumi.Input[bool] smb_encryption: Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later
        :param pulumi.Input[bool] snapshot_directory_visible: If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots (default to true).
        :param pulumi.Input[str] snapshot_id: UUID v4 or resource identifier used to identify the Snapshot.
        :param pulumi.Input[str] subnet_id: The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[float] usage_threshold: Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        :param pulumi.Input[str] volume_name: The name of the volume
        :param pulumi.Input[str] volume_type: What type of volume is this
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
            __props__['backup_id'] = backup_id
            if creation_token is None and not opts.urn:
                raise TypeError("Missing required property 'creation_token'")
            __props__['creation_token'] = creation_token
            __props__['data_protection'] = data_protection
            __props__['encryption_key_source'] = encryption_key_source
            __props__['export_policy'] = export_policy
            __props__['is_restoring'] = is_restoring
            if kerberos_enabled is None:
                kerberos_enabled = False
            __props__['kerberos_enabled'] = kerberos_enabled
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            if pool_name is None and not opts.urn:
                raise TypeError("Missing required property 'pool_name'")
            __props__['pool_name'] = pool_name
            __props__['protocol_types'] = protocol_types
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if security_style is None:
                security_style = 'unix'
            __props__['security_style'] = security_style
            if service_level is None:
                service_level = 'Premium'
            __props__['service_level'] = service_level
            if smb_continuously_available is None:
                smb_continuously_available = False
            __props__['smb_continuously_available'] = smb_continuously_available
            if smb_encryption is None:
                smb_encryption = False
            __props__['smb_encryption'] = smb_encryption
            if snapshot_directory_visible is None:
                snapshot_directory_visible = True
            __props__['snapshot_directory_visible'] = snapshot_directory_visible
            __props__['snapshot_id'] = snapshot_id
            if subnet_id is None and not opts.urn:
                raise TypeError("Missing required property 'subnet_id'")
            __props__['subnet_id'] = subnet_id
            __props__['tags'] = tags
            if throughput_mibps is None:
                throughput_mibps = 0
            __props__['throughput_mibps'] = throughput_mibps
            if usage_threshold is None:
                usage_threshold = 107374182400
            if usage_threshold is None and not opts.urn:
                raise TypeError("Missing required property 'usage_threshold'")
            __props__['usage_threshold'] = usage_threshold
            if volume_name is None and not opts.urn:
                raise TypeError("Missing required property 'volume_name'")
            __props__['volume_name'] = volume_name
            __props__['volume_type'] = volume_type
            __props__['baremetal_tenant_id'] = None
            __props__['file_system_id'] = None
            __props__['mount_targets'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:netapp/v20170815:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20190501:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20190601:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20190701:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20190801:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20191001:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20191101:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200201:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200301:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200501:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200601:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200701:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200801:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20200901:Volume"), pulumi.Alias(type_="azure-nextgen:netapp/v20201101:Volume")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Volume, __self__).__init__(
            'azure-nextgen:netapp/latest:Volume',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Volume':
        """
        Get an existing Volume resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Volume(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupId")
    def backup_id(self) -> pulumi.Output[Optional[str]]:
        """
        UUID v4 or resource identifier used to identify the Backup.
        """
        return pulumi.get(self, "backup_id")

    @property
    @pulumi.getter(name="baremetalTenantId")
    def baremetal_tenant_id(self) -> pulumi.Output[str]:
        """
        Unique Baremetal Tenant Identifier.
        """
        return pulumi.get(self, "baremetal_tenant_id")

    @property
    @pulumi.getter(name="creationToken")
    def creation_token(self) -> pulumi.Output[str]:
        """
        A unique file path for the volume. Used when creating mount targets
        """
        return pulumi.get(self, "creation_token")

    @property
    @pulumi.getter(name="dataProtection")
    def data_protection(self) -> pulumi.Output[Optional['outputs.VolumePropertiesResponseDataProtection']]:
        """
        DataProtection type volumes include an object containing details of the replication
        """
        return pulumi.get(self, "data_protection")

    @property
    @pulumi.getter(name="encryptionKeySource")
    def encryption_key_source(self) -> pulumi.Output[Optional[str]]:
        """
        Encryption Key Source. Possible values are: 'Microsoft.NetApp'
        """
        return pulumi.get(self, "encryption_key_source")

    @property
    @pulumi.getter(name="exportPolicy")
    def export_policy(self) -> pulumi.Output[Optional['outputs.VolumePropertiesResponseExportPolicy']]:
        """
        Set of export policy rules
        """
        return pulumi.get(self, "export_policy")

    @property
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> pulumi.Output[str]:
        """
        Unique FileSystem Identifier.
        """
        return pulumi.get(self, "file_system_id")

    @property
    @pulumi.getter(name="isRestoring")
    def is_restoring(self) -> pulumi.Output[Optional[bool]]:
        """
        Restoring
        """
        return pulumi.get(self, "is_restoring")

    @property
    @pulumi.getter(name="kerberosEnabled")
    def kerberos_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later
        """
        return pulumi.get(self, "kerberos_enabled")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="mountTargets")
    def mount_targets(self) -> pulumi.Output[Sequence['outputs.MountTargetPropertiesResponse']]:
        """
        List of mount targets
        """
        return pulumi.get(self, "mount_targets")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="protocolTypes")
    def protocol_types(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Set of protocol types, default NFSv3, CIFS fro SMB protocol
        """
        return pulumi.get(self, "protocol_types")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Azure lifecycle management
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="securityStyle")
    def security_style(self) -> pulumi.Output[Optional[str]]:
        """
        The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol
        """
        return pulumi.get(self, "security_style")

    @property
    @pulumi.getter(name="serviceLevel")
    def service_level(self) -> pulumi.Output[Optional[str]]:
        """
        The service level of the file system
        """
        return pulumi.get(self, "service_level")

    @property
    @pulumi.getter(name="smbContinuouslyAvailable")
    def smb_continuously_available(self) -> pulumi.Output[Optional[bool]]:
        """
        Enables continuously available share property for smb volume. Only applicable for SMB volume
        """
        return pulumi.get(self, "smb_continuously_available")

    @property
    @pulumi.getter(name="smbEncryption")
    def smb_encryption(self) -> pulumi.Output[Optional[bool]]:
        """
        Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later
        """
        return pulumi.get(self, "smb_encryption")

    @property
    @pulumi.getter(name="snapshotDirectoryVisible")
    def snapshot_directory_visible(self) -> pulumi.Output[Optional[bool]]:
        """
        If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots (default to true).
        """
        return pulumi.get(self, "snapshot_directory_visible")

    @property
    @pulumi.getter(name="snapshotId")
    def snapshot_id(self) -> pulumi.Output[Optional[str]]:
        """
        UUID v4 or resource identifier used to identify the Snapshot.
        """
        return pulumi.get(self, "snapshot_id")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> pulumi.Output[str]:
        """
        The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="throughputMibps")
    def throughput_mibps(self) -> pulumi.Output[Optional[float]]:
        return pulumi.get(self, "throughput_mibps")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="usageThreshold")
    def usage_threshold(self) -> pulumi.Output[float]:
        """
        Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        """
        return pulumi.get(self, "usage_threshold")

    @property
    @pulumi.getter(name="volumeType")
    def volume_type(self) -> pulumi.Output[Optional[str]]:
        """
        What type of volume is this
        """
        return pulumi.get(self, "volume_type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

