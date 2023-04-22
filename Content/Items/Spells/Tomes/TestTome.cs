using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArcaneMagic.Content.Items.Spells.Tomes
{
    public class TestTome : BaseTome
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Magic;
            Item.damage = 30;
            Item.width = 32; // The item texture's width
            Item.height = 20; // The item texture's height
        }
    }
}
