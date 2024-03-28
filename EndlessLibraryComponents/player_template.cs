using Godot;
using System;

public partial class player_template : CharacterBody3D
{



	// Get the gravity from the project settings to be synced with RigidBody nodes.
	//public float gravity = ProjectSettings.GetSetting("physics/3d/default_gravity").AsSingle();
	private wasd_input_movement InputNode;
	private basic_xy_movement MovementNode;
	public override void _Ready()
	{
		MovementNode = GetNode<basic_xy_movement>("PlayerMovement");
		InputNode = GetNode<wasd_input_movement>("PlayerInput");
		InputNode.MovementAxes += InputToMovement;
	}
	public override void _PhysicsProcess(double delta)
	{
		
	

	}
	public  void InputToMovement(float XAxis, float ZAxis)
	{
		//GD.Print(XAxis,"is X and ",ZAxis, " is Z");
		MovementNode.MoveInXZ(this, XAxis, ZAxis);
	}

}
