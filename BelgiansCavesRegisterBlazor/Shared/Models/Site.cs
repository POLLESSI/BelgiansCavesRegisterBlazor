﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiansCavesRegisterBlazor.Shared.Models
{
    public class Site
    {
        public string Site_Name { get; set; }
        public string Site_Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Length { get; set; }
        public decimal Depth { get; set; }
        public string AccesRequirement { get; set; }
        public string PracticalInformation { get; set; }
        public int DonneesLambda_Id { get; set; }
        public int NOwner_Id { get; set; }
        public int ScientificData_Id { get; set; }
        public int Bibliography_Id { get; set; }
        public bool Active { get; set; }
    }
}
