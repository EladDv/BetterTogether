using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;
namespace BetterTogether
{
	public class BaseModule : PartModule
	{
		public static List<BaseModule> Bases=new List<BaseModule>();
		public int counter=0;
		// public string Owner; the owner of the base
		public Vector3d MapPosition;

		public override void OnUpdate ()
		{
			if (MapView.MapIsEnabled && counter == 0) 
			{
				gameObject.AddComponent<Hex> ();
				counter++;
				//	MapPosition = ScaledSpace.LocalToScaledSpace(vessel.GetWorldPos3D());
				//	if (!Bases.Contains(this))
				//		Bases.Add(this);
			}
		}
	/*	public override void OnUpdate()
		{
			if (vessel.Landed == true && (ScaledSpace.LocalToScaledSpace(vessel.GetWorldPos3D()) != MapPosition))
				MapPosition = ScaledSpace.LocalToScaledSpace(vessel.GetWorldPos3D());

		}*/


	}

}


