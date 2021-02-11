// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNextGen.MachineLearningServices.Latest
{
    /// <summary>
    /// Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role.
    /// </summary>
    [EnumType]
    public readonly struct ApplicationSharingPolicy : IEquatable<ApplicationSharingPolicy>
    {
        private readonly string _value;

        private ApplicationSharingPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ApplicationSharingPolicy Personal { get; } = new ApplicationSharingPolicy("Personal");
        public static ApplicationSharingPolicy Shared { get; } = new ApplicationSharingPolicy("Shared");

        public static bool operator ==(ApplicationSharingPolicy left, ApplicationSharingPolicy right) => left.Equals(right);
        public static bool operator !=(ApplicationSharingPolicy left, ApplicationSharingPolicy right) => !left.Equals(right);

        public static explicit operator string(ApplicationSharingPolicy value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ApplicationSharingPolicy other && Equals(other);
        public bool Equals(ApplicationSharingPolicy other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Intended usage of the cluster
    /// </summary>
    [EnumType]
    public readonly struct ClusterPurpose : IEquatable<ClusterPurpose>
    {
        private readonly string _value;

        private ClusterPurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ClusterPurpose FastProd { get; } = new ClusterPurpose("FastProd");
        public static ClusterPurpose DenseProd { get; } = new ClusterPurpose("DenseProd");
        public static ClusterPurpose DevTest { get; } = new ClusterPurpose("DevTest");

        public static bool operator ==(ClusterPurpose left, ClusterPurpose right) => left.Equals(right);
        public static bool operator !=(ClusterPurpose left, ClusterPurpose right) => !left.Equals(right);

        public static explicit operator string(ClusterPurpose value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ClusterPurpose other && Equals(other);
        public bool Equals(ClusterPurpose other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The compute environment type for the service.
    /// </summary>
    [EnumType]
    public readonly struct ComputeEnvironmentType : IEquatable<ComputeEnvironmentType>
    {
        private readonly string _value;

        private ComputeEnvironmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ComputeEnvironmentType ACI { get; } = new ComputeEnvironmentType("ACI");
        public static ComputeEnvironmentType AKS { get; } = new ComputeEnvironmentType("AKS");

        public static bool operator ==(ComputeEnvironmentType left, ComputeEnvironmentType right) => left.Equals(right);
        public static bool operator !=(ComputeEnvironmentType left, ComputeEnvironmentType right) => !left.Equals(right);

        public static explicit operator string(ComputeEnvironmentType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ComputeEnvironmentType other && Equals(other);
        public bool Equals(ComputeEnvironmentType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The Compute Instance Authorization type. Available values are personal (default).
    /// </summary>
    [EnumType]
    public readonly struct ComputeInstanceAuthorizationType : IEquatable<ComputeInstanceAuthorizationType>
    {
        private readonly string _value;

        private ComputeInstanceAuthorizationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ComputeInstanceAuthorizationType Personal { get; } = new ComputeInstanceAuthorizationType("personal");

        public static bool operator ==(ComputeInstanceAuthorizationType left, ComputeInstanceAuthorizationType right) => left.Equals(right);
        public static bool operator !=(ComputeInstanceAuthorizationType left, ComputeInstanceAuthorizationType right) => !left.Equals(right);

        public static explicit operator string(ComputeInstanceAuthorizationType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ComputeInstanceAuthorizationType other && Equals(other);
        public bool Equals(ComputeInstanceAuthorizationType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of compute
    /// </summary>
    [EnumType]
    public readonly struct ComputeType : IEquatable<ComputeType>
    {
        private readonly string _value;

        private ComputeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ComputeType AKS { get; } = new ComputeType("AKS");
        public static ComputeType AmlCompute { get; } = new ComputeType("AmlCompute");
        public static ComputeType ComputeInstance { get; } = new ComputeType("ComputeInstance");
        public static ComputeType DataFactory { get; } = new ComputeType("DataFactory");
        public static ComputeType VirtualMachine { get; } = new ComputeType("VirtualMachine");
        public static ComputeType HDInsight { get; } = new ComputeType("HDInsight");
        public static ComputeType Databricks { get; } = new ComputeType("Databricks");
        public static ComputeType DataLakeAnalytics { get; } = new ComputeType("DataLakeAnalytics");

        public static bool operator ==(ComputeType left, ComputeType right) => left.Equals(right);
        public static bool operator !=(ComputeType left, ComputeType right) => !left.Equals(right);

        public static explicit operator string(ComputeType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ComputeType other && Equals(other);
        public bool Equals(ComputeType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Indicates whether or not the encryption is enabled for the workspace.
    /// </summary>
    [EnumType]
    public readonly struct EncryptionStatus : IEquatable<EncryptionStatus>
    {
        private readonly string _value;

        private EncryptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static EncryptionStatus Enabled { get; } = new EncryptionStatus("Enabled");
        public static EncryptionStatus Disabled { get; } = new EncryptionStatus("Disabled");

        public static bool operator ==(EncryptionStatus left, EncryptionStatus right) => left.Equals(right);
        public static bool operator !=(EncryptionStatus left, EncryptionStatus right) => !left.Equals(right);

        public static explicit operator string(EncryptionStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EncryptionStatus other && Equals(other);
        public bool Equals(EncryptionStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Compute OS Type
    /// </summary>
    [EnumType]
    public readonly struct OsType : IEquatable<OsType>
    {
        private readonly string _value;

        private OsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static OsType Linux { get; } = new OsType("Linux");
        public static OsType Windows { get; } = new OsType("Windows");

        public static bool operator ==(OsType left, OsType right) => left.Equals(right);
        public static bool operator !=(OsType left, OsType right) => !left.Equals(right);

        public static explicit operator string(OsType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is OsType other && Equals(other);
        public bool Equals(OsType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
    /// </summary>
    [EnumType]
    public readonly struct PrivateEndpointServiceConnectionStatus : IEquatable<PrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        private PrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static PrivateEndpointServiceConnectionStatus Pending { get; } = new PrivateEndpointServiceConnectionStatus("Pending");
        public static PrivateEndpointServiceConnectionStatus Approved { get; } = new PrivateEndpointServiceConnectionStatus("Approved");
        public static PrivateEndpointServiceConnectionStatus Rejected { get; } = new PrivateEndpointServiceConnectionStatus("Rejected");
        public static PrivateEndpointServiceConnectionStatus Disconnected { get; } = new PrivateEndpointServiceConnectionStatus("Disconnected");
        public static PrivateEndpointServiceConnectionStatus Timeout { get; } = new PrivateEndpointServiceConnectionStatus("Timeout");

        public static bool operator ==(PrivateEndpointServiceConnectionStatus left, PrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        public static bool operator !=(PrivateEndpointServiceConnectionStatus left, PrivateEndpointServiceConnectionStatus right) => !left.Equals(right);

        public static explicit operator string(PrivateEndpointServiceConnectionStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is PrivateEndpointServiceConnectionStatus other && Equals(other);
        public bool Equals(PrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled.
    /// </summary>
    [EnumType]
    public readonly struct RemoteLoginPortPublicAccess : IEquatable<RemoteLoginPortPublicAccess>
    {
        private readonly string _value;

        private RemoteLoginPortPublicAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static RemoteLoginPortPublicAccess Enabled { get; } = new RemoteLoginPortPublicAccess("Enabled");
        public static RemoteLoginPortPublicAccess Disabled { get; } = new RemoteLoginPortPublicAccess("Disabled");
        public static RemoteLoginPortPublicAccess NotSpecified { get; } = new RemoteLoginPortPublicAccess("NotSpecified");

        public static bool operator ==(RemoteLoginPortPublicAccess left, RemoteLoginPortPublicAccess right) => left.Equals(right);
        public static bool operator !=(RemoteLoginPortPublicAccess left, RemoteLoginPortPublicAccess right) => !left.Equals(right);

        public static explicit operator string(RemoteLoginPortPublicAccess value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RemoteLoginPortPublicAccess other && Equals(other);
        public bool Equals(RemoteLoginPortPublicAccess other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The identity type.
    /// </summary>
    [EnumType]
    public readonly struct ResourceIdentityType : IEquatable<ResourceIdentityType>
    {
        private readonly string _value;

        private ResourceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ResourceIdentityType SystemAssigned { get; } = new ResourceIdentityType("SystemAssigned");
        public static ResourceIdentityType SystemAssigned_UserAssigned { get; } = new ResourceIdentityType("SystemAssigned,UserAssigned");
        public static ResourceIdentityType UserAssigned { get; } = new ResourceIdentityType("UserAssigned");
        public static ResourceIdentityType None { get; } = new ResourceIdentityType("None");

        public static bool operator ==(ResourceIdentityType left, ResourceIdentityType right) => left.Equals(right);
        public static bool operator !=(ResourceIdentityType left, ResourceIdentityType right) => !left.Equals(right);

        public static explicit operator string(ResourceIdentityType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ResourceIdentityType other && Equals(other);
        public bool Equals(ResourceIdentityType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the VNet/subnet policy if applicable.
    /// </summary>
    [EnumType]
    public readonly struct SshPublicAccess : IEquatable<SshPublicAccess>
    {
        private readonly string _value;

        private SshPublicAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SshPublicAccess Enabled { get; } = new SshPublicAccess("Enabled");
        public static SshPublicAccess Disabled { get; } = new SshPublicAccess("Disabled");

        public static bool operator ==(SshPublicAccess left, SshPublicAccess right) => left.Equals(right);
        public static bool operator !=(SshPublicAccess left, SshPublicAccess right) => !left.Equals(right);

        public static explicit operator string(SshPublicAccess value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SshPublicAccess other && Equals(other);
        public bool Equals(SshPublicAccess other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// format for the workspace connection value
    /// </summary>
    [EnumType]
    public readonly struct ValueFormat : IEquatable<ValueFormat>
    {
        private readonly string _value;

        private ValueFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ValueFormat JSON { get; } = new ValueFormat("JSON");

        public static bool operator ==(ValueFormat left, ValueFormat right) => left.Equals(right);
        public static bool operator !=(ValueFormat left, ValueFormat right) => !left.Equals(right);

        public static explicit operator string(ValueFormat value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ValueFormat other && Equals(other);
        public bool Equals(ValueFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Virtual Machine priority
    /// </summary>
    [EnumType]
    public readonly struct VmPriority : IEquatable<VmPriority>
    {
        private readonly string _value;

        private VmPriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static VmPriority Dedicated { get; } = new VmPriority("Dedicated");
        public static VmPriority LowPriority { get; } = new VmPriority("LowPriority");

        public static bool operator ==(VmPriority left, VmPriority right) => left.Equals(right);
        public static bool operator !=(VmPriority left, VmPriority right) => !left.Equals(right);

        public static explicit operator string(VmPriority value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is VmPriority other && Equals(other);
        public bool Equals(VmPriority other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
