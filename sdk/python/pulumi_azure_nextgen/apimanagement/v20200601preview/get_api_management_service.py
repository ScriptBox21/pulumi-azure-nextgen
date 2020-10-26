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
    'GetApiManagementServiceResult',
    'AwaitableGetApiManagementServiceResult',
    'get_api_management_service',
]

@pulumi.output_type
class GetApiManagementServiceResult:
    """
    A single API Management service resource in List or Get response.
    """
    def __init__(__self__, additional_locations=None, api_version_constraint=None, certificates=None, created_at_utc=None, custom_properties=None, developer_portal_url=None, disable_gateway=None, enable_client_certificate=None, etag=None, gateway_regional_url=None, gateway_url=None, hostname_configurations=None, identity=None, location=None, management_api_url=None, name=None, notification_sender_email=None, portal_url=None, private_ip_addresses=None, provisioning_state=None, public_ip_addresses=None, publisher_email=None, publisher_name=None, restore=None, scm_url=None, sku=None, tags=None, target_provisioning_state=None, type=None, virtual_network_configuration=None, virtual_network_type=None, zones=None):
        if additional_locations and not isinstance(additional_locations, list):
            raise TypeError("Expected argument 'additional_locations' to be a list")
        pulumi.set(__self__, "additional_locations", additional_locations)
        if api_version_constraint and not isinstance(api_version_constraint, dict):
            raise TypeError("Expected argument 'api_version_constraint' to be a dict")
        pulumi.set(__self__, "api_version_constraint", api_version_constraint)
        if certificates and not isinstance(certificates, list):
            raise TypeError("Expected argument 'certificates' to be a list")
        pulumi.set(__self__, "certificates", certificates)
        if created_at_utc and not isinstance(created_at_utc, str):
            raise TypeError("Expected argument 'created_at_utc' to be a str")
        pulumi.set(__self__, "created_at_utc", created_at_utc)
        if custom_properties and not isinstance(custom_properties, dict):
            raise TypeError("Expected argument 'custom_properties' to be a dict")
        pulumi.set(__self__, "custom_properties", custom_properties)
        if developer_portal_url and not isinstance(developer_portal_url, str):
            raise TypeError("Expected argument 'developer_portal_url' to be a str")
        pulumi.set(__self__, "developer_portal_url", developer_portal_url)
        if disable_gateway and not isinstance(disable_gateway, bool):
            raise TypeError("Expected argument 'disable_gateway' to be a bool")
        pulumi.set(__self__, "disable_gateway", disable_gateway)
        if enable_client_certificate and not isinstance(enable_client_certificate, bool):
            raise TypeError("Expected argument 'enable_client_certificate' to be a bool")
        pulumi.set(__self__, "enable_client_certificate", enable_client_certificate)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if gateway_regional_url and not isinstance(gateway_regional_url, str):
            raise TypeError("Expected argument 'gateway_regional_url' to be a str")
        pulumi.set(__self__, "gateway_regional_url", gateway_regional_url)
        if gateway_url and not isinstance(gateway_url, str):
            raise TypeError("Expected argument 'gateway_url' to be a str")
        pulumi.set(__self__, "gateway_url", gateway_url)
        if hostname_configurations and not isinstance(hostname_configurations, list):
            raise TypeError("Expected argument 'hostname_configurations' to be a list")
        pulumi.set(__self__, "hostname_configurations", hostname_configurations)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if management_api_url and not isinstance(management_api_url, str):
            raise TypeError("Expected argument 'management_api_url' to be a str")
        pulumi.set(__self__, "management_api_url", management_api_url)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if notification_sender_email and not isinstance(notification_sender_email, str):
            raise TypeError("Expected argument 'notification_sender_email' to be a str")
        pulumi.set(__self__, "notification_sender_email", notification_sender_email)
        if portal_url and not isinstance(portal_url, str):
            raise TypeError("Expected argument 'portal_url' to be a str")
        pulumi.set(__self__, "portal_url", portal_url)
        if private_ip_addresses and not isinstance(private_ip_addresses, list):
            raise TypeError("Expected argument 'private_ip_addresses' to be a list")
        pulumi.set(__self__, "private_ip_addresses", private_ip_addresses)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if public_ip_addresses and not isinstance(public_ip_addresses, list):
            raise TypeError("Expected argument 'public_ip_addresses' to be a list")
        pulumi.set(__self__, "public_ip_addresses", public_ip_addresses)
        if publisher_email and not isinstance(publisher_email, str):
            raise TypeError("Expected argument 'publisher_email' to be a str")
        pulumi.set(__self__, "publisher_email", publisher_email)
        if publisher_name and not isinstance(publisher_name, str):
            raise TypeError("Expected argument 'publisher_name' to be a str")
        pulumi.set(__self__, "publisher_name", publisher_name)
        if restore and not isinstance(restore, bool):
            raise TypeError("Expected argument 'restore' to be a bool")
        pulumi.set(__self__, "restore", restore)
        if scm_url and not isinstance(scm_url, str):
            raise TypeError("Expected argument 'scm_url' to be a str")
        pulumi.set(__self__, "scm_url", scm_url)
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        pulumi.set(__self__, "sku", sku)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if target_provisioning_state and not isinstance(target_provisioning_state, str):
            raise TypeError("Expected argument 'target_provisioning_state' to be a str")
        pulumi.set(__self__, "target_provisioning_state", target_provisioning_state)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_network_configuration and not isinstance(virtual_network_configuration, dict):
            raise TypeError("Expected argument 'virtual_network_configuration' to be a dict")
        pulumi.set(__self__, "virtual_network_configuration", virtual_network_configuration)
        if virtual_network_type and not isinstance(virtual_network_type, str):
            raise TypeError("Expected argument 'virtual_network_type' to be a str")
        pulumi.set(__self__, "virtual_network_type", virtual_network_type)
        if zones and not isinstance(zones, list):
            raise TypeError("Expected argument 'zones' to be a list")
        pulumi.set(__self__, "zones", zones)

    @property
    @pulumi.getter(name="additionalLocations")
    def additional_locations(self) -> Optional[Sequence['outputs.AdditionalLocationResponse']]:
        """
        Additional datacenter locations of the API Management service.
        """
        return pulumi.get(self, "additional_locations")

    @property
    @pulumi.getter(name="apiVersionConstraint")
    def api_version_constraint(self) -> Optional['outputs.ApiVersionConstraintResponse']:
        """
        Control Plane Apis version constraint for the API Management service.
        """
        return pulumi.get(self, "api_version_constraint")

    @property
    @pulumi.getter
    def certificates(self) -> Optional[Sequence['outputs.CertificateConfigurationResponse']]:
        """
        List of Certificates that need to be installed in the API Management service. Max supported certificates that can be installed is 10.
        """
        return pulumi.get(self, "certificates")

    @property
    @pulumi.getter(name="createdAtUtc")
    def created_at_utc(self) -> str:
        """
        Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        """
        return pulumi.get(self, "created_at_utc")

    @property
    @pulumi.getter(name="customProperties")
    def custom_properties(self) -> Optional[Mapping[str, str]]:
        """
        Custom properties of the API Management service.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API Management service.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be used to disable just TLS 1.1 for communications with backends.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for communications with backends.</br>Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be used to enable HTTP2 protocol on an API Management service.</br>Not specifying any of these properties on PATCH operation will reset omitted properties' values to their defaults. For all the settings except Http2 the default value is `True` if the service was created on or before April 1st 2018 and `False` otherwise. Http2 setting's default value is `False`.</br></br>You can disable any of next ciphers by using settings `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example, `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default value is `true` for them.  Note: next ciphers can't be disabled since they are required by Azure CloudService internal components: TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384
        """
        return pulumi.get(self, "custom_properties")

    @property
    @pulumi.getter(name="developerPortalUrl")
    def developer_portal_url(self) -> str:
        """
        DEveloper Portal endpoint URL of the API Management service.
        """
        return pulumi.get(self, "developer_portal_url")

    @property
    @pulumi.getter(name="disableGateway")
    def disable_gateway(self) -> Optional[bool]:
        """
        Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in master region.
        """
        return pulumi.get(self, "disable_gateway")

    @property
    @pulumi.getter(name="enableClientCertificate")
    def enable_client_certificate(self) -> Optional[bool]:
        """
        Property only meant to be used for Consumption SKU Service. This enforces a client certificate to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the policy on the gateway.
        """
        return pulumi.get(self, "enable_client_certificate")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        ETag of the resource.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="gatewayRegionalUrl")
    def gateway_regional_url(self) -> str:
        """
        Gateway URL of the API Management service in the Default Region.
        """
        return pulumi.get(self, "gateway_regional_url")

    @property
    @pulumi.getter(name="gatewayUrl")
    def gateway_url(self) -> str:
        """
        Gateway URL of the API Management service.
        """
        return pulumi.get(self, "gateway_url")

    @property
    @pulumi.getter(name="hostnameConfigurations")
    def hostname_configurations(self) -> Optional[Sequence['outputs.HostnameConfigurationResponse']]:
        """
        Custom hostname configuration of the API Management service.
        """
        return pulumi.get(self, "hostname_configurations")

    @property
    @pulumi.getter
    def identity(self) -> Optional['outputs.ApiManagementServiceIdentityResponse']:
        """
        Managed service identity of the Api Management service.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managementApiUrl")
    def management_api_url(self) -> str:
        """
        Management API endpoint URL of the API Management service.
        """
        return pulumi.get(self, "management_api_url")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="notificationSenderEmail")
    def notification_sender_email(self) -> Optional[str]:
        """
        Email address from which the notification will be sent.
        """
        return pulumi.get(self, "notification_sender_email")

    @property
    @pulumi.getter(name="portalUrl")
    def portal_url(self) -> str:
        """
        Publisher portal endpoint Url of the API Management service.
        """
        return pulumi.get(self, "portal_url")

    @property
    @pulumi.getter(name="privateIPAddresses")
    def private_ip_addresses(self) -> Sequence[str]:
        """
        Private Static Load Balanced IP addresses of the API Management service in Primary region which is deployed in an Internal Virtual Network. Available only for Basic, Standard, Premium and Isolated SKU.
        """
        return pulumi.get(self, "private_ip_addresses")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicIPAddresses")
    def public_ip_addresses(self) -> Sequence[str]:
        """
        Public Static Load Balanced IP addresses of the API Management service in Primary region. Available only for Basic, Standard, Premium and Isolated SKU.
        """
        return pulumi.get(self, "public_ip_addresses")

    @property
    @pulumi.getter(name="publisherEmail")
    def publisher_email(self) -> str:
        """
        Publisher email.
        """
        return pulumi.get(self, "publisher_email")

    @property
    @pulumi.getter(name="publisherName")
    def publisher_name(self) -> str:
        """
        Publisher name.
        """
        return pulumi.get(self, "publisher_name")

    @property
    @pulumi.getter
    def restore(self) -> Optional[bool]:
        """
        Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True all other properties will be ignored.
        """
        return pulumi.get(self, "restore")

    @property
    @pulumi.getter(name="scmUrl")
    def scm_url(self) -> str:
        """
        SCM endpoint URL of the API Management service.
        """
        return pulumi.get(self, "scm_url")

    @property
    @pulumi.getter
    def sku(self) -> 'outputs.ApiManagementServiceSkuPropertiesResponse':
        """
        SKU properties of the API Management service.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="targetProvisioningState")
    def target_provisioning_state(self) -> str:
        """
        The provisioning state of the API Management service, which is targeted by the long running operation started on the service.
        """
        return pulumi.get(self, "target_provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type for API Management resource is set to Microsoft.ApiManagement.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkConfiguration")
    def virtual_network_configuration(self) -> Optional['outputs.VirtualNetworkConfigurationResponse']:
        """
        Virtual network configuration of the API Management service.
        """
        return pulumi.get(self, "virtual_network_configuration")

    @property
    @pulumi.getter(name="virtualNetworkType")
    def virtual_network_type(self) -> Optional[str]:
        """
        The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
        """
        return pulumi.get(self, "virtual_network_type")

    @property
    @pulumi.getter
    def zones(self) -> Optional[Sequence[str]]:
        """
        A list of availability zones denoting where the resource needs to come from.
        """
        return pulumi.get(self, "zones")


