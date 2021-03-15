using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = TimeConversion(s);
        }

        static string TimeConversion(string s)
        {
            var isBeforeNoon = s.Contains("AM") ? true : false;
            s = s.Replace("AM", string.Empty).Replace("PM", string.Empty);
            var h = s.Split(':');
            if (isBeforeNoon)
            {
                var hora = h[0] == "12" ? "00" : h[0];
                return $"{hora}:{h[1]}:{h[2]}";
            }
            else
            {
                var horaTarde = h[0] == "12" ? "12" : (int.Parse(h[0]) + 12).ToString();
                return $"{horaTarde}:{h[1]}:{h[2]}";
            }

        }
    }
}
