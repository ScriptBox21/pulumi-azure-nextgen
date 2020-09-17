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
    'GetAssessmentResult',
    'AwaitableGetAssessmentResult',
    'get_assessment',
]

@pulumi.output_type
class GetAssessmentResult:
    """
    Security assessment on a resource
    """
    def __init__(__self__, additional_data=None, display_name=None, links=None, name=None, resource_details=None, status=None, type=None):
        if additional_data and not isinstance(additional_data, dict):
            raise TypeError("Expected argument 'additional_data' to be a dict")
        pulumi.set(__self__, "additional_data", additional_data)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if links and not isinstance(links, dict):
            raise TypeError("Expected argument 'links' to be a dict")
        pulumi.set(__self__, "links", links)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if resource_details and not isinstance(resource_details, dict):
            raise TypeError("Expected argument 'resource_details' to be a dict")
        pulumi.set(__self__, "resource_details", resource_details)
        if status and not isinstance(status, dict):
            raise TypeError("Expected argument 'status' to be a dict")
        pulumi.set(__self__, "status", status)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="additionalData")
    def additional_data(self) -> Optional[Mapping[str, str]]:
        """
        Additional data regarding the assessment
        """
        return pulumi.get(self, "additional_data")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        User friendly display name of the assessment
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def links(self) -> Optional['outputs.AssessmentLinksResponse']:
        """
        Links relevant to the assessment
        """
        return pulumi.get(self, "links")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceDetails")
    def resource_details(self) -> Any:
        """
        Details of the resource that was assessed
        """
        return pulumi.get(self, "resource_details")

    @property
    @pulumi.getter
    def status(self) -> 'outputs.AssessmentStatusResponse':
        """
        The result of the assessment
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetAssessmentResult(GetAssessmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAssessmentResult(
            additional_data=self.additional_data,
            display_name=self.display_name,
            links=self.links,
            name=self.name,
            resource_details=self.resource_details,
            status=self.status,
            type=self.type)


def get_assessment(assessment_name: Optional[str] = None,
                   expand: Optional[str] = None,
                   resource_id: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAssessmentResult:
    """
    Use this data source to access information about an existing resource.

    :param str assessment_name: The Assessment Key - Unique key for the assessment type
    :param str expand: OData expand. Optional.
    :param str resource_id: The identifier of the resource.
    """
    __args__ = dict()
    __args__['assessmentName'] = assessment_name
    __args__['expand'] = expand
    __args__['resourceId'] = resource_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:security/v20190101preview:getAssessment', __args__, opts=opts, typ=GetAssessmentResult).value

    return AwaitableGetAssessmentResult(
        additional_data=__ret__.additional_data,
        display_name=__ret__.display_name,
        links=__ret__.links,
        name=__ret__.name,
        resource_details=__ret__.resource_details,
        status=__ret__.status,
        type=__ret__.type)