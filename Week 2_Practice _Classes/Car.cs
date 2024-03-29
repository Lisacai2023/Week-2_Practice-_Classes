﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice__Classes
{
    //Create car class
    public class Car
    {
        //Add fields
        string _make;
        string _model;
        int _year;
        string _color;
        int _mileage;

        //Add properties
        public string Make { get => _make; set => _make=value; }
        public string Model { get => _model; set => _model=value; }
        public int Year { get => _year; set => _year=value; }
        public string Color { get => _color; set => _color=value; }
        public int Mileage { get => _mileage; set => _mileage=value; }

    }
}
