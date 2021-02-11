# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = ['SiteHostNameBindingSlot']


class SiteHostNameBindingSlot(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 azure_resource_name: Optional[pulumi.Input[str]] = None,
                 azure_resource_type: Optional[pulumi.Input['AzureResourceType']] = None,
                 custom_host_name_dns_record_type: Optional[pulumi.Input['CustomHostNameDnsRecordType']] = None,
                 domain_id: Optional[pulumi.Input[str]] = None,
                 host_name: Optional[pulumi.Input[str]] = None,
                 host_name_type: Optional[pulumi.Input['HostNameType']] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 site_name: Optional[pulumi.Input[str]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A host name binding object

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] azure_resource_name: Azure resource name
        :param pulumi.Input['AzureResourceType'] azure_resource_type: Azure resource type
        :param pulumi.Input['CustomHostNameDnsRecordType'] custom_host_name_dns_record_type: Custom DNS record type
        :param pulumi.Input[str] domain_id: Fully qualified ARM domain resource URI
        :param pulumi.Input[str] host_name: Name of host
        :param pulumi.Input['HostNameType'] host_name_type: Host name type
        :param pulumi.Input[str] id: Resource Id
        :param pulumi.Input[str] kind: Kind of resource
        :param pulumi.Input[str] location: Resource Location
        :param pulumi.Input[str] name: Resource Name
        :param pulumi.Input[str] resource_group_name: Name of resource group
        :param pulumi.Input[str] site_name: Web app name
        :param pulumi.Input[str] slot: Name of web app slot. If not specified then will default to production slot.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[str] type: Resource type
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

            __props__['azure_resource_name'] = azure_resource_name
            __props__['azure_resource_type'] = azure_resource_type
            __props__['custom_host_name_dns_record_type'] = custom_host_name_dns_record_type
            __props__['domain_id'] = domain_id
            if host_name is None and not opts.urn:
                raise TypeError("Missing required property 'host_name'")
            __props__['host_name'] = host_name
            __props__['host_name_type'] = host_name_type
            __props__['id'] = id
            __props__['kind'] = kind
            __props__['location'] = location
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['site_name'] = site_name
            if slot is None and not opts.urn:
                raise TypeError("Missing required property 'slot'")
            __props__['slot'] = slot
            __props__['tags'] = tags
            __props__['type'] = type
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/latest:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20160801:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20180201:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20181101:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20190801:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200601:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200901:SiteHostNameBindingSlot"), pulumi.Alias(type_="azure-nextgen:web/v20201001:SiteHostNameBindingSlot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(SiteHostNameBindingSlot, __self__).__init__(
            'azure-nextgen:web/v20150801:SiteHostNameBindingSlot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'SiteHostNameBindingSlot':
        """
        Get an existing SiteHostNameBindingSlot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return SiteHostNameBindingSlot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="azureResourceName")
    def azure_resource_name(self) -> pulumi.Output[Optional[str]]:
        """
        Azure resource name
        """
        return pulumi.get(self, "azure_resource_name")

    @property
    @pulumi.getter(name="azureResourceType")
    def azure_resource_type(self) -> pulumi.Output[Optional[str]]:
        """
        Azure resource type
        """
        return pulumi.get(self, "azure_resource_type")

    @property
    @pulumi.getter(name="customHostNameDnsRecordType")
    def custom_host_name_dns_record_type(self) -> pulumi.Output[Optional[str]]:
        """
        Custom DNS record type
        """
        return pulumi.get(self, "custom_host_name_dns_record_type")

    @property
    @pulumi.getter(name="domainId")
    def domain_id(self) -> pulumi.Output[Optional[str]]:
        """
        Fully qualified ARM domain resource URI
        """
        return pulumi.get(self, "domain_id")

    @property
    @pulumi.getter(name="hostNameType")
    def host_name_type(self) -> pulumi.Output[Optional[str]]:
        """
        Host name type
        """
        return pulumi.get(self, "host_name_type")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="siteName")
    def site_name(self) -> pulumi.Output[Optional[str]]:
        """
        Web app name
        """
        return pulumi.get(self, "site_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

