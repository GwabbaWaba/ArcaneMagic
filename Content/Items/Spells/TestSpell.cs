using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;

namespace ArcaneMagic.Content.Items.Spells
{
	public class TestSpell : ModItem
	{
		public override void SetStaticDefaults()
		{
			// Tooltip.SetDefault("Fades in your inventory");
			Item.ResearchUnlockCount = -1;
		}
		public override void SetDefaults()
		{
			Item.damage = 12;
			Item.DamageType = DamageClass.Magic; // Makes the damage register as magic.
			Item.width = 16;
			Item.height = 16;
			Item.useTime = 10;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 6;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.ChlorophyteOrb;
			Item.shootSpeed = 20; // How fast the item shoots the projectile.
			Item.crit = 32; // crit chance
			Item.noUseGraphic = true;

			Item.maxStack = 3;
			Item.consumable = true;


		}

		// crafting
		public override void AddRecipes()
		{

			CreateRecipe(3)
				.AddCondition(Language.GetOrRegister("Has Test Tome"), () => Main.LocalPlayer.HasItem(ModContent.ItemType<Items.Spells.Tomes.TestTome>()))
				.AddCondition(Language.GetOrRegister("10 Mana"), () => Main.LocalPlayer.statMana >= 20)
				.AddCondition(Language.GetOrRegister("Not in inventory"), () => !Main.LocalPlayer.HasItem(ModContent.ItemType<Items.Spells.TestSpell>()))
				.Register();
		}
		public override void OnCreated(ItemCreationContext recipe)
		{
			Main.LocalPlayer.statMana -= 20;
		}
	}
}
