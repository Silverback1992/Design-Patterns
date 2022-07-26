using SOLID.I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.Printers
{
    //You can also implement the IMultiFunctionDevice using the decorator pattern
    public class MultiFunctionMachineDecorator : IMultiFunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;
        private IFaxer _faxer;

        public MultiFunctionMachineDecorator(IPrinter printer, IScanner scanner, IFaxer faxer)
        {
            if (printer == null)
                throw new ArgumentNullException(paramName: nameof(printer));

            if (scanner == null)
                throw new ArgumentNullException(paramName: nameof(scanner));

            if (faxer == null)
                throw new ArgumentNullException(paramName: nameof(faxer));

            _printer = printer;
            _scanner = scanner;
            _faxer = faxer;
        }

        public void Fax(Document d)
        {
            _faxer.Fax(d);
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }
}
