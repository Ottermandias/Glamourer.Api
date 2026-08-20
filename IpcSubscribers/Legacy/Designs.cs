using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using Luna;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Glamourer.Api.IpcSubscribers.Legacy;

public sealed class GetDesignList(IDalamudPluginInterface pi)
    : FuncSubscriber<(string Name, Guid Identifier)[]>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetDesignList)}";

    public new (string Name, Guid Identifier)[] Invoke()
        => base.Invoke();
}

public sealed class ApplyByGuid(IDalamudPluginInterface pi)
    : ActionSubscriber<Guid, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuid)}";

    public void Invoke(Guid design, string name)
        => base.Invoke(design, name);
}

public sealed class ApplyByGuidOnce(IDalamudPluginInterface pi)
    : ActionSubscriber<Guid, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidOnce)}";

    public void Invoke(Guid design, string name)
        => base.Invoke(design, name);
}

public sealed class ApplyByGuidToCharacter(IDalamudPluginInterface pi)
    : ActionSubscriber<Guid, ICharacter?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidToCharacter)}";

    public void Invoke(Guid design, ICharacter? character)
        => base.Invoke(design, character);
}

public sealed class ApplyByGuidOnceToCharacter(IDalamudPluginInterface pi)
    : ActionSubscriber<Guid, ICharacter?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyByGuidOnceToCharacter)}";

    public void Invoke(Guid design, ICharacter? character)
        => base.Invoke(design, character);
}
