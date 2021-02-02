using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_3.Models
{
    public class Asignado_a
    {
        // ATRIBUTOS
        private int id;
        private string cientifico;
        private string proyecto;

        // GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Cientifico { get => cientifico; set => cientifico = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }

        // CONSTRUCTORES
        public ICollection<Asignado_a> Asignado_As { get; set; }

    }
}
