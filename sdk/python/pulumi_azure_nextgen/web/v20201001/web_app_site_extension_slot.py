# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = ['WebAppSiteExtensionSlot']


class WebAppSiteExtensionSlot(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 site_extension_id: Optional[pulumi.Input[str]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Site Extension Information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: Site name.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[str] site_extension_id: Site extension name.
        :param pulumi.Input[str] slot: Name of the deployment slot. If a slot is not specified, the API uses the production slot.
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

            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if site_extension_id is None and not opts.urn:
                raise TypeError("Missing required property 'site_extension_id'")
            __props__['site_extension_id'] = site_extension_id
            if slot is None and not opts.urn:
                raise TypeError("Missing required property 'slot'")
            __props__['slot'] = slot
            __props__['authors'] = None
            __props__['comment'] = None
            __props__['description'] = None
            __props__['download_count'] = None
            __props__['extension_id'] = None
            __props__['extension_type'] = None
            __props__['extension_url'] = None
            __props__['feed_url'] = None
            __props__['icon_url'] = None
            __props__['installed_date_time'] = None
            __props__['installer_command_line_params'] = None
            __props__['kind'] = None
            __props__['license_url'] = None
            __props__['local_is_latest_version'] = None
            __props__['local_path'] = None
            __props__['project_url'] = None
            __props__['provisioning_state'] = None
            __props__['published_date_time'] = None
            __props__['summary'] = None
            __props__['system_data'] = None
            __props__['title'] = None
            __props__['type'] = None
            __props__['version'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/latest:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20160801:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20180201:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20181101:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20190801:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200601:WebAppSiteExtensionSlot"), pulumi.Alias(type_="azure-nextgen:web/v20200901:WebAppSiteExtensionSlot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WebAppSiteExtensionSlot, __self__).__init__(
            'azure-nextgen:web/v20201001:WebAppSiteExtensionSlot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WebAppSiteExtensionSlot':
        """
        Get an existing WebAppSiteExtensionSlot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return WebAppSiteExtensionSlot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def authors(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        List of authors.
        """
        return pulumi.get(self, "authors")

    @property
    @pulumi.getter
    def comment(self) -> pulumi.Output[Optional[str]]:
        """
        Site Extension comment.
        """
        return pulumi.get(self, "comment")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Detailed description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="downloadCount")
    def download_count(self) -> pulumi.Output[Optional[int]]:
        """
        Count of downloads.
        """
        return pulumi.get(self, "download_count")

    @property
    @pulumi.getter(name="extensionId")
    def extension_id(self) -> pulumi.Output[Optional[str]]:
        """
        Site extension ID.
        """
        return pulumi.get(self, "extension_id")

    @property
    @pulumi.getter(name="extensionType")
    def extension_type(self) -> pulumi.Output[Optional[str]]:
        """
        Site extension type.
        """
        return pulumi.get(self, "extension_type")

    @property
    @pulumi.getter(name="extensionUrl")
    def extension_url(self) -> pulumi.Output[Optional[str]]:
        """
        Extension URL.
        """
        return pulumi.get(self, "extension_url")

    @property
    @pulumi.getter(name="feedUrl")
    def feed_url(self) -> pulumi.Output[Optional[str]]:
        """
        Feed URL.
        """
        return pulumi.get(self, "feed_url")

    @property
    @pulumi.getter(name="iconUrl")
    def icon_url(self) -> pulumi.Output[Optional[str]]:
        """
        Icon URL.
        """
        return pulumi.get(self, "icon_url")

    @property
    @pulumi.getter(name="installedDateTime")
    def installed_date_time(self) -> pulumi.Output[Optional[str]]:
        """
        Installed timestamp.
        """
        return pulumi.get(self, "installed_date_time")

    @property
    @pulumi.getter(name="installerCommandLineParams")
    def installer_command_line_params(self) -> pulumi.Output[Optional[str]]:
        """
        Installer command line parameters.
        """
        return pulumi.get(self, "installer_command_line_params")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="licenseUrl")
    def license_url(self) -> pulumi.Output[Optional[str]]:
        """
        License URL.
        """
        return pulumi.get(self, "license_url")

    @property
    @pulumi.getter(name="localIsLatestVersion")
    def local_is_latest_version(self) -> pulumi.Output[Optional[bool]]:
        """
        <code>true</code> if the local version is the latest version; <code>false</code> otherwise.
        """
        return pulumi.get(self, "local_is_latest_version")

    @property
    @pulumi.getter(name="localPath")
    def local_path(self) -> pulumi.Output[Optional[str]]:
        """
        Local path.
        """
        return pulumi.get(self, "local_path")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="projectUrl")
    def project_url(self) -> pulumi.Output[Optional[str]]:
        """
        Project URL.
        """
        return pulumi.get(self, "project_url")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        Provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publishedDateTime")
    def published_date_time(self) -> pulumi.Output[Optional[str]]:
        """
        Published timestamp.
        """
        return pulumi.get(self, "published_date_time")

    @property
    @pulumi.getter
    def summary(self) -> pulumi.Output[Optional[str]]:
        """
        Summary description.
        """
        return pulumi.get(self, "summary")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[Optional[str]]:
        """
        Version information.
        """
        return pulumi.get(self, "version")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

