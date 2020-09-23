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

__all__ = [
    'GetApplicationGatewayBackendHealthOnDemandResult',
    'AwaitableGetApplicationGatewayBackendHealthOnDemandResult',
    'get_application_gateway_backend_health_on_demand',
]

@pulumi.output_type
class GetApplicationGatewayBackendHealthOnDemandResult:
    """
    Result of on demand test probe
    """
    def __init__(__self__, backend_address_pool=None, backend_health_http_settings=None):
        if backend_address_pool and not isinstance(backend_address_pool, dict):
            raise TypeError("Expected argument 'backend_address_pool' to be a dict")
        pulumi.set(__self__, "backend_address_pool", backend_address_pool)
        if backend_health_http_settings and not isinstance(backend_health_http_settings, dict):
            raise TypeError("Expected argument 'backend_health_http_settings' to be a dict")
        pulumi.set(__self__, "backend_health_http_settings", backend_health_http_settings)

    @property
    @pulumi.getter(name="backendAddressPool")
    def backend_address_pool(self) -> Optional['outputs.ApplicationGatewayBackendAddressPoolResponse']:
        """
        Reference of an ApplicationGatewayBackendAddressPool resource.
        """
        return pulumi.get(self, "backend_address_pool")

    @property
    @pulumi.getter(name="backendHealthHttpSettings")
    def backend_health_http_settings(self) -> Optional['outputs.ApplicationGatewayBackendHealthHttpSettingsResponseResult']:
        """
        Application gateway BackendHealthHttp settings.
        """
        return pulumi.get(self, "backend_health_http_settings")


class AwaitableGetApplicationGatewayBackendHealthOnDemandResult(GetApplicationGatewayBackendHealthOnDemandResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApplicationGatewayBackendHealthOnDemandResult(
            backend_address_pool=self.backend_address_pool,
            backend_health_http_settings=self.backend_health_http_settings)


def get_application_gateway_backend_health_on_demand(application_gateway_name: Optional[str] = None,
                                                     backend_address_pool: Optional[pulumi.InputType['SubResourceArgs']] = None,
                                                     backend_http_settings: Optional[pulumi.InputType['SubResourceArgs']] = None,
                                                     expand: Optional[str] = None,
                                                     host: Optional[str] = None,
                                                     match: Optional[pulumi.InputType['ApplicationGatewayProbeHealthResponseMatchArgs']] = None,
                                                     path: Optional[str] = None,
                                                     pick_host_name_from_backend_http_settings: Optional[bool] = None,
                                                     protocol: Optional[str] = None,
                                                     resource_group_name: Optional[str] = None,
                                                     timeout: Optional[int] = None,
                                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApplicationGatewayBackendHealthOnDemandResult:
    """
    Use this data source to access information about an existing resource.

    :param str application_gateway_name: The name of the application gateway.
    :param pulumi.InputType['SubResourceArgs'] backend_address_pool: Reference of backend pool of application gateway to which probe request will be sent.
    :param pulumi.InputType['SubResourceArgs'] backend_http_settings: Reference of backend http setting of application gateway to be used for test probe.
    :param str expand: Expands BackendAddressPool and BackendHttpSettings referenced in backend health.
    :param str host: Host name to send the probe to.
    :param pulumi.InputType['ApplicationGatewayProbeHealthResponseMatchArgs'] match: Criterion for classifying a healthy probe response.
    :param str path: Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path>
    :param bool pick_host_name_from_backend_http_settings: Whether the host header should be picked from the backend http settings. Default value is false.
    :param str protocol: The protocol used for the probe.
    :param str resource_group_name: The name of the resource group.
    :param int timeout: The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
    """
    __args__ = dict()
    __args__['applicationGatewayName'] = application_gateway_name
    __args__['backendAddressPool'] = backend_address_pool
    __args__['backendHttpSettings'] = backend_http_settings
    __args__['expand'] = expand
    __args__['host'] = host
    __args__['match'] = match
    __args__['path'] = path
    __args__['pickHostNameFromBackendHttpSettings'] = pick_host_name_from_backend_http_settings
    __args__['protocol'] = protocol
    __args__['resourceGroupName'] = resource_group_name
    __args__['timeout'] = timeout
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:network/v20190201:getApplicationGatewayBackendHealthOnDemand', __args__, opts=opts, typ=GetApplicationGatewayBackendHealthOnDemandResult).value

    return AwaitableGetApplicationGatewayBackendHealthOnDemandResult(
        backend_address_pool=__ret__.backend_address_pool,
        backend_health_http_settings=__ret__.backend_health_http_settings)
