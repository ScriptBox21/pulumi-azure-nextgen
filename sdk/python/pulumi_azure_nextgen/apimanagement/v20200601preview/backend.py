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

__all__ = ['Backend']


class Backend(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backend_id: Optional[pulumi.Input[str]] = None,
                 credentials: Optional[pulumi.Input[pulumi.InputType['BackendCredentialsContractArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 properties: Optional[pulumi.Input[pulumi.InputType['BackendPropertiesArgs']]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 proxy: Optional[pulumi.Input[pulumi.InputType['BackendProxyContractArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 service_name: Optional[pulumi.Input[str]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 tls: Optional[pulumi.Input[pulumi.InputType['BackendTlsPropertiesArgs']]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Backend details.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backend_id: Identifier of the Backend entity. Must be unique in the current API Management service instance.
        :param pulumi.Input[pulumi.InputType['BackendCredentialsContractArgs']] credentials: Backend Credentials Contract Properties
        :param pulumi.Input[str] description: Backend Description.
        :param pulumi.Input[pulumi.InputType['BackendPropertiesArgs']] properties: Backend Properties contract
        :param pulumi.Input[str] protocol: Backend communication protocol.
        :param pulumi.Input[pulumi.InputType['BackendProxyContractArgs']] proxy: Backend Proxy Contract Properties
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] resource_id: Management Uri of the Resource in External System. This url can be the Arm Resource Id of Logic Apps, Function Apps or Api Apps.
        :param pulumi.Input[str] service_name: The name of the API Management service.
        :param pulumi.Input[str] title: Backend Title.
        :param pulumi.Input[pulumi.InputType['BackendTlsPropertiesArgs']] tls: Backend TLS Properties
        :param pulumi.Input[str] url: Runtime Url of the Backend.
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

            if backend_id is None:
                raise TypeError("Missing required property 'backend_id'")
            __props__['backend_id'] = backend_id
            __props__['credentials'] = credentials
            __props__['description'] = description
            __props__['properties'] = properties
            if protocol is None:
                raise TypeError("Missing required property 'protocol'")
            __props__['protocol'] = protocol
            __props__['proxy'] = proxy
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['resource_id'] = resource_id
            if service_name is None:
                raise TypeError("Missing required property 'service_name'")
            __props__['service_name'] = service_name
            __props__['title'] = title
            __props__['tls'] = tls
            if url is None:
                raise TypeError("Missing required property 'url'")
            __props__['url'] = url
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:apimanagement/latest:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20160707:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20161010:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20170301:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20180101:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20180601preview:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20190101:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20191201:Backend"), pulumi.Alias(type_="azure-nextgen:apimanagement/v20191201preview:Backend")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Backend, __self__).__init__(
            'azure-nextgen:apimanagement/v20200601preview:Backend',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Backend':
        """
        Get an existing Backend resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Backend(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def credentials(self) -> pulumi.Output[Optional['outputs.BackendCredentialsContractResponse']]:
        """
        Backend Credentials Contract Properties
        """
        return pulumi.get(self, "credentials")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Backend Description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output['outputs.BackendPropertiesResponse']:
        """
        Backend Properties contract
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[str]:
        """
        Backend communication protocol.
        """
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter
    def proxy(self) -> pulumi.Output[Optional['outputs.BackendProxyContractResponse']]:
        """
        Backend Proxy Contract Properties
        """
        return pulumi.get(self, "proxy")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Output[Optional[str]]:
        """
        Management Uri of the Resource in External System. This url can be the Arm Resource Id of Logic Apps, Function Apps or Api Apps.
        """
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[Optional[str]]:
        """
        Backend Title.
        """
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def tls(self) -> pulumi.Output[Optional['outputs.BackendTlsPropertiesResponse']]:
        """
        Backend TLS Properties
        """
        return pulumi.get(self, "tls")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type for API Management resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def url(self) -> pulumi.Output[str]:
        """
        Runtime Url of the Backend.
        """
        return pulumi.get(self, "url")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

