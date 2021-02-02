using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_3.Models
{
    public class Proyecto
    {
        // ATRIBUTOS
        private string id;
        private string nombre;
        private int horas;

        // GETTERS Y SETTERS
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Horas { get => horas; set => horas = value; }
        
        // CONSTRUCTORES
        public ICollection<Proyecto> Proyectos { get; set; }
    }
}
