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

__all__ = ['AFDOriginGroup']


class AFDOriginGroup(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 health_probe_settings: Optional[pulumi.Input[pulumi.InputType['HealthProbeParametersArgs']]] = None,
                 load_balancing_settings: Optional[pulumi.Input[pulumi.InputType['LoadBalancingSettingsParametersArgs']]] = None,
                 origin_group_name: Optional[pulumi.Input[str]] = None,
                 profile_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 response_based_afd_origin_error_detection_settings: Optional[pulumi.Input[pulumi.InputType['ResponseBasedOriginErrorDetectionParametersArgs']]] = None,
                 session_affinity_state: Optional[pulumi.Input[str]] = None,
                 traffic_restoration_time_to_healed_or_new_endpoints_in_minutes: Optional[pulumi.Input[int]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        AFDOrigin group comprising of origins is used for load balancing to origins when the content cannot be served from CDN.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['HealthProbeParametersArgs']] health_probe_settings: Health probe settings to the origin that is used to determine the health of the origin.
        :param pulumi.Input[pulumi.InputType['LoadBalancingSettingsParametersArgs']] load_balancing_settings: Load balancing settings for a backend pool
        :param pulumi.Input[str] origin_group_name: Name of the origin group which is unique within the endpoint.
        :param pulumi.Input[str] profile_name: Name of the CDN profile which is unique within the resource group.
        :param pulumi.Input[str] resource_group_name: Name of the Resource group within the Azure subscription.
        :param pulumi.Input[pulumi.InputType['ResponseBasedOriginErrorDetectionParametersArgs']] response_based_afd_origin_error_detection_settings: The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported.
        :param pulumi.Input[str] session_affinity_state: Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        :param pulumi.Input[int] traffic_restoration_time_to_healed_or_new_endpoints_in_minutes: Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.
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

            __props__['health_probe_settings'] = health_probe_settings
            __props__['load_balancing_settings'] = load_balancing_settings
            if origin_group_name is None:
                raise TypeError("Missing required property 'origin_group_name'")
            __props__['origin_group_name'] = origin_group_name
            if profile_name is None:
                raise TypeError("Missing required property 'profile_name'")
            __props__['profile_name'] = profile_name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['response_based_afd_origin_error_detection_settings'] = response_based_afd_origin_error_detection_settings
            __props__['session_affinity_state'] = session_affinity_state
            __props__['traffic_restoration_time_to_healed_or_new_endpoints_in_minutes'] = traffic_restoration_time_to_healed_or_new_endpoints_in_minutes
            __props__['deployment_status'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:cdn/latest:AFDOriginGroup")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(AFDOriginGroup, __self__).__init__(
            'azure-nextgen:cdn/v20200901:AFDOriginGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AFDOriginGroup':
        """
        Get an existing AFDOriginGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return AFDOriginGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="deploymentStatus")
    def deployment_status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "deployment_status")

    @property
    @pulumi.getter(name="healthProbeSettings")
    def health_probe_settings(self) -> pulumi.Output[Optional['outputs.HealthProbeParametersResponse']]:
        """
        Health probe settings to the origin that is used to determine the health of the origin.
        """
        return pulumi.get(self, "health_probe_settings")

    @property
    @pulumi.getter(name="loadBalancingSettings")
    def load_balancing_settings(self) -> pulumi.Output[Optional['outputs.LoadBalancingSettingsParametersResponse']]:
        """
        Load balancing settings for a backend pool
        """
        return pulumi.get(self, "load_balancing_settings")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning status
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="responseBasedAfdOriginErrorDetectionSettings")
    def response_based_afd_origin_error_detection_settings(self) -> pulumi.Output[Optional['outputs.ResponseBasedOriginErrorDetectionParametersResponse']]:
        """
        The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported.
        """
        return pulumi.get(self, "response_based_afd_origin_error_detection_settings")

    @property
    @pulumi.getter(name="sessionAffinityState")
    def session_affinity_state(self) -> pulumi.Output[Optional[str]]:
        """
        Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        """
        return pulumi.get(self, "session_affinity_state")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        Read only system data
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter(name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes")
    def traffic_restoration_time_to_healed_or_new_endpoints_in_minutes(self) -> pulumi.Output[Optional[int]]:
        """
        Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.
        """
        return pulumi.get(self, "traffic_restoration_time_to_healed_or_new_endpoints_in_minutes")

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

