using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = "SELECT * From Seguridad ";

            Funciones fx = new Funciones();
            DataTable dt = fx.GetData(sql, "");

            dGrid1.DataSource = dt;
            dGrid1.Visible = true;
            dGrid1.Columns[0].Visible = false;

            dGrid1.Columns[1].Width = 70;
            dGrid1.Columns[2].Width = 70;
            dGrid1.Columns[3].Width = 70;

            dGrid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Seguridad_Load(object sender, EventArgs e)
        {
            cbNivel.Items.Insert(0, "Administrador");
            cbNivel.Items.Insert(1, "Planillero");
            cbNivel.Items.Insert(2, "Contador");
            cbNivel.Items.Insert(3, "Digitador");
            cbNivel.Items.Insert(4, "Solo Ver");

            cbNivel.SelectedIndex = 4;

            LoadData();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = " insert into seguridad (CLAVE, USUARIO, NIVEL ) VALUES (";
            sql = sql + " '" + txClave.Text.Trim() + "',";
            sql = sql + " '" + txRef.Text.Trim() + "',";
            sql = sql + cbNivel.SelectedIndex.ToString() + ") ";

            Funciones fx = new Funciones();
            fx.UpdateData(sql);

            LoadData();
        }

        private void dGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;
            lbCod.Text = dGrid1.Rows[row].Cells[0].Value.ToString();
            txClave.Text = dGrid1.Rows[row].Cells[1].Value.ToString();
            txRef.Text = dGrid1.Rows[row].Cells[2].Value.ToString();
            int nivel = Convert.ToInt32(dGrid1.Rows[row].Cells[3].Value.ToString());
            cbNivel.SelectedIndex = nivel;
        }

        private void txProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " Update seguridad set clave ='" + txClave.Text.Trim() + "', ";
            sql = sql + " USUARIO='"+txRef.Text.Trim() + "', ";
            sql = sql + " nivel =" + cbNivel.SelectedIndex.ToString();
            sql = sql + " where id=" + lbCod.Text;
            Funciones fx = new Funciones();
            fx.UpdateData(sql);
        }
    }
}
