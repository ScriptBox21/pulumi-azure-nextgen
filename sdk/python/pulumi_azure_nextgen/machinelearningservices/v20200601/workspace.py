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

__all__ = ['Workspace']


class Workspace(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allow_public_access_when_behind_vnet: Optional[pulumi.Input[bool]] = None,
                 application_insights: Optional[pulumi.Input[str]] = None,
                 container_registry: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 discovery_url: Optional[pulumi.Input[str]] = None,
                 encryption: Optional[pulumi.Input[pulumi.InputType['EncryptionPropertyArgs']]] = None,
                 friendly_name: Optional[pulumi.Input[str]] = None,
                 hbi_workspace: Optional[pulumi.Input[bool]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['IdentityArgs']]] = None,
                 image_build_compute: Optional[pulumi.Input[str]] = None,
                 key_vault: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 shared_private_link_resources: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SharedPrivateLinkResourceArgs']]]]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 storage_account: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 workspace_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        An object that represents a machine learning workspace.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] allow_public_access_when_behind_vnet: The flag to indicate whether to allow public access when behind VNet.
        :param pulumi.Input[str] application_insights: ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
        :param pulumi.Input[str] container_registry: ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
        :param pulumi.Input[str] description: The description of this workspace.
        :param pulumi.Input[str] discovery_url: Url for the discovery service to identify regional endpoints for machine learning experimentation services
        :param pulumi.Input[pulumi.InputType['EncryptionPropertyArgs']] encryption: The encryption settings of Azure ML workspace.
        :param pulumi.Input[str] friendly_name: The friendly name for this workspace. This name in mutable
        :param pulumi.Input[bool] hbi_workspace: The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
        :param pulumi.Input[pulumi.InputType['IdentityArgs']] identity: The identity of the resource.
        :param pulumi.Input[str] image_build_compute: The compute name for image build
        :param pulumi.Input[str] key_vault: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
        :param pulumi.Input[str] location: Specifies the location of the resource.
        :param pulumi.Input[str] resource_group_name: Name of the resource group in which workspace is located.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SharedPrivateLinkResourceArgs']]]] shared_private_link_resources: The list of shared private link resources in this workspace.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: The sku of the workspace.
        :param pulumi.Input[str] storage_account: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Contains resource tags defined as key/value pairs.
        :param pulumi.Input[str] workspace_name: Name of Azure Machine Learning workspace.
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

            __props__['allow_public_access_when_behind_vnet'] = allow_public_access_when_behind_vnet
            __props__['application_insights'] = application_insights
            __props__['container_registry'] = container_registry
            __props__['description'] = description
            __props__['discovery_url'] = discovery_url
            __props__['encryption'] = encryption
            __props__['friendly_name'] = friendly_name
            __props__['hbi_workspace'] = hbi_workspace
            __props__['identity'] = identity
            __props__['image_build_compute'] = image_build_compute
            __props__['key_vault'] = key_vault
            __props__['location'] = location
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['shared_private_link_resources'] = shared_private_link_resources
            __props__['sku'] = sku
            __props__['storage_account'] = storage_account
            __props__['tags'] = tags
            if workspace_name is None:
                raise TypeError("Missing required property 'workspace_name'")
            __props__['workspace_name'] = workspace_name
            __props__['creation_time'] = None
            __props__['name'] = None
            __props__['notebook_info'] = None
            __props__['private_endpoint_connections'] = None
            __props__['private_link_count'] = None
            __props__['provisioning_state'] = None
            __props__['service_provisioned_resource_group'] = None
            __props__['type'] = None
            __props__['workspace_id'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:machinelearningservices/latest:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20180301preview:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20181119:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20190501:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20190601:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20191101:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200101:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200218preview:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200301:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200401:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200501preview:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200515preview:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200801:Workspace"), pulumi.Alias(type_="azure-nextgen:machinelearningservices/v20200901preview:Workspace")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Workspace, __self__).__init__(
            'azure-nextgen:machinelearningservices/v20200601:Workspace',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Workspace':
        """
        Get an existing Workspace resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Workspace(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allowPublicAccessWhenBehindVnet")
    def allow_public_access_when_behind_vnet(self) -> pulumi.Output[Optional[bool]]:
        """
        The flag to indicate whether to allow public access when behind VNet.
        """
        return pulumi.get(self, "allow_public_access_when_behind_vnet")

    @property
    @pulumi.getter(name="applicationInsights")
    def application_insights(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
        """
        return pulumi.get(self, "application_insights")

    @property
    @pulumi.getter(name="containerRegistry")
    def container_registry(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
        """
        return pulumi.get(self, "container_registry")

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> pulumi.Output[str]:
        """
        The creation time of the machine learning workspace in ISO8601 format.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of this workspace.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="discoveryUrl")
    def discovery_url(self) -> pulumi.Output[Optional[str]]:
        """
        Url for the discovery service to identify regional endpoints for machine learning experimentation services
        """
        return pulumi.get(self, "discovery_url")

    @property
    @pulumi.getter
    def encryption(self) -> pulumi.Output[Optional['outputs.EncryptionPropertyResponse']]:
        """
        The encryption settings of Azure ML workspace.
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> pulumi.Output[Optional[str]]:
        """
        The friendly name for this workspace. This name in mutable
        """
        return pulumi.get(self, "friendly_name")

    @property
    @pulumi.getter(name="hbiWorkspace")
    def hbi_workspace(self) -> pulumi.Output[Optional[bool]]:
        """
        The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
        """
        return pulumi.get(self, "hbi_workspace")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.IdentityResponse']]:
        """
        The identity of the resource.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter(name="imageBuildCompute")
    def image_build_compute(self) -> pulumi.Output[Optional[str]]:
        """
        The compute name for image build
        """
        return pulumi.get(self, "image_build_compute")

    @property
    @pulumi.getter(name="keyVault")
    def key_vault(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
        """
        return pulumi.get(self, "key_vault")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the location of the resource.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="notebookInfo")
    def notebook_info(self) -> pulumi.Output['outputs.NotebookResourceInfoResponse']:
        """
        The notebook info of Azure ML workspace.
        """
        return pulumi.get(self, "notebook_info")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> pulumi.Output[Sequence['outputs.PrivateEndpointConnectionResponse']]:
        """
        The list of private endpoint connections in the workspace.
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="privateLinkCount")
    def private_link_count(self) -> pulumi.Output[int]:
        """
        Count of private connections in the workspace
        """
        return pulumi.get(self, "private_link_count")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serviceProvisionedResourceGroup")
    def service_provisioned_resource_group(self) -> pulumi.Output[str]:
        """
        The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
        """
        return pulumi.get(self, "service_provisioned_resource_group")

    @property
    @pulumi.getter(name="sharedPrivateLinkResources")
    def shared_private_link_resources(self) -> pulumi.Output[Optional[Sequence['outputs.SharedPrivateLinkResourceResponse']]]:
        """
        The list of shared private link resources in this workspace.
        """
        return pulumi.get(self, "shared_private_link_resources")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuResponse']]:
        """
        The sku of the workspace.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter(name="storageAccount")
    def storage_account(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
        """
        return pulumi.get(self, "storage_account")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Contains resource tags defined as key/value pairs.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Specifies the type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="workspaceId")
    def workspace_id(self) -> pulumi.Output[str]:
        """
        The immutable id associated with this workspace.
        """
        return pulumi.get(self, "workspace_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

