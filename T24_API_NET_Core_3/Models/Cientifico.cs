using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_3.Models
{
    public class Cientifico
    {
        // ATRIBUTOS
        private string dni;
        private string nomApels;

        // GETTERS Y SETTERS
        public string Dni { get => dni; set => dni = value; }
        public string NomApels { get => nomApels; set => nomApels = value; }

        // CONSTRUCTORES
        public ICollection<Cientifico> Cientificos { get; set; }
    }
}
