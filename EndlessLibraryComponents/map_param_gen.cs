using Godot;
using System;
using System.Linq;

public partial class map_param_gen : Node
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public int AmntToGen;

	//This describes an array of tuples 
	public Tuple<int, int>[] HexConnections;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	public Array GenerateHexParam(int numtogen)
	{
		HexConnections = new Tuple<int,int>[numtogen];
		var rng = new RandomNumberGenerator();
		int PrevHexExit = 0;
		int NewHexExit = rng.RandiRange(4, 6);
		HexConnections[0]=Tuple.Create(2, NewHexExit);
        GD.Print("HexConsize  ", HexConnections.Length);
        PrevHexExit = NewHexExit;
		if (numtogen>1) {
			// HexConnections.Append<Tuple<int,int>>((rng.RandiRange(1, 3),rng.RandiRange(4,6)));
			for (int i = 1; i < numtogen; i++) {
				NewHexExit = rng.RandiRange(4, 6);
				
				HexConnections[i] = Tuple.Create(7 - PrevHexExit, NewHexExit);
				//PrevHexExit = NewHexExit;
			//	GD.Print("Tuple added is (", 7- PrevHexExit,",",NewHexExit,")");

                PrevHexExit = NewHexExit;
            }
			
		}
		GD.Print("HexConsize  ",HexConnections.Length);
		return HexConnections;
	}
	//private 

}
