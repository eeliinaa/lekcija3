using System;
using System.Collections.Generic;
using System.Text;

namespace lekcija3._1
{
    public class Item
    {
        private float _height;
        private float _width;
        private float _weight;

        public float Height
        {
            get { return _height; }
        }
        public float Width
        {
            get { return _width; }
        }
        public float Weight
        {
            get { return _weight; }
        }

        public Item(float height, float width, float weight)
        {
            _height = height;
            _width = width;
            _weight = weight;
        }

        public void ShowInfo ()
        {
            Console.WriteLine($"Height={_height}; Width={_width}; Weight={_height}; ");
        }
    }
}
