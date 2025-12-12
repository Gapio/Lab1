using UnityEngine;

public class Node
{
    public readonly int X;
    public readonly int Y;
    public bool Walkable;
    public readonly GameObject Tile;
    public float GCost;
    public float HCost;
    public Node Parent;
    public float FCost => GCost + HCost;
    public Node(int x, int y, bool walkable, GameObject tile)
    {
        this.X = x;
        this.Y = y;
        this.Walkable = walkable;
        this.Tile = tile;
        GCost = float.PositiveInfinity;
        HCost = 0f;
        Parent = null;
    }

}
