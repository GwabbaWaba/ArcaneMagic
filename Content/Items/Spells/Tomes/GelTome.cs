using Terraria;
using Terraria.ModLoader;

namespace ArcaneMagic.Content.Items.Spells.Tomes
{
    public class GelTome : BaseTome
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 9;
        }
    }
}