class AwaitableGetApiManagementServiceResult(GetApiManagementServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApiManagementServiceResult(
            additional_locations=self.additional_locations,
            api_version_constraint=self.api_version_constraint,
            certificates=self.certificates,
            created_at_utc=self.created_at_utc,
            custom_properties=self.custom_properties,
            developer_portal_url=self.developer_portal_url,
            disable_gateway=self.disable_gateway,
            enable_client_certificate=self.enable_client_certificate,
            etag=self.etag,
            gateway_regional_url=self.gateway_regional_url,
            gateway_url=self.gateway_url,
            hostname_configurations=self.hostname_configurations,
            identity=self.identity,
            location=self.location,
            management_api_url=self.management_api_url,
            name=self.name,
            notification_sender_email=self.notification_sender_email,
            portal_url=self.portal_url,
            private_ip_addresses=self.private_ip_addresses,
            provisioning_state=self.provisioning_state,
            public_ip_addresses=self.public_ip_addresses,
            publisher_email=self.publisher_email,
            publisher_name=self.publisher_name,
            restore=self.restore,
            scm_url=self.scm_url,
            sku=self.sku,
            tags=self.tags,
            target_provisioning_state=self.target_provisioning_state,
            type=self.type,
            virtual_network_configuration=self.virtual_network_configuration,
            virtual_network_type=self.virtual_network_type,
            zones=self.zones)


def get_api_management_service(resource_group_name: Optional[str] = None,
                               service_name: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApiManagementServiceResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:apimanagement/v20200601preview:getApiManagementService', __args__, opts=opts, typ=GetApiManagementServiceResult).value

    return AwaitableGetApiManagementServiceResult(
        additional_locations=__ret__.additional_locations,
        api_version_constraint=__ret__.api_version_constraint,
        certificates=__ret__.certificates,
        created_at_utc=__ret__.created_at_utc,
        custom_properties=__ret__.custom_properties,
        developer_portal_url=__ret__.developer_portal_url,
        disable_gateway=__ret__.disable_gateway,
        enable_client_certificate=__ret__.enable_client_certificate,
        etag=__ret__.etag,
        gateway_regional_url=__ret__.gateway_regional_url,
        gateway_url=__ret__.gateway_url,
        hostname_configurations=__ret__.hostname_configurations,
        identity=__ret__.identity,
        location=__ret__.location,
        management_api_url=__ret__.management_api_url,
        name=__ret__.name,
        notification_sender_email=__ret__.notification_sender_email,
        portal_url=__ret__.portal_url,
        private_ip_addresses=__ret__.private_ip_addresses,
        provisioning_state=__ret__.provisioning_state,
        public_ip_addresses=__ret__.public_ip_addresses,
        publisher_email=__ret__.publisher_email,
        publisher_name=__ret__.publisher_name,
        restore=__ret__.restore,
        scm_url=__ret__.scm_url,
        sku=__ret__.sku,
        tags=__ret__.tags,
        target_provisioning_state=__ret__.target_provisioning_state,
        type=__ret__.type,
        virtual_network_configuration=__ret__.virtual_network_configuration,
        virtual_network_type=__ret__.virtual_network_type,
        zones=__ret__.zones)
