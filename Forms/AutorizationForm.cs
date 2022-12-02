using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО__Рулевой_.Forms
{
    using SQLClass = Modules.SQLClass;
    using BussnessClass = Modules.BussnessClass;
    using ViewClass = Modules.ViewClass;
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewForm Form = new ViewForm();
            this.Visible = false;
            Form.ShowDialog();
           
        }
    }
}
