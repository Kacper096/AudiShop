﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudiShop.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        public int CategoriaID { get; set; }
        public int SilnikID { get; set; }

        [Required(ErrorMessage = "Enter model name.")]
        [StringLength(100, ErrorMessage ="The length of model name cannot be under 100 chars.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Car Drive is required.")]
        public CarDriveType CarDrive { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Enter description.")]
        public string Description { get; set; }
        public string Color { get; set; }
        public string PictureName { get; set; }

        public decimal Price { get; set; }
        public bool Current { get; set; }

        //Categoria == UnderBody
        public virtual Categoria Categoria { get; set; }
        public virtual Engine Engine { get; set; }
    }

    public enum PackageType
    {
        Standard,
        Sportback,
        Advanced,
        SLine,
        Sport
    }

    public enum CarDriveType
    {
        Quattro,
        FrontAxle
    }
}