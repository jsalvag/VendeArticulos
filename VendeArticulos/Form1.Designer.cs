namespace VendeArticulos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cli_cBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numFac_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.art_dgv = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nom_cli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.venta_dgv = new System.Windows.Forms.DataGridView();
            this.vender_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.total_box = new System.Windows.Forms.TextBox();
            this.code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.totalVent_box = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.art_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes:";
            // 
            // cli_cBox
            // 
            this.cli_cBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_cBox.FormattingEnabled = true;
            this.cli_cBox.Location = new System.Drawing.Point(87, 7);
            this.cli_cBox.Margin = new System.Windows.Forms.Padding(4);
            this.cli_cBox.Name = "cli_cBox";
            this.cli_cBox.Size = new System.Drawing.Size(356, 24);
            this.cli_cBox.TabIndex = 1;
            this.cli_cBox.SelectedIndexChanged += new System.EventHandler(this.cli_cBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numFac_lb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cli_cBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 41);
            this.panel1.TabIndex = 2;
            // 
            // numFac_lb
            // 
            this.numFac_lb.AutoSize = true;
            this.numFac_lb.Location = new System.Drawing.Point(630, 11);
            this.numFac_lb.Name = "numFac_lb";
            this.numFac_lb.Size = new System.Drawing.Size(0, 17);
            this.numFac_lb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Facutra Nº - ";
            // 
            // art_dgv
            // 
            this.art_dgv.AllowUserToAddRows = false;
            this.art_dgv.AllowUserToDeleteRows = false;
            this.art_dgv.AllowUserToOrderColumns = true;
            this.art_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.art_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.nom,
            this.prec,
            this.cant,
            this.desc});
            this.art_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.art_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.art_dgv.Enabled = false;
            this.art_dgv.Location = new System.Drawing.Point(0, 41);
            this.art_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.art_dgv.Name = "art_dgv";
            this.art_dgv.ReadOnly = true;
            this.art_dgv.Size = new System.Drawing.Size(744, 170);
            this.art_dgv.TabIndex = 0;
            this.art_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.art_dgv_CellClick);
            // 
            // code
            // 
            this.code.Frozen = true;
            this.code.HeaderText = "CODIGO";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.Frozen = true;
            this.nom.HeaderText = "NOMBRE";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 120;
            // 
            // prec
            // 
            this.prec.Frozen = true;
            this.prec.HeaderText = "PRECIO";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            // 
            // cant
            // 
            this.cant.Frozen = true;
            this.cant.HeaderText = "CANTIDAD";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.Frozen = true;
            this.desc.HeaderText = "DESCRIPCION";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 300;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nom_cli);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 42);
            this.panel2.TabIndex = 3;
            // 
            // nom_cli
            // 
            this.nom_cli.AutoSize = true;
            this.nom_cli.Location = new System.Drawing.Point(81, 5);
            this.nom_cli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.Size = new System.Drawing.Size(0, 17);
            this.nom_cli.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista de Articulos:";
            // 
            // venta_dgv
            // 
            this.venta_dgv.AllowUserToAddRows = false;
            this.venta_dgv.AllowUserToDeleteRows = false;
            this.venta_dgv.AllowUserToOrderColumns = true;
            this.venta_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venta_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.precTotal});
            this.venta_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.venta_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.venta_dgv.Location = new System.Drawing.Point(0, 253);
            this.venta_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.venta_dgv.Name = "venta_dgv";
            this.venta_dgv.Size = new System.Drawing.Size(744, 173);
            this.venta_dgv.TabIndex = 4;
            this.venta_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venta_dgv_CellClick);
            // 
            // vender_btn
            // 
            this.vender_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vender_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vender_btn.Enabled = false;
            this.vender_btn.Location = new System.Drawing.Point(657, 438);
            this.vender_btn.Name = "vender_btn";
            this.vender_btn.Size = new System.Drawing.Size(75, 33);
            this.vender_btn.TabIndex = 5;
            this.vender_btn.Text = "Vender";
            this.vender_btn.UseVisualStyleBackColor = true;
            this.vender_btn.Click += new System.EventHandler(this.vender_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL:";
            // 
            // total_box
            // 
            this.total_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_box.Enabled = false;
            this.total_box.Location = new System.Drawing.Point(449, 443);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(100, 23);
            this.total_box.TabIndex = 7;
            // 
            // code1
            // 
            this.code1.Frozen = true;
            this.code1.HeaderText = "CODIGO";
            this.code1.Name = "code1";
            this.code1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // precTotal
            // 
            this.precTotal.Frozen = true;
            this.precTotal.HeaderText = "PRECIO";
            this.precTotal.Name = "precTotal";
            this.precTotal.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL VENTAS:";
            // 
            // totalVent_box
            // 
            this.totalVent_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalVent_box.Enabled = false;
            this.totalVent_box.Location = new System.Drawing.Point(19, 448);
            this.totalVent_box.Name = "totalVent_box";
            this.totalVent_box.Size = new System.Drawing.Size(114, 23);
            this.totalVent_box.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.totalVent_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vender_btn);
            this.Controls.Add(this.venta_dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.art_dgv);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vende Articulos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.art_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cli_cBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView art_dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nom_cli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView venta_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numFac_lb;
        private System.Windows.Forms.Button vender_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn precTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalVent_box;
    }
}

