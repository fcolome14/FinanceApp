
namespace Proyecto4_Bolsa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hora_lbl = new System.Windows.Forms.Label();
            this.desplegable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.fecha_lbl = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            this.buscar_bttn = new System.Windows.Forms.Button();
            this.volver_bttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.puntos_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ratios_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.icono = new System.Windows.Forms.PictureBox();
            this.bandera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandera)).BeginInit();
            this.SuspendLayout();
            // 
            // hora_lbl
            // 
            this.hora_lbl.AutoSize = true;
            this.hora_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_lbl.ForeColor = System.Drawing.Color.Teal;
            this.hora_lbl.Location = new System.Drawing.Point(22, 452);
            this.hora_lbl.Name = "hora_lbl";
            this.hora_lbl.Size = new System.Drawing.Size(210, 51);
            this.hora_lbl.TabIndex = 0;
            this.hora_lbl.Text = "hh:mm:ss";
            this.hora_lbl.MouseEnter += new System.EventHandler(this.hora_lbl_MouseEnter);
            this.hora_lbl.MouseLeave += new System.EventHandler(this.hora_lbl_MouseLeave);
            // 
            // desplegable
            // 
            this.desplegable.BackColor = System.Drawing.Color.DarkCyan;
            this.desplegable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desplegable.ForeColor = System.Drawing.Color.White;
            this.desplegable.FormattingEnabled = true;
            this.desplegable.Items.AddRange(new object[] {
            "IBEX 35",
            "EUROSTOXX 50",
            "DAX 30",
            "DOW JONES 30",
            "NASDAQ 100",
            "CAC 40",
            "FTSE 100",
            "EURONEXT 100"});
            this.desplegable.Location = new System.Drawing.Point(15, 244);
            this.desplegable.Name = "desplegable";
            this.desplegable.Size = new System.Drawing.Size(248, 33);
            this.desplegable.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccionar Mercado de Valores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 432);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(15, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.AutoSize = true;
            this.fecha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lbl.ForeColor = System.Drawing.Color.Teal;
            this.fecha_lbl.Location = new System.Drawing.Point(90, 504);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(173, 32);
            this.fecha_lbl.TabIndex = 6;
            this.fecha_lbl.Text = "dd/mm/aaaa";
            this.fecha_lbl.MouseEnter += new System.EventHandler(this.fecha_lbl_MouseEnter);
            this.fecha_lbl.MouseLeave += new System.EventHandler(this.fecha_lbl_MouseLeave);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.Teal;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.SystemColors.Info;
            this.buscar.Location = new System.Drawing.Point(532, 28);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(253, 30);
            this.buscar.TabIndex = 8;
            // 
            // buscar_bttn
            // 
            this.buscar_bttn.BackColor = System.Drawing.Color.DarkCyan;
            this.buscar_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_bttn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscar_bttn.Location = new System.Drawing.Point(808, 21);
            this.buscar_bttn.Name = "buscar_bttn";
            this.buscar_bttn.Size = new System.Drawing.Size(120, 44);
            this.buscar_bttn.TabIndex = 9;
            this.buscar_bttn.Text = "Buscar";
            this.buscar_bttn.UseVisualStyleBackColor = false;
            this.buscar_bttn.Click += new System.EventHandler(this.buscar_bttn_Click);
            this.buscar_bttn.MouseEnter += new System.EventHandler(this.buscar_bttn_MouseEnter);
            this.buscar_bttn.MouseLeave += new System.EventHandler(this.buscar_bttn_MouseLeave);
            // 
            // volver_bttn
            // 
            this.volver_bttn.BackColor = System.Drawing.Color.DarkCyan;
            this.volver_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver_bttn.ForeColor = System.Drawing.SystemColors.Control;
            this.volver_bttn.Location = new System.Drawing.Point(955, 21);
            this.volver_bttn.Name = "volver_bttn";
            this.volver_bttn.Size = new System.Drawing.Size(119, 44);
            this.volver_bttn.TabIndex = 10;
            this.volver_bttn.Text = "Volver";
            this.volver_bttn.UseVisualStyleBackColor = false;
            this.volver_bttn.Click += new System.EventHandler(this.volver_bttn_Click);
            this.volver_bttn.MouseEnter += new System.EventHandler(this.volver_bttn_MouseEnter);
            this.volver_bttn.MouseLeave += new System.EventHandler(this.volver_bttn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(327, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 479);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // puntos_lbl
            // 
            this.puntos_lbl.AutoSize = true;
            this.puntos_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos_lbl.ForeColor = System.Drawing.Color.PowderBlue;
            this.puntos_lbl.Location = new System.Drawing.Point(75, 10);
            this.puntos_lbl.Name = "puntos_lbl";
            this.puntos_lbl.Size = new System.Drawing.Size(134, 29);
            this.puntos_lbl.TabIndex = 12;
            this.puntos_lbl.Text = "puntos_lbl";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.icono);
            this.panel2.Controls.Add(this.ratios_lbl);
            this.panel2.Controls.Add(this.puntos_lbl);
            this.panel2.Controls.Add(this.bandera);
            this.panel2.Location = new System.Drawing.Point(331, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 47);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ratios_lbl
            // 
            this.ratios_lbl.AutoSize = true;
            this.ratios_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratios_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ratios_lbl.Location = new System.Drawing.Point(281, 17);
            this.ratios_lbl.Name = "ratios_lbl";
            this.ratios_lbl.Size = new System.Drawing.Size(77, 20);
            this.ratios_lbl.TabIndex = 14;
            this.ratios_lbl.Text = "ratios_lbl";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.fecha_lbl);
            this.panel3.Controls.Add(this.hora_lbl);
            this.panel3.Controls.Add(this.desplegable);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 625);
            this.panel3.TabIndex = 13;
            // 
            // search_icon
            // 
            this.search_icon.Image = global::Proyecto4_Bolsa.Properties.Resources.icon_search;
            this.search_icon.Location = new System.Drawing.Point(483, 28);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(43, 30);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_icon.TabIndex = 16;
            this.search_icon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Proyecto4_Bolsa.Properties.Resources.logo_bolsa;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 184);
            this.panel4.TabIndex = 8;
            // 
            // icono
            // 
            this.icono.Location = new System.Drawing.Point(200, 4);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(66, 38);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 15;
            this.icono.TabStop = false;
            // 
            // bandera
            // 
            this.bandera.Location = new System.Drawing.Point(3, 4);
            this.bandera.Name = "bandera";
            this.bandera.Size = new System.Drawing.Size(66, 38);
            this.bandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bandera.TabIndex = 13;
            this.bandera.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1088, 625);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.volver_bttn);
            this.Controls.Add(this.buscar_bttn);
            this.Controls.Add(this.buscar);
            this.Name = "Form1";
            this.Text = "finance App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hora_lbl;
        private System.Windows.Forms.ComboBox desplegable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Label fecha_lbl;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button buscar_bttn;
        private System.Windows.Forms.Button volver_bttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label puntos_lbl;
        private System.Windows.Forms.PictureBox bandera;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ratios_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.PictureBox search_icon;
    }
}

