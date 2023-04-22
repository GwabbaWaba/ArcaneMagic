using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using System;

namespace ArcaneMagic.Content.Items.Spells.Tomes
{
    public abstract class BaseTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Magic;
            Item.damage = 1;
        }
    }
}