using PrinterClass;

namespace BluePrinterClass
{
    public class BluePrinter : Printer
    {
        public override void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(text);
            Console.ResetColor();
        }
    }
}