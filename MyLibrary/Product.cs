using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Product (int id,string name, decimal unitPrice, int unitInStock)
    {
        public int Id  => id;
        public string Name  => name;
        public decimal UnitPrice  => unitPrice;
        public int UnitsInStock  => unitInStock;
        public bool Discontinued { get; set; }
        public void setDiscontinued() => Discontinued = true;
        public bool GetStatus()=>Discontinued;
    }



    //public class Product2 (int id, string name,
        //bool discontinued) 
        //: Product (id,name,default,default)
    //{ 
       // public bool Discontinued { get; set; } = discontinued;
   // }

}
