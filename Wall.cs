using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcousticalModeling
{
    public class Wall
    {
        public string name = "";
        public double _length;
        public double _height;
        public double _area;
        public double _volume;
        public Materials _material;

        public Wall()
        {

        }

        public Wall(string Name, double length, double height)
        {       
            name = Name;
            _length = length;
            
            _height = height;
        }

        public void SetLength(double length)
        {
            _length = length;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }

        public void SetMaterial(Materials material)
        {
            _material = material;
        }

        public double volume(double length, double depth, double height)
        {
            _volume = length * depth * height;
            return _volume; 
        }

        public double area(double length, double depth)
        {
            _area = length * depth;
            return _area;
        }

        

    }
}
