# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = ['Certificate']


class Certificate(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 key_vault_id: Optional[pulumi.Input[str]] = None,
                 key_vault_secret_name: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 pfx_blob: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 server_farm_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        SSL certificate for an app.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_names: Host names the certificate applies to.
        :param pulumi.Input[str] key_vault_id: Key Vault Csm resource Id.
        :param pulumi.Input[str] key_vault_secret_name: Key Vault secret name.
        :param pulumi.Input[str] kind: Kind of resource.
        :param pulumi.Input[str] location: Resource Location.
        :param pulumi.Input[str] name: Name of the certificate.
        :param pulumi.Input[str] password: Certificate password.
        :param pulumi.Input[str] pfx_blob: Pfx blob.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[str] server_farm_id: Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
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

            __props__['host_names'] = host_names
            __props__['key_vault_id'] = key_vault_id
            __props__['key_vault_secret_name'] = key_vault_secret_name
            __props__['kind'] = kind
            __props__['location'] = location
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if password is None and not opts.urn:
                raise TypeError("Missing required property 'password'")
            __props__['password'] = password
            __props__['pfx_blob'] = pfx_blob
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['server_farm_id'] = server_farm_id
            __props__['tags'] = tags
            __props__['cer_blob'] = None
            __props__['expiration_date'] = None
            __props__['friendly_name'] = None
            __props__['hosting_environment_profile'] = None
            __props__['issue_date'] = None
            __props__['issuer'] = None
            __props__['key_vault_secret_status'] = None
            __props__['public_key_hash'] = None
            __props__['self_link'] = None
            __props__['site_name'] = None
            __props__['subject_name'] = None
            __props__['thumbprint'] = None
            __props__['type'] = None
            __props__['valid'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/latest:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20150801:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20160301:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20181101:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20190801:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20200601:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20200901:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20201001:Certificate")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Certificate, __self__).__init__(
            'azure-nextgen:web/v20180201:Certificate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Certificate':
        """
        Get an existing Certificate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Certificate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cerBlob")
    def cer_blob(self) -> pulumi.Output[str]:
        """
        Raw bytes of .cer file
        """
        return pulumi.get(self, "cer_blob")

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> pulumi.Output[str]:
        """
        Certificate expiration date.
        """
        return pulumi.get(self, "expiration_date")

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> pulumi.Output[str]:
        """
        Friendly name of the certificate.
        """
        return pulumi.get(self, "friendly_name")

    @property
    @pulumi.getter(name="hostNames")
    def host_names(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Host names the certificate applies to.
        """
        return pulumi.get(self, "host_names")

    @property
    @pulumi.getter(name="hostingEnvironmentProfile")
    def hosting_environment_profile(self) -> pulumi.Output['outputs.HostingEnvironmentProfileResponse']:
        """
        Specification for the App Service Environment to use for the certificate.
        """
        return pulumi.get(self, "hosting_environment_profile")

    @property
    @pulumi.getter(name="issueDate")
    def issue_date(self) -> pulumi.Output[str]:
        """
        Certificate issue Date.
        """
        return pulumi.get(self, "issue_date")

    @property
    @pulumi.getter
    def issuer(self) -> pulumi.Output[str]:
        """
        Certificate issuer.
        """
        return pulumi.get(self, "issuer")

    @property
    @pulumi.getter(name="keyVaultId")
    def key_vault_id(self) -> pulumi.Output[Optional[str]]:
        """
        Key Vault Csm resource Id.
        """
        return pulumi.get(self, "key_vault_id")

    @property
    @pulumi.getter(name="keyVaultSecretName")
    def key_vault_secret_name(self) -> pulumi.Output[Optional[str]]:
        """
        Key Vault secret name.
        """
        return pulumi.get(self, "key_vault_secret_name")

    @property
    @pulumi.getter(name="keyVaultSecretStatus")
    def key_vault_secret_status(self) -> pulumi.Output[str]:
        """
        Status of the Key Vault secret.
        """
        return pulumi.get(self, "key_vault_secret_status")

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
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        Certificate password.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="pfxBlob")
    def pfx_blob(self) -> pulumi.Output[Optional[str]]:
        """
        Pfx blob.
        """
        return pulumi.get(self, "pfx_blob")

    @property
    @pulumi.getter(name="publicKeyHash")
    def public_key_hash(self) -> pulumi.Output[str]:
        """
        Public key hash.
        """
        return pulumi.get(self, "public_key_hash")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> pulumi.Output[str]:
        """
        Self link.
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter(name="serverFarmId")
    def server_farm_id(self) -> pulumi.Output[Optional[str]]:
        """
        Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        """
        return pulumi.get(self, "server_farm_id")

    @property
    @pulumi.getter(name="siteName")
    def site_name(self) -> pulumi.Output[str]:
        """
        App name.
        """
        return pulumi.get(self, "site_name")

    @property
    @pulumi.getter(name="subjectName")
    def subject_name(self) -> pulumi.Output[str]:
        """
        Subject name of the certificate.
        """
        return pulumi.get(self, "subject_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def thumbprint(self) -> pulumi.Output[str]:
        """
        Certificate thumbprint.
        """
        return pulumi.get(self, "thumbprint")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def valid(self) -> pulumi.Output[bool]:
        """
        Is the certificate valid?.
        """
        return pulumi.get(self, "valid")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

