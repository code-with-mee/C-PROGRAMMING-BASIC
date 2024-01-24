using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com1 = _20_Namespace.Model;
using com2 = Company.Organization;
using Marketing;
using Marketing.Operation;
using Sale;
using Sale.Operation;

namespace Company
{
    internal class Demo
    {
        public void Run()
        {
            ClsSale clsSale = new ClsSale();
            clsSale.Print();

            ClsOperation co = new ClsOperation();   
            co.Print();

            ClsMarketing  cm = new ClsMarketing();  
            cm.Print();

            MarketingOperation mo = new MarketingOperation();   
            mo.Print();

            com1.Staff staff = new com1.Staff();
            staff.Print();

            com2.Staff staff2 = new com2.Staff();

            //Console.WriteLine("");
            WriteLine("hello world");
        }
    }
}
