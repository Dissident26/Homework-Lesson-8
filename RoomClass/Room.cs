using PrinterClass;

namespace RoomClass
{
    public class Room
    {
        Printer? printer;
        public void MakeThisLazyPrinterWork(string value)
        {
            if(printer == null) {
                throw new ArgumentNullException("Принтер не установлен!");
            }

            printer.Print(value);

        }

        public void attachPrinter(Printer printer)
        {
            this.printer = printer;
        }
    }
}