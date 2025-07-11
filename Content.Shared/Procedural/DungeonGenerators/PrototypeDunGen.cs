using Robust.Shared.Prototypes;

namespace Content.Shared.Procedural.DungeonGenerators;

/// <summary>
/// Runs another <see cref="DungeonConfig"/>.
/// Used for storing data on 1 system.
/// </summary>
public sealed partial class PrototypeDunGen : IDunGenLayer
{
    /// <summary>
    /// Should we pass in the current level's dungeons to the prototype.
    /// </summary>
    [DataField]
    public DungeonInheritance InheritDungeons = DungeonInheritance.None;

    /// <summary>
    /// Should we pass in the current level's reserved tiles to the prototype.
    /// </summary>
    [DataField]
    public ReservedInheritance InheritReserved = ReservedInheritance.All;

    [DataField(required: true)]
    public ProtoId<DungeonConfigPrototype> Proto;
}

public enum DungeonInheritance : byte
{
    /// <summary>
    /// Don't inherit any of the current layer's dungeons for this <see cref="PrototypeDunGen"/>
    /// </summary>
    None,

    /// <summary>
    /// Inherit only the last dungeon ran.
    /// </summary>
    Last,

    /// <summary>
    /// Inherit all of the current layer's dungeons.
    /// </summary>
    All,
}

public enum ReservedInheritance : byte
{
    /// <summary>
    /// Don't inherit any reserved tiles.
    /// </summary>
    None,

    /// <summary>
    /// Inherit reserved tiles,
    /// </summary>
    All,
}
