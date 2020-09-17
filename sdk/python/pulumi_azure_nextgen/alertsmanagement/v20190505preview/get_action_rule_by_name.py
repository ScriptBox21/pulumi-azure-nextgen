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
    'GetActionRuleByNameResult',
    'AwaitableGetActionRuleByNameResult',
    'get_action_rule_by_name',
]

@pulumi.output_type
class GetActionRuleByNameResult:
    """
    Action rule object containing target scope, conditions and suppression logic
    """
    def __init__(__self__, location=None, name=None, properties=None, tags=None, type=None):
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Azure resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> Any:
        """
        action rule properties
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Azure resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetActionRuleByNameResult(GetActionRuleByNameResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetActionRuleByNameResult(
            location=self.location,
            name=self.name,
            properties=self.properties,
            tags=self.tags,
            type=self.type)


def get_action_rule_by_name(action_rule_name: Optional[str] = None,
                            resource_group_name: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetActionRuleByNameResult:
    """
    Use this data source to access information about an existing resource.

    :param str action_rule_name: The name of action rule that needs to be fetched
    :param str resource_group_name: Resource group name where the resource is created.
    """
    __args__ = dict()
    __args__['actionRuleName'] = action_rule_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:alertsmanagement/v20190505preview:getActionRuleByName', __args__, opts=opts, typ=GetActionRuleByNameResult).value

    return AwaitableGetActionRuleByNameResult(
        location=__ret__.location,
        name=__ret__.name,
        properties=__ret__.properties,
        tags=__ret__.tags,
        type=__ret__.type)