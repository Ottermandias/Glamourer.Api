﻿using Dalamud.Plugin;
using Glamourer.Api.Api;
using Glamourer.Api.Enums;
using Glamourer.Api.Helpers;
using Newtonsoft.Json.Linq;

namespace Glamourer.Api.IpcSubscribers;

/// <inheritdoc cref="IGlamourerApiState.GetState"/>
public sealed class GetState(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, (int, JObject?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetState)}";

    /// <inheritdoc cref="IGlamourerApiState.GetState"/>
    public new (GlamourerApiEc, JObject?) Invoke(int objectIndex, uint key = 0)
    {
        var (ec, data) = base.Invoke(objectIndex, key);
        return ((GlamourerApiEc)ec, data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, (int, JObject?)> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b) =>
        {
            var (ec, data) = api.GetState(a, b);
            return ((int)ec, data);
        });
}

/// <inheritdoc cref="IGlamourerApiState.GetStateName"/>
public sealed class GetStateName(IDalamudPluginInterface pi)
    : FuncSubscriber<string, uint, (int, JObject?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetStateName)}";

    /// <inheritdoc cref="IGlamourerApiState.GetStateName"/>
    public new (GlamourerApiEc, JObject?) Invoke(string objectName, uint key = 0)
    {
        var (ec, data) = base.Invoke(objectName, key);
        return ((GlamourerApiEc)ec, data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, uint, (int, JObject?)> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (i, k) =>
        {
            var (ec, data) = api.GetStateName(i, k);
            return ((int)ec, data);
        });
}

/// <inheritdoc cref="IGlamourerApiState.GetStateBase64"/>
public sealed class GetStateBase64(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, (int, string?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetStateBase64)}";

    /// <inheritdoc cref="IGlamourerApiState.GetStateBase64"/>
    public new (GlamourerApiEc, string?) Invoke(int objectIndex, uint key = 0)
    {
        var (ec, data) = base.Invoke(objectIndex, key);
        return ((GlamourerApiEc)ec, data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, (int, string?)> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b) =>
        {
            var (ec, data) = api.GetStateBase64(a, b);
            return ((int)ec, data);
        });
}

/// <inheritdoc cref="IGlamourerApiState.GetStateBase64Name"/>
public sealed class GetStateBase64Name(IDalamudPluginInterface pi)
    : FuncSubscriber<string, uint, (int, string?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetStateBase64Name)}";

    /// <inheritdoc cref="IGlamourerApiState.GetStateBase64Name"/>
    public new (GlamourerApiEc, string?) Invoke(string objectName, uint key = 0)
    {
        var (ec, data) = base.Invoke(objectName, key);
        return ((GlamourerApiEc)ec, data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, uint, (int, string?)> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (i, k) =>
        {
            var (ec, data) = api.GetStateBase64Name(i, k);
            return ((int)ec, data);
        });
}

/// <inheritdoc cref="IGlamourerApiState.ApplyState"/>
public sealed class ApplyState(IDalamudPluginInterface pi)
    : FuncSubscriber<object, int, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(ApplyState)}";

    /// <inheritdoc cref="IGlamourerApiState.ApplyState"/>
    public GlamourerApiEc Invoke(JObject state, int objectIndex, uint key = 0, ApplyFlag flags = ApplyFlagEx.StateDefault)
        => (GlamourerApiEc)Invoke(state, objectIndex, key, (ulong)flags);

    /// <inheritdoc cref="IGlamourerApiState.ApplyState"/>
    public GlamourerApiEc Invoke(string base64State, int objectIndex, uint key = 0, ApplyFlag flags = ApplyFlagEx.StateDefault)
        => (GlamourerApiEc)Invoke(base64State, objectIndex, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<object, int, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c, d) => (int)api.ApplyState(a, b, c, (ApplyFlag)d));
}

/// <inheritdoc cref="IGlamourerApiState.ApplyStateName"/>
public sealed class ApplyStateName(IDalamudPluginInterface pi)
    : FuncSubscriber<object, string, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(ApplyStateName)}";

    /// <inheritdoc cref="IGlamourerApiState.ApplyState"/>
    public GlamourerApiEc Invoke(JObject state, string objectName, uint key = 0, ApplyFlag flags = ApplyFlagEx.StateDefault)
        => (GlamourerApiEc)Invoke(state, objectName, key, (ulong)flags);

    /// <inheritdoc cref="IGlamourerApiState.ApplyState"/>
    public GlamourerApiEc Invoke(string base64State, string objectName, uint key = 0, ApplyFlag flags = ApplyFlagEx.StateDefault)
        => (GlamourerApiEc)Invoke(base64State, objectName, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<object, string, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c, d) => (int)api.ApplyStateName(a, b, c, (ApplyFlag)d));
}

/// <inheritdoc cref="IGlamourerApiState.RevertState"/>
public sealed class RevertState(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(RevertState)}";

    /// <inheritdoc cref="IGlamourerApiState.RevertState"/>
    public GlamourerApiEc Invoke(int objectIndex, uint key = 0, ApplyFlag flags = ApplyFlagEx.RevertDefault)
        => (GlamourerApiEc)Invoke(objectIndex, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c) => (int)api.RevertState(a, b, (ApplyFlag)c));
}

