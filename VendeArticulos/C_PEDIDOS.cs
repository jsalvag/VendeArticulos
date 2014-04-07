using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendeArticulos
{
    class C_PEDIDOS:IEquatable<C_PEDIDOS>
    {
        private int cant;
        private C_ARTICULOS art;

        public C_PEDIDOS(int c, C_ARTICULOS a)
        {
            this.cant = c;
            this.art = a;
        }

        public int getCant()
        {
            return this.cant;
        }

        public C_ARTICULOS getArt()
        {
            return this.art;
        }

        public void setCant(int c)
        {
            this.cant = c;
        }

        public bool Equals(C_PEDIDOS other)
        {
            if (other.getArt() == this.art)
                return true;
            return false;
        }

        public double total()
        {
            return art.getPrec() * cant;
        }
    }
}
