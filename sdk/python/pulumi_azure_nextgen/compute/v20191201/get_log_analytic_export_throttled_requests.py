# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetLogAnalyticExportThrottledRequestsResult',
    'AwaitableGetLogAnalyticExportThrottledRequestsResult',
    'get_log_analytic_export_throttled_requests',
]

@pulumi.output_type
class GetLogAnalyticExportThrottledRequestsResult:
    """
    LogAnalytics operation status response
    """
    def __init__(__self__, properties=None):
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.LogAnalyticsOutputResponseResult':
        """
        LogAnalyticsOutput
        """
        return pulumi.get(self, "properties")


class AwaitableGetLogAnalyticExportThrottledRequestsResult(GetLogAnalyticExportThrottledRequestsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLogAnalyticExportThrottledRequestsResult(
            properties=self.properties)


def get_log_analytic_export_throttled_requests(blob_container_sas_uri: Optional[str] = None,
                                               from_time: Optional[str] = None,
                                               group_by_operation_name: Optional[bool] = None,
                                               group_by_resource_name: Optional[bool] = None,
                                               group_by_throttle_policy: Optional[bool] = None,
                                               location: Optional[str] = None,
                                               to_time: Optional[str] = None,
                                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLogAnalyticExportThrottledRequestsResult:
    """
    Use this data source to access information about an existing resource.

    :param str blob_container_sas_uri: SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
    :param str from_time: From time of the query
    :param bool group_by_operation_name: Group query result by Operation Name.
    :param bool group_by_resource_name: Group query result by Resource Name.
    :param bool group_by_throttle_policy: Group query result by Throttle Policy applied.
    :param str location: The location upon which virtual-machine-sizes is queried.
    :param str to_time: To time of the query
    """
    __args__ = dict()
    __args__['blobContainerSasUri'] = blob_container_sas_uri
    __args__['fromTime'] = from_time
    __args__['groupByOperationName'] = group_by_operation_name
    __args__['groupByResourceName'] = group_by_resource_name
    __args__['groupByThrottlePolicy'] = group_by_throttle_policy
    __args__['location'] = location
    __args__['toTime'] = to_time
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:compute/v20191201:getLogAnalyticExportThrottledRequests', __args__, opts=opts, typ=GetLogAnalyticExportThrottledRequestsResult).value

    return AwaitableGetLogAnalyticExportThrottledRequestsResult(
        properties=__ret__.properties)
