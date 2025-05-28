using Dalamud.Plugin;
using Glamourer.Api.Api;
using Glamourer.Api.Enums;
using Glamourer.Api.Helpers;
using Newtonsoft.Json.Linq;

namespace Glamourer.Api.IpcSubscribers;

/// <inheritdoc cref="IGlamourerApiDesigns.GetDesignList"/>
public sealed class GetDesignList(IDalamudPluginInterface pi)
    : FuncSubscriber<Dictionary<Guid, string>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetDesignList)}.V2";

    /// <inheritdoc cref="IGlamourerApiDesigns.GetDesignList"/>
    public new Dictionary<Guid, string> Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Dictionary<Guid, string>> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, api.GetDesignList);
}

/// <inheritdoc cref="IGlamourerApiDesigns.GetDesignListExtended"/>
public sealed class GetDesignListExtended(IDalamudPluginInterface pi)
    : FuncSubscriber<Dictionary<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetDesignListExtended)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.GetDesignList"/>
    public new Dictionary<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)> Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Dictionary<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)>> Provider(
        IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, api.GetDesignListExtended);
}

/// <inheritdoc cref="IGlamourerApiDesigns.GetExtendedDesignData"/>
public sealed class GetExtendedDesignData(IDalamudPluginInterface pi)
    : FuncSubscriber<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetExtendedDesignData)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.GetExtendedDesignData"/>
    public new (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb) Invoke(Guid id)
        => base.Invoke(id);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)> Provider(
        IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, api.GetExtendedDesignData);
}

/// <inheritdoc cref="IGlamourerApiDesigns.ApplyDesign"/>
public sealed class ApplyDesign(IDalamudPluginInterface pi) : FuncSubscriber<Guid, int, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(ApplyDesign)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.ApplyDesign"/>
    public GlamourerApiEc Invoke(Guid designId, int objectIndex, uint key = 0, ApplyFlag flags = ApplyFlagEx.DesignDefault)
        => (GlamourerApiEc)Invoke(designId, objectIndex, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, int, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, (a, b, c, d) => (int)api.ApplyDesign(a, b, c, (ApplyFlag)d));
}

/// <inheritdoc cref="IGlamourerApiDesigns.ApplyDesignName"/>
public sealed class ApplyDesignName(IDalamudPluginInterface pi) : FuncSubscriber<Guid, string, uint, ulong, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(ApplyDesignName)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.ApplyDesignName"/>
    public GlamourerApiEc Invoke(Guid designId, string objectName, uint key = 0, ApplyFlag flags = ApplyFlagEx.DesignDefault)
        => (GlamourerApiEc)Invoke(designId, objectName, key, (ulong)flags);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, string, uint, ulong, int> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, (a, b, c, d) => (int)api.ApplyDesignName(a, b, c, (ApplyFlag)d));
}

/// <inheritdoc cref="IGlamourerApiDesigns.AddDesign"/>
public sealed class AddDesign(IDalamudPluginInterface pi) : FuncSubscriber<string, string, (int, Guid)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(AddDesign)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.AddDesign"/>
    public GlamourerApiEc Invoke(string designData, string designName, out Guid createdGuid)
    {
        (var ec, createdGuid) = Invoke(designData, designName);
        return (GlamourerApiEc)ec;
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, (int, Guid)> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, (a, b) =>
        {
            var (ec, guid) = api.AddDesign(a, b);
            return ((int)ec, guid);
        });
}

/// <inheritdoc cref="IGlamourerApiDesigns.DeleteDesign"/>
public sealed class DeleteDesign(IDalamudPluginInterface pi) : FuncSubscriber<Guid, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(DeleteDesign)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.DeleteDesign"/>
    public new GlamourerApiEc Invoke(Guid designId)
        => (GlamourerApiEc)base.Invoke(designId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, int> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, a => (int)api.DeleteDesign(a));
}

/// <inheritdoc cref="IGlamourerApiDesigns.GetDesignBase64"/>
public sealed class GetDesignBase64(IDalamudPluginInterface pi) : FuncSubscriber<Guid, string?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetDesignBase64)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.GetDesignBase64"/>
    public new string? Invoke(Guid designId)
        => base.Invoke(designId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, string?> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, api.GetDesignBase64);
}

/// <inheritdoc cref="IGlamourerApiDesigns.GetDesignJObject"/>
public sealed class GetDesignJObject(IDalamudPluginInterface pi) : FuncSubscriber<Guid, JObject?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Glamourer.{nameof(GetDesignJObject)}";

    /// <inheritdoc cref="IGlamourerApiDesigns.GetDesignJObject"/>
    public new JObject? Invoke(Guid designId)
        => base.Invoke(designId);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<Guid, JObject?> Provider(IDalamudPluginInterface pi, IGlamourerApiDesigns api)
        => new(pi, Label, api.GetDesignJObject);
}
