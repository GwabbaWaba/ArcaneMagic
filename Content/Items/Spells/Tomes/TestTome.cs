using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArcaneMagic.Content.Items.Spells.Tomes
{
    public class TestTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Test tome");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 32; // The item texture's width
            Item.height = 20; // The item texture's height

            Item.maxStack = 1; // The item's max stack value
        }
    }
}
