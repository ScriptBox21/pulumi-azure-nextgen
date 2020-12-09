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

__all__ = ['AppServicePlan']


class AppServicePlan(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 free_offer_expiration_time: Optional[pulumi.Input[str]] = None,
                 hosting_environment_profile: Optional[pulumi.Input[pulumi.InputType['HostingEnvironmentProfileArgs']]] = None,
                 hyper_v: Optional[pulumi.Input[bool]] = None,
                 is_spot: Optional[pulumi.Input[bool]] = None,
                 is_xenon: Optional[pulumi.Input[bool]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 maximum_elastic_worker_count: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 per_site_scaling: Optional[pulumi.Input[bool]] = None,
                 reserved: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuDescriptionArgs']]] = None,
                 spot_expiration_time: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 target_worker_count: Optional[pulumi.Input[int]] = None,
                 target_worker_size_id: Optional[pulumi.Input[int]] = None,
                 worker_tier_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        App Service plan.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] free_offer_expiration_time: The time when the server farm free offer expires.
        :param pulumi.Input[pulumi.InputType['HostingEnvironmentProfileArgs']] hosting_environment_profile: Specification for the App Service Environment to use for the App Service plan.
        :param pulumi.Input[bool] hyper_v: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        :param pulumi.Input[bool] is_spot: If <code>true</code>, this App Service Plan owns spot instances.
        :param pulumi.Input[bool] is_xenon: Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        :param pulumi.Input[str] kind: Kind of resource.
        :param pulumi.Input[str] location: Resource Location.
        :param pulumi.Input[int] maximum_elastic_worker_count: Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
        :param pulumi.Input[str] name: Name of the App Service plan.
        :param pulumi.Input[bool] per_site_scaling: If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
               If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan.
        :param pulumi.Input[bool] reserved: If Linux app service plan <code>true</code>, <code>false</code> otherwise.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[pulumi.InputType['SkuDescriptionArgs']] sku: Description of a SKU for a scalable resource.
        :param pulumi.Input[str] spot_expiration_time: The time when the server farm expires. Valid only if it is a spot server farm.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[int] target_worker_count: Scaling worker count.
        :param pulumi.Input[int] target_worker_size_id: Scaling worker size ID.
        :param pulumi.Input[str] worker_tier_name: Target worker tier assigned to the App Service plan.
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

            __props__['free_offer_expiration_time'] = free_offer_expiration_time
            __props__['hosting_environment_profile'] = hosting_environment_profile
            __props__['hyper_v'] = hyper_v
            __props__['is_spot'] = is_spot
            __props__['is_xenon'] = is_xenon
            __props__['kind'] = kind
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['maximum_elastic_worker_count'] = maximum_elastic_worker_count
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['per_site_scaling'] = per_site_scaling
            __props__['reserved'] = reserved
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku'] = sku
            __props__['spot_expiration_time'] = spot_expiration_time
            __props__['tags'] = tags
            __props__['target_worker_count'] = target_worker_count
            __props__['target_worker_size_id'] = target_worker_size_id
            __props__['worker_tier_name'] = worker_tier_name
            __props__['geo_region'] = None
            __props__['maximum_number_of_workers'] = None
            __props__['number_of_sites'] = None
            __props__['provisioning_state'] = None
            __props__['resource_group'] = None
            __props__['status'] = None
            __props__['subscription'] = None
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/v20150801:AppServicePlan"), pulumi.Alias(type_="azure-nextgen:web/v20160901:AppServicePlan"), pulumi.Alias(type_="azure-nextgen:web/v20180201:AppServicePlan"), pulumi.Alias(type_="azure-nextgen:web/v20190801:AppServicePlan"), pulumi.Alias(type_="azure-nextgen:web/v20200601:AppServicePlan"), pulumi.Alias(type_="azure-nextgen:web/v20200901:AppServicePlan")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(AppServicePlan, __self__).__init__(
            'azure-nextgen:web/latest:AppServicePlan',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AppServicePlan':
        """
        Get an existing AppServicePlan resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return AppServicePlan(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="freeOfferExpirationTime")
    def free_offer_expiration_time(self) -> pulumi.Output[Optional[str]]:
        """
        The time when the server farm free offer expires.
        """
        return pulumi.get(self, "free_offer_expiration_time")

    @property
    @pulumi.getter(name="geoRegion")
    def geo_region(self) -> pulumi.Output[str]:
        """
        Geographical location for the App Service plan.
        """
        return pulumi.get(self, "geo_region")

    @property
    @pulumi.getter(name="hostingEnvironmentProfile")
    def hosting_environment_profile(self) -> pulumi.Output[Optional['outputs.HostingEnvironmentProfileResponse']]:
        """
        Specification for the App Service Environment to use for the App Service plan.
        """
        return pulumi.get(self, "hosting_environment_profile")

    @property
    @pulumi.getter(name="hyperV")
    def hyper_v(self) -> pulumi.Output[Optional[bool]]:
        """
        If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        """
        return pulumi.get(self, "hyper_v")

    @property
    @pulumi.getter(name="isSpot")
    def is_spot(self) -> pulumi.Output[Optional[bool]]:
        """
        If <code>true</code>, this App Service Plan owns spot instances.
        """
        return pulumi.get(self, "is_spot")

    @property
    @pulumi.getter(name="isXenon")
    def is_xenon(self) -> pulumi.Output[Optional[bool]]:
        """
        Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        """
        return pulumi.get(self, "is_xenon")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource Location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maximumElasticWorkerCount")
    def maximum_elastic_worker_count(self) -> pulumi.Output[Optional[int]]:
        """
        Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
        """
        return pulumi.get(self, "maximum_elastic_worker_count")

    @property
    @pulumi.getter(name="maximumNumberOfWorkers")
    def maximum_number_of_workers(self) -> pulumi.Output[int]:
        """
        Maximum number of instances that can be assigned to this App Service plan.
        """
        return pulumi.get(self, "maximum_number_of_workers")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="numberOfSites")
    def number_of_sites(self) -> pulumi.Output[int]:
        """
        Number of apps assigned to this App Service plan.
        """
        return pulumi.get(self, "number_of_sites")

    @property
    @pulumi.getter(name="perSiteScaling")
    def per_site_scaling(self) -> pulumi.Output[Optional[bool]]:
        """
        If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
        If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan.
        """
        return pulumi.get(self, "per_site_scaling")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the App Service Environment.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def reserved(self) -> pulumi.Output[Optional[bool]]:
        """
        If Linux app service plan <code>true</code>, <code>false</code> otherwise.
        """
        return pulumi.get(self, "reserved")

    @property
    @pulumi.getter(name="resourceGroup")
    def resource_group(self) -> pulumi.Output[str]:
        """
        Resource group of the App Service plan.
        """
        return pulumi.get(self, "resource_group")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuDescriptionResponse']]:
        """
        Description of a SKU for a scalable resource.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter(name="spotExpirationTime")
    def spot_expiration_time(self) -> pulumi.Output[Optional[str]]:
        """
        The time when the server farm expires. Valid only if it is a spot server farm.
        """
        return pulumi.get(self, "spot_expiration_time")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        App Service plan status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def subscription(self) -> pulumi.Output[str]:
        """
        App Service plan subscription.
        """
        return pulumi.get(self, "subscription")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="targetWorkerCount")
    def target_worker_count(self) -> pulumi.Output[Optional[int]]:
        """
        Scaling worker count.
        """
        return pulumi.get(self, "target_worker_count")

    @property
    @pulumi.getter(name="targetWorkerSizeId")
    def target_worker_size_id(self) -> pulumi.Output[Optional[int]]:
        """
        Scaling worker size ID.
        """
        return pulumi.get(self, "target_worker_size_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="workerTierName")
    def worker_tier_name(self) -> pulumi.Output[Optional[str]]:
        """
        Target worker tier assigned to the App Service plan.
        """
        return pulumi.get(self, "worker_tier_name")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

