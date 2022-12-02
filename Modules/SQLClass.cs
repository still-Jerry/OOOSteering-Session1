using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ООО__Рулевой_.Modules
{

    class SQLClass
    {
        public static MySqlConnection Connect(){
            try
            {
                String con = "host=localhost; uid=root; pwd=root;database=trade2";
                MySqlConnection Connect = new MySqlConnection(con);
                Connect.Open();
                return Connect;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }
        public static void SelectProductFromBD(List<string> ProductArticleNumber, List<string> ProductName, 
            List <string> ProductDescription,List <string> ProductPhoto,List <string> ProductManufacturer,
            List <string> ProductCost,List <string> ProductDiscountAmount)
        {
            try
            {
                ProductArticleNumber.Clear();
                ProductName.Clear();
                ProductDescription.Clear();
                ProductPhoto.Clear();
                ProductManufacturer.Clear();
                ProductCost.Clear();
                ProductDiscountAmount.Clear();
                String cmd = "SELECT ProductArticleNumber, ProductName, ProductDescription,"+
                    "ProductPhoto, ProductManufacturer, ProductCost, ProductDiscountAmount  FROM trade2.product;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while(reader.Read()){
                    ProductArticleNumber.Add(reader[0].ToString());
                    ProductName.Add(reader[1].ToString());
                    ProductDescription.Add(reader[2].ToString());
                    ProductPhoto.Add(reader[3].ToString());
                    ProductManufacturer.Add(reader[4].ToString());
                    ProductCost.Add(reader[5].ToString());
                    ProductDiscountAmount.Add(reader[6].ToString());

                }
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
               
            }
        }
        
    }
}
