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

__all__ = ['Cluster']


class Cluster(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 enable_disk_encryption: Optional[pulumi.Input[bool]] = None,
                 enable_purge: Optional[pulumi.Input[bool]] = None,
                 enable_streaming_ingest: Optional[pulumi.Input[bool]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['IdentityArgs']]] = None,
                 key_vault_properties: Optional[pulumi.Input[pulumi.InputType['KeyVaultPropertiesArgs']]] = None,
                 language_extensions: Optional[pulumi.Input[pulumi.InputType['LanguageExtensionsListArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 optimized_autoscale: Optional[pulumi.Input[pulumi.InputType['OptimizedAutoscaleArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['AzureSkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 trusted_external_tenants: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrustedExternalTenantArgs']]]]] = None,
                 virtual_network_configuration: Optional[pulumi.Input[pulumi.InputType['VirtualNetworkConfigurationArgs']]] = None,
                 zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Class representing a Kusto cluster.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_name: The name of the Kusto cluster.
        :param pulumi.Input[bool] enable_disk_encryption: A boolean value that indicates if the cluster's disks are encrypted.
        :param pulumi.Input[bool] enable_purge: A boolean value that indicates if the purge operations are enabled.
        :param pulumi.Input[bool] enable_streaming_ingest: A boolean value that indicates if the streaming ingest is enabled.
        :param pulumi.Input[pulumi.InputType['IdentityArgs']] identity: The identity of the cluster, if configured.
        :param pulumi.Input[pulumi.InputType['KeyVaultPropertiesArgs']] key_vault_properties: KeyVault properties for the cluster encryption.
        :param pulumi.Input[pulumi.InputType['LanguageExtensionsListArgs']] language_extensions: List of the cluster's language extensions.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[pulumi.InputType['OptimizedAutoscaleArgs']] optimized_autoscale: Optimized auto scale definition.
        :param pulumi.Input[str] resource_group_name: The name of the resource group containing the Kusto cluster.
        :param pulumi.Input[pulumi.InputType['AzureSkuArgs']] sku: The SKU of the cluster.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrustedExternalTenantArgs']]]] trusted_external_tenants: The cluster's external tenants.
        :param pulumi.Input[pulumi.InputType['VirtualNetworkConfigurationArgs']] virtual_network_configuration: Virtual network definition.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] zones: The availability zones of the cluster.
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

            if cluster_name is None:
                raise TypeError("Missing required property 'cluster_name'")
            __props__['cluster_name'] = cluster_name
            __props__['enable_disk_encryption'] = enable_disk_encryption
            __props__['enable_purge'] = enable_purge
            __props__['enable_streaming_ingest'] = enable_streaming_ingest
            __props__['identity'] = identity
            __props__['key_vault_properties'] = key_vault_properties
            __props__['language_extensions'] = language_extensions
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['optimized_autoscale'] = optimized_autoscale
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku is None:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['trusted_external_tenants'] = trusted_external_tenants
            __props__['virtual_network_configuration'] = virtual_network_configuration
            __props__['zones'] = zones
            __props__['data_ingestion_uri'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['state'] = None
            __props__['state_reason'] = None
            __props__['type'] = None
            __props__['uri'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:kusto/latest:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20170907privatepreview:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20180907preview:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20190121:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20190515:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20190907:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20191109:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20200614:Cluster"), pulumi.Alias(type_="azure-nextgen:kusto/v20200918:Cluster")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Cluster, __self__).__init__(
            'azure-nextgen:kusto/v20200215:Cluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Cluster':
        """
        Get an existing Cluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Cluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dataIngestionUri")
    def data_ingestion_uri(self) -> pulumi.Output[str]:
        """
        The cluster data ingestion URI.
        """
        return pulumi.get(self, "data_ingestion_uri")

    @property
    @pulumi.getter(name="enableDiskEncryption")
    def enable_disk_encryption(self) -> pulumi.Output[Optional[bool]]:
        """
        A boolean value that indicates if the cluster's disks are encrypted.
        """
        return pulumi.get(self, "enable_disk_encryption")

    @property
    @pulumi.getter(name="enablePurge")
    def enable_purge(self) -> pulumi.Output[Optional[bool]]:
        """
        A boolean value that indicates if the purge operations are enabled.
        """
        return pulumi.get(self, "enable_purge")

    @property
    @pulumi.getter(name="enableStreamingIngest")
    def enable_streaming_ingest(self) -> pulumi.Output[Optional[bool]]:
        """
        A boolean value that indicates if the streaming ingest is enabled.
        """
        return pulumi.get(self, "enable_streaming_ingest")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.IdentityResponse']]:
        """
        The identity of the cluster, if configured.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter(name="keyVaultProperties")
    def key_vault_properties(self) -> pulumi.Output[Optional['outputs.KeyVaultPropertiesResponse']]:
        """
        KeyVault properties for the cluster encryption.
        """
        return pulumi.get(self, "key_vault_properties")

    @property
    @pulumi.getter(name="languageExtensions")
    def language_extensions(self) -> pulumi.Output[Optional['outputs.LanguageExtensionsListResponse']]:
        """
        List of the cluster's language extensions.
        """
        return pulumi.get(self, "language_extensions")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="optimizedAutoscale")
    def optimized_autoscale(self) -> pulumi.Output[Optional['outputs.OptimizedAutoscaleResponse']]:
        """
        Optimized auto scale definition.
        """
        return pulumi.get(self, "optimized_autoscale")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioned state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.AzureSkuResponse']:
        """
        The SKU of the cluster.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The state of the resource.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="stateReason")
    def state_reason(self) -> pulumi.Output[str]:
        """
        The reason for the cluster's current state.
        """
        return pulumi.get(self, "state_reason")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="trustedExternalTenants")
    def trusted_external_tenants(self) -> pulumi.Output[Optional[Sequence['outputs.TrustedExternalTenantResponse']]]:
        """
        The cluster's external tenants.
        """
        return pulumi.get(self, "trusted_external_tenants")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def uri(self) -> pulumi.Output[str]:
        """
        The cluster URI.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter(name="virtualNetworkConfiguration")
    def virtual_network_configuration(self) -> pulumi.Output[Optional['outputs.VirtualNetworkConfigurationResponse']]:
        """
        Virtual network definition.
        """
        return pulumi.get(self, "virtual_network_configuration")

    @property
    @pulumi.getter
    def zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The availability zones of the cluster.
        """
        return pulumi.get(self, "zones")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

