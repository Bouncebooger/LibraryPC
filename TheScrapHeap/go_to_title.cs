using Godot;
using System;

public partial class go_to_title : Node
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void GoToMenuEmit()
	{
		GetNode<scene_event_bus_autoload>("/root/SceneEventBusAutoload").EmitSignal(scene_event_bus_autoload.SignalName.ToTitleMenu);

	}

}
