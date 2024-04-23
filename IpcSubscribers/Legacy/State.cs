using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using Glamourer.Api.Helpers;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Glamourer.Api.IpcSubscribers.Legacy;

public sealed class Revert(DalamudPluginInterface pi)
    : ActionSubscriber<string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(Revert)}";

    public new void Invoke(string characterName)
        => base.Invoke(characterName);
}

public sealed class RevertCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Character?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(RevertCharacter)}";

    public new void Invoke(Character? character)
        => base.Invoke(character);
}

public sealed class RevertLock(DalamudPluginInterface pi)
    : ActionSubscriber<string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(RevertLock)}";

    public new void Invoke(string characterName, uint key)
        => base.Invoke(characterName, key);
}

public sealed class RevertCharacterLock(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(RevertCharacterLock)}";

    public new void Invoke(Character? character, uint key)
        => base.Invoke(character, key);
}

public sealed class RevertToAutomation(DalamudPluginInterface pi)
    : FuncSubscriber<string, uint, bool>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(RevertToAutomation)}";

    public new bool Invoke(string characterName, uint key)
        => base.Invoke(characterName, key);
}

public sealed class RevertToAutomationCharacter(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, uint, bool>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(RevertToAutomationCharacter)}";

    public new bool Invoke(Character? character, uint key)
        => base.Invoke(character, key);
}

public sealed class Unlock(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, uint, bool>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(Unlock)}";

    public new bool Invoke(Character? character, uint key)
        => base.Invoke(character, key);
}

public sealed class UnlockName(DalamudPluginInterface pi)
    : FuncSubscriber<string, uint, bool>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(UnlockName)}";

    public new bool Invoke(string characterName, uint key)
        => base.Invoke(characterName, key);
}

public static class StateChanged
{
    public const string Label = $"Penumbra.{nameof(StateChanged)}";

    public static EventSubscriber<int, nint, Lazy<string>> Subscriber(DalamudPluginInterface pi,
        params Action<int, nint, Lazy<string>>[] actions)
        => new(pi, Label, actions);
}

public sealed class GetAllCustomization(DalamudPluginInterface pi)
    : FuncSubscriber<string, string?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetAllCustomization)}";

    public new string? Invoke(string characterName)
        => base.Invoke(characterName);
}

public sealed class GetAllCustomizationFromCharacter(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, string?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetAllCustomizationFromCharacter)}";

    public new string? Invoke(Character? character)
        => base.Invoke(character);
}

public sealed class GetAllCustomizationLocked(DalamudPluginInterface pi)
    : FuncSubscriber<string, uint, string?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetAllCustomizationLocked)}";

    public new string? Invoke(string characterName, uint key)
        => base.Invoke(characterName, key);
}

public sealed class GetAllCustomizationFromLockedCharacter(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, uint, string?>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(GetAllCustomizationFromLockedCharacter)}";

    public new string? Invoke(Character? character, uint key)
        => base.Invoke(character, key);
}

public sealed class ApplyAll(DalamudPluginInterface pi)
    : ActionSubscriber<string, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAll)}";

    public new void Invoke(string characterName, string stateBase64)
        => base.Invoke(characterName, stateBase64);
}

public sealed class ApplyAllOnce(DalamudPluginInterface pi)
    : ActionSubscriber<string, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAllOnce)}";

    public new void Invoke(string characterName, string stateBase64)
        => base.Invoke(characterName, stateBase64);
}

public sealed class ApplyAllToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAllToCharacter)}";

    public new void Invoke(Character? character, string stateBase64)
        => base.Invoke(character, stateBase64);
}

public sealed class ApplyAllOnceToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAllOnceToCharacter)}";

    public new void Invoke(Character? character, string stateBase64)
        => base.Invoke(character, stateBase64);
}

public sealed class ApplyOnlyEquipment(DalamudPluginInterface pi)
    : ActionSubscriber<string, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyEquipment)}";

    public new void Invoke(string characterName, string stateBase64)
        => base.Invoke(characterName, stateBase64);
}

public sealed class ApplyOnlyEquipmentToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyEquipmentToCharacter)}";

    public new void Invoke(Character? character, string stateBase64)
        => base.Invoke(character, stateBase64);
}

public sealed class ApplyOnlyCustomization(DalamudPluginInterface pi)
    : ActionSubscriber<string, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyCustomization)}";

    public new void Invoke(string characterName, string stateBase64)
        => base.Invoke(characterName, stateBase64);
}

public sealed class ApplyOnlyCustomizationToCharacter(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyCustomizationToCharacter)}";

    public new void Invoke(Character? character, string stateBase64)
        => base.Invoke(character, stateBase64);
}

public sealed class ApplyAllLock(DalamudPluginInterface pi)
    : ActionSubscriber<string, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAllLock)}";

    public new void Invoke(string characterName, string stateBase64, uint key)
        => base.Invoke(characterName, stateBase64, key);
}

public sealed class ApplyAllToCharacterLock(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyAllToCharacterLock)}";

    public new void Invoke(Character? character, string stateBase64, uint key)
        => base.Invoke(character, stateBase64, key);
}

public sealed class ApplyOnlyEquipmentLock(DalamudPluginInterface pi)
    : ActionSubscriber<string, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyEquipmentLock)}";

    public new void Invoke(string characterName, string stateBase64, uint key)
        => base.Invoke(characterName, stateBase64, key);
}

public sealed class ApplyOnlyEquipmentToCharacterLock(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyEquipmentToCharacterLock)}";

    public new void Invoke(Character? character, string stateBase64, uint key)
        => base.Invoke(character, stateBase64, key);
}

public sealed class ApplyOnlyCustomizationLock(DalamudPluginInterface pi)
    : ActionSubscriber<string, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyCustomizationLock)}";

    public new void Invoke(string characterName, string stateBase64, uint key)
        => base.Invoke(characterName, stateBase64, key);
}

public sealed class ApplyOnlyCustomizationToCharacterLock(DalamudPluginInterface pi)
    : ActionSubscriber<Character?, string, uint>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(ApplyOnlyCustomizationToCharacterLock)}";

    public new void Invoke(Character? character, string stateBase64, uint key)
        => base.Invoke(character, stateBase64, key);
}
