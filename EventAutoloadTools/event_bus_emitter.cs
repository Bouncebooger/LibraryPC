using Godot;
using System;
//THIS IS A UNFINISHED HYPOTHETICAL COMPONENT AND IS NOT BEING USED ATM
//USE FOR FAR OFF NODES ONLY
//NOTE THAT THIS SEEMS VERY UNWIELDLY AND 
public partial class event_bus_emitter : Node
{

	[Export]
	private string BusAssigned = null;
    [Export]
    //private 
    // Called when the node enters the scene tree for the first time.
	private Godot.Collections.Array<string> New_Signals { get; set; }
	

	public override void _Ready()
	{
		System.Diagnostics.Debug.Assert(BusAssigned != null, $"Bus {BusAssigned} is null! ");
		//Node 

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void EmitYFromBus(  params string[] events)
	{

        
			foreach( string reqevent in events ){
	//			Bus.EmitSignal(reqevent);
			}
		
	}
	public void CreateNewSignalInBusAssigned( params string[] newSignals  )
	{
		Node funny = null;
		foreach(string newevent in newSignals)
		{

		}
        //System.Diagnostics.Debug.Assert()

    }
	/*
	private Node CheckBusExists(ref Node BusReq)
	{
		Node Buscheck = GetNode($"/root/{BusAssigned}");
		if (Buscheck == null)
		{
			GD.Print(BusAssigned, " is not a real bus");
			return BusReq;
		}

		else
		{
			return BusReq = Buscheck;
		}
	}
	*/

}
