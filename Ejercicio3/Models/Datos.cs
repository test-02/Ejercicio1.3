﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio3.Models
{
    public class Datos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(60)]
        public string Nombre { get; set; }        
        
        [MaxLength(60)]
        public string Apellidos { get; set; }
        
        public String Edad { get; set; }

        [MaxLength(60)]
        public string Correo { get; set; }

        [MaxLength(60)]
        public string Direccion { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Descripción: {Edad}";
        }

    }
}
