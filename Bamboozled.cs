using BepInEx;
using ItemManager;
using UnityEngine;
using PieceManager;
using ServerSync;
using HarmonyLib;


namespace Bamboozled
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class Bamboozled : BaseUnityPlugin
	{
		private const string ModName = "Bamboozled";
		private const string ModVersion = "0.0.2";
		private const string ModGUID = "org.bepinex.plugins.bamboozled";


		public void Awake()

		{
			BuildPiece OP_Bamboo_Sapling = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Sapling", true, "Cultivator");
			OP_Bamboo_Sapling.Name.English("Odins Bamboo Sapling");
			OP_Bamboo_Sapling.Description.English("A strange tree");
			OP_Bamboo_Sapling.RequiredItems.Add("AncientSeed", 1, true);

			Item OP_Bamboo_Wood = new("bamboo", "OP_Bamboo_Wood");  
			OP_Bamboo_Wood.Crafting.Add(CraftingTable.Workbench, 10);
			OP_Bamboo_Wood.RequiredItems.Add("SwordCheat", 1);
			OP_Bamboo_Wood.CraftAmount = 1;

			Item OP_Bamboo_Hammer = new("bamboo", "OP_Bamboo_Hammer");  //assetbundle name, Asset Name
			OP_Bamboo_Hammer.Crafting.Add(CraftingTable.Workbench, 1);
			OP_Bamboo_Hammer.RequiredItems.Add("OP_Bamboo_Wood", 1);
			OP_Bamboo_Hammer.CraftAmount = 1;



			GameObject OP_Bamboo_Brush_Fence = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence"); 
			
			GameObject OP_Bamboo_Brush_Fence_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_2"); 

			GameObject OP_Bamboo_Frame = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Frame"); 

			GameObject OP_Bamboo_Halfwall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Halfwall"); 

			GameObject OP_Bamboo_Wall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Wall"); 

			GameObject OP_Bamboo_Beam = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Beam"); 

			GameObject OP_Bamboo_Beam_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Beam_Light"); 

			GameObject OP_Bamboo_Pole = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Pole"); 

			GameObject OP_Bamboo_Pole_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Pole_Light"); 

			GameObject OP_Rock_Formation_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_1"); 

			GameObject OP_Rock_Formation_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_2"); 

			GameObject OP_Rock_Formation_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_3"); 

			GameObject OP_Rock_Formation_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Rock_Formation_4"); 

			GameObject OP_Wild_Bamboo_Wall = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Wall"); 

			GameObject OP_Wild_Bamboo = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo"); 

			GameObject OP_Wild_Bamboo_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Light"); 

			GameObject OP_Wild_Bamboo_Dark = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Dark"); 

			GameObject OP_Wild_Bamboo_Cluster = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster"); 

			GameObject OP_Wild_Bamboo_Cluster_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster_Light"); 

			GameObject OP_Wild_Bamboo_Cluster_Dark = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Cluster_Dark"); 

			GameObject OP_Bamboo_Floor = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Floor"); 

			GameObject OP_Bamboo_Stair = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Stair"); 

			GameObject OP_Stone_Path_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_1"); 

			GameObject OP_Stone_Path_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_2"); 

			GameObject OP_Stone_Path_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_3"); 

			GameObject OP_Stone_Path_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Stone_Path_4");

			GameObject OP_Leaves_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_1"); 

			GameObject OP_Leaves_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_2"); 

			GameObject OP_Leaves_3 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_3"); 

			GameObject OP_Bamboo_Door = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Door"); 

			GameObject OP_Bamboo_Thick_Pole = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Pole"); 

			GameObject OP_Bamboo_Thick_Pole_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Pole_Light"); 

			GameObject OP_Bamboo_Thick_Beam = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Beam"); 

			GameObject OP_Bamboo_Thick_Beam_Light = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Thick_Beam_Light"); 

			GameObject OP_Bamboo_Brush_Fence_Wide = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_Wide");

			GameObject OP_Bamboo_Brush_Fence_Wide_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Brush_Fence_Wide_2"); 

			GameObject OP_Wild_Bamboo_Wall_Door = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Wild_Bamboo_Wall_Door"); 

			GameObject OP_Bamboo_Gate = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Gate"); 

			GameObject OP_Bamboo_Roof_Tile = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Roof_Tile"); 

			GameObject OP_Bamboo_Straw_Gate = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Straw_Gate"); 

			GameObject OP_Leaves_4 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_4"); 

			GameObject OP_Leaves_5 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_5"); 

			GameObject OP_Leaves_6 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Leaves_6"); 

			GameObject OP_Bamboo_Straw_Gate_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Straw_Gate_2"); 
			
			//newshit
			GameObject OP_Bamboo_Log = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log"); 

			GameObject OP_Bamboo_Log_Half = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log_Half"); 

			GameObject OP_Bamboo_Stump = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Stump"); 

			GameObject OP_Bamboo_Tree_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_1"); 

			GameObject OP_Bamboo_Tree_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_2"); 

			GameObject OP_Bamboo_Build_Totem = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Build_Totem");


			new Harmony(ModName).PatchAll();			

		

		}
	}		
	
}