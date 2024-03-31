using Godot;
using System;

//Todo
//Make MoveinXZ generic for 2d and 3d
//MakeMovement have relative to world and to relative to player modes EX. player rotation means forward
// is the "forrward" of local player space
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
           // GD.Print("StillWorkin",XAxis,ZAxis);
        }
		Funny.Velocity =MoveDir;
		//GD.Print(Funny.Velocity, " is the velocity of the charbod ", MoveDir, "is what it should be");
		Funny.MoveAndSlide();
	}

}
