﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedidosApp.Models
{

    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre", Description = "")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Name { get; set; }

        [Display(Name = "Tipo", Description = "")]
        [Required(ErrorMessage = "Campo requerido")]
        public ProductType Type { get; set; }

        [Display(Name = "Thumbnail", Description = "")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Thumbnail { get; set; }

        //public int Version { get; set; }

        //public virtual ICollection<FileModel> Files { get; set; }

        public string describe_yourself()
        {
            return Id + ", " + Name + ", " + Type + ", " + Thumbnail;
            
        }
    }

    public enum ProductType
    {
        [Description("Derecha")]
        Right,
        [Description("Izquierda")]
        Left,
        [Description("Ambas")]
        Both,
    }


}