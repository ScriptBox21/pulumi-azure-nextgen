// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Activity Log Alert rule resource.
type ActivityLogAlert struct {
	pulumi.CustomResourceState

	// The actions that will activate when the condition is met.
	Actions ActionListResponseOutput `pulumi:"actions"`
	// The condition that will cause this alert to activate.
	Condition AlertRuleAllOfConditionResponseOutput `pulumi:"condition"`
	// A description of this Activity Log Alert rule.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with resource IDs that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewActivityLogAlert registers a new resource with the given unique name, arguments, and options.
func NewActivityLogAlert(ctx *pulumi.Context,
	name string, args *ActivityLogAlertArgs, opts ...pulumi.ResourceOption) (*ActivityLogAlert, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Actions == nil {
		return nil, errors.New("invalid value for required argument 'Actions'")
	}
	if args.ActivityLogAlertName == nil {
		return nil, errors.New("invalid value for required argument 'ActivityLogAlertName'")
	}
	if args.Condition == nil {
		return nil, errors.New("invalid value for required argument 'Condition'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Scopes == nil {
		return nil, errors.New("invalid value for required argument 'Scopes'")
	}
	if args.Enabled == nil {
		args.Enabled = pulumi.BoolPtr(true)
	}
	if args.Location == nil {
		args.Location = pulumi.StringPtr("global")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:insights/latest:ActivityLogAlert"),
		},
		{
			Type: pulumi.String("azure-nextgen:insights/v20170401:ActivityLogAlert"),
		},
	})
	opts = append(opts, aliases)
	var resource ActivityLogAlert
	err := ctx.RegisterResource("azure-nextgen:insights/v20201001:ActivityLogAlert", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetActivityLogAlert gets an existing ActivityLogAlert resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetActivityLogAlert(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ActivityLogAlertState, opts ...pulumi.ResourceOption) (*ActivityLogAlert, error) {
	var resource ActivityLogAlert
	err := ctx.ReadResource("azure-nextgen:insights/v20201001:ActivityLogAlert", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ActivityLogAlert resources.
type activityLogAlertState struct {
	// The actions that will activate when the condition is met.
	Actions *ActionListResponse `pulumi:"actions"`
	// The condition that will cause this alert to activate.
	Condition *AlertRuleAllOfConditionResponse `pulumi:"condition"`
	// A description of this Activity Log Alert rule.
	Description *string `pulumi:"description"`
	// Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated.
	Enabled *bool `pulumi:"enabled"`
	// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with resource IDs that fall under one of these prefixes. This list must include at least one item.
	Scopes []string `pulumi:"scopes"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type ActivityLogAlertState struct {
	// The actions that will activate when the condition is met.
	Actions ActionListResponsePtrInput
	// The condition that will cause this alert to activate.
	Condition AlertRuleAllOfConditionResponsePtrInput
	// A description of this Activity Log Alert rule.
	Description pulumi.StringPtrInput
	// Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrInput
	// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with resource IDs that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (ActivityLogAlertState) ElementType() reflect.Type {
	return reflect.TypeOf((*activityLogAlertState)(nil)).Elem()
}

type activityLogAlertArgs struct {
	// The actions that will activate when the condition is met.
	Actions ActionList `pulumi:"actions"`
	// The name of the Activity Log Alert rule.
	ActivityLogAlertName string `pulumi:"activityLogAlertName"`
	// The condition that will cause this alert to activate.
	Condition AlertRuleAllOfCondition `pulumi:"condition"`
	// A description of this Activity Log Alert rule.
	Description *string `pulumi:"description"`
	// Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated.
	Enabled *bool `pulumi:"enabled"`
	// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with resource IDs that fall under one of these prefixes. This list must include at least one item.
	Scopes []string `pulumi:"scopes"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ActivityLogAlert resource.
type ActivityLogAlertArgs struct {
	// The actions that will activate when the condition is met.
	Actions ActionListInput
	// The name of the Activity Log Alert rule.
	ActivityLogAlertName pulumi.StringInput
	// The condition that will cause this alert to activate.
	Condition AlertRuleAllOfConditionInput
	// A description of this Activity Log Alert rule.
	Description pulumi.StringPtrInput
	// Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrInput
	// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// A list of resource IDs that will be used as prefixes. The alert will only apply to Activity Log events with resource IDs that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
}

func (ActivityLogAlertArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*activityLogAlertArgs)(nil)).Elem()
}

type ActivityLogAlertInput interface {
	pulumi.Input

	ToActivityLogAlertOutput() ActivityLogAlertOutput
	ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput
}

func (*ActivityLogAlert) ElementType() reflect.Type {
	return reflect.TypeOf((*ActivityLogAlert)(nil))
}

func (i *ActivityLogAlert) ToActivityLogAlertOutput() ActivityLogAlertOutput {
	return i.ToActivityLogAlertOutputWithContext(context.Background())
}

func (i *ActivityLogAlert) ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ActivityLogAlertOutput)
}

type ActivityLogAlertOutput struct {
	*pulumi.OutputState
}

func (ActivityLogAlertOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ActivityLogAlert)(nil))
}

func (o ActivityLogAlertOutput) ToActivityLogAlertOutput() ActivityLogAlertOutput {
	return o
}

func (o ActivityLogAlertOutput) ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ActivityLogAlertOutput{})
}
