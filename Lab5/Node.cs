namespace Lab5;

public enum Color
{
	White, Gray, Black
}

public class Neighbor : IComparable<Neighbor>
{
    public Node Node { get; set; }
    public int Weight { get; set; }

    public int CompareTo(Neighbor? other)
    {
        return Node.CompareTo(other.Node);
    }
}

public class Node : IComparable<Node>
{
	public string Name { get; set; }
	public List<Neighbor> Neighbors { get; set; }
	public Color Color { get; set; }

	public Node(string name = "", Color color = Color.White)	
	{
		Name = name;
		Color = color;
		Neighbors = new List<Neighbor>();
	}

	public int CompareTo(Node? other)
	{
		return Name.CompareTo(other.Name);
	}

	public override bool Equals(object? obj)
	{
		if (obj is Node other)
		{
			return Name.Equals(other.Name);
		}
		
		return false;
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}
}


