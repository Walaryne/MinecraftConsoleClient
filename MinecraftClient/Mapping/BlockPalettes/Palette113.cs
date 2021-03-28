using System.Collections.Generic;
namespace MinecraftClient.Mapping.BlockPalettes
{
    /// <summary>
    /// Defines mappings for Minecraft 1.13.
    /// Automatically generated using BlockPaletteGenerator.cs
    /// </summary>
    public class Palette113 : BlockPalette
    {
        private static Dictionary<int, Material> materials = new Dictionary<int, Material>();

        static Palette113()
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
            for (var i = 72; i <= 74; i++)
                materials[i] = Material.OakLog;
            for (var i = 75; i <= 77; i++)
                materials[i] = Material.SpruceLog;
            for (var i = 78; i <= 80; i++)
                materials[i] = Material.BirchLog;
            for (var i = 81; i <= 83; i++)
                materials[i] = Material.JungleLog;
            for (var i = 84; i <= 86; i++)
                materials[i] = Material.AcaciaLog;
            for (var i = 87; i <= 89; i++)
                materials[i] = Material.DarkOakLog;
            for (var i = 90; i <= 92; i++)
                materials[i] = Material.StrippedSpruceLog;
            for (var i = 93; i <= 95; i++)
                materials[i] = Material.StrippedBirchLog;
            for (var i = 96; i <= 98; i++)
                materials[i] = Material.StrippedJungleLog;
            for (var i = 99; i <= 101; i++)
                materials[i] = Material.StrippedAcaciaLog;
            for (var i = 102; i <= 104; i++)
                materials[i] = Material.StrippedDarkOakLog;
            for (var i = 105; i <= 107; i++)
                materials[i] = Material.StrippedOakLog;
            for (var i = 108; i <= 110; i++)
                materials[i] = Material.OakWood;
            for (var i = 111; i <= 113; i++)
                materials[i] = Material.SpruceWood;
            for (var i = 114; i <= 116; i++)
                materials[i] = Material.BirchWood;
            for (var i = 117; i <= 119; i++)
                materials[i] = Material.JungleWood;
            for (var i = 120; i <= 122; i++)
                materials[i] = Material.AcaciaWood;
            for (var i = 123; i <= 125; i++)
                materials[i] = Material.DarkOakWood;
            for (var i = 126; i <= 128; i++)
                materials[i] = Material.StrippedOakWood;
            for (var i = 129; i <= 131; i++)
                materials[i] = Material.StrippedSpruceWood;
            for (var i = 132; i <= 134; i++)
                materials[i] = Material.StrippedBirchWood;
            for (var i = 135; i <= 137; i++)
                materials[i] = Material.StrippedJungleWood;
            for (var i = 138; i <= 140; i++)
                materials[i] = Material.StrippedAcaciaWood;
            for (var i = 141; i <= 143; i++)
                materials[i] = Material.StrippedDarkOakWood;
            for (var i = 144; i <= 157; i++)
                materials[i] = Material.OakLeaves;
            for (var i = 158; i <= 171; i++)
                materials[i] = Material.SpruceLeaves;
            for (var i = 172; i <= 185; i++)
                materials[i] = Material.BirchLeaves;
            for (var i = 186; i <= 199; i++)
                materials[i] = Material.JungleLeaves;
            for (var i = 200; i <= 213; i++)
                materials[i] = Material.AcaciaLeaves;
            for (var i = 214; i <= 227; i++)
                materials[i] = Material.DarkOakLeaves;
            materials[228] = Material.Sponge;
            materials[229] = Material.WetSponge;
            materials[230] = Material.Glass;
            materials[231] = Material.LapisOre;
            materials[232] = Material.LapisBlock;
            for (var i = 233; i <= 244; i++)
                materials[i] = Material.Dispenser;
            materials[245] = Material.Sandstone;
            materials[246] = Material.ChiseledSandstone;
            materials[247] = Material.CutSandstone;
            for (var i = 248; i <= 747; i++)
                materials[i] = Material.NoteBlock;
            for (var i = 748; i <= 763; i++)
                materials[i] = Material.WhiteBed;
            for (var i = 764; i <= 779; i++)
                materials[i] = Material.OrangeBed;
            for (var i = 780; i <= 795; i++)
                materials[i] = Material.MagentaBed;
            for (var i = 796; i <= 811; i++)
                materials[i] = Material.LightBlueBed;
            for (var i = 812; i <= 827; i++)
                materials[i] = Material.YellowBed;
            for (var i = 828; i <= 843; i++)
                materials[i] = Material.LimeBed;
            for (var i = 844; i <= 859; i++)
                materials[i] = Material.PinkBed;
            for (var i = 860; i <= 875; i++)
                materials[i] = Material.GrayBed;
            for (var i = 876; i <= 891; i++)
                materials[i] = Material.LightGrayBed;
            for (var i = 892; i <= 907; i++)
                materials[i] = Material.CyanBed;
            for (var i = 908; i <= 923; i++)
                materials[i] = Material.PurpleBed;
            for (var i = 924; i <= 939; i++)
                materials[i] = Material.BlueBed;
            for (var i = 940; i <= 955; i++)
                materials[i] = Material.BrownBed;
            for (var i = 956; i <= 971; i++)
                materials[i] = Material.GreenBed;
            for (var i = 972; i <= 987; i++)
                materials[i] = Material.RedBed;
            for (var i = 988; i <= 1003; i++)
                materials[i] = Material.BlackBed;
            for (var i = 1004; i <= 1015; i++)
                materials[i] = Material.PoweredRail;
            for (var i = 1016; i <= 1027; i++)
                materials[i] = Material.DetectorRail;
            for (var i = 1028; i <= 1039; i++)
                materials[i] = Material.StickyPiston;
            materials[1040] = Material.Cobweb;
            materials[1041] = Material.Grass;
            materials[1042] = Material.Fern;
            materials[1043] = Material.DeadBush;
            materials[1044] = Material.Seagrass;
            for (var i = 1045; i <= 1046; i++)
                materials[i] = Material.TallSeagrass;
            for (var i = 1047; i <= 1058; i++)
                materials[i] = Material.Piston;
            for (var i = 1059; i <= 1082; i++)
                materials[i] = Material.PistonHead;
            materials[1083] = Material.WhiteWool;
            materials[1084] = Material.OrangeWool;
            materials[1085] = Material.MagentaWool;
            materials[1086] = Material.LightBlueWool;
            materials[1087] = Material.YellowWool;
            materials[1088] = Material.LimeWool;
            materials[1089] = Material.PinkWool;
            materials[1090] = Material.GrayWool;
            materials[1091] = Material.LightGrayWool;
            materials[1092] = Material.CyanWool;
            materials[1093] = Material.PurpleWool;
            materials[1094] = Material.BlueWool;
            materials[1095] = Material.BrownWool;
            materials[1096] = Material.GreenWool;
            materials[1097] = Material.RedWool;
            materials[1098] = Material.BlackWool;
            for (var i = 1099; i <= 1110; i++)
                materials[i] = Material.MovingPiston;
            materials[1111] = Material.Dandelion;
            materials[1112] = Material.Poppy;
            materials[1113] = Material.BlueOrchid;
            materials[1114] = Material.Allium;
            materials[1115] = Material.AzureBluet;
            materials[1116] = Material.RedTulip;
            materials[1117] = Material.OrangeTulip;
            materials[1118] = Material.WhiteTulip;
            materials[1119] = Material.PinkTulip;
            materials[1120] = Material.OxeyeDaisy;
            materials[1121] = Material.BrownMushroom;
            materials[1122] = Material.RedMushroom;
            materials[1123] = Material.GoldBlock;
            materials[1124] = Material.IronBlock;
            materials[1125] = Material.Bricks;
            for (var i = 1126; i <= 1127; i++)
                materials[i] = Material.Tnt;
            materials[1128] = Material.Bookshelf;
            materials[1129] = Material.MossyCobblestone;
            materials[1130] = Material.Obsidian;
            materials[1131] = Material.Torch;
            for (var i = 1132; i <= 1135; i++)
                materials[i] = Material.WallTorch;
            for (var i = 1136; i <= 1647; i++)
                materials[i] = Material.Fire;
            materials[1648] = Material.Spawner;
            for (var i = 1649; i <= 1728; i++)
                materials[i] = Material.OakStairs;
            for (var i = 1729; i <= 1752; i++)
                materials[i] = Material.Chest;
            for (var i = 1753; i <= 3048; i++)
                materials[i] = Material.RedstoneWire;
            materials[3049] = Material.DiamondOre;
            materials[3050] = Material.DiamondBlock;
            materials[3051] = Material.CraftingTable;
            for (var i = 3052; i <= 3059; i++)
                materials[i] = Material.Wheat;
            for (var i = 3060; i <= 3067; i++)
                materials[i] = Material.Farmland;
            for (var i = 3068; i <= 3075; i++)
                materials[i] = Material.Furnace;
            for (var i = 3076; i <= 3107; i++)
                materials[i] = Material.OakSign;
            for (var i = 3108; i <= 3171; i++)
                materials[i] = Material.OakDoor;
            for (var i = 3172; i <= 3179; i++)
                materials[i] = Material.Ladder;
            for (var i = 3180; i <= 3189; i++)
                materials[i] = Material.Rail;
            for (var i = 3190; i <= 3269; i++)
                materials[i] = Material.CobblestoneStairs;
            for (var i = 3270; i <= 3277; i++)
                materials[i] = Material.OakWallSign;
            for (var i = 3278; i <= 3301; i++)
                materials[i] = Material.Lever;
            for (var i = 3302; i <= 3303; i++)
                materials[i] = Material.StonePressurePlate;
            for (var i = 3304; i <= 3367; i++)
                materials[i] = Material.IronDoor;
            for (var i = 3368; i <= 3369; i++)
                materials[i] = Material.OakPressurePlate;
            for (var i = 3370; i <= 3371; i++)
                materials[i] = Material.SprucePressurePlate;
            for (var i = 3372; i <= 3373; i++)
                materials[i] = Material.BirchPressurePlate;
            for (var i = 3374; i <= 3375; i++)
                materials[i] = Material.JunglePressurePlate;
            for (var i = 3376; i <= 3377; i++)
                materials[i] = Material.AcaciaPressurePlate;
            for (var i = 3378; i <= 3379; i++)
                materials[i] = Material.DarkOakPressurePlate;
            for (var i = 3380; i <= 3381; i++)
                materials[i] = Material.RedstoneOre;
            for (var i = 3382; i <= 3383; i++)
                materials[i] = Material.RedstoneTorch;
            for (var i = 3384; i <= 3391; i++)
                materials[i] = Material.RedstoneWallTorch;
            for (var i = 3392; i <= 3415; i++)
                materials[i] = Material.StoneButton;
            for (var i = 3416; i <= 3423; i++)
                materials[i] = Material.Snow;
            materials[3424] = Material.Ice;
            materials[3425] = Material.SnowBlock;
            for (var i = 3426; i <= 3441; i++)
                materials[i] = Material.Cactus;
            materials[3442] = Material.Clay;
            for (var i = 3443; i <= 3458; i++)
                materials[i] = Material.SugarCane;
            for (var i = 3459; i <= 3460; i++)
                materials[i] = Material.Jukebox;
            for (var i = 3461; i <= 3492; i++)
                materials[i] = Material.OakFence;
            materials[3493] = Material.Pumpkin;
            materials[3494] = Material.Netherrack;
            materials[3495] = Material.SoulSand;
            materials[3496] = Material.Glowstone;
            for (var i = 3497; i <= 3498; i++)
                materials[i] = Material.NetherPortal;
            for (var i = 3499; i <= 3502; i++)
                materials[i] = Material.CarvedPumpkin;
            for (var i = 3503; i <= 3506; i++)
                materials[i] = Material.JackOLantern;
            for (var i = 3507; i <= 3513; i++)
                materials[i] = Material.Cake;
            for (var i = 3514; i <= 3577; i++)
                materials[i] = Material.Repeater;
            materials[3578] = Material.WhiteStainedGlass;
            materials[3579] = Material.OrangeStainedGlass;
            materials[3580] = Material.MagentaStainedGlass;
            materials[3581] = Material.LightBlueStainedGlass;
            materials[3582] = Material.YellowStainedGlass;
            materials[3583] = Material.LimeStainedGlass;
            materials[3584] = Material.PinkStainedGlass;
            materials[3585] = Material.GrayStainedGlass;
            materials[3586] = Material.LightGrayStainedGlass;
            materials[3587] = Material.CyanStainedGlass;
            materials[3588] = Material.PurpleStainedGlass;
            materials[3589] = Material.BlueStainedGlass;
            materials[3590] = Material.BrownStainedGlass;
            materials[3591] = Material.GreenStainedGlass;
            materials[3592] = Material.RedStainedGlass;
            materials[3593] = Material.BlackStainedGlass;
            for (var i = 3594; i <= 3657; i++)
                materials[i] = Material.OakTrapdoor;
            for (var i = 3658; i <= 3721; i++)
                materials[i] = Material.SpruceTrapdoor;
            for (var i = 3722; i <= 3785; i++)
                materials[i] = Material.BirchTrapdoor;
            for (var i = 3786; i <= 3849; i++)
                materials[i] = Material.JungleTrapdoor;
            for (var i = 3850; i <= 3913; i++)
                materials[i] = Material.AcaciaTrapdoor;
            for (var i = 3914; i <= 3977; i++)
                materials[i] = Material.DarkOakTrapdoor;
            materials[3978] = Material.InfestedStone;
            materials[3979] = Material.InfestedCobblestone;
            materials[3980] = Material.InfestedStoneBricks;
            materials[3981] = Material.InfestedMossyStoneBricks;
            materials[3982] = Material.InfestedCrackedStoneBricks;
            materials[3983] = Material.InfestedChiseledStoneBricks;
            materials[3984] = Material.StoneBricks;
            materials[3985] = Material.MossyStoneBricks;
            materials[3986] = Material.CrackedStoneBricks;
            materials[3987] = Material.ChiseledStoneBricks;
            for (var i = 3988; i <= 4051; i++)
                materials[i] = Material.BrownMushroomBlock;
            for (var i = 4052; i <= 4115; i++)
                materials[i] = Material.RedMushroomBlock;
            for (var i = 4116; i <= 4179; i++)
                materials[i] = Material.MushroomStem;
            for (var i = 4180; i <= 4211; i++)
                materials[i] = Material.IronBars;
            for (var i = 4212; i <= 4243; i++)
                materials[i] = Material.GlassPane;
            materials[4244] = Material.Melon;
            for (var i = 4245; i <= 4248; i++)
                materials[i] = Material.AttachedPumpkinStem;
            for (var i = 4249; i <= 4252; i++)
                materials[i] = Material.AttachedMelonStem;
            for (var i = 4253; i <= 4260; i++)
                materials[i] = Material.PumpkinStem;
            for (var i = 4261; i <= 4268; i++)
                materials[i] = Material.MelonStem;
            for (var i = 4269; i <= 4300; i++)
                materials[i] = Material.Vine;
            for (var i = 4301; i <= 4332; i++)
                materials[i] = Material.OakFenceGate;
            for (var i = 4333; i <= 4412; i++)
                materials[i] = Material.BrickStairs;
            for (var i = 4413; i <= 4492; i++)
                materials[i] = Material.StoneBrickStairs;
            for (var i = 4493; i <= 4494; i++)
                materials[i] = Material.Mycelium;
            materials[4495] = Material.LilyPad;
            materials[4496] = Material.NetherBricks;
            for (var i = 4497; i <= 4528; i++)
                materials[i] = Material.NetherBrickFence;
            for (var i = 4529; i <= 4608; i++)
                materials[i] = Material.NetherBrickStairs;
            for (var i = 4609; i <= 4612; i++)
                materials[i] = Material.NetherWart;
            materials[4613] = Material.EnchantingTable;
            for (var i = 4614; i <= 4621; i++)
                materials[i] = Material.BrewingStand;
            for (var i = 4622; i <= 4625; i++)
                materials[i] = Material.Cauldron;
            materials[4626] = Material.EndPortal;
            for (var i = 4627; i <= 4634; i++)
                materials[i] = Material.EndPortalFrame;
            materials[4635] = Material.EndStone;
            materials[4636] = Material.DragonEgg;
            for (var i = 4637; i <= 4638; i++)
                materials[i] = Material.RedstoneLamp;
            for (var i = 4639; i <= 4650; i++)
                materials[i] = Material.Cocoa;
            for (var i = 4651; i <= 4730; i++)
                materials[i] = Material.SandstoneStairs;
            materials[4731] = Material.EmeraldOre;
            for (var i = 4732; i <= 4739; i++)
                materials[i] = Material.EnderChest;
            for (var i = 4740; i <= 4755; i++)
                materials[i] = Material.TripwireHook;
            for (var i = 4756; i <= 4883; i++)
                materials[i] = Material.Tripwire;
            materials[4884] = Material.EmeraldBlock;
            for (var i = 4885; i <= 4964; i++)
                materials[i] = Material.SpruceStairs;
            for (var i = 4965; i <= 5044; i++)
                materials[i] = Material.BirchStairs;
            for (var i = 5045; i <= 5124; i++)
                materials[i] = Material.JungleStairs;
            for (var i = 5125; i <= 5136; i++)
                materials[i] = Material.CommandBlock;
            materials[5137] = Material.Beacon;
            for (var i = 5138; i <= 5201; i++)
                materials[i] = Material.CobblestoneWall;
            for (var i = 5202; i <= 5265; i++)
                materials[i] = Material.MossyCobblestoneWall;
            materials[5266] = Material.FlowerPot;
            materials[5267] = Material.PottedOakSapling;
            materials[5268] = Material.PottedSpruceSapling;
            materials[5269] = Material.PottedBirchSapling;
            materials[5270] = Material.PottedJungleSapling;
            materials[5271] = Material.PottedAcaciaSapling;
            materials[5272] = Material.PottedDarkOakSapling;
            materials[5273] = Material.PottedFern;
            materials[5274] = Material.PottedDandelion;
            materials[5275] = Material.PottedPoppy;
            materials[5276] = Material.PottedBlueOrchid;
            materials[5277] = Material.PottedAllium;
            materials[5278] = Material.PottedAzureBluet;
            materials[5279] = Material.PottedRedTulip;
            materials[5280] = Material.PottedOrangeTulip;
            materials[5281] = Material.PottedWhiteTulip;
            materials[5282] = Material.PottedPinkTulip;
            materials[5283] = Material.PottedOxeyeDaisy;
            materials[5284] = Material.PottedRedMushroom;
            materials[5285] = Material.PottedBrownMushroom;
            materials[5286] = Material.PottedDeadBush;
            materials[5287] = Material.PottedCactus;
            for (var i = 5288; i <= 5295; i++)
                materials[i] = Material.Carrots;
            for (var i = 5296; i <= 5303; i++)
                materials[i] = Material.Potatoes;
            for (var i = 5304; i <= 5327; i++)
                materials[i] = Material.OakButton;
            for (var i = 5328; i <= 5351; i++)
                materials[i] = Material.SpruceButton;
            for (var i = 5352; i <= 5375; i++)
                materials[i] = Material.BirchButton;
            for (var i = 5376; i <= 5399; i++)
                materials[i] = Material.JungleButton;
            for (var i = 5400; i <= 5423; i++)
                materials[i] = Material.AcaciaButton;
            for (var i = 5424; i <= 5447; i++)
                materials[i] = Material.DarkOakButton;
            for (var i = 5448; i <= 5451; i++)
                materials[i] = Material.SkeletonWallSkull;
            for (var i = 5452; i <= 5467; i++)
                materials[i] = Material.SkeletonSkull;
            for (var i = 5468; i <= 5471; i++)
                materials[i] = Material.WitherSkeletonWallSkull;
            for (var i = 5472; i <= 5487; i++)
                materials[i] = Material.WitherSkeletonSkull;
            for (var i = 5488; i <= 5491; i++)
                materials[i] = Material.ZombieWallHead;
            for (var i = 5492; i <= 5507; i++)
                materials[i] = Material.ZombieHead;
            for (var i = 5508; i <= 5511; i++)
                materials[i] = Material.PlayerWallHead;
            for (var i = 5512; i <= 5527; i++)
                materials[i] = Material.PlayerHead;
            for (var i = 5528; i <= 5531; i++)
                materials[i] = Material.CreeperWallHead;
            for (var i = 5532; i <= 5547; i++)
                materials[i] = Material.CreeperHead;
            for (var i = 5548; i <= 5551; i++)
                materials[i] = Material.DragonWallHead;
            for (var i = 5552; i <= 5567; i++)
                materials[i] = Material.DragonHead;
            for (var i = 5568; i <= 5571; i++)
                materials[i] = Material.Anvil;
            for (var i = 5572; i <= 5575; i++)
                materials[i] = Material.ChippedAnvil;
            for (var i = 5576; i <= 5579; i++)
                materials[i] = Material.DamagedAnvil;
            for (var i = 5580; i <= 5603; i++)
                materials[i] = Material.TrappedChest;
            for (var i = 5604; i <= 5619; i++)
                materials[i] = Material.LightWeightedPressurePlate;
            for (var i = 5620; i <= 5635; i++)
                materials[i] = Material.HeavyWeightedPressurePlate;
            for (var i = 5636; i <= 5651; i++)
                materials[i] = Material.Comparator;
            for (var i = 5652; i <= 5683; i++)
                materials[i] = Material.DaylightDetector;
            materials[5684] = Material.RedstoneBlock;
            materials[5685] = Material.NetherQuartzOre;
            for (var i = 5686; i <= 5695; i++)
                materials[i] = Material.Hopper;
            materials[5696] = Material.QuartzBlock;
            materials[5697] = Material.ChiseledQuartzBlock;
            for (var i = 5698; i <= 5700; i++)
                materials[i] = Material.QuartzPillar;
            for (var i = 5701; i <= 5780; i++)
                materials[i] = Material.QuartzStairs;
            for (var i = 5781; i <= 5792; i++)
                materials[i] = Material.ActivatorRail;
            for (var i = 5793; i <= 5804; i++)
                materials[i] = Material.Dropper;
            materials[5805] = Material.WhiteTerracotta;
            materials[5806] = Material.OrangeTerracotta;
            materials[5807] = Material.MagentaTerracotta;
            materials[5808] = Material.LightBlueTerracotta;
            materials[5809] = Material.YellowTerracotta;
            materials[5810] = Material.LimeTerracotta;
            materials[5811] = Material.PinkTerracotta;
            materials[5812] = Material.GrayTerracotta;
            materials[5813] = Material.LightGrayTerracotta;
            materials[5814] = Material.CyanTerracotta;
            materials[5815] = Material.PurpleTerracotta;
            materials[5816] = Material.BlueTerracotta;
            materials[5817] = Material.BrownTerracotta;
            materials[5818] = Material.GreenTerracotta;
            materials[5819] = Material.RedTerracotta;
            materials[5820] = Material.BlackTerracotta;
            for (var i = 5821; i <= 5852; i++)
                materials[i] = Material.WhiteStainedGlassPane;
            for (var i = 5853; i <= 5884; i++)
                materials[i] = Material.OrangeStainedGlassPane;
            for (var i = 5885; i <= 5916; i++)
                materials[i] = Material.MagentaStainedGlassPane;
            for (var i = 5917; i <= 5948; i++)
                materials[i] = Material.LightBlueStainedGlassPane;
            for (var i = 5949; i <= 5980; i++)
                materials[i] = Material.YellowStainedGlassPane;
            for (var i = 5981; i <= 6012; i++)
                materials[i] = Material.LimeStainedGlassPane;
            for (var i = 6013; i <= 6044; i++)
                materials[i] = Material.PinkStainedGlassPane;
            for (var i = 6045; i <= 6076; i++)
                materials[i] = Material.GrayStainedGlassPane;
            for (var i = 6077; i <= 6108; i++)
                materials[i] = Material.LightGrayStainedGlassPane;
            for (var i = 6109; i <= 6140; i++)
                materials[i] = Material.CyanStainedGlassPane;
            for (var i = 6141; i <= 6172; i++)
                materials[i] = Material.PurpleStainedGlassPane;
            for (var i = 6173; i <= 6204; i++)
                materials[i] = Material.BlueStainedGlassPane;
            for (var i = 6205; i <= 6236; i++)
                materials[i] = Material.BrownStainedGlassPane;
            for (var i = 6237; i <= 6268; i++)
                materials[i] = Material.GreenStainedGlassPane;
            for (var i = 6269; i <= 6300; i++)
                materials[i] = Material.RedStainedGlassPane;
            for (var i = 6301; i <= 6332; i++)
                materials[i] = Material.BlackStainedGlassPane;
            for (var i = 6333; i <= 6412; i++)
                materials[i] = Material.AcaciaStairs;
            for (var i = 6413; i <= 6492; i++)
                materials[i] = Material.DarkOakStairs;
            materials[6493] = Material.SlimeBlock;
            materials[6494] = Material.Barrier;
            for (var i = 6495; i <= 6558; i++)
                materials[i] = Material.IronTrapdoor;
            materials[6559] = Material.Prismarine;
            materials[6560] = Material.PrismarineBricks;
            materials[6561] = Material.DarkPrismarine;
            for (var i = 6562; i <= 6641; i++)
                materials[i] = Material.PrismarineStairs;
            for (var i = 6642; i <= 6721; i++)
                materials[i] = Material.PrismarineBrickStairs;
            for (var i = 6722; i <= 6801; i++)
                materials[i] = Material.DarkPrismarineStairs;
            for (var i = 6802; i <= 6807; i++)
                materials[i] = Material.PrismarineSlab;
            for (var i = 6808; i <= 6813; i++)
                materials[i] = Material.PrismarineBrickSlab;
            for (var i = 6814; i <= 6819; i++)
                materials[i] = Material.DarkPrismarineSlab;
            materials[6820] = Material.SeaLantern;
            for (var i = 6821; i <= 6823; i++)
                materials[i] = Material.HayBlock;
            materials[6824] = Material.WhiteCarpet;
            materials[6825] = Material.OrangeCarpet;
            materials[6826] = Material.MagentaCarpet;
            materials[6827] = Material.LightBlueCarpet;
            materials[6828] = Material.YellowCarpet;
            materials[6829] = Material.LimeCarpet;
            materials[6830] = Material.PinkCarpet;
            materials[6831] = Material.GrayCarpet;
            materials[6832] = Material.LightGrayCarpet;
            materials[6833] = Material.CyanCarpet;
            materials[6834] = Material.PurpleCarpet;
            materials[6835] = Material.BlueCarpet;
            materials[6836] = Material.BrownCarpet;
            materials[6837] = Material.GreenCarpet;
            materials[6838] = Material.RedCarpet;
            materials[6839] = Material.BlackCarpet;
            materials[6840] = Material.Terracotta;
            materials[6841] = Material.CoalBlock;
            materials[6842] = Material.PackedIce;
            for (var i = 6843; i <= 6844; i++)
                materials[i] = Material.Sunflower;
            for (var i = 6845; i <= 6846; i++)
                materials[i] = Material.Lilac;
            for (var i = 6847; i <= 6848; i++)
                materials[i] = Material.RoseBush;
            for (var i = 6849; i <= 6850; i++)
                materials[i] = Material.Peony;
            for (var i = 6851; i <= 6852; i++)
                materials[i] = Material.TallGrass;
            for (var i = 6853; i <= 6854; i++)
                materials[i] = Material.LargeFern;
            for (var i = 6855; i <= 6870; i++)
                materials[i] = Material.WhiteBanner;
            for (var i = 6871; i <= 6886; i++)
                materials[i] = Material.OrangeBanner;
            for (var i = 6887; i <= 6902; i++)
                materials[i] = Material.MagentaBanner;
            for (var i = 6903; i <= 6918; i++)
                materials[i] = Material.LightBlueBanner;
            for (var i = 6919; i <= 6934; i++)
                materials[i] = Material.YellowBanner;
            for (var i = 6935; i <= 6950; i++)
                materials[i] = Material.LimeBanner;
            for (var i = 6951; i <= 6966; i++)
                materials[i] = Material.PinkBanner;
            for (var i = 6967; i <= 6982; i++)
                materials[i] = Material.GrayBanner;
            for (var i = 6983; i <= 6998; i++)
                materials[i] = Material.LightGrayBanner;
            for (var i = 6999; i <= 7014; i++)
                materials[i] = Material.CyanBanner;
            for (var i = 7015; i <= 7030; i++)
                materials[i] = Material.PurpleBanner;
            for (var i = 7031; i <= 7046; i++)
                materials[i] = Material.BlueBanner;
            for (var i = 7047; i <= 7062; i++)
                materials[i] = Material.BrownBanner;
            for (var i = 7063; i <= 7078; i++)
                materials[i] = Material.GreenBanner;
            for (var i = 7079; i <= 7094; i++)
                materials[i] = Material.RedBanner;
            for (var i = 7095; i <= 7110; i++)
                materials[i] = Material.BlackBanner;
            for (var i = 7111; i <= 7114; i++)
                materials[i] = Material.WhiteWallBanner;
            for (var i = 7115; i <= 7118; i++)
                materials[i] = Material.OrangeWallBanner;
            for (var i = 7119; i <= 7122; i++)
                materials[i] = Material.MagentaWallBanner;
            for (var i = 7123; i <= 7126; i++)
                materials[i] = Material.LightBlueWallBanner;
            for (var i = 7127; i <= 7130; i++)
                materials[i] = Material.YellowWallBanner;
            for (var i = 7131; i <= 7134; i++)
                materials[i] = Material.LimeWallBanner;
            for (var i = 7135; i <= 7138; i++)
                materials[i] = Material.PinkWallBanner;
            for (var i = 7139; i <= 7142; i++)
                materials[i] = Material.GrayWallBanner;
            for (var i = 7143; i <= 7146; i++)
                materials[i] = Material.LightGrayWallBanner;
            for (var i = 7147; i <= 7150; i++)
                materials[i] = Material.CyanWallBanner;
            for (var i = 7151; i <= 7154; i++)
                materials[i] = Material.PurpleWallBanner;
            for (var i = 7155; i <= 7158; i++)
                materials[i] = Material.BlueWallBanner;
            for (var i = 7159; i <= 7162; i++)
                materials[i] = Material.BrownWallBanner;
            for (var i = 7163; i <= 7166; i++)
                materials[i] = Material.GreenWallBanner;
            for (var i = 7167; i <= 7170; i++)
                materials[i] = Material.RedWallBanner;
            for (var i = 7171; i <= 7174; i++)
                materials[i] = Material.BlackWallBanner;
            materials[7175] = Material.RedSandstone;
            materials[7176] = Material.ChiseledRedSandstone;
            materials[7177] = Material.CutRedSandstone;
            for (var i = 7178; i <= 7257; i++)
                materials[i] = Material.RedSandstoneStairs;
            for (var i = 7258; i <= 7263; i++)
                materials[i] = Material.OakSlab;
            for (var i = 7264; i <= 7269; i++)
                materials[i] = Material.SpruceSlab;
            for (var i = 7270; i <= 7275; i++)
                materials[i] = Material.BirchSlab;
            for (var i = 7276; i <= 7281; i++)
                materials[i] = Material.JungleSlab;
            for (var i = 7282; i <= 7287; i++)
                materials[i] = Material.AcaciaSlab;
            for (var i = 7288; i <= 7293; i++)
                materials[i] = Material.DarkOakSlab;
            for (var i = 7294; i <= 7299; i++)
                materials[i] = Material.StoneSlab;
            for (var i = 7300; i <= 7305; i++)
                materials[i] = Material.SandstoneSlab;
            for (var i = 7306; i <= 7311; i++)
                materials[i] = Material.PetrifiedOakSlab;
            for (var i = 7312; i <= 7317; i++)
                materials[i] = Material.CobblestoneSlab;
            for (var i = 7318; i <= 7323; i++)
                materials[i] = Material.BrickSlab;
            for (var i = 7324; i <= 7329; i++)
                materials[i] = Material.StoneBrickSlab;
            for (var i = 7330; i <= 7335; i++)
                materials[i] = Material.NetherBrickSlab;
            for (var i = 7336; i <= 7341; i++)
                materials[i] = Material.QuartzSlab;
            for (var i = 7342; i <= 7347; i++)
                materials[i] = Material.RedSandstoneSlab;
            for (var i = 7348; i <= 7353; i++)
                materials[i] = Material.PurpurSlab;
            materials[7354] = Material.SmoothStone;
            materials[7355] = Material.SmoothSandstone;
            materials[7356] = Material.SmoothQuartz;
            materials[7357] = Material.SmoothRedSandstone;
            for (var i = 7358; i <= 7389; i++)
                materials[i] = Material.SpruceFenceGate;
            for (var i = 7390; i <= 7421; i++)
                materials[i] = Material.BirchFenceGate;
            for (var i = 7422; i <= 7453; i++)
                materials[i] = Material.JungleFenceGate;
            for (var i = 7454; i <= 7485; i++)
                materials[i] = Material.AcaciaFenceGate;
            for (var i = 7486; i <= 7517; i++)
                materials[i] = Material.DarkOakFenceGate;
            for (var i = 7518; i <= 7549; i++)
                materials[i] = Material.SpruceFence;
            for (var i = 7550; i <= 7581; i++)
                materials[i] = Material.BirchFence;
            for (var i = 7582; i <= 7613; i++)
                materials[i] = Material.JungleFence;
            for (var i = 7614; i <= 7645; i++)
                materials[i] = Material.AcaciaFence;
            for (var i = 7646; i <= 7677; i++)
                materials[i] = Material.DarkOakFence;
            for (var i = 7678; i <= 7741; i++)
                materials[i] = Material.SpruceDoor;
            for (var i = 7742; i <= 7805; i++)
                materials[i] = Material.BirchDoor;
            for (var i = 7806; i <= 7869; i++)
                materials[i] = Material.JungleDoor;
            for (var i = 7870; i <= 7933; i++)
                materials[i] = Material.AcaciaDoor;
            for (var i = 7934; i <= 7997; i++)
                materials[i] = Material.DarkOakDoor;
            for (var i = 7998; i <= 8003; i++)
                materials[i] = Material.EndRod;
            for (var i = 8004; i <= 8067; i++)
                materials[i] = Material.ChorusPlant;
            for (var i = 8068; i <= 8073; i++)
                materials[i] = Material.ChorusFlower;
            materials[8074] = Material.PurpurBlock;
            for (var i = 8075; i <= 8077; i++)
                materials[i] = Material.PurpurPillar;
            for (var i = 8078; i <= 8157; i++)
                materials[i] = Material.PurpurStairs;
            materials[8158] = Material.EndStoneBricks;
            for (var i = 8159; i <= 8162; i++)
                materials[i] = Material.Beetroots;
            materials[8163] = Material.GrassPath;
            materials[8164] = Material.EndGateway;
            for (var i = 8165; i <= 8176; i++)
                materials[i] = Material.RepeatingCommandBlock;
            for (var i = 8177; i <= 8188; i++)
                materials[i] = Material.ChainCommandBlock;
            for (var i = 8189; i <= 8192; i++)
                materials[i] = Material.FrostedIce;
            materials[8193] = Material.MagmaBlock;
            materials[8194] = Material.NetherWartBlock;
            materials[8195] = Material.RedNetherBricks;
            for (var i = 8196; i <= 8198; i++)
                materials[i] = Material.BoneBlock;
            materials[8199] = Material.StructureVoid;
            for (var i = 8200; i <= 8211; i++)
                materials[i] = Material.Observer;
            for (var i = 8212; i <= 8217; i++)
                materials[i] = Material.ShulkerBox;
            for (var i = 8218; i <= 8223; i++)
                materials[i] = Material.WhiteShulkerBox;
            for (var i = 8224; i <= 8229; i++)
                materials[i] = Material.OrangeShulkerBox;
            for (var i = 8230; i <= 8235; i++)
                materials[i] = Material.MagentaShulkerBox;
            for (var i = 8236; i <= 8241; i++)
                materials[i] = Material.LightBlueShulkerBox;
            for (var i = 8242; i <= 8247; i++)
                materials[i] = Material.YellowShulkerBox;
            for (var i = 8248; i <= 8253; i++)
                materials[i] = Material.LimeShulkerBox;
            for (var i = 8254; i <= 8259; i++)
                materials[i] = Material.PinkShulkerBox;
            for (var i = 8260; i <= 8265; i++)
                materials[i] = Material.GrayShulkerBox;
            for (var i = 8266; i <= 8271; i++)
                materials[i] = Material.LightGrayShulkerBox;
            for (var i = 8272; i <= 8277; i++)
                materials[i] = Material.CyanShulkerBox;
            for (var i = 8278; i <= 8283; i++)
                materials[i] = Material.PurpleShulkerBox;
            for (var i = 8284; i <= 8289; i++)
                materials[i] = Material.BlueShulkerBox;
            for (var i = 8290; i <= 8295; i++)
                materials[i] = Material.BrownShulkerBox;
            for (var i = 8296; i <= 8301; i++)
                materials[i] = Material.GreenShulkerBox;
            for (var i = 8302; i <= 8307; i++)
                materials[i] = Material.RedShulkerBox;
            for (var i = 8308; i <= 8313; i++)
                materials[i] = Material.BlackShulkerBox;
            for (var i = 8314; i <= 8317; i++)
                materials[i] = Material.WhiteGlazedTerracotta;
            for (var i = 8318; i <= 8321; i++)
                materials[i] = Material.OrangeGlazedTerracotta;
            for (var i = 8322; i <= 8325; i++)
                materials[i] = Material.MagentaGlazedTerracotta;
            for (var i = 8326; i <= 8329; i++)
                materials[i] = Material.LightBlueGlazedTerracotta;
            for (var i = 8330; i <= 8333; i++)
                materials[i] = Material.YellowGlazedTerracotta;
            for (var i = 8334; i <= 8337; i++)
                materials[i] = Material.LimeGlazedTerracotta;
            for (var i = 8338; i <= 8341; i++)
                materials[i] = Material.PinkGlazedTerracotta;
            for (var i = 8342; i <= 8345; i++)
                materials[i] = Material.GrayGlazedTerracotta;
            for (var i = 8346; i <= 8349; i++)
                materials[i] = Material.LightGrayGlazedTerracotta;
            for (var i = 8350; i <= 8353; i++)
                materials[i] = Material.CyanGlazedTerracotta;
            for (var i = 8354; i <= 8357; i++)
                materials[i] = Material.PurpleGlazedTerracotta;
            for (var i = 8358; i <= 8361; i++)
                materials[i] = Material.BlueGlazedTerracotta;
            for (var i = 8362; i <= 8365; i++)
                materials[i] = Material.BrownGlazedTerracotta;
            for (var i = 8366; i <= 8369; i++)
                materials[i] = Material.GreenGlazedTerracotta;
            for (var i = 8370; i <= 8373; i++)
                materials[i] = Material.RedGlazedTerracotta;
            for (var i = 8374; i <= 8377; i++)
                materials[i] = Material.BlackGlazedTerracotta;
            materials[8378] = Material.WhiteConcrete;
            materials[8379] = Material.OrangeConcrete;
            materials[8380] = Material.MagentaConcrete;
            materials[8381] = Material.LightBlueConcrete;
            materials[8382] = Material.YellowConcrete;
            materials[8383] = Material.LimeConcrete;
            materials[8384] = Material.PinkConcrete;
            materials[8385] = Material.GrayConcrete;
            materials[8386] = Material.LightGrayConcrete;
            materials[8387] = Material.CyanConcrete;
            materials[8388] = Material.PurpleConcrete;
            materials[8389] = Material.BlueConcrete;
            materials[8390] = Material.BrownConcrete;
            materials[8391] = Material.GreenConcrete;
            materials[8392] = Material.RedConcrete;
            materials[8393] = Material.BlackConcrete;
            materials[8394] = Material.WhiteConcretePowder;
            materials[8395] = Material.OrangeConcretePowder;
            materials[8396] = Material.MagentaConcretePowder;
            materials[8397] = Material.LightBlueConcretePowder;
            materials[8398] = Material.YellowConcretePowder;
            materials[8399] = Material.LimeConcretePowder;
            materials[8400] = Material.PinkConcretePowder;
            materials[8401] = Material.GrayConcretePowder;
            materials[8402] = Material.LightGrayConcretePowder;
            materials[8403] = Material.CyanConcretePowder;
            materials[8404] = Material.PurpleConcretePowder;
            materials[8405] = Material.BlueConcretePowder;
            materials[8406] = Material.BrownConcretePowder;
            materials[8407] = Material.GreenConcretePowder;
            materials[8408] = Material.RedConcretePowder;
            materials[8409] = Material.BlackConcretePowder;
            for (var i = 8410; i <= 8435; i++)
                materials[i] = Material.Kelp;
            materials[8436] = Material.KelpPlant;
            materials[8437] = Material.DriedKelpBlock;
            for (var i = 8438; i <= 8449; i++)
                materials[i] = Material.TurtleEgg;
            materials[8450] = Material.DeadTubeCoralBlock;
            materials[8451] = Material.DeadBrainCoralBlock;
            materials[8452] = Material.DeadBubbleCoralBlock;
            materials[8453] = Material.DeadFireCoralBlock;
            materials[8454] = Material.DeadHornCoralBlock;
            materials[8455] = Material.TubeCoralBlock;
            materials[8456] = Material.BrainCoralBlock;
            materials[8457] = Material.BubbleCoralBlock;
            materials[8458] = Material.FireCoralBlock;
            materials[8459] = Material.HornCoralBlock;
            for (var i = 8460; i <= 8461; i++)
                materials[i] = Material.DeadTubeCoral;
            for (var i = 8462; i <= 8463; i++)
                materials[i] = Material.DeadBrainCoral;
            for (var i = 8464; i <= 8465; i++)
                materials[i] = Material.DeadBubbleCoral;
            for (var i = 8466; i <= 8467; i++)
                materials[i] = Material.DeadFireCoral;
            for (var i = 8468; i <= 8469; i++)
                materials[i] = Material.DeadHornCoral;
            for (var i = 8470; i <= 8471; i++)
                materials[i] = Material.TubeCoral;
            for (var i = 8472; i <= 8473; i++)
                materials[i] = Material.BrainCoral;
            for (var i = 8474; i <= 8475; i++)
                materials[i] = Material.BubbleCoral;
            for (var i = 8476; i <= 8477; i++)
                materials[i] = Material.FireCoral;
            for (var i = 8478; i <= 8479; i++)
                materials[i] = Material.HornCoral;
            for (var i = 8480; i <= 8487; i++)
                materials[i] = Material.DeadTubeCoralWallFan;
            for (var i = 8488; i <= 8495; i++)
                materials[i] = Material.DeadBrainCoralWallFan;
            for (var i = 8496; i <= 8503; i++)
                materials[i] = Material.DeadBubbleCoralWallFan;
            for (var i = 8504; i <= 8511; i++)
                materials[i] = Material.DeadFireCoralWallFan;
            for (var i = 8512; i <= 8519; i++)
                materials[i] = Material.DeadHornCoralWallFan;
            for (var i = 8520; i <= 8527; i++)
                materials[i] = Material.TubeCoralWallFan;
            for (var i = 8528; i <= 8535; i++)
                materials[i] = Material.BrainCoralWallFan;
            for (var i = 8536; i <= 8543; i++)
                materials[i] = Material.BubbleCoralWallFan;
            for (var i = 8544; i <= 8551; i++)
                materials[i] = Material.FireCoralWallFan;
            for (var i = 8552; i <= 8559; i++)
                materials[i] = Material.HornCoralWallFan;
            for (var i = 8560; i <= 8561; i++)
                materials[i] = Material.DeadTubeCoralFan;
            for (var i = 8562; i <= 8563; i++)
                materials[i] = Material.DeadBrainCoralFan;
            for (var i = 8564; i <= 8565; i++)
                materials[i] = Material.DeadBubbleCoralFan;
            for (var i = 8566; i <= 8567; i++)
                materials[i] = Material.DeadFireCoralFan;
            for (var i = 8568; i <= 8569; i++)
                materials[i] = Material.DeadHornCoralFan;
            for (var i = 8570; i <= 8571; i++)
                materials[i] = Material.TubeCoralFan;
            for (var i = 8572; i <= 8573; i++)
                materials[i] = Material.BrainCoralFan;
            for (var i = 8574; i <= 8575; i++)
                materials[i] = Material.BubbleCoralFan;
            for (var i = 8576; i <= 8577; i++)
                materials[i] = Material.FireCoralFan;
            for (var i = 8578; i <= 8579; i++)
                materials[i] = Material.HornCoralFan;
            for (var i = 8580; i <= 8587; i++)
                materials[i] = Material.SeaPickle;
            materials[8588] = Material.BlueIce;
            for (var i = 8589; i <= 8590; i++)
                materials[i] = Material.Conduit;
            materials[8591] = Material.VoidAir;
            materials[8592] = Material.CaveAir;
            for (var i = 8593; i <= 8594; i++)
                materials[i] = Material.BubbleColumn;
            for (var i = 8595; i <= 8598; i++)
                materials[i] = Material.StructureBlock;
        }

        protected override Dictionary<int, Material> GetDict()
        {
            return materials;
        }
    }
}
