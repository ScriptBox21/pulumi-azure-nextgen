# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ApplicationAuthorizationArgs',
    'ApplicationDefinitionArtifactArgs',
    'ApplicationDeploymentPolicyArgs',
    'ApplicationJitAccessPolicyArgs',
    'ApplicationManagementPolicyArgs',
    'ApplicationNotificationEndpointArgs',
    'ApplicationNotificationPolicyArgs',
    'ApplicationPackageLockingPolicyDefinitionArgs',
    'ApplicationPolicyArgs',
    'IdentityArgs',
    'JitApproverDefinitionArgs',
    'JitAuthorizationPoliciesArgs',
    'JitSchedulingPolicyArgs',
    'PlanArgs',
    'SkuArgs',
]

@pulumi.input_type
class ApplicationAuthorizationArgs:
    def __init__(__self__, *,
                 principal_id: pulumi.Input[str],
                 role_definition_id: pulumi.Input[str]):
        """
        The managed application provider authorization.
        :param pulumi.Input[str] principal_id: The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources.
        :param pulumi.Input[str] role_definition_id: The provider's role definition identifier. This role will define all the permissions that the provider must have on the managed application's container resource group. This role definition cannot have permission to delete the resource group.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "role_definition_id", role_definition_id)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> pulumi.Input[str]:
        """
        The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources.
        """
        return pulumi.get(self, "principal_id")

    @principal_id.setter
    def principal_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "principal_id", value)

    @property
    @pulumi.getter(name="roleDefinitionId")
    def role_definition_id(self) -> pulumi.Input[str]:
        """
        The provider's role definition identifier. This role will define all the permissions that the provider must have on the managed application's container resource group. This role definition cannot have permission to delete the resource group.
        """
        return pulumi.get(self, "role_definition_id")

    @role_definition_id.setter
    def role_definition_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_definition_id", value)


@pulumi.input_type
class ApplicationDefinitionArtifactArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 type: pulumi.Input[str],
                 uri: pulumi.Input[str]):
        """
        Application definition artifact.
        :param pulumi.Input[str] name: The managed application definition artifact name.
        :param pulumi.Input[str] type: The managed application definition artifact type.
        :param pulumi.Input[str] uri: The managed application definition artifact blob uri.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The managed application definition artifact name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The managed application definition artifact type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def uri(self) -> pulumi.Input[str]:
        """
        The managed application definition artifact blob uri.
        """
        return pulumi.get(self, "uri")

    @uri.setter
    def uri(self, value: pulumi.Input[str]):
        pulumi.set(self, "uri", value)


@pulumi.input_type
class ApplicationDeploymentPolicyArgs:
    def __init__(__self__, *,
                 deployment_mode: pulumi.Input[str]):
        """
        Managed application deployment policy.
        :param pulumi.Input[str] deployment_mode: The managed application deployment mode.
        """
        pulumi.set(__self__, "deployment_mode", deployment_mode)

    @property
    @pulumi.getter(name="deploymentMode")
    def deployment_mode(self) -> pulumi.Input[str]:
        """
        The managed application deployment mode.
        """
        return pulumi.get(self, "deployment_mode")

    @deployment_mode.setter
    def deployment_mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "deployment_mode", value)


@pulumi.input_type
class ApplicationJitAccessPolicyArgs:
    def __init__(__self__, *,
                 jit_access_enabled: pulumi.Input[bool],
                 jit_approval_mode: Optional[pulumi.Input[str]] = None,
                 jit_approvers: Optional[pulumi.Input[Sequence[pulumi.Input['JitApproverDefinitionArgs']]]] = None,
                 maximum_jit_access_duration: Optional[pulumi.Input[str]] = None):
        """
        Managed application Jit access policy.
        :param pulumi.Input[bool] jit_access_enabled: Whether the JIT access is enabled.
        :param pulumi.Input[str] jit_approval_mode: JIT approval mode.
        :param pulumi.Input[Sequence[pulumi.Input['JitApproverDefinitionArgs']]] jit_approvers: The JIT approvers
        :param pulumi.Input[str] maximum_jit_access_duration: The maximum duration JIT access is granted. This is an ISO8601 time period value.
        """
        pulumi.set(__self__, "jit_access_enabled", jit_access_enabled)
        if jit_approval_mode is not None:
            pulumi.set(__self__, "jit_approval_mode", jit_approval_mode)
        if jit_approvers is not None:
            pulumi.set(__self__, "jit_approvers", jit_approvers)
        if maximum_jit_access_duration is not None:
            pulumi.set(__self__, "maximum_jit_access_duration", maximum_jit_access_duration)

    @property
    @pulumi.getter(name="jitAccessEnabled")
    def jit_access_enabled(self) -> pulumi.Input[bool]:
        """
        Whether the JIT access is enabled.
        """
        return pulumi.get(self, "jit_access_enabled")

    @jit_access_enabled.setter
    def jit_access_enabled(self, value: pulumi.Input[bool]):
        pulumi.set(self, "jit_access_enabled", value)

    @property
    @pulumi.getter(name="jitApprovalMode")
    def jit_approval_mode(self) -> Optional[pulumi.Input[str]]:
        """
        JIT approval mode.
        """
        return pulumi.get(self, "jit_approval_mode")

    @jit_approval_mode.setter
    def jit_approval_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "jit_approval_mode", value)

    @property
    @pulumi.getter(name="jitApprovers")
    def jit_approvers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['JitApproverDefinitionArgs']]]]:
        """
        The JIT approvers
        """
        return pulumi.get(self, "jit_approvers")

    @jit_approvers.setter
    def jit_approvers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['JitApproverDefinitionArgs']]]]):
        pulumi.set(self, "jit_approvers", value)

    @property
    @pulumi.getter(name="maximumJitAccessDuration")
    def maximum_jit_access_duration(self) -> Optional[pulumi.Input[str]]:
        """
        The maximum duration JIT access is granted. This is an ISO8601 time period value.
        """
        return pulumi.get(self, "maximum_jit_access_duration")

    @maximum_jit_access_duration.setter
    def maximum_jit_access_duration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "maximum_jit_access_duration", value)


