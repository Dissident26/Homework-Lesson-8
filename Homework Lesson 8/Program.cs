using RoomClass;
using PrinterClass;
using GreenPrinterClass;
using BluePrinterClass;

Room room = new Room();

Printer basePrinter = new Printer();
GreenPrinter greenPrinter = new GreenPrinter();
BluePrinter bluePrinter = new BluePrinter();

Printer[] printers = { basePrinter, greenPrinter, bluePrinter };

foreach (var printer in printers)
{
    room.attachPrinter(printer);
    room.MakeThisLazyPrinterWork("Random text");
}