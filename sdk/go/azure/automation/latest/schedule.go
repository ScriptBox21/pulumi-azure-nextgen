// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the schedule.
type Schedule struct {
	pulumi.CustomResourceState

	// Gets or sets the advanced schedule.
	AdvancedSchedule AdvancedScheduleResponsePtrOutput `pulumi:"advancedSchedule"`
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrOutput `pulumi:"creationTime"`
	// Gets or sets the description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Gets or sets the end time of the schedule.
	ExpiryTime pulumi.StringPtrOutput `pulumi:"expiryTime"`
	// Gets or sets the expiry time's offset in minutes.
	ExpiryTimeOffsetMinutes pulumi.Float64PtrOutput `pulumi:"expiryTimeOffsetMinutes"`
	// Gets or sets the frequency of the schedule.
	Frequency pulumi.StringPtrOutput `pulumi:"frequency"`
	// Gets or sets a value indicating whether this schedule is enabled.
	IsEnabled pulumi.BoolPtrOutput `pulumi:"isEnabled"`
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrOutput `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the next run time of the schedule.
	NextRun pulumi.StringPtrOutput `pulumi:"nextRun"`
	// Gets or sets the next run time's offset in minutes.
	NextRunOffsetMinutes pulumi.Float64PtrOutput `pulumi:"nextRunOffsetMinutes"`
	// Gets or sets the start time of the schedule.
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
	// Gets the start time's offset in minutes.
	StartTimeOffsetMinutes pulumi.Float64Output `pulumi:"startTimeOffsetMinutes"`
	// Gets or sets the time zone of the schedule.
	TimeZone pulumi.StringPtrOutput `pulumi:"timeZone"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSchedule registers a new resource with the given unique name, arguments, and options.
func NewSchedule(ctx *pulumi.Context,
	name string, args *ScheduleArgs, opts ...pulumi.ResourceOption) (*Schedule, error) {
	if args == nil || args.AutomationAccountName == nil {
		return nil, errors.New("missing required argument 'AutomationAccountName'")
	}
	if args == nil || args.Frequency == nil {
		return nil, errors.New("missing required argument 'Frequency'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ScheduleName == nil {
		return nil, errors.New("missing required argument 'ScheduleName'")
	}
	if args == nil || args.StartTime == nil {
		return nil, errors.New("missing required argument 'StartTime'")
	}
	if args == nil {
		args = &ScheduleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:automation/v20151031:Schedule"),
		},
	})
	opts = append(opts, aliases)
	var resource Schedule
	err := ctx.RegisterResource("azure-nextgen:automation/latest:Schedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSchedule gets an existing Schedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScheduleState, opts ...pulumi.ResourceOption) (*Schedule, error) {
	var resource Schedule
	err := ctx.ReadResource("azure-nextgen:automation/latest:Schedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Schedule resources.
type scheduleState struct {
	// Gets or sets the advanced schedule.
	AdvancedSchedule *AdvancedScheduleResponse `pulumi:"advancedSchedule"`
	// Gets or sets the creation time.
	CreationTime *string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the end time of the schedule.
	ExpiryTime *string `pulumi:"expiryTime"`
	// Gets or sets the expiry time's offset in minutes.
	ExpiryTimeOffsetMinutes *float64 `pulumi:"expiryTimeOffsetMinutes"`
	// Gets or sets the frequency of the schedule.
	Frequency *string `pulumi:"frequency"`
	// Gets or sets a value indicating whether this schedule is enabled.
	IsEnabled *bool `pulumi:"isEnabled"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Gets or sets the next run time of the schedule.
	NextRun *string `pulumi:"nextRun"`
	// Gets or sets the next run time's offset in minutes.
	NextRunOffsetMinutes *float64 `pulumi:"nextRunOffsetMinutes"`
	// Gets or sets the start time of the schedule.
	StartTime *string `pulumi:"startTime"`
	// Gets the start time's offset in minutes.
	StartTimeOffsetMinutes *float64 `pulumi:"startTimeOffsetMinutes"`
	// Gets or sets the time zone of the schedule.
	TimeZone *string `pulumi:"timeZone"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type ScheduleState struct {
	// Gets or sets the advanced schedule.
	AdvancedSchedule AdvancedScheduleResponsePtrInput
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrInput
	// Gets or sets the description.
	Description pulumi.StringPtrInput
	// Gets or sets the end time of the schedule.
	ExpiryTime pulumi.StringPtrInput
	// Gets or sets the expiry time's offset in minutes.
	ExpiryTimeOffsetMinutes pulumi.Float64PtrInput
	// Gets or sets the frequency of the schedule.
	Frequency pulumi.StringPtrInput
	// Gets or sets a value indicating whether this schedule is enabled.
	IsEnabled pulumi.BoolPtrInput
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Gets or sets the next run time of the schedule.
	NextRun pulumi.StringPtrInput
	// Gets or sets the next run time's offset in minutes.
	NextRunOffsetMinutes pulumi.Float64PtrInput
	// Gets or sets the start time of the schedule.
	StartTime pulumi.StringPtrInput
	// Gets the start time's offset in minutes.
	StartTimeOffsetMinutes pulumi.Float64PtrInput
	// Gets or sets the time zone of the schedule.
	TimeZone pulumi.StringPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (ScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleState)(nil)).Elem()
}

type scheduleArgs struct {
	// Gets or sets the AdvancedSchedule.
	AdvancedSchedule *AdvancedSchedule `pulumi:"advancedSchedule"`
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Gets or sets the description of the schedule.
	Description *string `pulumi:"description"`
	// Gets or sets the end time of the schedule.
	ExpiryTime *string `pulumi:"expiryTime"`
	// Gets or sets the frequency of the schedule.
	Frequency string `pulumi:"frequency"`
	// Gets or sets the interval of the schedule.
	Interval interface{} `pulumi:"interval"`
	// Gets or sets the name of the Schedule.
	Name string `pulumi:"name"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The schedule name.
	ScheduleName string `pulumi:"scheduleName"`
	// Gets or sets the start time of the schedule.
	StartTime string `pulumi:"startTime"`
	// Gets or sets the time zone of the schedule.
	TimeZone *string `pulumi:"timeZone"`
}

// The set of arguments for constructing a Schedule resource.
type ScheduleArgs struct {
	// Gets or sets the AdvancedSchedule.
	AdvancedSchedule AdvancedSchedulePtrInput
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// Gets or sets the description of the schedule.
	Description pulumi.StringPtrInput
	// Gets or sets the end time of the schedule.
	ExpiryTime pulumi.StringPtrInput
	// Gets or sets the frequency of the schedule.
	Frequency pulumi.StringInput
	// Gets or sets the interval of the schedule.
	Interval pulumi.Input
	// Gets or sets the name of the Schedule.
	Name pulumi.StringInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
	// The schedule name.
	ScheduleName pulumi.StringInput
	// Gets or sets the start time of the schedule.
	StartTime pulumi.StringInput
	// Gets or sets the time zone of the schedule.
	TimeZone pulumi.StringPtrInput
}

func (ScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleArgs)(nil)).Elem()
}