@pulumi.input_type
class ApplicationManagementPolicyArgs:
    def __init__(__self__, *,
                 mode: Optional[pulumi.Input[str]] = None):
        """
        Managed application management policy.
        :param pulumi.Input[str] mode: The managed application management mode.
        """
        if mode is not None:
            pulumi.set(__self__, "mode", mode)

    @property
    @pulumi.getter
    def mode(self) -> Optional[pulumi.Input[str]]:
        """
        The managed application management mode.
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mode", value)


@pulumi.input_type
class ApplicationNotificationEndpointArgs:
    def __init__(__self__, *,
                 uri: pulumi.Input[str]):
        """
        Managed application notification endpoint.
        :param pulumi.Input[str] uri: The managed application notification endpoint uri.
        """
        pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter
    def uri(self) -> pulumi.Input[str]:
        """
        The managed application notification endpoint uri.
        """
        return pulumi.get(self, "uri")

    @uri.setter
    def uri(self, value: pulumi.Input[str]):
        pulumi.set(self, "uri", value)


@pulumi.input_type
class ApplicationNotificationPolicyArgs:
    def __init__(__self__, *,
                 notification_endpoints: pulumi.Input[Sequence[pulumi.Input['ApplicationNotificationEndpointArgs']]]):
        """
        Managed application notification policy.
        :param pulumi.Input[Sequence[pulumi.Input['ApplicationNotificationEndpointArgs']]] notification_endpoints: The managed application notification endpoint.
        """
        pulumi.set(__self__, "notification_endpoints", notification_endpoints)

    @property
    @pulumi.getter(name="notificationEndpoints")
    def notification_endpoints(self) -> pulumi.Input[Sequence[pulumi.Input['ApplicationNotificationEndpointArgs']]]:
        """
        The managed application notification endpoint.
        """
        return pulumi.get(self, "notification_endpoints")

    @notification_endpoints.setter
    def notification_endpoints(self, value: pulumi.Input[Sequence[pulumi.Input['ApplicationNotificationEndpointArgs']]]):
        pulumi.set(self, "notification_endpoints", value)


@pulumi.input_type
class ApplicationPackageLockingPolicyDefinitionArgs:
    def __init__(__self__, *,
                 allowed_actions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Managed application locking policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] allowed_actions: The deny assignment excluded actions.
        """
        if allowed_actions is not None:
            pulumi.set(__self__, "allowed_actions", allowed_actions)

    @property
    @pulumi.getter(name="allowedActions")
    def allowed_actions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The deny assignment excluded actions.
        """
        return pulumi.get(self, "allowed_actions")

    @allowed_actions.setter
    def allowed_actions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "allowed_actions", value)


@pulumi.input_type
class ApplicationPolicyArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[str]] = None,
                 policy_definition_id: Optional[pulumi.Input[str]] = None):
        """
        Managed application policy.
        :param pulumi.Input[str] name: The policy name
        :param pulumi.Input[str] parameters: The policy parameters.
        :param pulumi.Input[str] policy_definition_id: The policy definition Id.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if policy_definition_id is not None:
            pulumi.set(__self__, "policy_definition_id", policy_definition_id)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The policy name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parameters(self) -> Optional[pulumi.Input[str]]:
        """
        The policy parameters.
        """
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "parameters", value)

    @property
    @pulumi.getter(name="policyDefinitionId")
    def policy_definition_id(self) -> Optional[pulumi.Input[str]]:
        """
        The policy definition Id.
        """
        return pulumi.get(self, "policy_definition_id")

    @policy_definition_id.setter
    def policy_definition_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "policy_definition_id", value)


