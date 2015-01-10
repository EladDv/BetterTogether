using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



namespace BetterTogether 
{

	class Hex : MonoBehaviour
	{
		public Vector3d Position;
		public Vector3d ScaledPosition;
		public Texture texture;
		public GameObject Gobject;

		public MeshFilter meshFilter;
		public MeshRenderer meshRend;
		public Mesh mesh ;

		public float hexRadiusSize=0.25f;
		public Vector3[] vertices;
		public Vector2[] uv;
		public int[] triangles;

		void ()
		{
			Gobject = SpaceCenter.Instance.gameObject;
			Gobject.AddComponent<Hex> ();
			ScaledSpace.AddScaledSpaceTransform (Gobject.transform);
			gameObject.layer = 10;
			mesh = new Mesh();
			meshFilter = gameObject.AddComponent<MeshFilter>();
			meshFilter.mesh = mesh;
			meshRend = gameObject.AddComponent<MeshRenderer>();
			MeshSetup();
		}

		void MeshSetup()
		{
			float floorLevel = 0;
			vertices = new Vector3[]
			{
				new Vector3(-1f , floorLevel, -.5f),
				new Vector3(-1f, floorLevel, .5f),
				new Vector3(0f, floorLevel, 1f),
				new Vector3(1f, floorLevel, .5f),
				new Vector3(1f, floorLevel, -.5f),
				new Vector3(0f, floorLevel, -1f)			};

			triangles = new int[]
			{
				1,5,0,
				1,4,5,
				1,2,4,
				2,3,4
			};

			uv = new Vector2[]
			{
				new Vector2(0,0.25f),
				new Vector2(0,0.75f),
				new Vector2(0.5f,1),
				new Vector2(1,0.75f),
				new Vector2(1,0.25f),
				new Vector2(0.5f,0),
			};

			mesh.vertices = vertices;
			mesh.triangles = triangles;
			mesh.uv = uv;
			mesh.RecalculateBounds ();
			mesh.RecalculateNormals();
			meshFilter.mesh = mesh;
			meshRend.enabled = true;
			//for(int i=0;i<mesh.colors32.Length;i++)
			//{mesh.colors32[i] = Color.red;}


		}



	}
}
