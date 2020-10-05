using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graden
{
    public partial class frmTermometer : Form
    {
        public frmTermometer()
        {
            InitializeComponent();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            txtGradenCelsius.Text = "";
            txtFahrenheit.Text = "";
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            decimal Graden;
            decimal Farenheit;

            Graden = Convert.ToInt32 (txtGradenCelsius.Text);

            Farenheit = ((decimal)9.0 / 5) * Graden + 32;

            txtFahrenheit.Text = Convert.ToString (Farenheit);

        }
    }
}
