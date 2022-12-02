using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ООО__Рулевой_.Modules
{
    class ViewClass
    {
        public static  string  GetRandom() {
            Random rnd = new Random();
            string alf = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
           
            return alf[rnd.Next(alf.Count())].ToString();
        }
    }
}
