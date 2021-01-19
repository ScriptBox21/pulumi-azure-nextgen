# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = [
    'ProviderResponse',
    'QuantumWorkspaceResponseIdentity',
]

@pulumi.output_type
class ProviderResponse(dict):
    """
    Information about a Provider. A Provider is an entity that offers Targets to run Azure Quantum Jobs.
    """
    def __init__(__self__, *,
                 application_name: Optional[str] = None,
                 instance_uri: Optional[str] = None,
                 provider_id: Optional[str] = None,
                 provider_sku: Optional[str] = None,
                 provisioning_state: Optional[str] = None,
                 resource_usage_id: Optional[str] = None):
        """
        Information about a Provider. A Provider is an entity that offers Targets to run Azure Quantum Jobs.
        :param str application_name: The provider's marketplace application display name.
        :param str instance_uri: A Uri identifying the specific instance of this provider.
        :param str provider_id: Unique id of this provider.
        :param str provider_sku: The sku associated with pricing information for this provider.
        :param str provisioning_state: Provisioning status field
        :param str resource_usage_id: Id to track resource usage for the provider.
        """
        if application_name is not None:
            pulumi.set(__self__, "application_name", application_name)
        if instance_uri is not None:
            pulumi.set(__self__, "instance_uri", instance_uri)
        if provider_id is not None:
            pulumi.set(__self__, "provider_id", provider_id)
        if provider_sku is not None:
            pulumi.set(__self__, "provider_sku", provider_sku)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_usage_id is not None:
            pulumi.set(__self__, "resource_usage_id", resource_usage_id)

    @property
    @pulumi.getter(name="applicationName")
    def application_name(self) -> Optional[str]:
        """
        The provider's marketplace application display name.
        """
        return pulumi.get(self, "application_name")

    @property
    @pulumi.getter(name="instanceUri")
    def instance_uri(self) -> Optional[str]:
        """
        A Uri identifying the specific instance of this provider.
        """
        return pulumi.get(self, "instance_uri")

    @property
    @pulumi.getter(name="providerId")
    def provider_id(self) -> Optional[str]:
        """
        Unique id of this provider.
        """
        return pulumi.get(self, "provider_id")

    @property
    @pulumi.getter(name="providerSku")
    def provider_sku(self) -> Optional[str]:
        """
        The sku associated with pricing information for this provider.
        """
        return pulumi.get(self, "provider_sku")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        Provisioning status field
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceUsageId")
    def resource_usage_id(self) -> Optional[str]:
        """
        Id to track resource usage for the provider.
        """
        return pulumi.get(self, "resource_usage_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class QuantumWorkspaceResponseIdentity(dict):
    """
    Managed Identity information.
    """
    def __init__(__self__, *,
                 principal_id: str,
                 tenant_id: str,
                 type: Optional[str] = None):
        """
        Managed Identity information.
        :param str principal_id: The principal ID of resource identity.
        :param str tenant_id: The tenant ID of resource.
        :param str type: The identity type.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        The principal ID of resource identity.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The tenant ID of resource.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The identity type.
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


