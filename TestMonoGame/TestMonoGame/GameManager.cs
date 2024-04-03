using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame
{
    public class GameManager
    {
        private readonly Card card;

        public GameManager()
        {
            var cardTexture = Globals.Content.Load<Texture2D>("snek");
            card = new(cardTexture, new(100, 100));
        }

        public void Update()
        {
            MouseInput.Update();
            DragDrop.Update();
        }

        public void Draw()
        {
            card.Draw();
        }
    }
}
