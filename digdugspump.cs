using Terraria.ID;
using Terraria.ModLoader;
namespace mod1.Items
{
public class digdugspump : ModItem
{
public override void SetStaticDefaults()
{
DisplayName.SetDefault("digdugspump");
Tooltip.SetDefault("a pump that infates monsters until they pop");
}

public override void SetDefaults()
{
item.ranged = true;
item.noMelee = true;
item.damage = 10;
item.useStyle = 1;
item.useTime = 60;
item.useAnimation = 60;
item.knockBack = ;
item.value = 50;
item.rare = 2;
item.UseSound = SoundID.Item1;
item.autoReuse = true;
item.width = 38;
item.height = 47;
item.mana = 6;

item.shoot = 49;
item.shootSpeed = 50f;
}

public override void AddRecipes()
{
ModRecipe digdugspumprecipe = new ModRecipe(mod);
digdugspumprecipe.AddIngredient(54, 4);
digdugspumprecipe.AddIngredient(132, 6);
digdugspumprecipe.AddIngredient(280, 1);



digdugspumprecipe.AddTile(18);
digdugspumprecipe.SetResult(this);
digdugspumprecipe.AddRecipe();
}
}
}