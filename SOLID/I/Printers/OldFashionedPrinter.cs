using SOLID.I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.Printers
{
    //But we have a problem here since OldFashionedPrinter can't scan or fax and can only print
    //So what should you do with the other methods that you need to implement?
    //There are ways but none of them is pretty, we are violating the Interface Segregation principle here
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
