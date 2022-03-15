using PrinterClass;

namespace GreenPrinterClass
{
    public class GreenPrinter : Printer
    {
        public override void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(text);
            Console.ResetColor();
        }
    }
}