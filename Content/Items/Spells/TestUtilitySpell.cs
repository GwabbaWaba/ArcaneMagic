using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;

namespace ArcaneMagic.Content.Items.Spells
{
    public class TestUtilitySpell : ModItem
    {
		public const int HEAL_AMOUNT = 50;

		public override void SetStaticDefaults()
        {
            /* Tooltip.SetDefault("Fades in your inventory" +
                "\nWeak spell which heals you for " + HEAL_AMOUNT.ToString() + " hp" +
                "\nApplies potion sickness"); */
        }

		public override void UpdateInventory(Player player)
		{
			Item.TurnToAir();
		}
		public override void HoldItem(Player player)
		{
			player.AddBuff(BuffID.PotionSickness, 900);
			Item.TurnToAir();
		}
		public override void OnConsumeItem(Player player)
        {
			Main.LocalPlayer.statLife += HEAL_AMOUNT;
			player.AddBuff(BuffID.PotionSickness, 900);
		}

		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;

			Item.maxStack = 1; 
			Item.consumable = true;
		}

		// crafting
		public override void AddRecipes()
		{
			Recipe recipe = Recipe.Create(ModContent.ItemType<Spells.TestUtilitySpell>(), 1);
			recipe.AddCondition(NetworkText.FromKey("Test Tome"), r => Main.LocalPlayer.HasItem(ModContent.ItemType<Items.Spells.Tomes.TestTome>()));
			recipe.AddCondition(NetworkText.FromKey("50 Mana"), r => Main.LocalPlayer.statMana >= 50);
			recipe.AddCondition(NetworkText.FromKey("< max hp"), r => Main.LocalPlayer.statLife < Main.LocalPlayer.statLifeMax);
			recipe.AddCondition(NetworkText.FromKey("No potion sickness"), r => !Main.LocalPlayer.HasBuff(BuffID.PotionSickness));
			recipe.Register();
		}
        public override void OnCreated(ItemCreationContext recipe)
        {
			Main.LocalPlayer.statMana -= 50;
        }
    }
}
