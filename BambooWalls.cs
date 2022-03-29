using BepInEx;
using ItemManager;
using UnityEngine;
using PieceManager;
using ServerSync;
using HarmonyLib;


namespace BambooWalls
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class BambooWalls : BaseUnityPlugin
	{
		private const string ModName = "BambooWalls";
		private const string ModVersion = "0.0.6";
		private const string ModGUID = "org.bepinex.plugins.BambooWalls";


		public void Awake()

		{

			BuildPiece OP_Bamboo_Sapling = new("bamboo", "OP_Bamboo_Sapling");
			OP_Bamboo_Sapling.Name.English("Odins Bamboo Sapling");
			OP_Bamboo_Sapling.Description.English("A strange tree");
			OP_Bamboo_Sapling.RequiredItems.Add("AncientSeed", 1, true);

			Item OP_Bamboo_Hammer = new("bamboo", "OP_Bamboo_Hammer");  //assetbundle name, Asset Name
			OP_Bamboo_Hammer.Crafting.Add(CraftingTable.Workbench, 1);
			OP_Bamboo_Hammer.RequiredItems.Add("OP_Bamboo_Wood", 1);
			OP_Bamboo_Hammer.CraftAmount = 1;

			GameObject OP_Bamboo_Brush_Fence = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence"); 
			
			GameObject OP_Bamboo_Brush_Fence_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_2"); 

			GameObject OP_Bamboo_Frame = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Frame"); 

			GameObject OP_Bamboo_Halfwall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Halfwall"); 

			GameObject OP_Bamboo_Wall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Wall"); 

			GameObject OP_Bamboo_Beam = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Beam"); //register projectile

			GameObject OP_Bamboo_Beam_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Beam_Light"); //register projectile

			GameObject OP_Bamboo_Pole = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Pole"); //register projectile

			GameObject OP_Bamboo_Pole_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Pole_Light"); //register projectile

			GameObject OP_Rock_Formation_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_1"); //register projectile

			GameObject OP_Rock_Formation_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_2"); //register projectile

			GameObject OP_Rock_Formation_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_3"); //register projectile

			GameObject OP_Rock_Formation_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_4"); //register projectile

			GameObject OP_Wild_Bamboo_Wall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Wall"); //register projectile

			GameObject OP_Wild_Bamboo = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo"); //register projectile

			GameObject OP_Wild_Bamboo_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Light"); //register projectile

			GameObject OP_Wild_Bamboo_Dark = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Dark"); //register projectile

			GameObject OP_Wild_Bamboo_Cluster = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster"); //register projectile

			GameObject OP_Wild_Bamboo_Cluster_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster_Light"); //register projectile

			GameObject OP_Wild_Bamboo_Cluster_Dark = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster_Dark"); //register projectile

			GameObject OP_Bamboo_Floor = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Floor"); //register projectile

			GameObject OP_Bamboo_Stair = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Stair"); //register projectile

			GameObject OP_Stone_Path_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_1"); //register projectile

			GameObject OP_Stone_Path_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_2"); //register projectile

			GameObject OP_Stone_Path_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_3"); //register projectile

			GameObject OP_Stone_Path_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_4"); //register projectile

			GameObject OP_Leaves_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_1"); //register projectile

			GameObject OP_Leaves_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_2"); //register projectile

			GameObject OP_Leaves_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_3"); //register projectile

			GameObject OP_Bamboo_Door = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Door"); //register projectile

			GameObject OP_Bamboo_Thick_Pole = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Pole"); //register projectile

			GameObject OP_Bamboo_Thick_Pole_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Pole_Light"); //register projectile

			GameObject OP_Bamboo_Thick_Beam = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Beam"); //register projectile

			GameObject OP_Bamboo_Thick_Beam_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Beam_Light"); //register projectile

			GameObject OP_Bamboo_Brush_Fence_Wide = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_Wide"); //register projectile

			GameObject OP_Bamboo_Brush_Fence_Wide_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_Wide_2"); //register projectile

			GameObject OP_Wild_Bamboo_Wall_Door = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Wall_Door"); //register projectile

			GameObject OP_Bamboo_Gate = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Gate"); //register projectile

			GameObject OP_Bamboo_Roof_Tile = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Roof_Tile"); //register projectile

			GameObject OP_Bamboo_Straw_Gate = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Straw_Gate"); //register projectile

			GameObject OP_Leaves_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_4"); //register projectile

			GameObject OP_Leaves_5 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_5"); //register projectile

			GameObject OP_Leaves_6 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_6"); //register projectile

			GameObject OP_Bamboo_Straw_Gate_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Straw_Gate_2"); //register projectile
			
			//newshit
			GameObject OP_Bamboo_Log = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log"); //register projectile

			GameObject OP_Bamboo_Log_Half = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log_Half"); //register projectile

			GameObject OP_Bamboo_Stump = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Stump"); //register projectile

			GameObject OP_Bamboo_Tree_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_1"); //register projectile

			GameObject OP_Bamboo_Tree_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_2"); //register projectile

			GameObject OP_Bamboo_Wood = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Wood"); //register projectile




			new Harmony(ModName).PatchAll();			

		

		}
	}		
	
}