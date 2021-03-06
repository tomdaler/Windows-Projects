using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla.RepEmpl
{
    public partial class Observaciones : Form
    {
        public Observaciones()
        {
            InitializeComponent();
        }

        private void Observaciones_Load(object sender, EventArgs e)
        {
            string sql = "select DUI, nombre_usual as Nombre, Observacion from Empleado where Observacion<>''";
            Funciones fx = new Funciones();
            DataTable dt = fx.GetData(sql, "");
            if (dt.Rows.Count > 0)
            {
                dgObs.DataSource = dt;
                dgObs.Visible = true;
                dgObs.Columns[1].Width = 130;
            }
            else
                dgObs.Visible = false;
        }
    }
}
