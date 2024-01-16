using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice__Classes
{
    //Add bike class
    public class Bike
    {
        //Add fields
        string _brand;
        string _mode;
        string _color;
        int _size;

        //Add constructor
        public Bike (string brand, string mode, string color, int size)
        {
            Brand=brand;
            Mode=mode;
            Color=color;
            Size=size;
        }


        //Add properties
        public string Brand { get => _brand; set => _brand=value; }
        public string Mode { get => _mode; set => _mode=value; }
        public string Color { get => _color; set => _color=value; }
        public int Size { get => _size; set => _size=value; }
    }
}
