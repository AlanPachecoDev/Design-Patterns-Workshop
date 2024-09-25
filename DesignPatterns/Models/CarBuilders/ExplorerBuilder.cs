﻿using System.Drawing;
using System.Reflection;

namespace DesignPatterns.Models.CarBuilders
{
    public class ExplorerBuilder : CarBuilder
    {

        public override CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }
        public override CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public override CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public override CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }
    }
}
