using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using Glamourer.Api.Helpers;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Glamourer.Api.IpcSubscribers.Legacy;

public sealed class GetDesignList(DalamudPluginInterface pi)
    : FuncSubscriber<(string Name, Guid Identifier)[]>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetDesignList)}";

    public new (string Name, Guid Identifier)[] Invoke()
        => base.Invoke();
}

public sealed class ApplyByGuid(DalamudPluginInterface pi)
    : ActionSubscriber<Guid, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuid)}";

    public new void Invoke(Guid design, string name)
        => base.Invoke(design, name);
}

public sealed class ApplyByGuidOnce(DalamudPluginInterface pi)
    : ActionSubscriber<Guid, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidOnce)}";

    public new void Invoke(Guid design, string name)
        => base.Invoke(design, name);
}

public sealed class ApplyByGuidToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Guid, Character?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidToCharacter)}";

    public new void Invoke(Guid design, Character? character)
        => base.Invoke(design, character);
}

public sealed class ApplyByGuidOnceToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Guid, Character?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidOnceToCharacter)}";

    public new void Invoke(Guid design, Character? character)
        => base.Invoke(design, character);
}
