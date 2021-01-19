// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNextGen.Quantum.V20191104Preview
{
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
    /// Provisioning status field
    /// </summary>
    [EnumType]
    public readonly struct Status : IEquatable<Status>
    {
        private readonly string _value;

        private Status(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Status Succeeded { get; } = new Status("Succeeded");
        public static Status Launching { get; } = new Status("Launching");
        public static Status Updating { get; } = new Status("Updating");
        public static Status Deleting { get; } = new Status("Deleting");
        public static Status Deleted { get; } = new Status("Deleted");
        public static Status Failed { get; } = new Status("Failed");

        public static bool operator ==(Status left, Status right) => left.Equals(right);
        public static bool operator !=(Status left, Status right) => !left.Equals(right);

        public static explicit operator string(Status value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Status other && Equals(other);
        public bool Equals(Status other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
