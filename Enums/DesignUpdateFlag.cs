namespace Glamourer.Api.Enums;

/// <summary> Flags controlling which sections are skipped when updating an existing design. </summary>
/// <remarks>
/// Setting a flag disables updating that section. A value of <see cref="None"/> (0) updates all sections
/// present in the input, while <see cref="All"/> (all bits set) updates nothing.
/// </remarks>
[Flags]
public enum DesignUpdateFlag : ulong
{
    /// <summary> Skip nothing and update all sections present in the input. </summary>
    None = 0,

    /// <summary> Do not update equipment items (armor, accessories, and weapons). </summary>
    SkipEquipment = 1ul << 0,

    /// <summary> Do not update equipment stains (dyes). </summary>
    SkipStains = 1ul << 1,

    /// <summary> Do not update equipment crest visibility. </summary>
    SkipCrests = 1ul << 2,

    /// <summary> Do not update bonus items (e.g. glasses / facewear). </summary>
    SkipBonusItems = 1ul << 3,

    /// <summary> Do not update meta toggles (hat, visor, weapon, Viera ears, wetness). </summary>
    SkipMeta = 1ul << 4,

    /// <summary> Do not update character customizations. </summary>
    SkipCustomize = 1ul << 5,

    /// <summary> Do not update advanced customization parameters. </summary>
    SkipParameters = 1ul << 6,

    /// <summary> Do not update advanced dyes (material color values). </summary>
    SkipMaterials = 1ul << 7,

    /// <summary> Do not update application rules (which slots, customizations, parameters, meta toggles, or materials are enabled to apply). </summary>
    SkipApplicationRules = 1ul << 8,

    /// <summary> Do not update associated Penumbra mods (only applies when the input is a full design). </summary>
    SkipMods = 1ul << 9,

    /// <summary> Do not update linked designs (only applies when the input is a full design). </summary>
    SkipLinks = 1ul << 10,

    /// <summary> Do not update design metadata such as name, description, tags, color, or quick design bar visibility (only applies when the input is a full design). </summary>
    SkipMetadata = 1ul << 11,

    /// <summary> Do not update design settings such as forced redraw, reset/revert advanced dyes, or reset temporary settings (only applies when the input is a full design). </summary>
    SkipSettings = 1ul << 12,

    /// <summary> Skip all sections and update nothing. </summary>
    All = ulong.MaxValue,
}
