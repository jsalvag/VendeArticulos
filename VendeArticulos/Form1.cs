using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendeArticulos
{
    public partial class Form1 : Form
    {
        List<C_ARTICULOS> listaArticulos;
        List<C_CLIENTES> listaClientes;
        List<C_FACTURA> listaFacturas;
        C_CLIENTES cli;
        C_FACTURA fac;
        C_PEDIDOS ped;
        C_ARTICULOS art;
        int id_fac;
        double tVentas;

        public Form1()
        {
            InitializeComponent();
            id_fac = 0;

            listaArticulos = new List<C_ARTICULOS>();
            listaClientes = new List<C_CLIENTES>();
            listaFacturas = new List<C_FACTURA>();

            listaClientes.Add(new C_CLIENTES("3489436", "Maria", "Marcano", "Porlamar", "04168885555"));
            listaClientes.Add(new C_CLIENTES("11111111", "Luis", "Contreras", "Juangriego", "02951112233"));
            listaClientes.Add(new C_CLIENTES("13655092", "Claudia", "Muñoz", "La Asumcion", "04145554433"));
            listaClientes.Add(new C_CLIENTES("16825525", "Jose", "Guevara", "Porlamar", "04168995399"));
            listaClientes.Add(new C_CLIENTES("65432187", "Pedro", "Perez", "Pampatar", "04126543298"));

            foreach (C_CLIENTES c in listaClientes)
            {
                string[] d = c.datos();
                cli_cBox.Items.Add(d[0] + " / " + d[2] + ", " + d[1]);
            }

            listaArticulos.Add(new C_ARTICULOS("DF35A2", "THC ONE", "Smartphone de gama alta", 10, 10000));
            listaArticulos.Add(new C_ARTICULOS("CB255D", "GALAXY S5", "Smartphone de gama alta", 100, 20000));
            listaArticulos.Add(new C_ARTICULOS("789DDA", "HTC 8S", "Smartphone de gama media", 100, 8000));
            listaArticulos.Add(new C_ARTICULOS("321ABC", "MOTO G", "Smartphone de gama media", 100, 8500));
            listaArticulos.Add(new C_ARTICULOS("A1B2C3", "HTC DESIRE C", "Smartphone de gama baja", 100, 4500));
            listaArticulos.Add(new C_ARTICULOS("C1B2A3", "NOKIA 500", "Smartphone de gama baja", 100, 5000));

            llenarArticulos();

            numFac_lb.Text = Convert.ToString(id_fac);
        }

        private void llenarArticulos()
        {
            art_dgv.Rows.Clear();
            foreach (C_ARTICULOS a in listaArticulos)
                art_dgv.Rows.Add(a.datos());
        }

        private void verCliSelec()
        {
            string ci = cli_cBox.Text.Split('/')[0];
            ci = ci.Trim();
            cli = listaClientes.Find(c => c.datos()[0] == ci);
            nom_cli.Text = cli.datos()[2] + ", " + cli.datos()[1];
            art_dgv.Enabled = true;
            fac = new C_FACTURA(id_fac, cli, DateTime.Now);
            venta_dgv.Rows.Clear();
        }

        private void llenarListaPedido()
        {
            venta_dgv.Rows.Clear();
            string[] d = new string[4];
            foreach (C_PEDIDOS p in fac.listaPedidos)
            {
                art = p.getArt();
                d[0] = art.datos()[0];
                d[1] = art.datos()[1];
                d[2] = Convert.ToString(p.getCant());
                d[3] = Convert.ToString(p.total());
                venta_dgv.Rows.Add(d);
            }
            total_box.Text = Convert.ToString(fac.total());
        }

        private void cargArt(C_ARTICULOS art)
        {
            int c1 = art.getCant();
            if (c1 > 0)
            {
                ped = fac.listaPedidos.Find(p => p.getArt() == art);
                if (ped == null)
                {
                    fac.listaPedidos.Add(new C_PEDIDOS(1, art));
                    --c1;
                    art.setCant(c1);
                    llenarArticulos();
                }
                else
                {
                    int c = ped.getCant();
                    if (c >= 0)
                    {
                        ++c;
                        --c1;
                        ped.setCant(c);
                        art.setCant(c1);
                        llenarArticulos();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay mas articulos de ese modelo");
            }

            llenarListaPedido();
            vender_btn.Enabled = true;
        }

        private void art_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = art_dgv.Rows[e.RowIndex];
                art = listaArticulos.Find(a => a.datos()[0] == Convert.ToString(fila.Cells["code"].Value));
                cargArt(art);
            }
        }

        private void cli_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verCliSelec();
            total_box.Clear();
        }

        private void vender_btn_Click(object sender, EventArgs e)
        {
            listaFacturas.Add(fac);
            cli_cBox.ResetText();
            venta_dgv.Rows.Clear();
            art_dgv.Enabled = false;
            nom_cli.Text = "";
            id_fac++;
            numFac_lb.Text = Convert.ToString(id_fac);
            vender_btn.Enabled = false;
            total_box.Clear();
            tVentas = 0;
            foreach (C_FACTURA f in listaFacturas)
                tVentas += f.total();
            totalVent_box.Text = Convert.ToString(tVentas);
            cli_cBox.Focus();
        }

        private void venta_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = venta_dgv.Rows[e.RowIndex];
                ped = fac.listaPedidos.Find(a => a.getArt().datos()[0] == Convert.ToString(fila.Cells["code1"].Value));

                int c = ped.getCant();
                int c1 = art.getCant();
                if (c > 1)
                {
                    c--;
                    ped.setCant(c);
                }
                else
                {
                    fac.listaPedidos.Remove(ped);
                }
                c1++;
                art.setCant(c1);
                llenarListaPedido();
                llenarArticulos();
            }
        }
    }
}
