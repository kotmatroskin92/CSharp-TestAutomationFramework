using System;
using System.Linq;

namespace Test.utils
{
    public static class DateMapper
    {
        private static readonly  string[] Months = 
        {
            "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября",
            "ноября", "декабря"
        };
       
        public static string ConvertDate(string stringValue)
        {
            return stringValue switch
            {
                "сегодня" => DateTime.Now.ToShortDateString(),
                "вчера" => DateTime.Now.AddDays(-1).ToShortDateString(),

                _ => Replace(stringValue)
            };
        }

        private static string Replace(string stringValue)
        {
            var result = stringValue;
            var year = DateTime.Now.ToString("yy");
      

            var sKeyResult = Months.FirstOrDefault(stringValue.Contains);

            result = sKeyResult switch
            {
                "января" => stringValue.Replace("января", $".02.{year}"),
                "февраля" => stringValue.Replace("февраля", $".02.{year}"),
                _ => result
            };

            return DateTime.ParseExact(result.Replace(" ", string.Empty), "d.MM.yy",
                null).ToShortDateString();
        }
    }
}