﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MantenedorProductos.LIB.Modelos
{
    public class SubCategoria
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Nombre { get; set; }        
    }
}
