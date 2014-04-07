using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendeArticulos
{
    class C_FACTURA
    {
        public List<C_PEDIDOS> listaPedidos;
        private int id;
        private C_CLIENTES cli;
        private DateTime fecha;

        public C_FACTURA(int i, C_CLIENTES c, DateTime f)
        {
            this.id = i;
            this.cli = c;
            this.fecha = f;
            listaPedidos = new List<C_PEDIDOS>();
        }

        public double total()
        {
            double t = 0;
            foreach (C_PEDIDOS p in listaPedidos)
            {
                t += p.total();
            }
            return t;
        }
    }
}
