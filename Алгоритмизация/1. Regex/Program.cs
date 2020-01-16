using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            // У avito есть проблемки с кодировкой, устанавливаем ожидаемую кодировку строки
            client.Encoding = ASCIIEncoding.UTF8;
            string htmlCode = client.DownloadString("https://avito.ru/perm/zhivotnye");

            // Паттерн для поиска заголовка в Desktop версии сайта
            string pattern = @"<h3 class=""snippet-title"".+title="".+"">\s*(.+?)\s*<\/a>.+<div class=""about""";
            // Паттерн для поиска цены в Desktop версии сайта
            pattern += @".*data-marker=""item-price"">\s*([\d,\w,\s]+)\s*.+span";
            // Оба паттерна объединяем в одну строку, чтобы искать одним вызовом регулярки

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            
            // Преобразуем все HTML-коды в нормальные символы
            htmlCode = WebUtility.HtmlDecode(htmlCode);

            Match match = null;
            string sub = String.Empty;
            string[] lines = Regex.Split(htmlCode, @"<div class=""item_table-wrapper"">");
            foreach (string line in lines)
            {
                // Для уменьшения объемов обрабатываемой информации, обрезаем строку до 100 символов (можно и меньше)
                sub = line.Substring(0, 1000); 
                // Ищем совпадения в строке из 1000 символов 
                match = reg.Match(sub);
                // Если совпадение имеется, то будет True
                if (match.Success)
                {
                    // Выводим название объявления (кажется максимальная длина названия 50) и цену/Бесплатно/и т.д.
                    Console.WriteLine($"{match.Groups[1],-50}\t{match.Groups[2]}");
                }
            }

            /*
            WebClient client_m = new WebClient();
            client_m.Encoding = ASCIIEncoding.UTF8;
            // Если установить UserAgent для Клиента, то можно и на Мобильную версию шагать
            // тогда, цены будут красивее парситься 
            // + дешевле по времени
            client_m.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Linux; Android 4.4.2; Nexus 4 Build/KOT49H) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.114 Mobile Safari/537.36");
            string htmlCode_m = client_m.DownloadString("https://m.avito.ru/perm/zhivotnye");

            string pattern_m = @"itemProp=""name"">(.+?)<.+itemProp=""price"".+?>(.+?)<";
            Regex reg_m = new Regex(pattern_m, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            // Преобразуем все HTML-коды в нормальные символы
            htmlCode_m = WebUtility.HtmlDecode(htmlCode_m);
            Match match_m = null;
            string[] lines_m = Regex.Split(htmlCode_m, @"data-marker=""item\/link""");
            foreach (string line in lines_m)
            {
                match_m = reg_m.Match(line);
                // Если совпадение имеется, то будет True
                if (match_m.Success)
                {
                    // Выводим название объявления (кажется максимальная длина названия 50) и цену/Бесплатно/и т.д.
                    Console.WriteLine($"{match_m.Groups[1],-50}\t{match_m.Groups[2],-20}");
                }
            }
            */
        }
    }
}


