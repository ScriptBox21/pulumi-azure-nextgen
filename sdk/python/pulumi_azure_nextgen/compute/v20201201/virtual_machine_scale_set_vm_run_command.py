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

__all__ = ['VirtualMachineScaleSetVMRunCommand']


class VirtualMachineScaleSetVMRunCommand(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 async_execution: Optional[pulumi.Input[bool]] = None,
                 error_blob_uri: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 output_blob_uri: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RunCommandInputParameterArgs']]]]] = None,
                 protected_parameters: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RunCommandInputParameterArgs']]]]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 run_as_password: Optional[pulumi.Input[str]] = None,
                 run_as_user: Optional[pulumi.Input[str]] = None,
                 run_command_name: Optional[pulumi.Input[str]] = None,
                 source: Optional[pulumi.Input[pulumi.InputType['VirtualMachineRunCommandScriptSourceArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[int]] = None,
                 vm_scale_set_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Describes a Virtual Machine run command.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] async_execution: Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
        :param pulumi.Input[str] error_blob_uri: Specifies the Azure storage blob where script error stream will be uploaded.
        :param pulumi.Input[str] instance_id: The instance ID of the virtual machine.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[str] output_blob_uri: Specifies the Azure storage blob where script output stream will be uploaded.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RunCommandInputParameterArgs']]]] parameters: The parameters used by the script.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RunCommandInputParameterArgs']]]] protected_parameters: The parameters used by the script.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] run_as_password: Specifies the user account password on the VM when executing the run command.
        :param pulumi.Input[str] run_as_user: Specifies the user account on the VM when executing the run command.
        :param pulumi.Input[str] run_command_name: The name of the virtual machine run command.
        :param pulumi.Input[pulumi.InputType['VirtualMachineRunCommandScriptSourceArgs']] source: The source of the run command script.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[int] timeout_in_seconds: The timeout in seconds to execute the run command.
        :param pulumi.Input[str] vm_scale_set_name: The name of the VM scale set.
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

            if async_execution is None:
                async_execution = False
            __props__['async_execution'] = async_execution
            __props__['error_blob_uri'] = error_blob_uri
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__['instance_id'] = instance_id
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['output_blob_uri'] = output_blob_uri
            __props__['parameters'] = parameters
            __props__['protected_parameters'] = protected_parameters
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['run_as_password'] = run_as_password
            __props__['run_as_user'] = run_as_user
            if run_command_name is None and not opts.urn:
                raise TypeError("Missing required property 'run_command_name'")
            __props__['run_command_name'] = run_command_name
            __props__['source'] = source
            __props__['tags'] = tags
            __props__['timeout_in_seconds'] = timeout_in_seconds
            if vm_scale_set_name is None and not opts.urn:
                raise TypeError("Missing required property 'vm_scale_set_name'")
            __props__['vm_scale_set_name'] = vm_scale_set_name
            __props__['instance_view'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:compute/latest:VirtualMachineScaleSetVMRunCommand"), pulumi.Alias(type_="azure-nextgen:compute/v20200601:VirtualMachineScaleSetVMRunCommand")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualMachineScaleSetVMRunCommand, __self__).__init__(
            'azure-nextgen:compute/v20201201:VirtualMachineScaleSetVMRunCommand',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualMachineScaleSetVMRunCommand':
        """
        Get an existing VirtualMachineScaleSetVMRunCommand resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualMachineScaleSetVMRunCommand(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="asyncExecution")
    def async_execution(self) -> pulumi.Output[Optional[bool]]:
        """
        Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
        """
        return pulumi.get(self, "async_execution")

    @property
    @pulumi.getter(name="errorBlobUri")
    def error_blob_uri(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the Azure storage blob where script error stream will be uploaded.
        """
        return pulumi.get(self, "error_blob_uri")

    @property
    @pulumi.getter(name="instanceView")
    def instance_view(self) -> pulumi.Output['outputs.VirtualMachineRunCommandInstanceViewResponse']:
        """
        The virtual machine run command instance view.
        """
        return pulumi.get(self, "instance_view")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="outputBlobUri")
    def output_blob_uri(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the Azure storage blob where script output stream will be uploaded.
        """
        return pulumi.get(self, "output_blob_uri")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional[Sequence['outputs.RunCommandInputParameterResponse']]]:
        """
        The parameters used by the script.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="protectedParameters")
    def protected_parameters(self) -> pulumi.Output[Optional[Sequence['outputs.RunCommandInputParameterResponse']]]:
        """
        The parameters used by the script.
        """
        return pulumi.get(self, "protected_parameters")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="runAsPassword")
    def run_as_password(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the user account password on the VM when executing the run command.
        """
        return pulumi.get(self, "run_as_password")

    @property
    @pulumi.getter(name="runAsUser")
    def run_as_user(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the user account on the VM when executing the run command.
        """
        return pulumi.get(self, "run_as_user")

    @property
    @pulumi.getter
    def source(self) -> pulumi.Output[Optional['outputs.VirtualMachineRunCommandScriptSourceResponse']]:
        """
        The source of the run command script.
        """
        return pulumi.get(self, "source")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="timeoutInSeconds")
    def timeout_in_seconds(self) -> pulumi.Output[Optional[int]]:
        """
        The timeout in seconds to execute the run command.
        """
        return pulumi.get(self, "timeout_in_seconds")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

