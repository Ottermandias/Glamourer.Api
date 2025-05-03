using Glamourer.Api.Enums;

namespace Glamourer.Api.Api;

/// <summary> All functions related to Glamourer designs. </summary>
public interface IGlamourerApiDesigns
{
    /// <summary> Obtain a list of all available designs. </summary>
    /// <returns> A dictionary of all designs from their GUID to their current display name. </returns>
    public Dictionary<Guid, string> GetDesignList();

    /// <summary> Obtain a list of all available designs with some display information for the designs. </summary>
    /// <returns> A dictionary of all designs from their GUID to their current display name. </returns>
    public Dictionary<Guid, (string DisplayName, string FullPath, uint DisplayColor, bool ShownInQdb)> GetDesignListExtended();

    /// <summary> Obtain the additional data returned by <seealso cref="GetDesignListExtended"/> for a specific design. </summary>
    /// <param name="design"> The GUID of the design to query. </param>
    /// <returns> The additional data of the design if it exists, empty data otherwise. </returns>
    public (string DisplayName, string FullPath, uint DisplayColor, bool ShowInQdb) GetExtendedDesignData(Guid design);

    /// <summary> Apply an existing design to an actor.  </summary>
    /// <param name="designId"> The GUID of the design to apply. </param>
    /// <param name="objectIndex"> The game object index of the actor to be manipulated. </param>
    /// <param name="key"> A key to unlock or lock the state if necessary. </param>
    /// <param name="flags"> The flags used for the reversion. Respects Once, Equipment, Customization, Lock (see <see cref="ApplyFlag"/>.)</param>
    /// <returns> DesignNotFound, ActorNotFound, InvalidKey, Success. </returns>
    public GlamourerApiEc ApplyDesign(Guid designId, int objectIndex, uint key, ApplyFlag flags);

    /// <summary> Apply an existing design to an actor.  </summary>
    /// <param name="designId"> The GUID of the design to apply. </param>
    /// <param name="playerName"> The name of the players to be manipulated. </param>
    /// <param name="key"> A key to unlock or lock the state if necessary. </param>
    /// <param name="flags"> The flags used for the reversion. Respects Once, Equipment, Customization, Lock (see <see cref="ApplyFlag"/>.)</param>
    /// <returns> DesignNotFound, ActorNotFound, InvalidKey, Success. </returns>
    /// /// <remarks>
    /// The player does not have to be currently available as long as he has a persisted Glamourer state.<br/>
    /// Only players are checked for name equality, no NPCs.<br/>
    /// If multiple players of the same name are found, all of them are reverted.<br/>
    /// Prefer to use the index-based function unless you need to get the state of someone currently unavailable.
    /// </remarks>
    public GlamourerApiEc ApplyDesignName(Guid designId, string playerName, uint key, ApplyFlag flags);

    /// <summary> Add a new design and write it to disk. </summary>
    /// <param name="designInput"> The content of the design in Base64 or JSON object format. </param>
    /// <param name="name"> The name of the design to be created. </param>
    /// <returns> CouldNotParse on failure to parse, Success; along with the GUID of the newly created design upon success or a 0-GUID otherwise. </returns>
    public (GlamourerApiEc, Guid) AddDesign(string designInput, string name);

    /// <summary> Obtain the Base64 string of a design. </summary>
    /// <param name="design"> The GUID of the design to query. </param>
    /// <returns> A Base64 string of the design data on success or null. </returns>
    public string? GetDesignBase64(Guid design);
}
