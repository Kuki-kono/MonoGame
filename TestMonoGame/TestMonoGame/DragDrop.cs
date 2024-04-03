using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame
{
    public static class DragDrop
    {
        private static readonly List<IDraggable> draggables = new();
        private static IDraggable dragItem;

        public static void AddDraggable(IDraggable item)
        {
            draggables.Add(item);
        }

        private static void DragStart()
        {
            if (MouseInput.MouseDown)
            {
                foreach(var item in draggables)
                {
                    if (item.Rectangle.Contains(MouseInput.MousePos))
                    {
                        dragItem = item;
                        break;
                    }
                }
            }
        }

        private static void DragStop()
        {
            if (MouseInput.MouseUp)
            {
                dragItem = null;
            }
        }

        public static void Update()
        {
            DragStart();

            if (dragItem is not null)
            {
                dragItem.Position = MouseInput.MousePos;
                DragStop();
            }
        }
    }
}