@pulumi.input_type
class IdentityArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Identity for the resource.
        :param pulumi.Input[str] type: The identity type.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The identity type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class JitApproverDefinitionArgs:
    def __init__(__self__, *,
                 id: pulumi.Input[str],
                 display_name: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        JIT approver definition.
        :param pulumi.Input[str] id: The approver service principal Id.
        :param pulumi.Input[str] display_name: The approver display name.
        :param pulumi.Input[str] type: The approver type.
        """
        pulumi.set(__self__, "id", id)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> pulumi.Input[str]:
        """
        The approver service principal Id.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: pulumi.Input[str]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        The approver display name.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The approver type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class JitAuthorizationPoliciesArgs:
    def __init__(__self__, *,
                 principal_id: pulumi.Input[str],
                 role_definition_id: pulumi.Input[str]):
        """
        The JIT authorization policies.
        :param pulumi.Input[str] principal_id: The the principal id that will be granted JIT access.
        :param pulumi.Input[str] role_definition_id: The role definition id that will be granted to the Principal.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "role_definition_id", role_definition_id)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> pulumi.Input[str]:
        """
        The the principal id that will be granted JIT access.
        """
        return pulumi.get(self, "principal_id")

    @principal_id.setter
    def principal_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "principal_id", value)

    @property
    @pulumi.getter(name="roleDefinitionId")
    def role_definition_id(self) -> pulumi.Input[str]:
        """
        The role definition id that will be granted to the Principal.
        """
        return pulumi.get(self, "role_definition_id")

    @role_definition_id.setter
    def role_definition_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_definition_id", value)


@pulumi.input_type
class JitSchedulingPolicyArgs:
    def __init__(__self__, *,
                 duration: pulumi.Input[str],
                 start_time: pulumi.Input[str]):
        """
        The JIT scheduling policies.
        :param pulumi.Input[str] start_time: The start time of the request.
        """
        pulumi.set(__self__, "duration", duration)
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter
    def duration(self) -> pulumi.Input[str]:
        return pulumi.get(self, "duration")

    @duration.setter
    def duration(self, value: pulumi.Input[str]):
        pulumi.set(self, "duration", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Input[str]:
        """
        The start time of the request.
        """
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "start_time", value)


@pulumi.input_type
class PlanArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 product: pulumi.Input[str],
                 publisher: pulumi.Input[str],
                 version: pulumi.Input[str],
                 promotion_code: Optional[pulumi.Input[str]] = None):
        """
        Plan for the managed application.
        :param pulumi.Input[str] name: The plan name.
        :param pulumi.Input[str] product: The product code.
        :param pulumi.Input[str] publisher: The publisher ID.
        :param pulumi.Input[str] version: The plan's version.
        :param pulumi.Input[str] promotion_code: The promotion code.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "product", product)
        pulumi.set(__self__, "publisher", publisher)
        pulumi.set(__self__, "version", version)
        if promotion_code is not None:
            pulumi.set(__self__, "promotion_code", promotion_code)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The plan name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def product(self) -> pulumi.Input[str]:
        """
        The product code.
        """
        return pulumi.get(self, "product")

    @product.setter
    def product(self, value: pulumi.Input[str]):
        pulumi.set(self, "product", value)

    @property
    @pulumi.getter
    def publisher(self) -> pulumi.Input[str]:
        """
        The publisher ID.
        """
        return pulumi.get(self, "publisher")

    @publisher.setter
    def publisher(self, value: pulumi.Input[str]):
        pulumi.set(self, "publisher", value)

    @property
    @pulumi.getter
    def version(self) -> pulumi.Input[str]:
        """
        The plan's version.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: pulumi.Input[str]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter(name="promotionCode")
    def promotion_code(self) -> Optional[pulumi.Input[str]]:
        """
        The promotion code.
        """
        return pulumi.get(self, "promotion_code")

    @promotion_code.setter
    def promotion_code(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "promotion_code", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 capacity: Optional[pulumi.Input[int]] = None,
                 family: Optional[pulumi.Input[str]] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[str]] = None,
                 tier: Optional[pulumi.Input[str]] = None):
        """
        SKU for the resource.
        :param pulumi.Input[str] name: The SKU name.
        :param pulumi.Input[int] capacity: The SKU capacity.
        :param pulumi.Input[str] family: The SKU family.
        :param pulumi.Input[str] model: The SKU model.
        :param pulumi.Input[str] size: The SKU size.
        :param pulumi.Input[str] tier: The SKU tier.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if family is not None:
            pulumi.set(__self__, "family", family)
        if model is not None:
            pulumi.set(__self__, "model", model)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The SKU name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[pulumi.Input[int]]:
        """
        The SKU capacity.
        """
        return pulumi.get(self, "capacity")

    @capacity.setter
    def capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "capacity", value)

    @property
    @pulumi.getter
    def family(self) -> Optional[pulumi.Input[str]]:
        """
        The SKU family.
        """
        return pulumi.get(self, "family")

    @family.setter
    def family(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "family", value)

    @property
    @pulumi.getter
    def model(self) -> Optional[pulumi.Input[str]]:
        """
        The SKU model.
        """
        return pulumi.get(self, "model")

    @model.setter
    def model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "model", value)

    @property
    @pulumi.getter
    def size(self) -> Optional[pulumi.Input[str]]:
        """
        The SKU size.
        """
        return pulumi.get(self, "size")

    @size.setter
    def size(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "size", value)

    @property
    @pulumi.getter
    def tier(self) -> Optional[pulumi.Input[str]]:
        """
        The SKU tier.
        """
        return pulumi.get(self, "tier")

    @tier.setter
    def tier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tier", value)


