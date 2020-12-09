# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AddressArgs',
    'ContactArgs',
    'DomainPurchaseConsentArgs',
]

@pulumi.input_type
class AddressArgs:
    def __init__(__self__, *,
                 address1: pulumi.Input[str],
                 city: pulumi.Input[str],
                 country: pulumi.Input[str],
                 postal_code: pulumi.Input[str],
                 state: pulumi.Input[str],
                 address2: Optional[pulumi.Input[str]] = None):
        """
        Address information for domain registration.
        :param pulumi.Input[str] address1: First line of an Address.
        :param pulumi.Input[str] city: The city for the address.
        :param pulumi.Input[str] country: The country for the address.
        :param pulumi.Input[str] postal_code: The postal code for the address.
        :param pulumi.Input[str] state: The state or province for the address.
        :param pulumi.Input[str] address2: The second line of the Address. Optional.
        """
        pulumi.set(__self__, "address1", address1)
        pulumi.set(__self__, "city", city)
        pulumi.set(__self__, "country", country)
        pulumi.set(__self__, "postal_code", postal_code)
        pulumi.set(__self__, "state", state)
        if address2 is not None:
            pulumi.set(__self__, "address2", address2)

    @property
    @pulumi.getter
    def address1(self) -> pulumi.Input[str]:
        """
        First line of an Address.
        """
        return pulumi.get(self, "address1")

    @address1.setter
    def address1(self, value: pulumi.Input[str]):
        pulumi.set(self, "address1", value)

    @property
    @pulumi.getter
    def city(self) -> pulumi.Input[str]:
        """
        The city for the address.
        """
        return pulumi.get(self, "city")

    @city.setter
    def city(self, value: pulumi.Input[str]):
        pulumi.set(self, "city", value)

    @property
    @pulumi.getter
    def country(self) -> pulumi.Input[str]:
        """
        The country for the address.
        """
        return pulumi.get(self, "country")

    @country.setter
    def country(self, value: pulumi.Input[str]):
        pulumi.set(self, "country", value)

    @property
    @pulumi.getter(name="postalCode")
    def postal_code(self) -> pulumi.Input[str]:
        """
        The postal code for the address.
        """
        return pulumi.get(self, "postal_code")

    @postal_code.setter
    def postal_code(self, value: pulumi.Input[str]):
        pulumi.set(self, "postal_code", value)

    @property
    @pulumi.getter
    def state(self) -> pulumi.Input[str]:
        """
        The state or province for the address.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: pulumi.Input[str]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter
    def address2(self) -> Optional[pulumi.Input[str]]:
        """
        The second line of the Address. Optional.
        """
        return pulumi.get(self, "address2")

    @address2.setter
    def address2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address2", value)


@pulumi.input_type
class ContactArgs:
    def __init__(__self__, *,
                 email: pulumi.Input[str],
                 name_first: pulumi.Input[str],
                 name_last: pulumi.Input[str],
                 phone: pulumi.Input[str],
                 address_mailing: Optional[pulumi.Input['AddressArgs']] = None,
                 fax: Optional[pulumi.Input[str]] = None,
                 job_title: Optional[pulumi.Input[str]] = None,
                 name_middle: Optional[pulumi.Input[str]] = None,
                 organization: Optional[pulumi.Input[str]] = None):
        """
        Contact information for domain registration. If 'Domain Privacy' option is not selected then the contact information is made publicly available through the Whois 
        directories as per ICANN requirements.
        :param pulumi.Input[str] email: Email address.
        :param pulumi.Input[str] name_first: First name.
        :param pulumi.Input[str] name_last: Last name.
        :param pulumi.Input[str] phone: Phone number.
        :param pulumi.Input['AddressArgs'] address_mailing: Mailing address.
        :param pulumi.Input[str] fax: Fax number.
        :param pulumi.Input[str] job_title: Job title.
        :param pulumi.Input[str] name_middle: Middle name.
        :param pulumi.Input[str] organization: Organization contact belongs to.
        """
        pulumi.set(__self__, "email", email)
        pulumi.set(__self__, "name_first", name_first)
        pulumi.set(__self__, "name_last", name_last)
        pulumi.set(__self__, "phone", phone)
        if address_mailing is not None:
            pulumi.set(__self__, "address_mailing", address_mailing)
        if fax is not None:
            pulumi.set(__self__, "fax", fax)
        if job_title is not None:
            pulumi.set(__self__, "job_title", job_title)
        if name_middle is not None:
            pulumi.set(__self__, "name_middle", name_middle)
        if organization is not None:
            pulumi.set(__self__, "organization", organization)

    @property
    @pulumi.getter
    def email(self) -> pulumi.Input[str]:
        """
        Email address.
        """
        return pulumi.get(self, "email")

    @email.setter
    def email(self, value: pulumi.Input[str]):
        pulumi.set(self, "email", value)

    @property
    @pulumi.getter(name="nameFirst")
    def name_first(self) -> pulumi.Input[str]:
        """
        First name.
        """
        return pulumi.get(self, "name_first")

    @name_first.setter
    def name_first(self, value: pulumi.Input[str]):
        pulumi.set(self, "name_first", value)

    @property
    @pulumi.getter(name="nameLast")
    def name_last(self) -> pulumi.Input[str]:
        """
        Last name.
        """
        return pulumi.get(self, "name_last")

    @name_last.setter
    def name_last(self, value: pulumi.Input[str]):
        pulumi.set(self, "name_last", value)

    @property
    @pulumi.getter
    def phone(self) -> pulumi.Input[str]:
        """
        Phone number.
        """
        return pulumi.get(self, "phone")

    @phone.setter
    def phone(self, value: pulumi.Input[str]):
        pulumi.set(self, "phone", value)

    @property
    @pulumi.getter(name="addressMailing")
    def address_mailing(self) -> Optional[pulumi.Input['AddressArgs']]:
        """
        Mailing address.
        """
        return pulumi.get(self, "address_mailing")

    @address_mailing.setter
    def address_mailing(self, value: Optional[pulumi.Input['AddressArgs']]):
        pulumi.set(self, "address_mailing", value)

    @property
    @pulumi.getter
    def fax(self) -> Optional[pulumi.Input[str]]:
        """
        Fax number.
        """
        return pulumi.get(self, "fax")

    @fax.setter
    def fax(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fax", value)

    @property
    @pulumi.getter(name="jobTitle")
    def job_title(self) -> Optional[pulumi.Input[str]]:
        """
        Job title.
        """
        return pulumi.get(self, "job_title")

    @job_title.setter
    def job_title(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "job_title", value)

    @property
    @pulumi.getter(name="nameMiddle")
    def name_middle(self) -> Optional[pulumi.Input[str]]:
        """
        Middle name.
        """
        return pulumi.get(self, "name_middle")

    @name_middle.setter
    def name_middle(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name_middle", value)

    @property
    @pulumi.getter
    def organization(self) -> Optional[pulumi.Input[str]]:
        """
        Organization contact belongs to.
        """
        return pulumi.get(self, "organization")

    @organization.setter
    def organization(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "organization", value)


@pulumi.input_type
class DomainPurchaseConsentArgs:
    def __init__(__self__, *,
                 agreed_at: Optional[pulumi.Input[str]] = None,
                 agreed_by: Optional[pulumi.Input[str]] = None,
                 agreement_keys: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Domain purchase consent object, representing acceptance of applicable legal agreements.
        :param pulumi.Input[str] agreed_at: Timestamp when the agreements were accepted.
        :param pulumi.Input[str] agreed_by: Client IP address.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] agreement_keys: List of applicable legal agreement keys. This list can be retrieved using ListLegalAgreements API under <code>TopLevelDomain</code> resource.
        """
        if agreed_at is not None:
            pulumi.set(__self__, "agreed_at", agreed_at)
        if agreed_by is not None:
            pulumi.set(__self__, "agreed_by", agreed_by)
        if agreement_keys is not None:
            pulumi.set(__self__, "agreement_keys", agreement_keys)

    @property
    @pulumi.getter(name="agreedAt")
    def agreed_at(self) -> Optional[pulumi.Input[str]]:
        """
        Timestamp when the agreements were accepted.
        """
        return pulumi.get(self, "agreed_at")

    @agreed_at.setter
    def agreed_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "agreed_at", value)

    @property
    @pulumi.getter(name="agreedBy")
    def agreed_by(self) -> Optional[pulumi.Input[str]]:
        """
        Client IP address.
        """
        return pulumi.get(self, "agreed_by")

    @agreed_by.setter
    def agreed_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "agreed_by", value)

    @property
    @pulumi.getter(name="agreementKeys")
    def agreement_keys(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of applicable legal agreement keys. This list can be retrieved using ListLegalAgreements API under <code>TopLevelDomain</code> resource.
        """
        return pulumi.get(self, "agreement_keys")

    @agreement_keys.setter
    def agreement_keys(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "agreement_keys", value)


