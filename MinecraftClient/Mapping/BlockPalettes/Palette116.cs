using System.Collections.Generic;
namespace MinecraftClient.Mapping.BlockPalettes
{
    public class Palette116 : BlockPalette
    {
        private static Dictionary<int, Material> materials = new Dictionary<int, Material>();

        static Palette116()
        {
            materials[0] = Material.Air;
            materials[1] = Material.Stone;
            materials[2] = Material.Granite;
            materials[3] = Material.PolishedGranite;
            materials[4] = Material.Diorite;
            materials[5] = Material.PolishedDiorite;
            materials[6] = Material.Andesite;
            materials[7] = Material.PolishedAndesite;
            for (var i = 8; i <= 9; i++)
                materials[i] = Material.GrassBlock;
            materials[10] = Material.Dirt;
            materials[11] = Material.CoarseDirt;
            for (var i = 12; i <= 13; i++)
                materials[i] = Material.Podzol;
            materials[14] = Material.Cobblestone;
            materials[15] = Material.OakPlanks;
            materials[16] = Material.SprucePlanks;
            materials[17] = Material.BirchPlanks;
            materials[18] = Material.JunglePlanks;
            materials[19] = Material.AcaciaPlanks;
            materials[20] = Material.DarkOakPlanks;
            for (var i = 21; i <= 22; i++)
                materials[i] = Material.OakSapling;
            for (var i = 23; i <= 24; i++)
                materials[i] = Material.SpruceSapling;
            for (var i = 25; i <= 26; i++)
                materials[i] = Material.BirchSapling;
            for (var i = 27; i <= 28; i++)
                materials[i] = Material.JungleSapling;
            for (var i = 29; i <= 30; i++)
                materials[i] = Material.AcaciaSapling;
            for (var i = 31; i <= 32; i++)
                materials[i] = Material.DarkOakSapling;
            materials[33] = Material.Bedrock;
            for (var i = 34; i <= 49; i++)
                materials[i] = Material.Water;
            for (var i = 50; i <= 65; i++)
                materials[i] = Material.Lava;
            materials[66] = Material.Sand;
            materials[67] = Material.RedSand;
            materials[68] = Material.Gravel;
            materials[69] = Material.GoldOre;
            materials[70] = Material.IronOre;
            materials[71] = Material.CoalOre;
            materials[72] = Material.NetherGoldOre;
            for (var i = 73; i <= 75; i++)
                materials[i] = Material.OakLog;
            for (var i = 76; i <= 78; i++)
                materials[i] = Material.SpruceLog;
            for (var i = 79; i <= 81; i++)
                materials[i] = Material.BirchLog;
            for (var i = 82; i <= 84; i++)
                materials[i] = Material.JungleLog;
            for (var i = 85; i <= 87; i++)
                materials[i] = Material.AcaciaLog;
            for (var i = 88; i <= 90; i++)
                materials[i] = Material.DarkOakLog;
            for (var i = 91; i <= 93; i++)
                materials[i] = Material.StrippedSpruceLog;
            for (var i = 94; i <= 96; i++)
                materials[i] = Material.StrippedBirchLog;
            for (var i = 97; i <= 99; i++)
                materials[i] = Material.StrippedJungleLog;
            for (var i = 100; i <= 102; i++)
                materials[i] = Material.StrippedAcaciaLog;
            for (var i = 103; i <= 105; i++)
                materials[i] = Material.StrippedDarkOakLog;
            for (var i = 106; i <= 108; i++)
                materials[i] = Material.StrippedOakLog;
            for (var i = 109; i <= 111; i++)
                materials[i] = Material.OakWood;
            for (var i = 112; i <= 114; i++)
                materials[i] = Material.SpruceWood;
            for (var i = 115; i <= 117; i++)
                materials[i] = Material.BirchWood;
            for (var i = 118; i <= 120; i++)
                materials[i] = Material.JungleWood;
            for (var i = 121; i <= 123; i++)
                materials[i] = Material.AcaciaWood;
            for (var i = 124; i <= 126; i++)
                materials[i] = Material.DarkOakWood;
            for (var i = 127; i <= 129; i++)
                materials[i] = Material.StrippedOakWood;
            for (var i = 130; i <= 132; i++)
                materials[i] = Material.StrippedSpruceWood;
            for (var i = 133; i <= 135; i++)
                materials[i] = Material.StrippedBirchWood;
            for (var i = 136; i <= 138; i++)
                materials[i] = Material.StrippedJungleWood;
            for (var i = 139; i <= 141; i++)
                materials[i] = Material.StrippedAcaciaWood;
            for (var i = 142; i <= 144; i++)
                materials[i] = Material.StrippedDarkOakWood;
            for (var i = 145; i <= 158; i++)
                materials[i] = Material.OakLeaves;
            for (var i = 159; i <= 172; i++)
                materials[i] = Material.SpruceLeaves;
            for (var i = 173; i <= 186; i++)
                materials[i] = Material.BirchLeaves;
            for (var i = 187; i <= 200; i++)
                materials[i] = Material.JungleLeaves;
            for (var i = 201; i <= 214; i++)
                materials[i] = Material.AcaciaLeaves;
            for (var i = 215; i <= 228; i++)
                materials[i] = Material.DarkOakLeaves;
            materials[229] = Material.Sponge;
            materials[230] = Material.WetSponge;
            materials[231] = Material.Glass;
            materials[232] = Material.LapisOre;
            materials[233] = Material.LapisBlock;
            for (var i = 234; i <= 245; i++)
                materials[i] = Material.Dispenser;
            materials[246] = Material.Sandstone;
            materials[247] = Material.ChiseledSandstone;
            materials[248] = Material.CutSandstone;
            for (var i = 249; i <= 1048; i++)
                materials[i] = Material.NoteBlock;
            for (var i = 1049; i <= 1064; i++)
                materials[i] = Material.WhiteBed;
            for (var i = 1065; i <= 1080; i++)
                materials[i] = Material.OrangeBed;
            for (var i = 1081; i <= 1096; i++)
                materials[i] = Material.MagentaBed;
            for (var i = 1097; i <= 1112; i++)
                materials[i] = Material.LightBlueBed;
            for (var i = 1113; i <= 1128; i++)
                materials[i] = Material.YellowBed;
            for (var i = 1129; i <= 1144; i++)
                materials[i] = Material.LimeBed;
            for (var i = 1145; i <= 1160; i++)
                materials[i] = Material.PinkBed;
            for (var i = 1161; i <= 1176; i++)
                materials[i] = Material.GrayBed;
            for (var i = 1177; i <= 1192; i++)
                materials[i] = Material.LightGrayBed;
            for (var i = 1193; i <= 1208; i++)
                materials[i] = Material.CyanBed;
            for (var i = 1209; i <= 1224; i++)
                materials[i] = Material.PurpleBed;
            for (var i = 1225; i <= 1240; i++)
                materials[i] = Material.BlueBed;
            for (var i = 1241; i <= 1256; i++)
                materials[i] = Material.BrownBed;
            for (var i = 1257; i <= 1272; i++)
                materials[i] = Material.GreenBed;
            for (var i = 1273; i <= 1288; i++)
                materials[i] = Material.RedBed;
            for (var i = 1289; i <= 1304; i++)
                materials[i] = Material.BlackBed;
            for (var i = 1305; i <= 1316; i++)
                materials[i] = Material.PoweredRail;
            for (var i = 1317; i <= 1328; i++)
                materials[i] = Material.DetectorRail;
            for (var i = 1329; i <= 1340; i++)
                materials[i] = Material.StickyPiston;
            materials[1341] = Material.Cobweb;
            materials[1342] = Material.Grass;
            materials[1343] = Material.Fern;
            materials[1344] = Material.DeadBush;
            materials[1345] = Material.Seagrass;
            for (var i = 1346; i <= 1347; i++)
                materials[i] = Material.TallSeagrass;
            for (var i = 1348; i <= 1359; i++)
                materials[i] = Material.Piston;
            for (var i = 1360; i <= 1383; i++)
                materials[i] = Material.PistonHead;
            materials[1384] = Material.WhiteWool;
            materials[1385] = Material.OrangeWool;
            materials[1386] = Material.MagentaWool;
            materials[1387] = Material.LightBlueWool;
            materials[1388] = Material.YellowWool;
            materials[1389] = Material.LimeWool;
            materials[1390] = Material.PinkWool;
            materials[1391] = Material.GrayWool;
            materials[1392] = Material.LightGrayWool;
            materials[1393] = Material.CyanWool;
            materials[1394] = Material.PurpleWool;
            materials[1395] = Material.BlueWool;
            materials[1396] = Material.BrownWool;
            materials[1397] = Material.GreenWool;
            materials[1398] = Material.RedWool;
            materials[1399] = Material.BlackWool;
            for (var i = 1400; i <= 1411; i++)
                materials[i] = Material.MovingPiston;
            materials[1412] = Material.Dandelion;
            materials[1413] = Material.Poppy;
            materials[1414] = Material.BlueOrchid;
            materials[1415] = Material.Allium;
            materials[1416] = Material.AzureBluet;
            materials[1417] = Material.RedTulip;
            materials[1418] = Material.OrangeTulip;
            materials[1419] = Material.WhiteTulip;
            materials[1420] = Material.PinkTulip;
            materials[1421] = Material.OxeyeDaisy;
            materials[1422] = Material.Cornflower;
            materials[1423] = Material.WitherRose;
            materials[1424] = Material.LilyOfTheValley;
            materials[1425] = Material.BrownMushroom;
            materials[1426] = Material.RedMushroom;
            materials[1427] = Material.GoldBlock;
            materials[1428] = Material.IronBlock;
            materials[1429] = Material.Bricks;
            for (var i = 1430; i <= 1431; i++)
                materials[i] = Material.Tnt;
            materials[1432] = Material.Bookshelf;
            materials[1433] = Material.MossyCobblestone;
            materials[1434] = Material.Obsidian;
            materials[1435] = Material.Torch;
            for (var i = 1436; i <= 1439; i++)
                materials[i] = Material.WallTorch;
            for (var i = 1440; i <= 1951; i++)
                materials[i] = Material.Fire;
            materials[1952] = Material.SoulFire;
            materials[1953] = Material.Spawner;
            for (var i = 1954; i <= 2033; i++)
                materials[i] = Material.OakStairs;
            for (var i = 2034; i <= 2057; i++)
                materials[i] = Material.Chest;
            for (var i = 2058; i <= 3353; i++)
                materials[i] = Material.RedstoneWire;
            materials[3354] = Material.DiamondOre;
            materials[3355] = Material.DiamondBlock;
            materials[3356] = Material.CraftingTable;
            for (var i = 3357; i <= 3364; i++)
                materials[i] = Material.Wheat;
            for (var i = 3365; i <= 3372; i++)
                materials[i] = Material.Farmland;
            for (var i = 3373; i <= 3380; i++)
                materials[i] = Material.Furnace;
            for (var i = 3381; i <= 3412; i++)
                materials[i] = Material.OakSign;
            for (var i = 3413; i <= 3444; i++)
                materials[i] = Material.SpruceSign;
            for (var i = 3445; i <= 3476; i++)
                materials[i] = Material.BirchSign;
            for (var i = 3477; i <= 3508; i++)
                materials[i] = Material.AcaciaSign;
            for (var i = 3509; i <= 3540; i++)
                materials[i] = Material.JungleSign;
            for (var i = 3541; i <= 3572; i++)
                materials[i] = Material.DarkOakSign;
            for (var i = 3573; i <= 3636; i++)
                materials[i] = Material.OakDoor;
            for (var i = 3637; i <= 3644; i++)
                materials[i] = Material.Ladder;
            for (var i = 3645; i <= 3654; i++)
                materials[i] = Material.Rail;
            for (var i = 3655; i <= 3734; i++)
                materials[i] = Material.CobblestoneStairs;
            for (var i = 3735; i <= 3742; i++)
                materials[i] = Material.OakWallSign;
            for (var i = 3743; i <= 3750; i++)
                materials[i] = Material.SpruceWallSign;
            for (var i = 3751; i <= 3758; i++)
                materials[i] = Material.BirchWallSign;
            for (var i = 3759; i <= 3766; i++)
                materials[i] = Material.AcaciaWallSign;
            for (var i = 3767; i <= 3774; i++)
                materials[i] = Material.JungleWallSign;
            for (var i = 3775; i <= 3782; i++)
                materials[i] = Material.DarkOakWallSign;
            for (var i = 3783; i <= 3806; i++)
                materials[i] = Material.Lever;
            for (var i = 3807; i <= 3808; i++)
                materials[i] = Material.StonePressurePlate;
            for (var i = 3809; i <= 3872; i++)
                materials[i] = Material.IronDoor;
            for (var i = 3873; i <= 3874; i++)
                materials[i] = Material.OakPressurePlate;
            for (var i = 3875; i <= 3876; i++)
                materials[i] = Material.SprucePressurePlate;
            for (var i = 3877; i <= 3878; i++)
                materials[i] = Material.BirchPressurePlate;
            for (var i = 3879; i <= 3880; i++)
                materials[i] = Material.JunglePressurePlate;
            for (var i = 3881; i <= 3882; i++)
                materials[i] = Material.AcaciaPressurePlate;
            for (var i = 3883; i <= 3884; i++)
                materials[i] = Material.DarkOakPressurePlate;
            for (var i = 3885; i <= 3886; i++)
                materials[i] = Material.RedstoneOre;
            for (var i = 3887; i <= 3888; i++)
                materials[i] = Material.RedstoneTorch;
            for (var i = 3889; i <= 3896; i++)
                materials[i] = Material.RedstoneWallTorch;
            for (var i = 3897; i <= 3920; i++)
                materials[i] = Material.StoneButton;
            for (var i = 3921; i <= 3928; i++)
                materials[i] = Material.Snow;
            materials[3929] = Material.Ice;
            materials[3930] = Material.SnowBlock;
            for (var i = 3931; i <= 3946; i++)
                materials[i] = Material.Cactus;
            materials[3947] = Material.Clay;
            for (var i = 3948; i <= 3963; i++)
                materials[i] = Material.SugarCane;
            for (var i = 3964; i <= 3965; i++)
                materials[i] = Material.Jukebox;
            for (var i = 3966; i <= 3997; i++)
                materials[i] = Material.OakFence;
            materials[3998] = Material.Pumpkin;
            materials[3999] = Material.Netherrack;
            materials[4000] = Material.SoulSand;
            materials[4001] = Material.SoulSoil;
            for (var i = 4002; i <= 4004; i++)
                materials[i] = Material.Basalt;
            for (var i = 4005; i <= 4007; i++)
                materials[i] = Material.PolishedBasalt;
            materials[4008] = Material.SoulTorch;
            for (var i = 4009; i <= 4012; i++)
                materials[i] = Material.SoulWallTorch;
            materials[4013] = Material.Glowstone;
            for (var i = 4014; i <= 4015; i++)
                materials[i] = Material.NetherPortal;
            for (var i = 4016; i <= 4019; i++)
                materials[i] = Material.CarvedPumpkin;
            for (var i = 4020; i <= 4023; i++)
                materials[i] = Material.JackOLantern;
            for (var i = 4024; i <= 4030; i++)
                materials[i] = Material.Cake;
            for (var i = 4031; i <= 4094; i++)
                materials[i] = Material.Repeater;
            materials[4095] = Material.WhiteStainedGlass;
            materials[4096] = Material.OrangeStainedGlass;
            materials[4097] = Material.MagentaStainedGlass;
            materials[4098] = Material.LightBlueStainedGlass;
            materials[4099] = Material.YellowStainedGlass;
            materials[4100] = Material.LimeStainedGlass;
            materials[4101] = Material.PinkStainedGlass;
            materials[4102] = Material.GrayStainedGlass;
            materials[4103] = Material.LightGrayStainedGlass;
            materials[4104] = Material.CyanStainedGlass;
            materials[4105] = Material.PurpleStainedGlass;
            materials[4106] = Material.BlueStainedGlass;
            materials[4107] = Material.BrownStainedGlass;
            materials[4108] = Material.GreenStainedGlass;
            materials[4109] = Material.RedStainedGlass;
            materials[4110] = Material.BlackStainedGlass;
            for (var i = 4111; i <= 4174; i++)
                materials[i] = Material.OakTrapdoor;
            for (var i = 4175; i <= 4238; i++)
                materials[i] = Material.SpruceTrapdoor;
            for (var i = 4239; i <= 4302; i++)
                materials[i] = Material.BirchTrapdoor;
            for (var i = 4303; i <= 4366; i++)
                materials[i] = Material.JungleTrapdoor;
            for (var i = 4367; i <= 4430; i++)
                materials[i] = Material.AcaciaTrapdoor;
            for (var i = 4431; i <= 4494; i++)
                materials[i] = Material.DarkOakTrapdoor;
            materials[4495] = Material.StoneBricks;
            materials[4496] = Material.MossyStoneBricks;
            materials[4497] = Material.CrackedStoneBricks;
            materials[4498] = Material.ChiseledStoneBricks;
            materials[4499] = Material.InfestedStone;
            materials[4500] = Material.InfestedCobblestone;
            materials[4501] = Material.InfestedStoneBricks;
            materials[4502] = Material.InfestedMossyStoneBricks;
            materials[4503] = Material.InfestedCrackedStoneBricks;
            materials[4504] = Material.InfestedChiseledStoneBricks;
            for (var i = 4505; i <= 4568; i++)
                materials[i] = Material.BrownMushroomBlock;
            for (var i = 4569; i <= 4632; i++)
                materials[i] = Material.RedMushroomBlock;
            for (var i = 4633; i <= 4696; i++)
                materials[i] = Material.MushroomStem;
            for (var i = 4697; i <= 4728; i++)
                materials[i] = Material.IronBars;
            for (var i = 4729; i <= 4734; i++)
                materials[i] = Material.Chain;
            for (var i = 4735; i <= 4766; i++)
                materials[i] = Material.GlassPane;
            materials[4767] = Material.Melon;
            for (var i = 4768; i <= 4771; i++)
                materials[i] = Material.AttachedPumpkinStem;
            for (var i = 4772; i <= 4775; i++)
                materials[i] = Material.AttachedMelonStem;
            for (var i = 4776; i <= 4783; i++)
                materials[i] = Material.PumpkinStem;
            for (var i = 4784; i <= 4791; i++)
                materials[i] = Material.MelonStem;
            for (var i = 4792; i <= 4823; i++)
                materials[i] = Material.Vine;
            for (var i = 4824; i <= 4855; i++)
                materials[i] = Material.OakFenceGate;
            for (var i = 4856; i <= 4935; i++)
                materials[i] = Material.BrickStairs;
            for (var i = 4936; i <= 5015; i++)
                materials[i] = Material.StoneBrickStairs;
            for (var i = 5016; i <= 5017; i++)
                materials[i] = Material.Mycelium;
            materials[5018] = Material.LilyPad;
            materials[5019] = Material.NetherBricks;
            for (var i = 5020; i <= 5051; i++)
                materials[i] = Material.NetherBrickFence;
            for (var i = 5052; i <= 5131; i++)
                materials[i] = Material.NetherBrickStairs;
            for (var i = 5132; i <= 5135; i++)
                materials[i] = Material.NetherWart;
            materials[5136] = Material.EnchantingTable;
            for (var i = 5137; i <= 5144; i++)
                materials[i] = Material.BrewingStand;
            for (var i = 5145; i <= 5148; i++)
                materials[i] = Material.Cauldron;
            materials[5149] = Material.EndPortal;
            for (var i = 5150; i <= 5157; i++)
                materials[i] = Material.EndPortalFrame;
            materials[5158] = Material.EndStone;
            materials[5159] = Material.DragonEgg;
            for (var i = 5160; i <= 5161; i++)
                materials[i] = Material.RedstoneLamp;
            for (var i = 5162; i <= 5173; i++)
                materials[i] = Material.Cocoa;
            for (var i = 5174; i <= 5253; i++)
                materials[i] = Material.SandstoneStairs;
            materials[5254] = Material.EmeraldOre;
            for (var i = 5255; i <= 5262; i++)
                materials[i] = Material.EnderChest;
            for (var i = 5263; i <= 5278; i++)
                materials[i] = Material.TripwireHook;
            for (var i = 5279; i <= 5406; i++)
                materials[i] = Material.Tripwire;
            materials[5407] = Material.EmeraldBlock;
            for (var i = 5408; i <= 5487; i++)
                materials[i] = Material.SpruceStairs;
            for (var i = 5488; i <= 5567; i++)
                materials[i] = Material.BirchStairs;
            for (var i = 5568; i <= 5647; i++)
                materials[i] = Material.JungleStairs;
            for (var i = 5648; i <= 5659; i++)
                materials[i] = Material.CommandBlock;
            materials[5660] = Material.Beacon;
            for (var i = 5661; i <= 5984; i++)
                materials[i] = Material.CobblestoneWall;
            for (var i = 5985; i <= 6308; i++)
                materials[i] = Material.MossyCobblestoneWall;
            materials[6309] = Material.FlowerPot;
            materials[6310] = Material.PottedOakSapling;
            materials[6311] = Material.PottedSpruceSapling;
            materials[6312] = Material.PottedBirchSapling;
            materials[6313] = Material.PottedJungleSapling;
            materials[6314] = Material.PottedAcaciaSapling;
            materials[6315] = Material.PottedDarkOakSapling;
            materials[6316] = Material.PottedFern;
            materials[6317] = Material.PottedDandelion;
            materials[6318] = Material.PottedPoppy;
            materials[6319] = Material.PottedBlueOrchid;
            materials[6320] = Material.PottedAllium;
            materials[6321] = Material.PottedAzureBluet;
            materials[6322] = Material.PottedRedTulip;
            materials[6323] = Material.PottedOrangeTulip;
            materials[6324] = Material.PottedWhiteTulip;
            materials[6325] = Material.PottedPinkTulip;
            materials[6326] = Material.PottedOxeyeDaisy;
            materials[6327] = Material.PottedCornflower;
            materials[6328] = Material.PottedLilyOfTheValley;
            materials[6329] = Material.PottedWitherRose;
            materials[6330] = Material.PottedRedMushroom;
            materials[6331] = Material.PottedBrownMushroom;
            materials[6332] = Material.PottedDeadBush;
            materials[6333] = Material.PottedCactus;
            for (var i = 6334; i <= 6341; i++)
                materials[i] = Material.Carrots;
            for (var i = 6342; i <= 6349; i++)
                materials[i] = Material.Potatoes;
            for (var i = 6350; i <= 6373; i++)
                materials[i] = Material.OakButton;
            for (var i = 6374; i <= 6397; i++)
                materials[i] = Material.SpruceButton;
            for (var i = 6398; i <= 6421; i++)
                materials[i] = Material.BirchButton;
            for (var i = 6422; i <= 6445; i++)
                materials[i] = Material.JungleButton;
            for (var i = 6446; i <= 6469; i++)
                materials[i] = Material.AcaciaButton;
            for (var i = 6470; i <= 6493; i++)
                materials[i] = Material.DarkOakButton;
            for (var i = 6494; i <= 6509; i++)
                materials[i] = Material.SkeletonSkull;
            for (var i = 6510; i <= 6513; i++)
                materials[i] = Material.SkeletonWallSkull;
            for (var i = 6514; i <= 6529; i++)
                materials[i] = Material.WitherSkeletonSkull;
            for (var i = 6530; i <= 6533; i++)
                materials[i] = Material.WitherSkeletonWallSkull;
            for (var i = 6534; i <= 6549; i++)
                materials[i] = Material.ZombieHead;
            for (var i = 6550; i <= 6553; i++)
                materials[i] = Material.ZombieWallHead;
            for (var i = 6554; i <= 6569; i++)
                materials[i] = Material.PlayerHead;
            for (var i = 6570; i <= 6573; i++)
                materials[i] = Material.PlayerWallHead;
            for (var i = 6574; i <= 6589; i++)
                materials[i] = Material.CreeperHead;
            for (var i = 6590; i <= 6593; i++)
                materials[i] = Material.CreeperWallHead;
            for (var i = 6594; i <= 6609; i++)
                materials[i] = Material.DragonHead;
            for (var i = 6610; i <= 6613; i++)
                materials[i] = Material.DragonWallHead;
            for (var i = 6614; i <= 6617; i++)
                materials[i] = Material.Anvil;
            for (var i = 6618; i <= 6621; i++)
                materials[i] = Material.ChippedAnvil;
            for (var i = 6622; i <= 6625; i++)
                materials[i] = Material.DamagedAnvil;
            for (var i = 6626; i <= 6649; i++)
                materials[i] = Material.TrappedChest;
            for (var i = 6650; i <= 6665; i++)
                materials[i] = Material.LightWeightedPressurePlate;
            for (var i = 6666; i <= 6681; i++)
                materials[i] = Material.HeavyWeightedPressurePlate;
            for (var i = 6682; i <= 6697; i++)
                materials[i] = Material.Comparator;
            for (var i = 6698; i <= 6729; i++)
                materials[i] = Material.DaylightDetector;
            materials[6730] = Material.RedstoneBlock;
            materials[6731] = Material.NetherQuartzOre;
            for (var i = 6732; i <= 6741; i++)
                materials[i] = Material.Hopper;
            materials[6742] = Material.QuartzBlock;
            materials[6743] = Material.ChiseledQuartzBlock;
            for (var i = 6744; i <= 6746; i++)
                materials[i] = Material.QuartzPillar;
            for (var i = 6747; i <= 6826; i++)
                materials[i] = Material.QuartzStairs;
            for (var i = 6827; i <= 6838; i++)
                materials[i] = Material.ActivatorRail;
            for (var i = 6839; i <= 6850; i++)
                materials[i] = Material.Dropper;
            materials[6851] = Material.WhiteTerracotta;
            materials[6852] = Material.OrangeTerracotta;
            materials[6853] = Material.MagentaTerracotta;
            materials[6854] = Material.LightBlueTerracotta;
            materials[6855] = Material.YellowTerracotta;
            materials[6856] = Material.LimeTerracotta;
            materials[6857] = Material.PinkTerracotta;
            materials[6858] = Material.GrayTerracotta;
            materials[6859] = Material.LightGrayTerracotta;
            materials[6860] = Material.CyanTerracotta;
            materials[6861] = Material.PurpleTerracotta;
            materials[6862] = Material.BlueTerracotta;
            materials[6863] = Material.BrownTerracotta;
            materials[6864] = Material.GreenTerracotta;
            materials[6865] = Material.RedTerracotta;
            materials[6866] = Material.BlackTerracotta;
            for (var i = 6867; i <= 6898; i++)
                materials[i] = Material.WhiteStainedGlassPane;
            for (var i = 6899; i <= 6930; i++)
                materials[i] = Material.OrangeStainedGlassPane;
            for (var i = 6931; i <= 6962; i++)
                materials[i] = Material.MagentaStainedGlassPane;
            for (var i = 6963; i <= 6994; i++)
                materials[i] = Material.LightBlueStainedGlassPane;
            for (var i = 6995; i <= 7026; i++)
                materials[i] = Material.YellowStainedGlassPane;
            for (var i = 7027; i <= 7058; i++)
                materials[i] = Material.LimeStainedGlassPane;
            for (var i = 7059; i <= 7090; i++)
                materials[i] = Material.PinkStainedGlassPane;
            for (var i = 7091; i <= 7122; i++)
                materials[i] = Material.GrayStainedGlassPane;
            for (var i = 7123; i <= 7154; i++)
                materials[i] = Material.LightGrayStainedGlassPane;
            for (var i = 7155; i <= 7186; i++)
                materials[i] = Material.CyanStainedGlassPane;
            for (var i = 7187; i <= 7218; i++)
                materials[i] = Material.PurpleStainedGlassPane;
            for (var i = 7219; i <= 7250; i++)
                materials[i] = Material.BlueStainedGlassPane;
            for (var i = 7251; i <= 7282; i++)
                materials[i] = Material.BrownStainedGlassPane;
            for (var i = 7283; i <= 7314; i++)
                materials[i] = Material.GreenStainedGlassPane;
            for (var i = 7315; i <= 7346; i++)
                materials[i] = Material.RedStainedGlassPane;
            for (var i = 7347; i <= 7378; i++)
                materials[i] = Material.BlackStainedGlassPane;
            for (var i = 7379; i <= 7458; i++)
                materials[i] = Material.AcaciaStairs;
            for (var i = 7459; i <= 7538; i++)
                materials[i] = Material.DarkOakStairs;
            materials[7539] = Material.SlimeBlock;
            materials[7540] = Material.Barrier;
            for (var i = 7541; i <= 7604; i++)
                materials[i] = Material.IronTrapdoor;
            materials[7605] = Material.Prismarine;
            materials[7606] = Material.PrismarineBricks;
            materials[7607] = Material.DarkPrismarine;
            for (var i = 7608; i <= 7687; i++)
                materials[i] = Material.PrismarineStairs;
            for (var i = 7688; i <= 7767; i++)
                materials[i] = Material.PrismarineBrickStairs;
            for (var i = 7768; i <= 7847; i++)
                materials[i] = Material.DarkPrismarineStairs;
            for (var i = 7848; i <= 7853; i++)
                materials[i] = Material.PrismarineSlab;
            for (var i = 7854; i <= 7859; i++)
                materials[i] = Material.PrismarineBrickSlab;
            for (var i = 7860; i <= 7865; i++)
                materials[i] = Material.DarkPrismarineSlab;
            materials[7866] = Material.SeaLantern;
            for (var i = 7867; i <= 7869; i++)
                materials[i] = Material.HayBlock;
            materials[7870] = Material.WhiteCarpet;
            materials[7871] = Material.OrangeCarpet;
            materials[7872] = Material.MagentaCarpet;
            materials[7873] = Material.LightBlueCarpet;
            materials[7874] = Material.YellowCarpet;
            materials[7875] = Material.LimeCarpet;
            materials[7876] = Material.PinkCarpet;
            materials[7877] = Material.GrayCarpet;
            materials[7878] = Material.LightGrayCarpet;
            materials[7879] = Material.CyanCarpet;
            materials[7880] = Material.PurpleCarpet;
            materials[7881] = Material.BlueCarpet;
            materials[7882] = Material.BrownCarpet;
            materials[7883] = Material.GreenCarpet;
            materials[7884] = Material.RedCarpet;
            materials[7885] = Material.BlackCarpet;
            materials[7886] = Material.Terracotta;
            materials[7887] = Material.CoalBlock;
            materials[7888] = Material.PackedIce;
            for (var i = 7889; i <= 7890; i++)
                materials[i] = Material.Sunflower;
            for (var i = 7891; i <= 7892; i++)
                materials[i] = Material.Lilac;
            for (var i = 7893; i <= 7894; i++)
                materials[i] = Material.RoseBush;
            for (var i = 7895; i <= 7896; i++)
                materials[i] = Material.Peony;
            for (var i = 7897; i <= 7898; i++)
                materials[i] = Material.TallGrass;
            for (var i = 7899; i <= 7900; i++)
                materials[i] = Material.LargeFern;
            for (var i = 7901; i <= 7916; i++)
                materials[i] = Material.WhiteBanner;
            for (var i = 7917; i <= 7932; i++)
                materials[i] = Material.OrangeBanner;
            for (var i = 7933; i <= 7948; i++)
                materials[i] = Material.MagentaBanner;
            for (var i = 7949; i <= 7964; i++)
                materials[i] = Material.LightBlueBanner;
            for (var i = 7965; i <= 7980; i++)
                materials[i] = Material.YellowBanner;
            for (var i = 7981; i <= 7996; i++)
                materials[i] = Material.LimeBanner;
            for (var i = 7997; i <= 8012; i++)
                materials[i] = Material.PinkBanner;
            for (var i = 8013; i <= 8028; i++)
                materials[i] = Material.GrayBanner;
            for (var i = 8029; i <= 8044; i++)
                materials[i] = Material.LightGrayBanner;
            for (var i = 8045; i <= 8060; i++)
                materials[i] = Material.CyanBanner;
            for (var i = 8061; i <= 8076; i++)
                materials[i] = Material.PurpleBanner;
            for (var i = 8077; i <= 8092; i++)
                materials[i] = Material.BlueBanner;
            for (var i = 8093; i <= 8108; i++)
                materials[i] = Material.BrownBanner;
            for (var i = 8109; i <= 8124; i++)
                materials[i] = Material.GreenBanner;
            for (var i = 8125; i <= 8140; i++)
                materials[i] = Material.RedBanner;
            for (var i = 8141; i <= 8156; i++)
                materials[i] = Material.BlackBanner;
            for (var i = 8157; i <= 8160; i++)
                materials[i] = Material.WhiteWallBanner;
            for (var i = 8161; i <= 8164; i++)
                materials[i] = Material.OrangeWallBanner;
            for (var i = 8165; i <= 8168; i++)
                materials[i] = Material.MagentaWallBanner;
            for (var i = 8169; i <= 8172; i++)
                materials[i] = Material.LightBlueWallBanner;
            for (var i = 8173; i <= 8176; i++)
                materials[i] = Material.YellowWallBanner;
            for (var i = 8177; i <= 8180; i++)
                materials[i] = Material.LimeWallBanner;
            for (var i = 8181; i <= 8184; i++)
                materials[i] = Material.PinkWallBanner;
            for (var i = 8185; i <= 8188; i++)
                materials[i] = Material.GrayWallBanner;
            for (var i = 8189; i <= 8192; i++)
                materials[i] = Material.LightGrayWallBanner;
            for (var i = 8193; i <= 8196; i++)
                materials[i] = Material.CyanWallBanner;
            for (var i = 8197; i <= 8200; i++)
                materials[i] = Material.PurpleWallBanner;
            for (var i = 8201; i <= 8204; i++)
                materials[i] = Material.BlueWallBanner;
            for (var i = 8205; i <= 8208; i++)
                materials[i] = Material.BrownWallBanner;
            for (var i = 8209; i <= 8212; i++)
                materials[i] = Material.GreenWallBanner;
            for (var i = 8213; i <= 8216; i++)
                materials[i] = Material.RedWallBanner;
            for (var i = 8217; i <= 8220; i++)
                materials[i] = Material.BlackWallBanner;
            materials[8221] = Material.RedSandstone;
            materials[8222] = Material.ChiseledRedSandstone;
            materials[8223] = Material.CutRedSandstone;
            for (var i = 8224; i <= 8303; i++)
                materials[i] = Material.RedSandstoneStairs;
            for (var i = 8304; i <= 8309; i++)
                materials[i] = Material.OakSlab;
            for (var i = 8310; i <= 8315; i++)
                materials[i] = Material.SpruceSlab;
            for (var i = 8316; i <= 8321; i++)
                materials[i] = Material.BirchSlab;
            for (var i = 8322; i <= 8327; i++)
                materials[i] = Material.JungleSlab;
            for (var i = 8328; i <= 8333; i++)
                materials[i] = Material.AcaciaSlab;
            for (var i = 8334; i <= 8339; i++)
                materials[i] = Material.DarkOakSlab;
            for (var i = 8340; i <= 8345; i++)
                materials[i] = Material.StoneSlab;
            for (var i = 8346; i <= 8351; i++)
                materials[i] = Material.SmoothStoneSlab;
            for (var i = 8352; i <= 8357; i++)
                materials[i] = Material.SandstoneSlab;
            for (var i = 8358; i <= 8363; i++)
                materials[i] = Material.CutSandstoneSlab;
            for (var i = 8364; i <= 8369; i++)
                materials[i] = Material.PetrifiedOakSlab;
            for (var i = 8370; i <= 8375; i++)
                materials[i] = Material.CobblestoneSlab;
            for (var i = 8376; i <= 8381; i++)
                materials[i] = Material.BrickSlab;
            for (var i = 8382; i <= 8387; i++)
                materials[i] = Material.StoneBrickSlab;
            for (var i = 8388; i <= 8393; i++)
                materials[i] = Material.NetherBrickSlab;
            for (var i = 8394; i <= 8399; i++)
                materials[i] = Material.QuartzSlab;
            for (var i = 8400; i <= 8405; i++)
                materials[i] = Material.RedSandstoneSlab;
            for (var i = 8406; i <= 8411; i++)
                materials[i] = Material.CutRedSandstoneSlab;
            for (var i = 8412; i <= 8417; i++)
                materials[i] = Material.PurpurSlab;
            materials[8418] = Material.SmoothStone;
            materials[8419] = Material.SmoothSandstone;
            materials[8420] = Material.SmoothQuartz;
            materials[8421] = Material.SmoothRedSandstone;
            for (var i = 8422; i <= 8453; i++)
                materials[i] = Material.SpruceFenceGate;
            for (var i = 8454; i <= 8485; i++)
                materials[i] = Material.BirchFenceGate;
            for (var i = 8486; i <= 8517; i++)
                materials[i] = Material.JungleFenceGate;
            for (var i = 8518; i <= 8549; i++)
                materials[i] = Material.AcaciaFenceGate;
            for (var i = 8550; i <= 8581; i++)
                materials[i] = Material.DarkOakFenceGate;
            for (var i = 8582; i <= 8613; i++)
                materials[i] = Material.SpruceFence;
            for (var i = 8614; i <= 8645; i++)
                materials[i] = Material.BirchFence;
            for (var i = 8646; i <= 8677; i++)
                materials[i] = Material.JungleFence;
            for (var i = 8678; i <= 8709; i++)
                materials[i] = Material.AcaciaFence;
            for (var i = 8710; i <= 8741; i++)
                materials[i] = Material.DarkOakFence;
            for (var i = 8742; i <= 8805; i++)
                materials[i] = Material.SpruceDoor;
            for (var i = 8806; i <= 8869; i++)
                materials[i] = Material.BirchDoor;
            for (var i = 8870; i <= 8933; i++)
                materials[i] = Material.JungleDoor;
            for (var i = 8934; i <= 8997; i++)
                materials[i] = Material.AcaciaDoor;
            for (var i = 8998; i <= 9061; i++)
                materials[i] = Material.DarkOakDoor;
            for (var i = 9062; i <= 9067; i++)
                materials[i] = Material.EndRod;
            for (var i = 9068; i <= 9131; i++)
                materials[i] = Material.ChorusPlant;
            for (var i = 9132; i <= 9137; i++)
                materials[i] = Material.ChorusFlower;
            materials[9138] = Material.PurpurBlock;
            for (var i = 9139; i <= 9141; i++)
                materials[i] = Material.PurpurPillar;
            for (var i = 9142; i <= 9221; i++)
                materials[i] = Material.PurpurStairs;
            materials[9222] = Material.EndStoneBricks;
            for (var i = 9223; i <= 9226; i++)
                materials[i] = Material.Beetroots;
            materials[9227] = Material.GrassPath;
            materials[9228] = Material.EndGateway;
            for (var i = 9229; i <= 9240; i++)
                materials[i] = Material.RepeatingCommandBlock;
            for (var i = 9241; i <= 9252; i++)
                materials[i] = Material.ChainCommandBlock;
            for (var i = 9253; i <= 9256; i++)
                materials[i] = Material.FrostedIce;
            materials[9257] = Material.MagmaBlock;
            materials[9258] = Material.NetherWartBlock;
            materials[9259] = Material.RedNetherBricks;
            for (var i = 9260; i <= 9262; i++)
                materials[i] = Material.BoneBlock;
            materials[9263] = Material.StructureVoid;
            for (var i = 9264; i <= 9275; i++)
                materials[i] = Material.Observer;
            for (var i = 9276; i <= 9281; i++)
                materials[i] = Material.ShulkerBox;
            for (var i = 9282; i <= 9287; i++)
                materials[i] = Material.WhiteShulkerBox;
            for (var i = 9288; i <= 9293; i++)
                materials[i] = Material.OrangeShulkerBox;
            for (var i = 9294; i <= 9299; i++)
                materials[i] = Material.MagentaShulkerBox;
            for (var i = 9300; i <= 9305; i++)
                materials[i] = Material.LightBlueShulkerBox;
            for (var i = 9306; i <= 9311; i++)
                materials[i] = Material.YellowShulkerBox;
            for (var i = 9312; i <= 9317; i++)
                materials[i] = Material.LimeShulkerBox;
            for (var i = 9318; i <= 9323; i++)
                materials[i] = Material.PinkShulkerBox;
            for (var i = 9324; i <= 9329; i++)
                materials[i] = Material.GrayShulkerBox;
            for (var i = 9330; i <= 9335; i++)
                materials[i] = Material.LightGrayShulkerBox;
            for (var i = 9336; i <= 9341; i++)
                materials[i] = Material.CyanShulkerBox;
            for (var i = 9342; i <= 9347; i++)
                materials[i] = Material.PurpleShulkerBox;
            for (var i = 9348; i <= 9353; i++)
                materials[i] = Material.BlueShulkerBox;
            for (var i = 9354; i <= 9359; i++)
                materials[i] = Material.BrownShulkerBox;
            for (var i = 9360; i <= 9365; i++)
                materials[i] = Material.GreenShulkerBox;
            for (var i = 9366; i <= 9371; i++)
                materials[i] = Material.RedShulkerBox;
            for (var i = 9372; i <= 9377; i++)
                materials[i] = Material.BlackShulkerBox;
            for (var i = 9378; i <= 9381; i++)
                materials[i] = Material.WhiteGlazedTerracotta;
            for (var i = 9382; i <= 9385; i++)
                materials[i] = Material.OrangeGlazedTerracotta;
            for (var i = 9386; i <= 9389; i++)
                materials[i] = Material.MagentaGlazedTerracotta;
            for (var i = 9390; i <= 9393; i++)
                materials[i] = Material.LightBlueGlazedTerracotta;
            for (var i = 9394; i <= 9397; i++)
                materials[i] = Material.YellowGlazedTerracotta;
            for (var i = 9398; i <= 9401; i++)
                materials[i] = Material.LimeGlazedTerracotta;
            for (var i = 9402; i <= 9405; i++)
                materials[i] = Material.PinkGlazedTerracotta;
            for (var i = 9406; i <= 9409; i++)
                materials[i] = Material.GrayGlazedTerracotta;
            for (var i = 9410; i <= 9413; i++)
                materials[i] = Material.LightGrayGlazedTerracotta;
            for (var i = 9414; i <= 9417; i++)
                materials[i] = Material.CyanGlazedTerracotta;
            for (var i = 9418; i <= 9421; i++)
                materials[i] = Material.PurpleGlazedTerracotta;
            for (var i = 9422; i <= 9425; i++)
                materials[i] = Material.BlueGlazedTerracotta;
            for (var i = 9426; i <= 9429; i++)
                materials[i] = Material.BrownGlazedTerracotta;
            for (var i = 9430; i <= 9433; i++)
                materials[i] = Material.GreenGlazedTerracotta;
            for (var i = 9434; i <= 9437; i++)
                materials[i] = Material.RedGlazedTerracotta;
            for (var i = 9438; i <= 9441; i++)
                materials[i] = Material.BlackGlazedTerracotta;
            materials[9442] = Material.WhiteConcrete;
            materials[9443] = Material.OrangeConcrete;
            materials[9444] = Material.MagentaConcrete;
            materials[9445] = Material.LightBlueConcrete;
            materials[9446] = Material.YellowConcrete;
            materials[9447] = Material.LimeConcrete;
            materials[9448] = Material.PinkConcrete;
            materials[9449] = Material.GrayConcrete;
            materials[9450] = Material.LightGrayConcrete;
            materials[9451] = Material.CyanConcrete;
            materials[9452] = Material.PurpleConcrete;
            materials[9453] = Material.BlueConcrete;
            materials[9454] = Material.BrownConcrete;
            materials[9455] = Material.GreenConcrete;
            materials[9456] = Material.RedConcrete;
            materials[9457] = Material.BlackConcrete;
            materials[9458] = Material.WhiteConcretePowder;
            materials[9459] = Material.OrangeConcretePowder;
            materials[9460] = Material.MagentaConcretePowder;
            materials[9461] = Material.LightBlueConcretePowder;
            materials[9462] = Material.YellowConcretePowder;
            materials[9463] = Material.LimeConcretePowder;
            materials[9464] = Material.PinkConcretePowder;
            materials[9465] = Material.GrayConcretePowder;
            materials[9466] = Material.LightGrayConcretePowder;
            materials[9467] = Material.CyanConcretePowder;
            materials[9468] = Material.PurpleConcretePowder;
            materials[9469] = Material.BlueConcretePowder;
            materials[9470] = Material.BrownConcretePowder;
            materials[9471] = Material.GreenConcretePowder;
            materials[9472] = Material.RedConcretePowder;
            materials[9473] = Material.BlackConcretePowder;
            for (var i = 9474; i <= 9499; i++)
                materials[i] = Material.Kelp;
            materials[9500] = Material.KelpPlant;
            materials[9501] = Material.DriedKelpBlock;
            for (var i = 9502; i <= 9513; i++)
                materials[i] = Material.TurtleEgg;
            materials[9514] = Material.DeadTubeCoralBlock;
            materials[9515] = Material.DeadBrainCoralBlock;
            materials[9516] = Material.DeadBubbleCoralBlock;
            materials[9517] = Material.DeadFireCoralBlock;
            materials[9518] = Material.DeadHornCoralBlock;
            materials[9519] = Material.TubeCoralBlock;
            materials[9520] = Material.BrainCoralBlock;
            materials[9521] = Material.BubbleCoralBlock;
            materials[9522] = Material.FireCoralBlock;
            materials[9523] = Material.HornCoralBlock;
            for (var i = 9524; i <= 9525; i++)
                materials[i] = Material.DeadTubeCoral;
            for (var i = 9526; i <= 9527; i++)
                materials[i] = Material.DeadBrainCoral;
            for (var i = 9528; i <= 9529; i++)
                materials[i] = Material.DeadBubbleCoral;
            for (var i = 9530; i <= 9531; i++)
                materials[i] = Material.DeadFireCoral;
            for (var i = 9532; i <= 9533; i++)
                materials[i] = Material.DeadHornCoral;
            for (var i = 9534; i <= 9535; i++)
                materials[i] = Material.TubeCoral;
            for (var i = 9536; i <= 9537; i++)
                materials[i] = Material.BrainCoral;
            for (var i = 9538; i <= 9539; i++)
                materials[i] = Material.BubbleCoral;
            for (var i = 9540; i <= 9541; i++)
                materials[i] = Material.FireCoral;
            for (var i = 9542; i <= 9543; i++)
                materials[i] = Material.HornCoral;
            for (var i = 9544; i <= 9545; i++)
                materials[i] = Material.DeadTubeCoralFan;
            for (var i = 9546; i <= 9547; i++)
                materials[i] = Material.DeadBrainCoralFan;
            for (var i = 9548; i <= 9549; i++)
                materials[i] = Material.DeadBubbleCoralFan;
            for (var i = 9550; i <= 9551; i++)
                materials[i] = Material.DeadFireCoralFan;
            for (var i = 9552; i <= 9553; i++)
                materials[i] = Material.DeadHornCoralFan;
            for (var i = 9554; i <= 9555; i++)
                materials[i] = Material.TubeCoralFan;
            for (var i = 9556; i <= 9557; i++)
                materials[i] = Material.BrainCoralFan;
            for (var i = 9558; i <= 9559; i++)
                materials[i] = Material.BubbleCoralFan;
            for (var i = 9560; i <= 9561; i++)
                materials[i] = Material.FireCoralFan;
            for (var i = 9562; i <= 9563; i++)
                materials[i] = Material.HornCoralFan;
            for (var i = 9564; i <= 9571; i++)
                materials[i] = Material.DeadTubeCoralWallFan;
            for (var i = 9572; i <= 9579; i++)
                materials[i] = Material.DeadBrainCoralWallFan;
            for (var i = 9580; i <= 9587; i++)
                materials[i] = Material.DeadBubbleCoralWallFan;
            for (var i = 9588; i <= 9595; i++)
                materials[i] = Material.DeadFireCoralWallFan;
            for (var i = 9596; i <= 9603; i++)
                materials[i] = Material.DeadHornCoralWallFan;
            for (var i = 9604; i <= 9611; i++)
                materials[i] = Material.TubeCoralWallFan;
            for (var i = 9612; i <= 9619; i++)
                materials[i] = Material.BrainCoralWallFan;
            for (var i = 9620; i <= 9627; i++)
                materials[i] = Material.BubbleCoralWallFan;
            for (var i = 9628; i <= 9635; i++)
                materials[i] = Material.FireCoralWallFan;
            for (var i = 9636; i <= 9643; i++)
                materials[i] = Material.HornCoralWallFan;
            for (var i = 9644; i <= 9651; i++)
                materials[i] = Material.SeaPickle;
            materials[9652] = Material.BlueIce;
            for (var i = 9653; i <= 9654; i++)
                materials[i] = Material.Conduit;
            materials[9655] = Material.BambooSapling;
            for (var i = 9656; i <= 9667; i++)
                materials[i] = Material.Bamboo;
            materials[9668] = Material.PottedBamboo;
            materials[9669] = Material.VoidAir;
            materials[9670] = Material.CaveAir;
            for (var i = 9671; i <= 9672; i++)
                materials[i] = Material.BubbleColumn;
            for (var i = 9673; i <= 9752; i++)
                materials[i] = Material.PolishedGraniteStairs;
            for (var i = 9753; i <= 9832; i++)
                materials[i] = Material.SmoothRedSandstoneStairs;
            for (var i = 9833; i <= 9912; i++)
                materials[i] = Material.MossyStoneBrickStairs;
            for (var i = 9913; i <= 9992; i++)
                materials[i] = Material.PolishedDioriteStairs;
            for (var i = 9993; i <= 10072; i++)
                materials[i] = Material.MossyCobblestoneStairs;
            for (var i = 10073; i <= 10152; i++)
                materials[i] = Material.EndStoneBrickStairs;
            for (var i = 10153; i <= 10232; i++)
                materials[i] = Material.StoneStairs;
            for (var i = 10233; i <= 10312; i++)
                materials[i] = Material.SmoothSandstoneStairs;
            for (var i = 10313; i <= 10392; i++)
                materials[i] = Material.SmoothQuartzStairs;
            for (var i = 10393; i <= 10472; i++)
                materials[i] = Material.GraniteStairs;
            for (var i = 10473; i <= 10552; i++)
                materials[i] = Material.AndesiteStairs;
            for (var i = 10553; i <= 10632; i++)
                materials[i] = Material.RedNetherBrickStairs;
            for (var i = 10633; i <= 10712; i++)
                materials[i] = Material.PolishedAndesiteStairs;
            for (var i = 10713; i <= 10792; i++)
                materials[i] = Material.DioriteStairs;
            for (var i = 10793; i <= 10798; i++)
                materials[i] = Material.PolishedGraniteSlab;
            for (var i = 10799; i <= 10804; i++)
                materials[i] = Material.SmoothRedSandstoneSlab;
            for (var i = 10805; i <= 10810; i++)
                materials[i] = Material.MossyStoneBrickSlab;
            for (var i = 10811; i <= 10816; i++)
                materials[i] = Material.PolishedDioriteSlab;
            for (var i = 10817; i <= 10822; i++)
                materials[i] = Material.MossyCobblestoneSlab;
            for (var i = 10823; i <= 10828; i++)
                materials[i] = Material.EndStoneBrickSlab;
            for (var i = 10829; i <= 10834; i++)
                materials[i] = Material.SmoothSandstoneSlab;
            for (var i = 10835; i <= 10840; i++)
                materials[i] = Material.SmoothQuartzSlab;
            for (var i = 10841; i <= 10846; i++)
                materials[i] = Material.GraniteSlab;
            for (var i = 10847; i <= 10852; i++)
                materials[i] = Material.AndesiteSlab;
            for (var i = 10853; i <= 10858; i++)
                materials[i] = Material.RedNetherBrickSlab;
            for (var i = 10859; i <= 10864; i++)
                materials[i] = Material.PolishedAndesiteSlab;
            for (var i = 10865; i <= 10870; i++)
                materials[i] = Material.DioriteSlab;
            for (var i = 10871; i <= 11194; i++)
                materials[i] = Material.BrickWall;
            for (var i = 11195; i <= 11518; i++)
                materials[i] = Material.PrismarineWall;
            for (var i = 11519; i <= 11842; i++)
                materials[i] = Material.RedSandstoneWall;
            for (var i = 11843; i <= 12166; i++)
                materials[i] = Material.MossyStoneBrickWall;
            for (var i = 12167; i <= 12490; i++)
                materials[i] = Material.GraniteWall;
            for (var i = 12491; i <= 12814; i++)
                materials[i] = Material.StoneBrickWall;
            for (var i = 12815; i <= 13138; i++)
                materials[i] = Material.NetherBrickWall;
            for (var i = 13139; i <= 13462; i++)
                materials[i] = Material.AndesiteWall;
            for (var i = 13463; i <= 13786; i++)
                materials[i] = Material.RedNetherBrickWall;
            for (var i = 13787; i <= 14110; i++)
                materials[i] = Material.SandstoneWall;
            for (var i = 14111; i <= 14434; i++)
                materials[i] = Material.EndStoneBrickWall;
            for (var i = 14435; i <= 14758; i++)
                materials[i] = Material.DioriteWall;
            for (var i = 14759; i <= 14790; i++)
                materials[i] = Material.Scaffolding;
            for (var i = 14791; i <= 14794; i++)
                materials[i] = Material.Loom;
            for (var i = 14795; i <= 14806; i++)
                materials[i] = Material.Barrel;
            for (var i = 14807; i <= 14814; i++)
                materials[i] = Material.Smoker;
            for (var i = 14815; i <= 14822; i++)
                materials[i] = Material.BlastFurnace;
            materials[14823] = Material.CartographyTable;
            materials[14824] = Material.FletchingTable;
            for (var i = 14825; i <= 14836; i++)
                materials[i] = Material.Grindstone;
            for (var i = 14837; i <= 14852; i++)
                materials[i] = Material.Lectern;
            materials[14853] = Material.SmithingTable;
            for (var i = 14854; i <= 14857; i++)
                materials[i] = Material.Stonecutter;
            for (var i = 14858; i <= 14889; i++)
                materials[i] = Material.Bell;
            for (var i = 14890; i <= 14893; i++)
                materials[i] = Material.Lantern;
            for (var i = 14894; i <= 14897; i++)
                materials[i] = Material.SoulLantern;
            for (var i = 14898; i <= 14929; i++)
                materials[i] = Material.Campfire;
            for (var i = 14930; i <= 14961; i++)
                materials[i] = Material.SoulCampfire;
            for (var i = 14962; i <= 14965; i++)
                materials[i] = Material.SweetBerryBush;
            for (var i = 14966; i <= 14968; i++)
                materials[i] = Material.WarpedStem;
            for (var i = 14969; i <= 14971; i++)
                materials[i] = Material.StrippedWarpedStem;
            for (var i = 14972; i <= 14974; i++)
                materials[i] = Material.WarpedHyphae;
            for (var i = 14975; i <= 14977; i++)
                materials[i] = Material.StrippedWarpedHyphae;
            materials[14978] = Material.WarpedNylium;
            materials[14979] = Material.WarpedFungus;
            materials[14980] = Material.WarpedWartBlock;
            materials[14981] = Material.WarpedRoots;
            materials[14982] = Material.NetherSprouts;
            for (var i = 14983; i <= 14985; i++)
                materials[i] = Material.CrimsonStem;
            for (var i = 14986; i <= 14988; i++)
                materials[i] = Material.StrippedCrimsonStem;
            for (var i = 14989; i <= 14991; i++)
                materials[i] = Material.CrimsonHyphae;
            for (var i = 14992; i <= 14994; i++)
                materials[i] = Material.StrippedCrimsonHyphae;
            materials[14995] = Material.CrimsonNylium;
            materials[14996] = Material.CrimsonFungus;
            materials[14997] = Material.Shroomlight;
            for (var i = 14998; i <= 15023; i++)
                materials[i] = Material.WeepingVines;
            materials[15024] = Material.WeepingVinesPlant;
            for (var i = 15025; i <= 15050; i++)
                materials[i] = Material.TwistingVines;
            materials[15051] = Material.TwistingVinesPlant;
            materials[15052] = Material.CrimsonRoots;
            materials[15053] = Material.CrimsonPlanks;
            materials[15054] = Material.WarpedPlanks;
            for (var i = 15055; i <= 15060; i++)
                materials[i] = Material.CrimsonSlab;
            for (var i = 15061; i <= 15066; i++)
                materials[i] = Material.WarpedSlab;
            for (var i = 15067; i <= 15068; i++)
                materials[i] = Material.CrimsonPressurePlate;
            for (var i = 15069; i <= 15070; i++)
                materials[i] = Material.WarpedPressurePlate;
            for (var i = 15071; i <= 15102; i++)
                materials[i] = Material.CrimsonFence;
            for (var i = 15103; i <= 15134; i++)
                materials[i] = Material.WarpedFence;
            for (var i = 15135; i <= 15198; i++)
                materials[i] = Material.CrimsonTrapdoor;
            for (var i = 15199; i <= 15262; i++)
                materials[i] = Material.WarpedTrapdoor;
            for (var i = 15263; i <= 15294; i++)
                materials[i] = Material.CrimsonFenceGate;
            for (var i = 15295; i <= 15326; i++)
                materials[i] = Material.WarpedFenceGate;
            for (var i = 15327; i <= 15406; i++)
                materials[i] = Material.CrimsonStairs;
            for (var i = 15407; i <= 15486; i++)
                materials[i] = Material.WarpedStairs;
            for (var i = 15487; i <= 15510; i++)
                materials[i] = Material.CrimsonButton;
            for (var i = 15511; i <= 15534; i++)
                materials[i] = Material.WarpedButton;
            for (var i = 15535; i <= 15598; i++)
                materials[i] = Material.CrimsonDoor;
            for (var i = 15599; i <= 15662; i++)
                materials[i] = Material.WarpedDoor;
            for (var i = 15663; i <= 15694; i++)
                materials[i] = Material.CrimsonSign;
            for (var i = 15695; i <= 15726; i++)
                materials[i] = Material.WarpedSign;
            for (var i = 15727; i <= 15734; i++)
                materials[i] = Material.CrimsonWallSign;
            for (var i = 15735; i <= 15742; i++)
                materials[i] = Material.WarpedWallSign;
            for (var i = 15743; i <= 15746; i++)
                materials[i] = Material.StructureBlock;
            for (var i = 15747; i <= 15758; i++)
                materials[i] = Material.Jigsaw;
            for (var i = 15759; i <= 15767; i++)
                materials[i] = Material.Composter;
            for (var i = 15768; i <= 15783; i++)
                materials[i] = Material.Target;
            for (var i = 15784; i <= 15807; i++)
                materials[i] = Material.BeeNest;
            for (var i = 15808; i <= 15831; i++)
                materials[i] = Material.Beehive;
            materials[15832] = Material.HoneyBlock;
            materials[15833] = Material.HoneycombBlock;
            materials[15834] = Material.NetheriteBlock;
            materials[15835] = Material.AncientDebris;
            materials[15836] = Material.CryingObsidian;
            for (var i = 15837; i <= 15841; i++)
                materials[i] = Material.RespawnAnchor;
            materials[15842] = Material.PottedCrimsonFungus;
            materials[15843] = Material.PottedWarpedFungus;
            materials[15844] = Material.PottedCrimsonRoots;
            materials[15845] = Material.PottedWarpedRoots;
            materials[15846] = Material.Lodestone;
            materials[15847] = Material.Blackstone;
            for (var i = 15848; i <= 15927; i++)
                materials[i] = Material.BlackstoneStairs;
            for (var i = 15928; i <= 16251; i++)
                materials[i] = Material.BlackstoneWall;
            for (var i = 16252; i <= 16257; i++)
                materials[i] = Material.BlackstoneSlab;
            materials[16258] = Material.PolishedBlackstone;
            materials[16259] = Material.PolishedBlackstoneBricks;
            materials[16260] = Material.CrackedPolishedBlackstoneBricks;
            materials[16261] = Material.ChiseledPolishedBlackstone;
            for (var i = 16262; i <= 16267; i++)
                materials[i] = Material.PolishedBlackstoneBrickSlab;
            for (var i = 16268; i <= 16347; i++)
                materials[i] = Material.PolishedBlackstoneBrickStairs;
            for (var i = 16348; i <= 16671; i++)
                materials[i] = Material.PolishedBlackstoneBrickWall;
            materials[16672] = Material.GildedBlackstone;
            for (var i = 16673; i <= 16752; i++)
                materials[i] = Material.PolishedBlackstoneStairs;
            for (var i = 16753; i <= 16758; i++)
                materials[i] = Material.PolishedBlackstoneSlab;
            for (var i = 16759; i <= 16760; i++)
                materials[i] = Material.PolishedBlackstonePressurePlate;
            for (var i = 16761; i <= 16784; i++)
                materials[i] = Material.PolishedBlackstoneButton;
            for (var i = 16785; i <= 17108; i++)
                materials[i] = Material.PolishedBlackstoneWall;
            materials[17109] = Material.ChiseledNetherBricks;
            materials[17110] = Material.CrackedNetherBricks;
            materials[17111] = Material.QuartzBricks;
        }

        protected override Dictionary<int, Material> GetDict()
        {
            return materials;
        }
    }
}
