# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from ._enums import *
from ._inputs import *

__all__ = ['ThreatIntelligenceIndicator']


class ThreatIntelligenceIndicator(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 confidence: Optional[pulumi.Input[int]] = None,
                 created: Optional[pulumi.Input[str]] = None,
                 created_by_ref: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 extensions: Optional[Any] = None,
                 external_id: Optional[pulumi.Input[str]] = None,
                 external_references: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 granular_markings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceGranularMarkingModelArgs']]]]] = None,
                 indicator_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 kill_chain_phases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceKillChainPhaseArgs']]]]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'ThreatIntelligenceResourceKind']]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 language: Optional[pulumi.Input[str]] = None,
                 last_updated_time_utc: Optional[pulumi.Input[str]] = None,
                 modified: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 operational_insights_resource_provider: Optional[pulumi.Input[str]] = None,
                 parsed_pattern: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceParsedPatternArgs']]]]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 pattern_type: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 revoked: Optional[pulumi.Input[bool]] = None,
                 source: Optional[pulumi.Input[str]] = None,
                 threat_intelligence_tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 threat_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 valid_from: Optional[pulumi.Input[str]] = None,
                 valid_until: Optional[pulumi.Input[str]] = None,
                 workspace_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Threat intelligence information object.
        API Version: 2019-01-01-preview.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] confidence: Confidence of threat intelligence entity
        :param pulumi.Input[str] created: Created by
        :param pulumi.Input[str] created_by_ref: Created by reference of threat intelligence entity
        :param pulumi.Input[str] description: Description of a threat intelligence entity
        :param pulumi.Input[str] display_name: Display name of a threat intelligence entity
        :param pulumi.Input[str] etag: Etag of the azure resource
        :param Any extensions: Extensions map
        :param pulumi.Input[str] external_id: External ID of threat intelligence entity
        :param pulumi.Input[Sequence[pulumi.Input[str]]] external_references: External References
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceGranularMarkingModelArgs']]]] granular_markings: Granular Markings
        :param pulumi.Input[Sequence[pulumi.Input[str]]] indicator_types: Indicator types of threat intelligence entities
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceKillChainPhaseArgs']]]] kill_chain_phases: Kill chain phases
        :param pulumi.Input[Union[str, 'ThreatIntelligenceResourceKind']] kind: The kind of the entity.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] labels: Labels  of threat intelligence entity
        :param pulumi.Input[str] language: Language of threat intelligence entity
        :param pulumi.Input[str] last_updated_time_utc: Last updated time in UTC
        :param pulumi.Input[str] modified: Modified by
        :param pulumi.Input[str] name: Threat intelligence indicator name field.
        :param pulumi.Input[str] operational_insights_resource_provider: The namespace of workspaces resource provider- Microsoft.OperationalInsights.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ThreatIntelligenceParsedPatternArgs']]]] parsed_pattern: Parsed patterns
        :param pulumi.Input[str] pattern: Pattern of a threat intelligence entity
        :param pulumi.Input[str] pattern_type: Pattern type of a threat intelligence entity
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
        :param pulumi.Input[bool] revoked: Is threat intelligence entity revoked
        :param pulumi.Input[str] source: Source of a threat intelligence entity
        :param pulumi.Input[Sequence[pulumi.Input[str]]] threat_intelligence_tags: List of tags
        :param pulumi.Input[Sequence[pulumi.Input[str]]] threat_types: Threat types
        :param pulumi.Input[str] valid_from: Valid from
        :param pulumi.Input[str] valid_until: Valid until
        :param pulumi.Input[str] workspace_name: The name of the workspace.
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

            __props__['confidence'] = confidence
            __props__['created'] = created
            __props__['created_by_ref'] = created_by_ref
            __props__['description'] = description
            __props__['display_name'] = display_name
            __props__['etag'] = etag
            __props__['extensions'] = extensions
            __props__['external_id'] = external_id
            __props__['external_references'] = external_references
            __props__['granular_markings'] = granular_markings
            __props__['indicator_types'] = indicator_types
            __props__['kill_chain_phases'] = kill_chain_phases
            if kind is None and not opts.urn:
                raise TypeError("Missing required property 'kind'")
            __props__['kind'] = kind
            __props__['labels'] = labels
            __props__['language'] = language
            __props__['last_updated_time_utc'] = last_updated_time_utc
            __props__['modified'] = modified
            __props__['name'] = name
            if operational_insights_resource_provider is None and not opts.urn:
                raise TypeError("Missing required property 'operational_insights_resource_provider'")
            __props__['operational_insights_resource_provider'] = operational_insights_resource_provider
            __props__['parsed_pattern'] = parsed_pattern
            __props__['pattern'] = pattern
            __props__['pattern_type'] = pattern_type
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['revoked'] = revoked
            __props__['source'] = source
            __props__['threat_intelligence_tags'] = threat_intelligence_tags
            __props__['threat_types'] = threat_types
            __props__['valid_from'] = valid_from
            __props__['valid_until'] = valid_until
            if workspace_name is None and not opts.urn:
                raise TypeError("Missing required property 'workspace_name'")
            __props__['workspace_name'] = workspace_name
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:securityinsights/v20190101preview:ThreatIntelligenceIndicator")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(ThreatIntelligenceIndicator, __self__).__init__(
            'azure-nextgen:securityinsights:ThreatIntelligenceIndicator',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ThreatIntelligenceIndicator':
        """
        Get an existing ThreatIntelligenceIndicator resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return ThreatIntelligenceIndicator(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        Etag of the azure resource
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[str]:
        """
        The kind of the entity.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Azure resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Azure resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

