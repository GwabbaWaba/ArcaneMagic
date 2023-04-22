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
            Item.ResearchUnlockCount = -1;
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
			Item.healLife = HEAL_AMOUNT;
		}

		// crafting
		public override void AddRecipes()
		{
			Recipe.Create(ModContent.ItemType<Spells.TestUtilitySpell>(), 3)
				.AddCondition(Language.GetOrRegister("Test Tome"), () => Main.LocalPlayer.HasItem(ModContent.ItemType<Items.Spells.Tomes.TestTome>()))
				.AddCondition(Language.GetOrRegister("50 Mana"), () => Main.LocalPlayer.statMana >= 50)
				.AddCondition(Language.GetOrRegister("< max hp"), () => Main.LocalPlayer.statLife < Main.LocalPlayer.statLifeMax)
				.AddCondition(Language.GetOrRegister("No potion sickness"), () => !Main.LocalPlayer.HasBuff(BuffID.PotionSickness))
				.Register();
		}
		public override void OnCreated(ItemCreationContext recipe)
        {
			Main.LocalPlayer.statMana -= 50;
        }
    }
}
