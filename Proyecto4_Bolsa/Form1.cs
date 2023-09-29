using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Proyecto4_Bolsa
{
    public partial class Form1 : Form
    {
        int tick;
        string url;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            buscar_bttn.Visible = false;
            buscar.Visible = false;
            volver_bttn.Visible = false;
            puntos_lbl.Visible = false;
            bandera.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            search_icon.Visible = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;

            dataGridView1.ColumnCount = 9;
            dataGridView1.RowCount = 1;

            dataGridView1.Columns[0].Name = "Valor";

            dataGridView1.Columns[1].Name = "Último";

            dataGridView1.Columns[2].Name = "Variación [%]";

            dataGridView1.Columns[3].Name = "Acumulado Anual";

            dataGridView1.Columns[4].Name = "Máximo";

            dataGridView1.Columns[5].Name = "Mínimo";

            dataGridView1.Columns[6].Name = "Volumen Acciones";

            dataGridView1.Columns[7].Name = "Capitalización";

            dataGridView1.Columns[8].Name = "Hora";


        }

        public void Load_Data(string mercado)
        {
            dataGridView1.Visible = true;
            buscar_bttn.Visible = true;
            buscar.Visible = true;
            search_icon.Visible = true;

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(mercado);

            int i = 1;
            string nombre;
            string ultimo;
            string variacion;
            string acumulado;
            string max;
            string min;
            string volumen;
            string capitalizacion;
            string hora;

            while (doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[1]/a") != null)
            {
                foreach (var id in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[1]/a"))
                {
                    nombre = id.InnerText;

                    foreach (var id2 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[2]"))
                    {
                        ultimo = id2.InnerText;

                        foreach (var id3 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[3]"))
                        {
                            variacion = id3.InnerText;

                            foreach (var id4 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[5]"))
                            {
                                acumulado = id4.InnerText;

                                foreach (var id5 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[6]"))
                                {
                                    max = id5.InnerText;

                                    foreach (var id6 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[7]"))
                                    {
                                        min = id6.InnerText;

                                        foreach (var id7 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[8]"))
                                        {
                                            volumen = id7.InnerText;

                                            foreach (var id8 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[9]"))
                                            {
                                                capitalizacion = id8.InnerText;

                                                foreach (var id9 in doc.DocumentNode.SelectNodes("//*[@id='listado_valores']/tbody/tr[" + i + "]/td[10]"))
                                                {
                                                    hora = id9.InnerText;

                                                    dataGridView1.Rows.Add(nombre, ultimo, variacion, acumulado, max, min, volumen, capitalizacion, hora);
                                                }
                                            }
                                        }
                                    }
                                }

                            }


                        }

                    }

                }
                i++;
            }

            i = 0;
            double valor;
            while (i<dataGridView1.Rows.Count)
            {
                valor = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                if (valor>0)
                {
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }

                i++;
            }

            try
            {
                puntos_lbl.Visible = true;
                foreach (var puntos in doc.DocumentNode.SelectNodes("//*[@id='datos_principales_indice']/ul/li[1]"))
                {
                    puntos_lbl.Text = puntos.InnerText; 
                }
            }

            catch
            {
                puntos_lbl.Visible = false;
            }

            bandera.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            switch (desplegable.Text)
            {
                case "IBEX 35":
                    {
                       bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_esp.png");
                       
                        break;
                    }
                case "DOW JONES 30":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_us.jpg");
                        break;
                    }

                case "EUROSTOXX 50":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_eu.png");
                        break;
                    }
                case "DAX 30":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_al.png");
                        break;
                    }

                case "NASDAQ 100":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_us.jpg");
                        break;
                    }

                case "FTSE 100":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_uk.png");
                        break;
                    }

                case "CAC 40":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_fr.png");
                        break;
                    }
                case "EURONEXT 100":
                    {
                        bandera.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/bandera_eu.png");
                        break;
                    }

                    }

            try
            {
                ratios_lbl.Visible = true;
                foreach (var ratios in doc.DocumentNode.SelectNodes("//*[@id='datos_principales_indice']/ul/li[2]/span"))
                {
                    ratios_lbl.Text = ratios.InnerText;
                }
            }

            catch
            {
                ratios_lbl.Visible = false;
            }

            string ratios_valores = ratios_lbl.Text;
            string[] ratios_vector = ratios_valores.Split(' ');
            string[] ratios_variacion = ratios_vector[1].Split('%');
           
            if (Convert.ToDouble(ratios_vector[0])>0)
            {
                icono.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/icon_up.png");
                ratios_lbl.ForeColor = Color.LimeGreen;
            }
            else
            {
                icono.Image = Image.FromFile("C:/Users/USUARIO/Documents/PROYECTOS C#/Proyecto4_Bolsa/Proyecto4_Bolsa/bin/Debug/icon_down.png");
                ratios_lbl.ForeColor = Color.Red;
            }

            this.tick = 0;

        }//Cargar datos de tabla

        private void button1_Click(object sender, EventArgs e)
        {
            
            string mercado = desplegable.Text;
            try 
            {
                switch (mercado)
                {
                    case "IBEX 35":
                        {
                            string url = "https://www.expansion.com/mercados/cotizaciones/indices/ibex35_I.IB.html";
                            Load_Data(url);
                            break;
                        }

                    case "DOW JONES 30":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/dowjones_I.NY.html";
                            Load_Data(url);
                            break;
                        }

                    case "EUROSTOXX 50":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/eurostoxx_I.5E.html";
                            Load_Data(url);
                            break;
                        }
                    case "DAX 30":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/dax_I.DI.html";
                            Load_Data(url);
                            break;
                        }

                    case "NASDAQ 100":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/nasdaq100_I.QQ.html";
                            Load_Data(url);
                            break;
                        }

                    case "FTSE 100":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/ftse100_I.LE.html";
                            Load_Data(url);
                            break;
                        }

                    case "CAC 40":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/cac40_I.PB.html";
                            Load_Data(url);
                            break;
                        }
                    case "EURONEXT 100":
                        {
                            this.url = "https://www.expansion.com/mercados/cotizaciones/indices/euronext100_I.EN.html";
                            Load_Data(url);
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Compruebe su conexión a internet");
            }
            
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            hora_lbl.Text = DateTime.Now.ToLongTimeString();
            fecha_lbl.Text = DateTime.Now.ToShortDateString();

            if (this.url!=null)
            {
                if (this.tick == 800)
                {
                    this.tick = 0;
                    Load_Data(url);
                }
                
            }
            if (this.tick==800)
            {
                this.tick = 0;
            }
            this.tick++;
        }

        private void buscar_bttn_Click(object sender, EventArgs e)
        {
            if (buscar.Text!="")
            {
                int i = 0;
                bool encontrado = false;
                volver_bttn.Visible = true;

                while ((!encontrado) && (i < dataGridView1.Rows.Count))
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == buscar.Text)
                    {
                        encontrado = true;
                    }
                    i++;
                }

                if (encontrado == true)
                {
                    i = i - 1;

                    string nombre = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    string ultimo = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    string variacion = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    string acumulado = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    string max = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    string min = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    string volumen = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    string capitalizacion = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    string hora = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value);

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();

                    dataGridView1.Rows.Add(nombre, ultimo, variacion, acumulado, max, min, volumen, capitalizacion, hora);

                }
                else
                {
                    MessageBox.Show("No hay resultados");
                }
                buscar.Text = "";
            }
            else
            {

            }
        }

        private void volver_bttn_Click(object sender, EventArgs e)
        {
            string mercado = desplegable.Text;
            volver_bttn.Visible = false;

            switch (mercado)
            {
                case "IBEX 35":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/ibex35_I.IB.html";
                        Load_Data(url);
                        break;
                    }

                case "DOW JONES 30":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/dowjones_I.NY.html";
                        Load_Data(url);
                        break;
                    }

                case "EUROSTOXX 50":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/eurostoxx_I.5E.html";
                        Load_Data(url);
                        break;
                    }
                case "DAX 30":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/dax_I.DI.html";
                        Load_Data(url);
                        break;
                    }

                case "NASDAQ 100":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/nasdaq100_I.QQ.html";
                        Load_Data(url);
                        break;
                    }

                case "FTSE 100":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/ftse100_I.LE.html";
                        Load_Data(url);
                        break;
                    }

                case "CAC 40":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/cac40_I.PB.html";
                        Load_Data(url);
                        break;
                    }
                case "EURONEXT 100":
                    {
                        string url = "https://www.expansion.com/mercados/cotizaciones/indices/euronext100_I.EN.html";
                        Load_Data(url);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }

        private void buscar_bttn_MouseEnter(object sender, EventArgs e)
        {
            buscar_bttn.BackColor = Color.DodgerBlue;
        }

        private void buscar_bttn_MouseLeave(object sender, EventArgs e)
        {
            buscar_bttn.BackColor = Color.DarkCyan;
        }

        private void volver_bttn_MouseEnter(object sender, EventArgs e)
        {
            volver_bttn.BackColor = Color.DodgerBlue;
        }

        private void volver_bttn_MouseLeave(object sender, EventArgs e)
        {
            volver_bttn.BackColor = Color.DarkCyan;
        }

        private void hora_lbl_MouseEnter(object sender, EventArgs e)
        {
            hora_lbl.ForeColor = Color.DodgerBlue;
        }

        private void hora_lbl_MouseLeave(object sender, EventArgs e)
        {
            hora_lbl.ForeColor = Color.DarkCyan;
        }

        private void fecha_lbl_MouseEnter(object sender, EventArgs e)
        {
            fecha_lbl.ForeColor = Color.DodgerBlue;
        }

        private void fecha_lbl_MouseLeave(object sender, EventArgs e)
        {
            fecha_lbl.ForeColor = Color.DarkCyan;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Transparent, ButtonBorderStyle.Solid);
        }
    }
}
