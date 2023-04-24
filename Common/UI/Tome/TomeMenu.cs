using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.UI;

namespace ArcaneMagic.Common.UI.Tome
{
    public class TomeMenu : UIState
    {
        
    }
    public class TomeMenuSlot : UIElement
    {
        public static string texture = "SpellSlot";
        public Vector2 position = new();
        public TomeMenuSlot(Vector2 position)
        {
            IgnoresMouseInteraction = false;
        }
        public override void Draw(SpriteBatch sprite_batch)
        {

        }
    }
}
