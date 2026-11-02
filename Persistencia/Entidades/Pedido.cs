using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia.Entidades
{
    public class Pedido
    {
        public string ID {get;set;} = string.Empty;
        public Alumno Alumno {get;set;} 
        public List<ItemPedido> Items {get;set;} 
        public decimal MontoTotal {get;set;}
        public string MetodoPago {get;set;} = string.Empty;
        public string Estado {get;set;} = string.Empty;
    }
}