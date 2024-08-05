﻿using BlazorAppVSCode.Interfaces.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorAppVSCode.Models.Commons
{
    public class Materia : IEntityIdNombre
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        [Display(Name ="Año carrera")]
        public int AnioCarreraId { get; set; }
        [Display(Name = "Año carrera")]
        public AnioCarrera? AnioCarrera { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
