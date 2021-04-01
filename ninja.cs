using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace mod1.NPCs
{
public class ninja : ModNPC
{
public override void SetStaticDefaults()
{
DisplayName.SetDefault("ninja");
}

public override void SetDefaults()
{
npc.width = 38;
npc.height = 48;
npc.damage = 13;
npc.defense = 15;
npc.lifeMax = 50;
npc.HitSound = SoundID.NPCHit2;
npc.DeathSound = SoundID.NPCDeath2;
npc.aiStyle = -45;
Main.npcFrameCount[npc.type] = 3;
aiType = -45;
animationType = -45;
}

public override float SpawnChance(NPCSpawnInfo spawnInfo)
{
return SpawnCondition.OverworldNightMonster.Chance * 50f;
}
public override void NPCLoot()
{
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 1, Main.rand.Next(9, 1));
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 257, Main.rand.Next(0, 1));
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 258, Main.rand.Next(0, 1));
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2273, Main.rand.Next(1, 1));
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 1168, Main.rand.Next(3, 5));
}
}
}