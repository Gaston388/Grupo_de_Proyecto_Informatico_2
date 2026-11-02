using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia.Entidades
{
    public class ItemPedido
    {
        public int ID {get;set;}
        public string Producto {get;set;} = string.Empty; 
        public int Cantidad {get;set;}
        public decimal Precio {get;set;}
    }
}