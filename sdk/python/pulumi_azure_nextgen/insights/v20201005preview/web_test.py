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

__all__ = ['WebTest']


class WebTest(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 configuration: Optional[pulumi.Input[pulumi.InputType['WebTestPropertiesConfigurationArgs']]] = None,
                 content_validation: Optional[pulumi.Input[pulumi.InputType['WebTestPropertiesContentValidationArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 expected_http_status_code: Optional[pulumi.Input[int]] = None,
                 frequency: Optional[pulumi.Input[int]] = None,
                 ignore_https_status_code: Optional[pulumi.Input[bool]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 locations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WebTestGeolocationArgs']]]]] = None,
                 request: Optional[pulumi.Input[pulumi.InputType['WebTestPropertiesRequestArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 retry_enabled: Optional[pulumi.Input[bool]] = None,
                 s_sl_cert_remaining_lifetime_check: Optional[pulumi.Input[int]] = None,
                 s_sl_check: Optional[pulumi.Input[bool]] = None,
                 synthetic_monitor_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 timeout: Optional[pulumi.Input[int]] = None,
                 web_test_kind: Optional[pulumi.Input[str]] = None,
                 web_test_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        An Application Insights WebTest definition.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['WebTestPropertiesConfigurationArgs']] configuration: An XML configuration specification for a WebTest.
        :param pulumi.Input[pulumi.InputType['WebTestPropertiesContentValidationArgs']] content_validation: The collection of content validation properties
        :param pulumi.Input[str] description: User defined description for this WebTest.
        :param pulumi.Input[bool] enabled: Is the test actively being monitored.
        :param pulumi.Input[int] expected_http_status_code: Validate that the WebTest returns the http status code provided.
        :param pulumi.Input[int] frequency: Interval in seconds between test runs for this WebTest. Default value is 300.
        :param pulumi.Input[bool] ignore_https_status_code: When set, validation will ignore the status code.
        :param pulumi.Input[str] kind: The kind of WebTest that this web test watches. Choices are ping and multistep.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WebTestGeolocationArgs']]]] locations: A list of where to physically run the tests from to give global coverage for accessibility of your application.
        :param pulumi.Input[pulumi.InputType['WebTestPropertiesRequestArgs']] request: The collection of request properties
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[bool] retry_enabled: Allow for retries should this WebTest fail.
        :param pulumi.Input[int] s_sl_cert_remaining_lifetime_check: A number of days to check still remain before the the existing SSL cert expires.
        :param pulumi.Input[bool] s_sl_check: Checks to see if the SSL cert is still valid.
        :param pulumi.Input[str] synthetic_monitor_id: Unique ID of this WebTest. This is typically the same value as the Name field.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[int] timeout: Seconds until this WebTest will timeout and fail. Default value is 30.
        :param pulumi.Input[str] web_test_kind: The kind of web test this is, valid choices are ping, multistep, basic, and standard.
        :param pulumi.Input[str] web_test_name: User defined name if this WebTest.
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

            __props__['configuration'] = configuration
            __props__['content_validation'] = content_validation
            __props__['description'] = description
            __props__['enabled'] = enabled
            __props__['expected_http_status_code'] = expected_http_status_code
            __props__['frequency'] = frequency
            __props__['ignore_https_status_code'] = ignore_https_status_code
            __props__['kind'] = kind
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            if locations is None:
                raise TypeError("Missing required property 'locations'")
            __props__['locations'] = locations
            __props__['request'] = request
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['retry_enabled'] = retry_enabled
            __props__['s_sl_cert_remaining_lifetime_check'] = s_sl_cert_remaining_lifetime_check
            __props__['s_sl_check'] = s_sl_check
            if synthetic_monitor_id is None:
                raise TypeError("Missing required property 'synthetic_monitor_id'")
            __props__['synthetic_monitor_id'] = synthetic_monitor_id
            __props__['tags'] = tags
            __props__['timeout'] = timeout
            if web_test_kind is None:
                raise TypeError("Missing required property 'web_test_kind'")
            __props__['web_test_kind'] = web_test_kind
            if web_test_name is None:
                raise TypeError("Missing required property 'web_test_name'")
            __props__['web_test_name'] = web_test_name
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:insights/latest:WebTest"), pulumi.Alias(type_="azure-nextgen:insights/v20150501:WebTest")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WebTest, __self__).__init__(
            'azure-nextgen:insights/v20201005preview:WebTest',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WebTest':
        """
        Get an existing WebTest resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return WebTest(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def configuration(self) -> pulumi.Output[Optional['outputs.WebTestPropertiesResponseConfiguration']]:
        """
        An XML configuration specification for a WebTest.
        """
        return pulumi.get(self, "configuration")

    @property
    @pulumi.getter(name="contentValidation")
    def content_validation(self) -> pulumi.Output[Optional['outputs.WebTestPropertiesResponseContentValidation']]:
        """
        The collection of content validation properties
        """
        return pulumi.get(self, "content_validation")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        User defined description for this WebTest.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Is the test actively being monitored.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="expectedHttpStatusCode")
    def expected_http_status_code(self) -> pulumi.Output[Optional[int]]:
        """
        Validate that the WebTest returns the http status code provided.
        """
        return pulumi.get(self, "expected_http_status_code")

    @property
    @pulumi.getter
    def frequency(self) -> pulumi.Output[Optional[int]]:
        """
        Interval in seconds between test runs for this WebTest. Default value is 300.
        """
        return pulumi.get(self, "frequency")

    @property
    @pulumi.getter(name="ignoreHttpsStatusCode")
    def ignore_https_status_code(self) -> pulumi.Output[Optional[bool]]:
        """
        When set, validation will ignore the status code.
        """
        return pulumi.get(self, "ignore_https_status_code")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        The kind of WebTest that this web test watches. Choices are ping and multistep.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def locations(self) -> pulumi.Output[Sequence['outputs.WebTestGeolocationResponse']]:
        """
        A list of where to physically run the tests from to give global coverage for accessibility of your application.
        """
        return pulumi.get(self, "locations")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Azure resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def request(self) -> pulumi.Output[Optional['outputs.WebTestPropertiesResponseRequest']]:
        """
        The collection of request properties
        """
        return pulumi.get(self, "request")

    @property
    @pulumi.getter(name="retryEnabled")
    def retry_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Allow for retries should this WebTest fail.
        """
        return pulumi.get(self, "retry_enabled")

    @property
    @pulumi.getter(name="sSLCertRemainingLifetimeCheck")
    def s_sl_cert_remaining_lifetime_check(self) -> pulumi.Output[Optional[int]]:
        """
        A number of days to check still remain before the the existing SSL cert expires.
        """
        return pulumi.get(self, "s_sl_cert_remaining_lifetime_check")

    @property
    @pulumi.getter(name="sSLCheck")
    def s_sl_check(self) -> pulumi.Output[Optional[bool]]:
        """
        Checks to see if the SSL cert is still valid.
        """
        return pulumi.get(self, "s_sl_check")

    @property
    @pulumi.getter(name="syntheticMonitorId")
    def synthetic_monitor_id(self) -> pulumi.Output[str]:
        """
        Unique ID of this WebTest. This is typically the same value as the Name field.
        """
        return pulumi.get(self, "synthetic_monitor_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def timeout(self) -> pulumi.Output[Optional[int]]:
        """
        Seconds until this WebTest will timeout and fail. Default value is 30.
        """
        return pulumi.get(self, "timeout")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Azure resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="webTestKind")
    def web_test_kind(self) -> pulumi.Output[str]:
        """
        The kind of web test this is, valid choices are ping, multistep, basic, and standard.
        """
        return pulumi.get(self, "web_test_kind")

    @property
    @pulumi.getter(name="webTestName")
    def web_test_name(self) -> pulumi.Output[str]:
        """
        User defined name if this WebTest.
        """
        return pulumi.get(self, "web_test_name")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

