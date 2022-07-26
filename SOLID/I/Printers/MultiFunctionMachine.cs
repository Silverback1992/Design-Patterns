using SOLID.I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.Printers
{
    //And here you can implement your IMultiFunctionDevice interface that inherits from the smaller, perfectly segregated interfaces
    public class MultiFunctionMachine : IMultiFunctionDevice
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
