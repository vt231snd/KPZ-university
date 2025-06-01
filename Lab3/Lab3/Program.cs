using Lab3.Bridge;
using Lab3.Decorator;
using Lab3.Proxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lab3.LightHTML.Node;
using Lab3.LightHTML;

namespace Lab3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //1Адаптер
            Console.OutputEncoding = Encoding.UTF8;
            Logger logger = new Logger();
            logger.Log("Інформаційне повідомлення");
            logger.Error("Повідомлення помилки");
            logger.Warn("Попередження");


            LoggerAdapter file_logger = new LoggerAdapter(new FileWriter("file_adapter.txt"));
            file_logger.Log("Інформаційне повідомлення");
            file_logger.Error("Повідомлення помилки");
            file_logger.Warn("Попередження");

            Console.WriteLine("Логи записано у файл file_adapter.txt");
            Console.WriteLine("-----------\n");


            //2Декоратор
            Random random = new Random();

            // Створюємо випадкового персонажа
            Characters character = new Warrior(); // Можна замінити на Mage або Paladin
            Console.WriteLine($"Початковий персонаж: {character.GetInfo()}, Сила: {character.GetStrength()}");

            int item = random.Next(1, 4);

            for (int i = 0; i < item; i++)
            {
                int type_staf = random.Next(1, 4);

                switch (type_staf)
                {
                    case 1:
                        character = new Outfit(character);
                        Console.WriteLine($"- Додано броню: {character.GetInfo()}, Сила: {character.GetStrength()}");
                        break;
                    case 2:
                        character = new Weapon(character);
                        Console.WriteLine($"- Додано зброю: {character.GetInfo()}, Сила: {character.GetStrength()}");
                        break;
                    case 3:
                        character = new Artifact(character);
                        Console.WriteLine($"- Додано артефакт: {character.GetInfo()}, Сила: {character.GetStrength()}");
                        break;
                }
            }

            Console.WriteLine($"Споряджений персонажа: {character.GetInfo()}, Сила: {character.GetStrength()}");
            Console.WriteLine("-----------\n");


            //3Міст
            Render vectorRenderer = new Vector();
            Render rasterRenderer = new Rastred();

            Shape circle = new Circle(rasterRenderer);
            Shape square = new Square(rasterRenderer);
            Shape triangle = new Triangle(vectorRenderer);

            square.Draw();
            circle.Draw();
            triangle.Draw();
            Console.WriteLine("-----------\n");


            //4Проксі
            string filePath = "file1.txt";

            SmartTextReader smartTextReader = new SmartTextReader();

            SmartTextChecker textChecker = new SmartTextChecker(smartTextReader);

            SmartTextReaderLocker textLocker = new SmartTextReaderLocker(".*forbidden.*");

            Console.WriteLine("Читання з обмеженням доступу:");
            textLocker.ReadFile(filePath);

            Console.WriteLine("\nЧитання з логуванням:");
            textChecker.ReadFile(filePath);
            Console.WriteLine("-----------\n");


            //5Компонувальник
            var table = new LightElementNode("table", ViewType.Block, CloseType.Normal);
            table.AddClass("styled-table");

            var headerRow = new LightElementNode("tr", ViewType.Block, CloseType.Normal);
            var header1 = new LightElementNode("th", ViewType.Inline, CloseType.Normal);
            header1.AddChild(new LightTextNode("Ім’я"));
            var header2 = new LightElementNode("th", ViewType.Inline, CloseType.Normal);
            header2.AddChild(new LightTextNode("Вік"));
            headerRow.AddChild(header1);
            headerRow.AddChild(header2);

            var dataRow1 = new LightElementNode("tr", ViewType.Block, CloseType.Normal);
            var cell1 = new LightElementNode("td", ViewType.Inline, CloseType.Normal);
            cell1.AddChild(new LightTextNode("Софія"));
            var cell2 = new LightElementNode("td", ViewType.Inline, CloseType.Normal);
            cell2.AddChild(new LightTextNode("19"));
            dataRow1.AddChild(cell1);
            dataRow1.AddChild(cell2);

            var dataRow2 = new LightElementNode("tr", ViewType.Block, CloseType.Normal);
            var cell3 = new LightElementNode("td", ViewType.Inline, CloseType.Normal);
            cell3.AddChild(new LightTextNode("В'ячеслав"));
            var cell4 = new LightElementNode("td", ViewType.Inline, CloseType.Normal);
            cell4.AddChild(new LightTextNode("20"));
            dataRow2.AddChild(cell3);
            dataRow2.AddChild(cell4);

            table.AddChild(headerRow);
            table.AddChild(dataRow1);
            table.AddChild(dataRow2);

            Console.WriteLine("- Таблиця -\n");
            Console.WriteLine("OuterHTML:\n" + table.OuterHTML);
            Console.WriteLine("\nInnerHTML:\n" + table.InnerHTML);
            Console.WriteLine("-----------\n");


            //6Легковаговик
            string bookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";

            Console.WriteLine("Завантаження книги...");
            WorkwBook parser = new WorkwBook();

            long memoryBefore = Memory.GetMemoryUsage();
            LightElementNode bookHtml = await parser.ParseBookAsync(bookUrl);
            long memoryAfter = Memory.GetMemoryUsage();

            Console.WriteLine("Генерація HTML завершена!");
            Console.WriteLine($"Використання пам'яті до: {memoryBefore} байт");
            Console.WriteLine($"Використання пам'яті після: {memoryAfter} байт");
            Console.WriteLine($"Різниця: {memoryAfter - memoryBefore} байт");
            
            string htmlContent = $"<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"UTF-8\">\n<title>Book</title>\n</head>\n<body>\n{bookHtml.OuterHTML}\n</body>\n</html>";
            
            File.WriteAllText("book.html", htmlContent);
            Console.WriteLine("HTML збережено у файл book.html");


        }
    }
}
