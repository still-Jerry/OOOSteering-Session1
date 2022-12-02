using System;
using System.IO;
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
    public partial class ViewForm : Form
    {
        static List<string> ProductArticleNumber = new List<string>();
        static List<string> ProductName = new List<string>();
        static List<string> ProductDescription = new List<string>();
        static List<string> ProductPhoto = new List<string>();
        static List<string> ProductManufacturer = new List<string>();
        static List<string> ProductCost = new List<string>();
        static  List<string> ProductDiscountAmount = new List<string>();
         static Int32 AllNotes = ProductArticleNumber.Count();
         static Int32 NoteNow =0;
         static Int32 Page = 1;
        public ViewForm()
        {
            InitializeComponent();
            SQLClass.SelectProductFromBD(ProductArticleNumber, ProductName,
                        ProductDescription,ProductPhoto,ProductManufacturer,
                        ProductCost, ProductDiscountAmount);
            FillGroupBoxes();
            AllNotes = ProductArticleNumber.Count();
            NotesLable.Text = (NoteNow+2) + "\n" + AllNotes;
            if (NoteNow%2==0){
                PagesLable.Text = Page + " из " + AllNotes / 2;
            }{
                PagesLable.Text = Page + " из " + (AllNotes / 2 + 1);
            
            }
        }
        public void FillGroupBoxes() {
            //try
            //{
           
                groupBox1.Visible = true;
                NameLable1.Text = ProductName[NoteNow];
                DisctroptionTextBox1.Text = ProductDescription[NoteNow];
                ManufactureLabel1.Text = ProductManufacturer[NoteNow];

                DiscountlLabel1.Text = ProductDiscountAmount[NoteNow]+"%";

                OldCost1.Text = ProductCost[NoteNow];
                DisctroptionTextBox1.Text = ProductDescription[NoteNow];
               
                NewCost1.Text = Convert.ToString(Convert.ToDouble(ProductCost[NoteNow]) * (100 - Convert.ToDouble(ProductDiscountAmount[NoteNow])) / 100);
                if (NewCost1.Text == OldCost1.Text)
                {
                    OldCost1.Visible = false;

                }
                else {
                    OldCost1.Visible = true;
                }
            //}
            //catch { 
            //}

            try
            {
                groupBox2.Visible = true;
                NameLable2.Text = ProductName[NoteNow+1+1];
                DisctroptionTextBox2.Text = ProductDescription[NoteNow+1];
                ManufactureLabel2.Text = ProductManufacturer[NoteNow+1];

                DiscountlLabel2.Text = ProductDiscountAmount[NoteNow + 1] + "%";

                OldCost2.Text = ProductCost[NoteNow+1];
                DisctroptionTextBox2.Text = ProductDescription[NoteNow+1];
                NewCost2.Text = (Convert.ToDouble(ProductCost[NoteNow + 1]) * (100 - Convert.ToDouble(ProductDiscountAmount[NoteNow + 1])) / 100).ToString();
                if (NewCost2.Text == OldCost2.Text)
                {
                    OldCost2.Visible = false;

                }
                else
                {
                    OldCost2.Visible = true;
                }
            }
            catch
            {
            }
        
        
        }
        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AutorizationForm Form = new AutorizationForm();
            this.Visible = false;
            Form.ShowDialog();
           
        }

    }
}
