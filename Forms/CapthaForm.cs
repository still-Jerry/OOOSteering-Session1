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
    using ViewClass = Modules.ViewClass;
    public partial class CapthaForm : Form
    {
        public CapthaForm()
        {
            InitializeComponent();
            Change();
        }
        public void Change() {
            Random rnd = new Random();
            string alf = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";


            label1.Text = alf[rnd.Next(alf.Count())].ToString();
            label2.Text = alf[rnd.Next(alf.Count())].ToString();
            label3.Text = alf[rnd.Next(alf.Count())].ToString();
            label4.Text = alf[rnd.Next(alf.Count())].ToString();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void OKBbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text + label2.Text + label3.Text + label4.Text)
            {
                this.Visible = false;

            }
            else {
                textBox1.Text = "";
                Change();
            }
        }

 
    }
}
