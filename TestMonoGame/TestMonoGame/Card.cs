using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame
{
    public class Card : Sprite, IDraggable
    {
        public Card(Texture2D tex, Vector2 pos) : base(tex, pos)
        {
            (this as IDraggable).RegisterDraggable();
        }

    }
}
