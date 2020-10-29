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
    'ClientInfoResponse',
    'IncidentAdditionalDataResponse',
    'IncidentInfoResponse',
    'IncidentLabelResponse',
    'IncidentOwnerInfoResponse',
    'UserInfoResponse',
    'WatchlistItemResponse',
]

@pulumi.output_type
class ClientInfoResponse(dict):
    """
    Information on the client (user or application) that made some action
    """
    def __init__(__self__, *,
                 email: Optional[str] = None,
                 name: Optional[str] = None,
                 object_id: Optional[str] = None,
                 user_principal_name: Optional[str] = None):
        """
        Information on the client (user or application) that made some action
        :param str email: The email of the client.
        :param str name: The name of the client.
        :param str object_id: The object id of the client.
        :param str user_principal_name: The user principal name of the client.
        """
        if email is not None:
            pulumi.set(__self__, "email", email)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if object_id is not None:
            pulumi.set(__self__, "object_id", object_id)
        if user_principal_name is not None:
            pulumi.set(__self__, "user_principal_name", user_principal_name)

    @property
    @pulumi.getter
    def email(self) -> Optional[str]:
        """
        The email of the client.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the client.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> Optional[str]:
        """
        The object id of the client.
        """
        return pulumi.get(self, "object_id")

    @property
    @pulumi.getter(name="userPrincipalName")
    def user_principal_name(self) -> Optional[str]:
        """
        The user principal name of the client.
        """
        return pulumi.get(self, "user_principal_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IncidentAdditionalDataResponse(dict):
    """
    Incident additional data property bag.
    """
    def __init__(__self__, *,
                 alert_product_names: Sequence[str],
                 alerts_count: int,
                 bookmarks_count: int,
                 comments_count: int,
                 tactics: Sequence[str]):
        """
        Incident additional data property bag.
        :param Sequence[str] alert_product_names: List of product names of alerts in the incident
        :param int alerts_count: The number of alerts in the incident
        :param int bookmarks_count: The number of bookmarks in the incident
        :param int comments_count: The number of comments in the incident
        :param Sequence[str] tactics: The tactics associated with incident
        """
        pulumi.set(__self__, "alert_product_names", alert_product_names)
        pulumi.set(__self__, "alerts_count", alerts_count)
        pulumi.set(__self__, "bookmarks_count", bookmarks_count)
        pulumi.set(__self__, "comments_count", comments_count)
        pulumi.set(__self__, "tactics", tactics)

    @property
    @pulumi.getter(name="alertProductNames")
    def alert_product_names(self) -> Sequence[str]:
        """
        List of product names of alerts in the incident
        """
        return pulumi.get(self, "alert_product_names")

    @property
    @pulumi.getter(name="alertsCount")
    def alerts_count(self) -> int:
        """
        The number of alerts in the incident
        """
        return pulumi.get(self, "alerts_count")

    @property
    @pulumi.getter(name="bookmarksCount")
    def bookmarks_count(self) -> int:
        """
        The number of bookmarks in the incident
        """
        return pulumi.get(self, "bookmarks_count")

    @property
    @pulumi.getter(name="commentsCount")
    def comments_count(self) -> int:
        """
        The number of comments in the incident
        """
        return pulumi.get(self, "comments_count")

    @property
    @pulumi.getter
    def tactics(self) -> Sequence[str]:
        """
        The tactics associated with incident
        """
        return pulumi.get(self, "tactics")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IncidentInfoResponse(dict):
    """
    Describes related incident information for the bookmark
    """
    def __init__(__self__, *,
                 incident_id: str,
                 relation_name: str,
                 severity: str,
                 title: str):
        """
        Describes related incident information for the bookmark
        :param str incident_id: Incident Id
        :param str relation_name: Relation Name
        :param str severity: The severity of the incident
        :param str title: The title of the incident
        """
        pulumi.set(__self__, "incident_id", incident_id)
        pulumi.set(__self__, "relation_name", relation_name)
        pulumi.set(__self__, "severity", severity)
        pulumi.set(__self__, "title", title)

    @property
    @pulumi.getter(name="incidentId")
    def incident_id(self) -> str:
        """
        Incident Id
        """
        return pulumi.get(self, "incident_id")

    @property
    @pulumi.getter(name="relationName")
    def relation_name(self) -> str:
        """
        Relation Name
        """
        return pulumi.get(self, "relation_name")

    @property
    @pulumi.getter
    def severity(self) -> str:
        """
        The severity of the incident
        """
        return pulumi.get(self, "severity")

    @property
    @pulumi.getter
    def title(self) -> str:
        """
        The title of the incident
        """
        return pulumi.get(self, "title")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IncidentLabelResponse(dict):
    """
    Represents an incident label
    """
    def __init__(__self__, *,
                 label_name: str,
                 label_type: str):
        """
        Represents an incident label
        :param str label_name: The name of the label
        :param str label_type: The type of the label
        """
        pulumi.set(__self__, "label_name", label_name)
        pulumi.set(__self__, "label_type", label_type)

    @property
    @pulumi.getter(name="labelName")
    def label_name(self) -> str:
        """
        The name of the label
        """
        return pulumi.get(self, "label_name")

    @property
    @pulumi.getter(name="labelType")
    def label_type(self) -> str:
        """
        The type of the label
        """
        return pulumi.get(self, "label_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IncidentOwnerInfoResponse(dict):
    """
    Information on the user an incident is assigned to
    """
    def __init__(__self__, *,
                 assigned_to: Optional[str] = None,
                 email: Optional[str] = None,
                 object_id: Optional[str] = None,
                 user_principal_name: Optional[str] = None):
        """
        Information on the user an incident is assigned to
        :param str assigned_to: The name of the user the incident is assigned to.
        :param str email: The email of the user the incident is assigned to.
        :param str object_id: The object id of the user the incident is assigned to.
        :param str user_principal_name: The user principal name of the user the incident is assigned to.
        """
        if assigned_to is not None:
            pulumi.set(__self__, "assigned_to", assigned_to)
        if email is not None:
            pulumi.set(__self__, "email", email)
        if object_id is not None:
            pulumi.set(__self__, "object_id", object_id)
        if user_principal_name is not None:
            pulumi.set(__self__, "user_principal_name", user_principal_name)

    @property
    @pulumi.getter(name="assignedTo")
    def assigned_to(self) -> Optional[str]:
        """
        The name of the user the incident is assigned to.
        """
        return pulumi.get(self, "assigned_to")

    @property
    @pulumi.getter
    def email(self) -> Optional[str]:
        """
        The email of the user the incident is assigned to.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> Optional[str]:
        """
        The object id of the user the incident is assigned to.
        """
        return pulumi.get(self, "object_id")

    @property
    @pulumi.getter(name="userPrincipalName")
    def user_principal_name(self) -> Optional[str]:
        """
        The user principal name of the user the incident is assigned to.
        """
        return pulumi.get(self, "user_principal_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class UserInfoResponse(dict):
    """
    User information that made some action
    """
    def __init__(__self__, *,
                 email: str,
                 name: str,
                 object_id: Optional[str] = None):
        """
        User information that made some action
        :param str email: The email of the user.
        :param str name: The name of the user.
        :param str object_id: The object id of the user.
        """
        pulumi.set(__self__, "email", email)
        pulumi.set(__self__, "name", name)
        if object_id is not None:
            pulumi.set(__self__, "object_id", object_id)

    @property
    @pulumi.getter
    def email(self) -> str:
        """
        The email of the user.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the user.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> Optional[str]:
        """
        The object id of the user.
        """
        return pulumi.get(self, "object_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class WatchlistItemResponse(dict):
    """
    Represents a Watchlist Item in Azure Security Insights.
    """
    def __init__(__self__, *,
                 id: str,
                 name: str,
                 type: str,
                 watchlist_id: str,
                 watchlist_item_pair: Any,
                 created_by: Optional['outputs.UserInfoResponse'] = None,
                 created_time_utc: Optional[str] = None,
                 entity_mapping: Optional[Any] = None,
                 last_updated_time_utc: Optional[str] = None,
                 tenant_id: Optional[str] = None,
                 time_to_live_utc: Optional[str] = None,
                 updated_by: Optional['outputs.UserInfoResponse'] = None,
                 watchlist_item_name: Optional[str] = None,
                 watchlist_item_type: Optional[str] = None):
        """
        Represents a Watchlist Item in Azure Security Insights.
        :param str id: Azure resource Id
        :param str name: Azure resource name
        :param str type: Azure resource type
        :param str watchlist_id: The watchlist id of the parent of this watchlist item
        :param Any watchlist_item_pair: A key-value pair for a watchlist item
        :param 'UserInfoResponseArgs' created_by: Describes a user that created the watchlist
        :param str created_time_utc: The time the watchlist item was created
        :param Any entity_mapping: A key-value pair for a watchlist item entity mapping
        :param str last_updated_time_utc: The last time the watchlist item was updated
        :param str tenant_id: The tenantId to which this watchlist item belongs to
        :param str time_to_live_utc: The time to live for the watchlist item
        :param 'UserInfoResponseArgs' updated_by: Describes a user that updated the watchlist
        :param str watchlist_item_name: Name of the watchlist item
        :param str watchlist_item_type: The type of the watchlist item
        """
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "watchlist_id", watchlist_id)
        pulumi.set(__self__, "watchlist_item_pair", watchlist_item_pair)
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if created_time_utc is not None:
            pulumi.set(__self__, "created_time_utc", created_time_utc)
        if entity_mapping is not None:
            pulumi.set(__self__, "entity_mapping", entity_mapping)
        if last_updated_time_utc is not None:
            pulumi.set(__self__, "last_updated_time_utc", last_updated_time_utc)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if time_to_live_utc is not None:
            pulumi.set(__self__, "time_to_live_utc", time_to_live_utc)
        if updated_by is not None:
            pulumi.set(__self__, "updated_by", updated_by)
        if watchlist_item_name is not None:
            pulumi.set(__self__, "watchlist_item_name", watchlist_item_name)
        if watchlist_item_type is not None:
            pulumi.set(__self__, "watchlist_item_type", watchlist_item_type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Azure resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Azure resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Azure resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="watchlistId")
    def watchlist_id(self) -> str:
        """
        The watchlist id of the parent of this watchlist item
        """
        return pulumi.get(self, "watchlist_id")

    @property
    @pulumi.getter(name="watchlistItemPair")
    def watchlist_item_pair(self) -> Any:
        """
        A key-value pair for a watchlist item
        """
        return pulumi.get(self, "watchlist_item_pair")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional['outputs.UserInfoResponse']:
        """
        Describes a user that created the watchlist
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdTimeUtc")
    def created_time_utc(self) -> Optional[str]:
        """
        The time the watchlist item was created
        """
        return pulumi.get(self, "created_time_utc")

    @property
    @pulumi.getter(name="entityMapping")
    def entity_mapping(self) -> Optional[Any]:
        """
        A key-value pair for a watchlist item entity mapping
        """
        return pulumi.get(self, "entity_mapping")

    @property
    @pulumi.getter(name="lastUpdatedTimeUtc")
    def last_updated_time_utc(self) -> Optional[str]:
        """
        The last time the watchlist item was updated
        """
        return pulumi.get(self, "last_updated_time_utc")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[str]:
        """
        The tenantId to which this watchlist item belongs to
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter(name="timeToLiveUtc")
    def time_to_live_utc(self) -> Optional[str]:
        """
        The time to live for the watchlist item
        """
        return pulumi.get(self, "time_to_live_utc")

    @property
    @pulumi.getter(name="updatedBy")
    def updated_by(self) -> Optional['outputs.UserInfoResponse']:
        """
        Describes a user that updated the watchlist
        """
        return pulumi.get(self, "updated_by")

    @property
    @pulumi.getter(name="watchlistItemName")
    def watchlist_item_name(self) -> Optional[str]:
        """
        Name of the watchlist item
        """
        return pulumi.get(self, "watchlist_item_name")

    @property
    @pulumi.getter(name="watchlistItemType")
    def watchlist_item_type(self) -> Optional[str]:
        """
        The type of the watchlist item
        """
        return pulumi.get(self, "watchlist_item_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


