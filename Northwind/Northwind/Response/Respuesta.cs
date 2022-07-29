using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WEB.Response
{
    public class Respuesta
    {
        public int Win { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public Respuesta()
        {
            this.Win = 0;
        }
    }
}
