using Godot;
using System;

public partial class basic_xy_movement : Node
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public float MoveSpeed;
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{

	}
	public void MoveInXZ( CharacterBody3D Funny,float XAxis, float ZAxis)
	{
		
		var MoveDir = Vector3.Zero;
		if (XAxis != 0 || ZAxis != 0)
		{
			MoveDir.X = XAxis;
			MoveDir.Z = ZAxis;
			MoveDir = MoveDir.Normalized() * MoveSpeed;
			
		}
		Funny.Velocity =MoveDir;
		GD.Print(Funny.Velocity, " is the velocity of the charbod ", MoveDir, "is what it should be");
		Funny.MoveAndSlide();
	}

}
