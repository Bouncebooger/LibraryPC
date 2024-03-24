using Godot;
using System;

public partial class title_menu_button : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void  _Pressed()
	{
		GD.Print("It Works!");
		GetNode<go_to_title>("GoToTitle").GoToMenuEmit();
	}
}
