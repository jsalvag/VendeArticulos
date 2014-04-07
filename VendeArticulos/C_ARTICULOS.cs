using System;

namespace VendeArticulos
{
    class C_ARTICULOS:IEquatable<C_ARTICULOS>
    {
        private string cod;
        private string nom;
        private string desc;
        private int cant;
        private double prec;

        public C_ARTICULOS(string c, string n, string d, int ca, double p)
        {
            this.cod = c;
            this.nom = n;
            this.desc = d;
            this.cant = ca;
            this.prec = p;
        }

        public string[] datos()
        {
            string[] d = new string[5];
            d[0] = this.cod;
            d[1] = this.nom;
            d[3] = Convert.ToString(this.cant);
            d[4] = this.desc;
            d[2] = Convert.ToString(this.prec);

            return d;
        }

        public string getCod()
        {
            return this.cod;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getDesc()
        {
            return this.desc;
        }

        public int getCant()
        {
            return this.cant;
        }

        public double getPrec()
        {
            return this.prec;
        }

        public void setCant(int ca)
        {
            this.cant = ca;
        }

        public bool Equals(C_ARTICULOS other)
        {
            if (other.cod == this.cod)
                return true;
            return false;
        }
    }
}
