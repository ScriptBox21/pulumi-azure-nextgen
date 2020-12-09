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
    'GetWebAppPublicCertificateResult',
    'AwaitableGetWebAppPublicCertificateResult',
    'get_web_app_public_certificate',
]

@pulumi.output_type
class GetWebAppPublicCertificateResult:
    """
    Public certificate object
    """
    def __init__(__self__, blob=None, kind=None, name=None, public_certificate_location=None, system_data=None, thumbprint=None, type=None):
        if blob and not isinstance(blob, str):
            raise TypeError("Expected argument 'blob' to be a str")
        pulumi.set(__self__, "blob", blob)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if public_certificate_location and not isinstance(public_certificate_location, str):
            raise TypeError("Expected argument 'public_certificate_location' to be a str")
        pulumi.set(__self__, "public_certificate_location", public_certificate_location)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if thumbprint and not isinstance(thumbprint, str):
            raise TypeError("Expected argument 'thumbprint' to be a str")
        pulumi.set(__self__, "thumbprint", thumbprint)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def blob(self) -> Optional[str]:
        """
        Public Certificate byte array
        """
        return pulumi.get(self, "blob")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="publicCertificateLocation")
    def public_certificate_location(self) -> Optional[str]:
        """
        Public Certificate Location
        """
        return pulumi.get(self, "public_certificate_location")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system metadata relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def thumbprint(self) -> str:
        """
        Certificate Thumbprint
        """
        return pulumi.get(self, "thumbprint")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetWebAppPublicCertificateResult(GetWebAppPublicCertificateResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWebAppPublicCertificateResult(
            blob=self.blob,
            kind=self.kind,
            name=self.name,
            public_certificate_location=self.public_certificate_location,
            system_data=self.system_data,
            thumbprint=self.thumbprint,
            type=self.type)


def get_web_app_public_certificate(name: Optional[str] = None,
                                   public_certificate_name: Optional[str] = None,
                                   resource_group_name: Optional[str] = None,
                                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWebAppPublicCertificateResult:
    """
    Use this data source to access information about an existing resource.

    :param str name: Name of the app.
    :param str public_certificate_name: Public certificate name.
    :param str resource_group_name: Name of the resource group to which the resource belongs.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['publicCertificateName'] = public_certificate_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:web/latest:getWebAppPublicCertificate', __args__, opts=opts, typ=GetWebAppPublicCertificateResult).value

    return AwaitableGetWebAppPublicCertificateResult(
        blob=__ret__.blob,
        kind=__ret__.kind,
        name=__ret__.name,
        public_certificate_location=__ret__.public_certificate_location,
        system_data=__ret__.system_data,
        thumbprint=__ret__.thumbprint,
        type=__ret__.type)
