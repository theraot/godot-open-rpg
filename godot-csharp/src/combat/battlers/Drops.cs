using Godot;
using Godot.Collections;

/// <summary>
/// Holds a list of items to reward the player with upon e.g.
/// killing a monster
/// </summary>
public class Drops : Node
{
    [Export]
    public int Experience;

    public Array GetDrops()
    {
        return GetChildren();
    }
}