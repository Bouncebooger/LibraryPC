using Godot;
using System;

public partial class map_factory : Node3D
{
	enum SidesOut : int
	{
		SIDE4 =4,
		SIDE5= 5,
		SIDE6 = 6
	};
	// Called when the node enters the scene tree for the first time.
	[Export]
	public PackedScene HexTiles;

	private map_param_gen Mpg;
	private Array MadeMapParam;
	public override void _Ready()
	{
		Mpg = GetNode<map_param_gen>("HexGen");
		MadeMapParam = Mpg.GenerateHexParam(5);
		CreateMap(MadeMapParam);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void CreateMap(Array Hexparams)
	{
		float zdchange = 0.9f;
		float xdchange = 1.5f;
		float zchange = 1.8f;
		int HexTag = 0 ;
		Vector3 NextOrigin = new Vector3(0f,0f,0f);
		foreach (Tuple<int, int> HexNode in Hexparams) {
			GD.Print("\n", "This Tuple Made it", HexNode);
			Node3D NewHex = HexTiles.Instantiate<Node3D>();
			NewHex.Name = $"HexTile_{HexTag}";
			AddChild(NewHex);
			//if (HexTag ==0)
			switch (HexNode.Item2) {
				case (int)SidesOut.SIDE4:

					
                    NewHex.Position = NextOrigin;
					NextOrigin =  new Vector3(NewHex.Position.X - xdchange,
						NewHex.Position.Y , NewHex.Position.Z - zdchange);
					
					break;

                case (int)SidesOut.SIDE5:
                    NewHex.Position = NextOrigin;
                    NextOrigin =  new Vector3(NewHex.Position.X ,
                        NewHex.Position.Y , NewHex.Position.Z - zchange);
                    break;

                case (int)SidesOut.SIDE6:
                    NewHex.Position = NextOrigin;
                    NextOrigin =  new Vector3(NewHex.Position.X + xdchange,
                        NewHex.Position.Y , NewHex.Position.Z - zdchange);
                    break;

                default:
					GD.Print("MapFactory machine Broken");
					break;
			}
			GD.Print("\n this is the next vector",NextOrigin);
			HexTag += 1;
		} 
	}

	
	private void PlaceHex()
	{
		
	}
}
