using Glamourer.Api.Enums;

namespace Glamourer.Api.Api;

/// <summary> Any functions related to Glamourer's own plugin state. </summary>
public interface IGlamourerApiPlugin
{
    /// <summary> Open or close Glamourer's main window, optionally to a specific tab. </summary>
    /// <param name="open"> Whether the window should be open or closed. If this is null, it will be toggled instead. </param>
    /// <param name="tab"> The tab to select. </param>
    public void OpenMainWindow(bool? open, MainTabType tab = MainTabType.None);

    /// <summary> Open Glamourer's main window to the designs tab, selecting a specific design. </summary>
    /// <param name="designId"> The GUID of the design to select. If this is empty or can not be found, the current selection will be kept. </param>
    public void OpenDesign(Guid designId);

    /// <summary> Open Glamourer's main window to the actors tab, selecting a specific actor. </summary>
    /// <param name="objectIndex"> The object index of the actor to select. If this is negative or does not exist, the current selection will be kept. </param>
    public void OpenActorIndex(int objectIndex);

    /// <summary> Open Glamourer's main window to the actors tab, selecting a specific player character if available. </summary>
    /// <param name="name"> The name of the actor to select. </param>
    /// <param name="world"> The home world of the actor to select. If this is <see cref="ushort.MaxValue"/>, the first actor with matching name will be used. </param>
    /// <remarks> If no matching actor can be found either as already saved state or as currently available actor, the current selection will be kept. </remarks>
    public void OpenActorName(string name, ushort world = ushort.MaxValue);

    /// <summary> Open or close Glamourer's quick design bar, optionally to a specific design. </summary>
    /// <param name="open"> Whether the bar should be open or closed. If this is null, it will be toggled instead. </param>
    /// <param name="designId"> The design to select in the quick design combo. If this is empty or does not exist, the current selection will be kept. </param>
    public void OpenQuickDesignBar(bool? open, Guid designId = default);

    /// <summary> Open or close Glamourer's equipment bar, optionally to a specific actor state. </summary>
    /// <param name="open"> Whether the bar should be open or closed. If this is null, it will be toggled instead. </param>
    /// <param name="objectIndex"> The object index of the actor to select. If this is negative or does not exist, the current selection will be kept. </param>
    public void OpenEquipmentBarIndex(bool? open, int objectIndex = -1);

    /// <summary> Open or close Glamourer's equipment bar, optionally to a specific actor state. </summary>
    /// <param name="open"> Whether the bar should be open or closed. If this is null, it will be toggled instead. </param>
    /// <param name="name"> The name of the actor to select. </param>
    /// <param name="world"> The home world of the actor to select. If this is <see cref="ushort.MaxValue"/>, the first actor with matching name will be used. </param>
    /// <remarks> If no matching actor can be found either as already saved state or as currently available actor, the current selection will be kept. </remarks>
    public void OpenEquipmentBarName(bool? open, string name, ushort world = ushort.MaxValue);
}


