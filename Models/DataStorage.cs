﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Models.Interfaces;

namespace Lab1.models
{
    public class DataStorage : IPriceable, IIdentifiable
    {
        public required int Id { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required string Type { get; set; }
        public required int Storage { get; set; }
        public required decimal Price { get; set; }
    }
}
