using Godot;
using System;

public partial class map_factory : Node3D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public PackedScene HexTiles;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


}
