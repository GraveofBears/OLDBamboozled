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
		private const string ModVersion = "0.0.4";
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


			//pieces


			BuildPiece OP_Bamboo_Pole = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Pole", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Pole.Name.English("OP_Bamboo_Pole");
			OP_Bamboo_Pole.Description.English("A bamboozled piece");
			OP_Bamboo_Pole.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Pole_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Pole_Light", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Pole_Light.Name.English("OP_Bamboo_Pole_Light");
			OP_Bamboo_Pole_Light.Description.English("A bamboozled piece");
			OP_Bamboo_Pole_Light.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Thick_Pole = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Thick_Pole", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Thick_Pole.Name.English("OP_Bamboo_Thick_Pole");
			OP_Bamboo_Thick_Pole.Description.English("A bamboozled piece");
			OP_Bamboo_Thick_Pole.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Thick_Pole_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Thick_Pole_Light", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Thick_Pole_Light.Name.English("OP_Bamboo_Thick_Pole_Light");
			OP_Bamboo_Thick_Pole_Light.Description.English("A bamboozled piece");
			OP_Bamboo_Thick_Pole_Light.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Small_Pole_Dark = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Small_Pole_Dark", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Small_Pole_Dark.Name.English("OP_Bamboo_Small_Pole_Dark");
			OP_Bamboo_Small_Pole_Dark.Description.English("A Small Pole");
			OP_Bamboo_Small_Pole_Dark.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Small_Pole_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Small_Pole_Light", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Small_Pole_Light.Name.English("OP_Bamboo_Small_Pole_Light");
			OP_Bamboo_Small_Pole_Light.Description.English("A Small Pole");
			OP_Bamboo_Small_Pole_Light.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Beam = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Beam", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Beam.Name.English("OP_Bamboo_Beam");
			OP_Bamboo_Beam.Description.English("A bamboozled piece");
			OP_Bamboo_Beam.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Beam_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Beam_Light", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Beam_Light.Name.English("OP_Bamboo_Beam_Light");
			OP_Bamboo_Beam_Light.Description.English("A bamboozled piece");
			OP_Bamboo_Beam_Light.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Thick_Beam = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Thick_Beam", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Thick_Beam.Name.English("OP_Bamboo_Thick_Beam");
			OP_Bamboo_Thick_Beam.Description.English("A bamboozled piece");
			OP_Bamboo_Thick_Beam.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Thick_Beam_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Thick_Beam_Light", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Thick_Beam_Light.Name.English("OP_Bamboo_Thick_Beam_Light");
			OP_Bamboo_Thick_Beam_Light.Description.English("A bamboozled piece");
			OP_Bamboo_Thick_Beam_Light.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Angle_Beam_25 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Angle_Beam_25", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Angle_Beam_25.Name.English("OP_Bamboo_Angle_Beam_25");
			OP_Bamboo_Angle_Beam_25.Description.English("A bamboozled piece");
			OP_Bamboo_Angle_Beam_25.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Angle_Beam_45 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Angle_Beam_45", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Angle_Beam_45.Name.English("OP_Bamboo_Angle_Beam_45");
			OP_Bamboo_Angle_Beam_45.Description.English("A bamboozled piece");
			OP_Bamboo_Angle_Beam_45.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Short_Beam_1 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Short_Beam_1", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Short_Beam_1.Name.English("OP_Bamboo_Short_Beam_1");
			OP_Bamboo_Short_Beam_1.Description.English("A bamboozled piece");
			OP_Bamboo_Short_Beam_1.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Short_Beam_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Short_Beam_2", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Short_Beam_2.Name.English("OP_Bamboo_Short_Beam_2");
			OP_Bamboo_Short_Beam_2.Description.English("A bamboozled piece");
			OP_Bamboo_Short_Beam_2.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Bamboo_Brush_Fence = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Brush_Fence", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Brush_Fence.Name.English("OP_Bamboo_Brush_Fence");
			OP_Bamboo_Brush_Fence.Description.English("A bamboozled piece");
			OP_Bamboo_Brush_Fence.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Brush_Fence_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Brush_Fence_2", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Brush_Fence_2.Name.English("OP_Bamboo_Brush_Fence_2");
			OP_Bamboo_Brush_Fence_2.Description.English("A bamboozled piece");
			OP_Bamboo_Brush_Fence_2.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Brush_Fence_Wide = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Brush_Fence_Wide", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Brush_Fence_Wide.Name.English("OP_Bamboo_Brush_Fence_Wide");
			OP_Bamboo_Brush_Fence_Wide.Description.English("A bamboozled piece");
			OP_Bamboo_Brush_Fence_Wide.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			BuildPiece OP_Bamboo_Brush_Fence_Wide_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Brush_Fence_Wide_2", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Brush_Fence_Wide_2.Name.English("OP_Bamboo_Brush_Fence_Wide_2");
			OP_Bamboo_Brush_Fence_Wide_2.Description.English("A bamboozled piece");
			OP_Bamboo_Brush_Fence_Wide_2.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			BuildPiece OP_Bamboo_Frame = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Frame", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Frame.Name.English("OP_Bamboo_Frame");
			OP_Bamboo_Frame.Description.English("A bamboozled piece");
			OP_Bamboo_Frame.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Halfwall = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Halfwall", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Halfwall.Name.English("OP_Bamboo_Halfwall");
			OP_Bamboo_Halfwall.Description.English("A bamboozled piece");
			OP_Bamboo_Halfwall.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Wall = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Wall", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Wall.Name.English("OP_Bamboo_Wall");
			OP_Bamboo_Wall.Description.English("A bamboozled piece");
			OP_Bamboo_Wall.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			BuildPiece OP_Bamboo_Gate = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Gate", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Gate.Name.English("OP_Bamboo_Gate");
			OP_Bamboo_Gate.Description.English("A bamboozled piece");
			OP_Bamboo_Gate.RequiredItems.Add("OP_Bamboo_Wood", 8, true);

			BuildPiece OP_Bamboo_Floor = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Floor", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Floor.Name.English("OP_Bamboo_Floor");
			OP_Bamboo_Floor.Description.English("A bamboozled piece");
			OP_Bamboo_Floor.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Stair = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Stair", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Stair.Name.English("OP_Bamboo_Stair");
			OP_Bamboo_Stair.Description.English("A bamboozled piece");
			OP_Bamboo_Stair.RequiredItems.Add("OP_Bamboo_Wood", 8, true);

			BuildPiece OP_Bamboo_Door = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Door", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Door.Name.English("OP_Bamboo_Door");
			OP_Bamboo_Door.Description.English("A bamboozled piece");
			OP_Bamboo_Door.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			BuildPiece OP_Bamboo_Roof_Tile = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Roof_Tile", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Roof_Tile.Name.English("OP_Bamboo_Roof_Tile");
			OP_Bamboo_Roof_Tile.Description.English("A bamboozled piece");
			OP_Bamboo_Roof_Tile.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Straw_Gate = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Straw_Gate", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Straw_Gate.Name.English("OP_Bamboo_Straw_Gate");
			OP_Bamboo_Straw_Gate.Description.English("A bamboozled piece");
			OP_Bamboo_Straw_Gate.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			BuildPiece OP_Bamboo_Straw_Gate_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Straw_Gate_2", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Straw_Gate_2.Name.English("OP_Bamboo_Straw_Gate_2");
			OP_Bamboo_Straw_Gate_2.Description.English("A bamboozled piece");
			OP_Bamboo_Straw_Gate_2.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Wall_Top_25 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Wall_Top_25", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Wall_Top_25.Name.English("OP_Bamboo_Wall_Top_25");
			OP_Bamboo_Wall_Top_25.Description.English("A bamboozled piece");
			OP_Bamboo_Wall_Top_25.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Wall_Top_45 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Wall_Top_45", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Wall_Top_45.Name.English("OP_Bamboo_Wall_Top_45");
			OP_Bamboo_Wall_Top_45.Description.English("A bamboozled piece");
			OP_Bamboo_Wall_Top_45.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Wall_25 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Wall_25", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Wall_25.Name.English("OP_Bamboo_Wall_25");
			OP_Bamboo_Wall_25.Description.English("A bamboozled piece");
			OP_Bamboo_Wall_25.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Wall_45 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Wall_45", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Wall_45.Name.English("OP_Bamboo_Wall_45");
			OP_Bamboo_Wall_45.Description.English("A bamboozled piece");
			OP_Bamboo_Wall_45.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Bamboo_Ladder = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Bamboo_Ladder", true, "OP_Bamboo_Hammer");
			OP_Bamboo_Ladder.Name.English("OP_Bamboo_Ladder");
			OP_Bamboo_Ladder.Description.English("A ladder");
			OP_Bamboo_Ladder.RequiredItems.Add("OP_Bamboo_Wood", 4, true);

			//leaves

			BuildPiece OP_Leaves_1 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_1", true, "OP_Bamboo_Hammer");
			OP_Leaves_1.Name.English("OP_Leaves_2");
			OP_Leaves_1.Description.English("A bamboozled piece");
			OP_Leaves_1.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Leaves_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_2", true, "OP_Bamboo_Hammer");
			OP_Leaves_2.Name.English("OP_Leaves_2");
			OP_Leaves_2.Description.English("A bamboozled piece");
			OP_Leaves_2.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Leaves_3 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_3", true, "OP_Bamboo_Hammer");
			OP_Leaves_3.Name.English("OP_Leaves_3");
			OP_Leaves_3.Description.English("A bamboozled piece");
			OP_Leaves_3.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			BuildPiece OP_Leaves_4 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_4", true, "OP_Bamboo_Hammer");
			OP_Leaves_4.Name.English("OP_Leaves_4");
			OP_Leaves_4.Description.English("A bamboozled piece");
			OP_Leaves_4.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Leaves_5 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_5", true, "OP_Bamboo_Hammer");
			OP_Leaves_5.Name.English("OP_Leaves_5");
			OP_Leaves_5.Description.English("A bamboozled piece");
			OP_Leaves_5.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			BuildPiece OP_Leaves_6 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Leaves_6", true, "OP_Bamboo_Hammer");
			OP_Leaves_6.Name.English("OP_Leaves_6");
			OP_Leaves_6.Description.English("A bamboozled piece");
			OP_Leaves_6.RequiredItems.Add("OP_Bamboo_Wood", 2, true);

			//stone 

			BuildPiece OP_Ruin_Pillar_1 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Ruin_Pillar_1", true, "OP_Bamboo_Hammer");
			OP_Ruin_Pillar_1.Name.English("OP_Ruin_Pillar_1");
			OP_Ruin_Pillar_1.Description.English("A stone pillar");
			OP_Ruin_Pillar_1.RequiredItems.Add("Stone", 2, true);
			OP_Ruin_Pillar_1.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Ruin_Pillar_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Ruin_Pillar_2", true, "OP_Bamboo_Hammer");
			OP_Ruin_Pillar_2.Name.English("OP_Ruin_Pillar_2");
			OP_Ruin_Pillar_2.Description.English("A stone pillar");
			OP_Ruin_Pillar_2.RequiredItems.Add("Stone", 4, true);
			OP_Ruin_Pillar_2.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Ruin_Pillar_3 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Ruin_Pillar_3", true, "OP_Bamboo_Hammer");
			OP_Ruin_Pillar_3.Name.English("OP_Ruin_Pillar_3");
			OP_Ruin_Pillar_3.Description.English("A stone pillar");
			OP_Ruin_Pillar_3.RequiredItems.Add("Stone", 6, true);
			OP_Ruin_Pillar_3.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Rock_Formation_1 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Rock_Formation_1", true, "OP_Bamboo_Hammer");
			OP_Rock_Formation_1.Name.English("OP_Rock_Formation_1");
			OP_Rock_Formation_1.Description.English("A stone rock formation");
			OP_Rock_Formation_1.RequiredItems.Add("Stone", 4, true);
			OP_Rock_Formation_1.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Rock_Formation_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Rock_Formation_2", true, "OP_Bamboo_Hammer");
			OP_Rock_Formation_2.Name.English("OP_Rock_Formation_2");
			OP_Rock_Formation_2.Description.English("A stone rock formation");
			OP_Rock_Formation_2.RequiredItems.Add("Stone", 4, true);
			OP_Rock_Formation_2.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Rock_Formation_3 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Rock_Formation_3", true, "OP_Bamboo_Hammer");
			OP_Rock_Formation_3.Name.English("OP_Rock_Formation_3");
			OP_Rock_Formation_3.Description.English("A stone rock formation");
			OP_Rock_Formation_3.RequiredItems.Add("Stone", 4, true);
			OP_Rock_Formation_3.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Rock_Formation_4 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Rock_Formation_4", true, "OP_Bamboo_Hammer");
			OP_Rock_Formation_4.Name.English("OP_Rock_Formation_4");
			OP_Rock_Formation_4.Description.English("A stone rock formation");
			OP_Rock_Formation_4.RequiredItems.Add("Stone", 4, true);
			OP_Rock_Formation_4.RequiredItems.Add("OP_Bamboo_Wood", 2, true);


			BuildPiece OP_Stone_Path_1 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Stone_Path_1", true, "OP_Bamboo_Hammer");
			OP_Stone_Path_1.Name.English("OP_Stone_Path_1");
			OP_Stone_Path_1.Description.English("A path stone");
			OP_Stone_Path_1.RequiredItems.Add("Stone", 1, true);
			OP_Stone_Path_1.RequiredItems.Add("OP_Bamboo_Wood", 1, true);


			BuildPiece OP_Stone_Path_2 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Stone_Path_2", true, "OP_Bamboo_Hammer");
			OP_Stone_Path_2.Name.English("OP_Stone_Path_2");
			OP_Stone_Path_2.Description.English("A path stone");
			OP_Stone_Path_2.RequiredItems.Add("Stone", 1, true);
			OP_Stone_Path_2.RequiredItems.Add("OP_Bamboo_Wood", 1, true);


			BuildPiece OP_Stone_Path_3 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Stone_Path_3", true, "OP_Bamboo_Hammer");
			OP_Stone_Path_3.Name.English("OP_Stone_Path_3");
			OP_Stone_Path_3.Description.English("A path stone");
			OP_Stone_Path_3.RequiredItems.Add("Stone", 1, true);
			OP_Stone_Path_3.RequiredItems.Add("OP_Bamboo_Wood", 1, true);


			BuildPiece OP_Stone_Path_4 = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Stone_Path_4", true, "OP_Bamboo_Hammer");
			OP_Stone_Path_4.Name.English("OP_Stone_Path_4");
			OP_Stone_Path_4.Description.English("A path stone");
			OP_Stone_Path_4.RequiredItems.Add("Stone", 1, true);
			OP_Stone_Path_4.RequiredItems.Add("OP_Bamboo_Wood", 1, true);

			//bamboo forest walls

			BuildPiece OP_Wild_Bamboo_Wall = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Wall", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Wall.Name.English("OP_Wild_Bamboo_Wall");
			OP_Wild_Bamboo_Wall.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Wall.RequiredItems.Add("OP_Bamboo_Wood", 12, true);


			BuildPiece OP_Wild_Bamboo = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo.Name.English("OP_Wild_Bamboo");
			OP_Wild_Bamboo.Description.English("A bamboozled piece");
			OP_Wild_Bamboo.RequiredItems.Add("OP_Bamboo_Wood", 4, true);


			BuildPiece OP_Wild_Bamboo_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Light", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Light.Name.English("OP_Wild_Bamboo_Light");
			OP_Wild_Bamboo_Light.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Light.RequiredItems.Add("OP_Bamboo_Wood", 4, true);


			BuildPiece OP_Wild_Bamboo_Dark = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Dark", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Dark.Name.English("OP_Wild_Bamboo_Dark");
			OP_Wild_Bamboo_Dark.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Dark.RequiredItems.Add("OP_Bamboo_Wood", 4, true);


			BuildPiece OP_Wild_Bamboo_Cluster = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Cluster", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Cluster.Name.English("OP_Wild_Bamboo_Cluster");
			OP_Wild_Bamboo_Cluster.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Cluster.RequiredItems.Add("OP_Bamboo_Wood", 8, true);


			BuildPiece OP_Wild_Bamboo_Cluster_Light = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Cluster_Light", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Cluster_Light.Name.English("OP_Wild_Bamboo_Cluster_Light");
			OP_Wild_Bamboo_Cluster_Light.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Cluster_Light.RequiredItems.Add("OP_Bamboo_Wood", 8, true);


			BuildPiece OP_Wild_Bamboo_Cluster_Dark = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Cluster_Dark", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Cluster_Dark.Name.English("OP_Wild_Bamboo_Cluster_Dark");
			OP_Wild_Bamboo_Cluster_Dark.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Cluster_Light.RequiredItems.Add("OP_Bamboo_Wood", 8, true);


			BuildPiece OP_Wild_Bamboo_Wall_Door = new(PiecePrefabManager.RegisterAssetBundle("bamboo"), "OP_Wild_Bamboo_Wall_Door", true, "OP_Bamboo_Hammer");
			OP_Wild_Bamboo_Wall_Door.Name.English("OP_Wild_Bamboo_Wall_Door");
			OP_Wild_Bamboo_Wall_Door.Description.English("A bamboozled piece");
			OP_Wild_Bamboo_Cluster_Light.RequiredItems.Add("OP_Bamboo_Wood", 10, true);



			//trees
			GameObject OP_Bamboo_Log = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log");

			GameObject OP_Bamboo_Log_Half = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Log_Half");

			GameObject OP_Bamboo_Stump = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Stump");

			GameObject OP_Bamboo_Tree_1 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_1");

			GameObject OP_Bamboo_Tree_2 = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Tree_2");

			//totem
			GameObject OP_Bamboo_Build_Totem = ItemManager.PrefabManager.RegisterPrefab("bamboo", "OP_Bamboo_Build_Totem");

			new Harmony(ModName).PatchAll();



		}
	}

}