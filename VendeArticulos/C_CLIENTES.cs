using System;

namespace VendeArticulos
{
    class C_CLIENTES:IEquatable<C_CLIENTES>
    {
        private string
            ci,
            nom,
            ape,
            dir,
            tlf;
        
        public C_CLIENTES(string c, string n, string a, string d, string t)
        {
            this.ci = c;
            this.nom = n;
            this.ape = a;
            this.dir = d;
            this.tlf = t;
        }

        public string[] datos()
        {
            string[] d = new string[5];
            d[0] = this.ci;
            d[1] = this.nom;
            d[2] = this.ape;
            d[3] = this.dir;
            d[4] = this.tlf;
         
            return d;
        }

        public bool Equals(C_CLIENTES other)
        {
            if (other.ci == this.ci)
                return true;
            return false;
        }
    }
}