/// <inheritdoc cref="IGlamourerApiState.RevertStateName"/>
public sealed class RevertStateName(IDalamudPluginInterface pi)
    : FuncSubscriber<string, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(RevertStateName)}";

    /// <inheritdoc cref="IGlamourerApiState.RevertStateName"/>
    public GlamourerApiEc Invoke(string objectName, uint key = 0, ApplyFlag flags = ApplyFlagEx.RevertDefault)
        => (GlamourerApiEc)Invoke(objectName, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c) => (int)api.RevertStateName(a, b, (ApplyFlag)c));
}

/// <inheritdoc cref="IGlamourerApiState.UnlockState"/>
public sealed class UnlockState(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(UnlockState)}";

    /// <inheritdoc cref="IGlamourerApiState.UnlockState"/>
    public new GlamourerApiEc Invoke(int objectIndex, uint key = 0)
        => (GlamourerApiEc)base.Invoke(objectIndex, key);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b) => (int)api.UnlockState(a, b));
}

/// <inheritdoc cref="IGlamourerApiState.IsUnlocked"/>
public sealed class IsUnlocked(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, (GlamourerApiEc, bool?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(IsUnlocked)}";

    /// <inheritdoc cref="IGlamourerApiState.IsUnlocked"/>
    public new (GlamourerApiEc, bool?) Invoke(int objectIndex, uint key = 0)
        => base.Invoke(objectIndex, key);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, (GlamourerApiEc, bool?)> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b) => api.IsUnlocked(a, b));
}

/// <inheritdoc cref="IGlamourerApiState.UnlockStateName"/>
public sealed class UnlockStateName(IDalamudPluginInterface pi)
    : FuncSubscriber<string, uint, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(UnlockStateName)}";

    /// <inheritdoc cref="IGlamourerApiState.UnlockStateName"/>
    public new GlamourerApiEc Invoke(string objectName, uint key = 0)
        => (GlamourerApiEc)base.Invoke(objectName, key);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, uint, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b) => (int)api.UnlockStateName(a, b));
}

/// <inheritdoc cref="IGlamourerApiState.UnlockAll"/>
public sealed class UnlockAll(IDalamudPluginInterface pi)
    : FuncSubscriber<uint, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(UnlockAll)}";

    /// <inheritdoc cref="IGlamourerApiState.UnlockAll"/>
    public new int Invoke(uint key)
        => base.Invoke(key);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<uint, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, api.UnlockAll);
}

/// <inheritdoc cref="IGlamourerApiState.RevertToAutomation"/>
public sealed class RevertToAutomation(IDalamudPluginInterface pi)
    : FuncSubscriber<int, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(RevertToAutomation)}.V2";

    /// <inheritdoc cref="IGlamourerApiState.RevertToAutomation"/>
    public GlamourerApiEc Invoke(int objectIndex, uint key = 0, ApplyFlag flags = ApplyFlagEx.RevertDefault)
        => (GlamourerApiEc)Invoke(objectIndex, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c) => (int)api.RevertToAutomation(a, b, (ApplyFlag)c));
}

/// <inheritdoc cref="IGlamourerApiState.RevertToAutomationName"/>
public sealed class RevertToAutomationName(IDalamudPluginInterface pi)
    : FuncSubscriber<string, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(RevertToAutomationName)}";

    /// <inheritdoc cref="IGlamourerApiState.RevertToAutomationName"/>
    public GlamourerApiEc Invoke(string objectName, uint key = 0, ApplyFlag flags = ApplyFlagEx.RevertDefault)
        => (GlamourerApiEc)Invoke(objectName, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (a, b, c) => (int)api.RevertToAutomationName(a, b, (ApplyFlag)c));
}

/// <inheritdoc cref="IGlamourerApiState.StateChanged" />
public static class StateChanged
{
    /// <summary> The label. </summary>
    public const string Label = $"Penumbra.{nameof(StateChanged)}.V2";

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<nint> Subscriber(IDalamudPluginInterface pi, params Action<nint>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<nint> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (t => api.StateChanged += t, t => api.StateChanged -= t));
}

/// <inheritdoc cref="IGlamourerApiState.StateChangedWithType" />
public static class StateChangedWithType
{
    /// <summary> The label. </summary>
    public const string Label = $"Penumbra.{nameof(StateChangedWithType)}";

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<nint, StateChangeType> Subscriber(IDalamudPluginInterface pi, params Action<nint, StateChangeType>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<nint, StateChangeType> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (t => api.StateChangedWithType += t, t => api.StateChangedWithType -= t));
}

/// <inheritdoc cref="IGlamourerApiState.StateFinalized" />
public static class StateFinalized
{
    /// <summary> The label. </summary>
    public const string Label = $"Penumbra.{nameof(StateFinalized)}";

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<nint, StateFinalizationType> Subscriber(IDalamudPluginInterface pi, params Action<nint, StateFinalizationType>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<nint, StateFinalizationType> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (t => api.StateFinalized += t, t => api.StateFinalized -= t));
}

/// <inheritdoc cref="IGlamourerApiState.GPoseChanged" />
public static class GPoseChanged
{
    /// <summary> The label. </summary>
    public const string Label = $"Penumbra.{nameof(GPoseChanged)}";

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<bool> Subscriber(IDalamudPluginInterface pi, params Action<bool>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<bool> Provider(IDalamudPluginInterface pi, IGlamourerApiState api)
        => new(pi, Label, (t => api.GPoseChanged += t, t => api.GPoseChanged -= t));
}

