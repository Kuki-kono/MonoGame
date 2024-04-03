using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame
{
    public interface IDraggable
    {
        Rectangle Rectangle { get; }
        Vector2 Position { get; set; }

        void RegisterDraggable()
        {
            DragDrop.AddDraggable(this);
        }
    }
}
