﻿using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using Glamourer.Api.Enums;
using Glamourer.Api.Helpers;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Glamourer.Api.IpcSubscribers.Legacy;

public sealed class SetItem(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, byte, ulong, byte, uint, int>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(SetItem)}";

    public new GlamourerApiEc Invoke(Character? character, byte slot, ulong itemId, byte stainId, uint key)
        => (GlamourerApiEc)base.Invoke(character, slot, itemId, stainId, key);
}

public sealed class SetItemOnce(DalamudPluginInterface pi)
    : FuncSubscriber<Character?, byte, ulong, byte, uint, int>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(SetItemOnce)}";

    public new GlamourerApiEc Invoke(Character? character, byte slot, ulong itemId, byte stainId, uint key)
        => (GlamourerApiEc)base.Invoke(character, slot, itemId, stainId, key);
}

public sealed class SetItemByActorName(DalamudPluginInterface pi)
    : FuncSubscriber<string, byte, ulong, byte, uint, int>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(SetItemByActorName)}";

    public new GlamourerApiEc Invoke(string actorName, byte slot, ulong itemId, byte stainId, uint key)
        => (GlamourerApiEc)base.Invoke(actorName, slot, itemId, stainId, key);
}

public sealed class SetItemOnceByActorName(DalamudPluginInterface pi)
    : FuncSubscriber<string, byte, ulong, byte, uint, int>(pi, Label)
{
    public const string Label = $"Glamourer.{nameof(SetItemOnceByActorName)}";

    public new GlamourerApiEc Invoke(string actorName, byte slot, ulong itemId, byte stainId, uint key)
        => (GlamourerApiEc)base.Invoke(actorName, slot, itemId, stainId, key);
}
