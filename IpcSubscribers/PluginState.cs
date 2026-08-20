using Dalamud.Plugin;
using Glamourer.Api.Api;
using Glamourer.Api.Enums;
using Luna;

namespace Glamourer.Api.IpcSubscribers;

/// <inheritdoc cref="IGlamourerApiBase.ApiVersion"/>
public sealed class ApiVersion(IDalamudPluginInterface pi)
    : FuncSubscriber<(int, int)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(ApiVersion)}.V2";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.ApiVersion.V2"u8;

    /// <inheritdoc cref="IGlamourerApiBase.ApiVersion"/>
    public new (int Major, int Minor) Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<(int, int)> Provider(IDalamudPluginInterface pi, IGlamourerApiBase api)
        => new(pi, Label, () => api.ApiVersion);
}

/// <inheritdoc cref="IGlamourerApiBase.AutoReloadGearEnabled"/>
public sealed class AutoReloadGearEnabled(IDalamudPluginInterface pi)
    : FuncSubscriber<bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(AutoReloadGearEnabled)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.AutoReloadGearEnabled"u8;

    /// <inheritdoc cref="IGlamourerApiBase.AutoReloadGearEnabled"/>
    public new bool Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<bool> Provider(IDalamudPluginInterface pi, IGlamourerApiBase api)
        => new(pi, Label, () => api.AutoReloadGearEnabled);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenMainWindow"/>
public sealed class OpenMainWindow(IDalamudPluginInterface pi)
    : ActionSubscriber<bool?, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenMainWindow)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenMainWindow"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenMainWindow"/>
    public void Invoke(bool? open, MainTabType tab = MainTabType.None)
        => base.Invoke(open, (int)tab);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<bool?, int> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, (open, tab) => api.OpenMainWindow(open, (MainTabType)tab));
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenDesign"/>
public sealed class OpenDesign(IDalamudPluginInterface pi)
    : ActionSubscriber<Guid>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenDesign)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenDesign"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenDesign"/>
    public void Invoke(Guid design)
        => base.Invoke(design);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<Guid> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenDesign);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenActorIndex"/>
public sealed class OpenActorIndex(IDalamudPluginInterface pi)
    : ActionSubscriber<int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenActorIndex)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenActorIndex"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenActorIndex"/>
    public void Invoke(int objectIndex)
        => base.Invoke(objectIndex);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<int> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenActorIndex);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenActorName"/>
public sealed class OpenActorName(IDalamudPluginInterface pi)
    : ActionSubscriber<string, ushort>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenActorName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenActorName"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenActorName"/>
    public void Invoke(string name, ushort world = ushort.MaxValue)
        => base.Invoke(name, world);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<string, ushort> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenActorName);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenQuickDesignBar"/>
public sealed class OpenQuickDesignBar(IDalamudPluginInterface pi)
    : ActionSubscriber<bool?, Guid>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenQuickDesignBar)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenQuickDesignBar"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenQuickDesignBar"/>
    public void Invoke(bool? open, Guid designId = default)
        => base.Invoke(open, designId);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<bool?, Guid> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenQuickDesignBar);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenEquipmentBarIndex"/>
public sealed class OpenEquipmentBarIndex(IDalamudPluginInterface pi)
    : ActionSubscriber<bool?, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenEquipmentBarIndex)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenEquipmentBarIndex"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenEquipmentBarIndex"/>
    public void Invoke(bool? open, int objectIndex = -1)
        => base.Invoke(open, objectIndex);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<bool?, int> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenEquipmentBarIndex);
}

/// <inheritdoc cref="IGlamourerApiPlugin.OpenEquipmentBarName"/>
public sealed class OpenEquipmentBarName(IDalamudPluginInterface pi)
    : ActionSubscriber<bool?, string, ushort>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(OpenEquipmentBarName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.OpenEquipmentBarName"u8;

    /// <inheritdoc cref="IGlamourerApiPlugin.OpenEquipmentBarName"/>
    public void Invoke(bool? open, string name, ushort world = ushort.MaxValue)
        => base.Invoke(open, name, world);

    /// <summary> Create a provider. </summary>
    public static ActionProvider<bool?, string, ushort> Provider(IDalamudPluginInterface pi, IGlamourerApiPlugin api)
        => new(pi, Label, api.OpenEquipmentBarName);
}

/// <summary> Triggered when the Glamourer API is initialized and ready. </summary>
public static class Initialized
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(Initialized)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.Initialized"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber Subscriber(IDalamudPluginInterface pi, params Action[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider Provider(IDalamudPluginInterface pi)
        => new(pi, Label);
}

/// <summary> Triggered when the Glamourer API is fully disposed and unavailable. </summary>
public static class Disposed
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(Disposed)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8
        => "Glamourer.Disposed"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber Subscriber(IDalamudPluginInterface pi, params Action[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider Provider(IDalamudPluginInterface pi)
        => new(pi, Label);
}
