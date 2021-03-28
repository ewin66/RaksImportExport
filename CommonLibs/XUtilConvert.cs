using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class XUtilConvert


    {


        private static string[,] _znakiHtml = new string[8, 2] { { "&", "&amp;" }, { "<", "&lt;" }, { ">", "&gt;" }, { "\"", "&quot;" }, { "\r\n", "<br>" }, { "\n", "<br>" }, { "+chr(10)+", "<br>" }, { "'", "&#39;" } };

        //------------------------------------------------------------------------------------
        // funkcje do konwersji z klasy SqlDataReader

        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na string
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static string IsNullString(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return string.Empty;
            else
                return rdr.ToString().Trim();
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na int
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static int IsNullInt(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return 0;
            else
                return (int)rdr;
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na byte (sql to tinyint)
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static byte IsNullByte(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return 0;
            else
                return (byte)rdr;
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na decimal (sql to numeric lub decimal)
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static decimal IsNullDecimal(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return 0;
            else
                return (Decimal)rdr;
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na bool (sql to tinyint)
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static bool IsNullBool(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return false;
            else
            {
                if ((byte)rdr == 0)
                    return false;
                else
                    return true;
            };
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na DateTime (sql to DateTime), jeśli jest null to ustawiam YEmptyDateTime();
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static DateTime IsNullDateTime(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return DateTime.MinValue;
            else
                return (DateTime)rdr;
        }
        /// <summary>
        /// IsNull na obiekcie SqlDataReader rzutowanym na Guid (sql to uniqueidentifier), jeśli jest null to ustawiam Empty
        /// </summary>
        /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
        public static Guid IsNullGuid(object rdr)
        {
            if (rdr == null || rdr == DBNull.Value)
                return Guid.Empty;
            else
                return (Guid)rdr;
        }

        //Funkcje do konwersji na string 
        /// <summary>
        /// Funkcja konwertuje null na pusty łańcuch znaków
        /// </summary>
        /// <param name="str">Konwertowany łańcuch znaków</param>
        public static string IsNull(string str)
        {
            if (str != null)
                return str;
            else
                return string.Empty;
        }
        /// <summary>
        /// Funkcja konwertuje null na pusty łańcuch znaków
        /// </summary>
        /// <param name="str">Konwertowany łancuch znaków</param>
        /// <param name="is_null">Wartość domyślna, jeśli konwertowany łańcuch znaków jest null</param>
        public static string IsNull(string str, string is_null)
        {
            if (str != null)
                return str;
            else
                return is_null;
        }
        /// <summary>
        /// Konwertuje łańcuch znaków (string) do liczby całkowitej (int), jeśli błąd konwersji zwraca 0
        /// </summary>
        /// <param name="n">Konwertowany łańcuch znaków</param>
        public static int StringToInt(string n)
        {
            try
            {
                return int.Parse(n);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// Konwertuje łańcuch znaków (string) do liczby całkowitej (int), jeśli błąd konwersji zwraca wartość domyślną
        /// 
        /// </summary>
        /// <param name="n">Konwertowany łańcuch znaków</param>
        /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
        /// wycofana zamiast tego uzywac int.Parse();
        [Obsolete("Method is deprecated, please use int.Parse() instead.")]
        public static int StringToInt(string n, int d)
        {
            try
            {
                return int.Parse(n);
            }
            catch
            {
                return d;
            }
        }
        [Obsolete("Method is deprecated, please use decimal.Parse() instead.")]
        public static decimal StringToDecimal(string n)
        {
            if (n == null)
                return 0;

            n = n.Replace(" ", "");
            try
            {
                decimal b = decimal.Parse(n);
                return b;
            }
            catch
            {

            }

            if (n.Length > 3 && n.Substring(n.Length - 3, 1) == ",")
            {
                n = n.Replace(".", "");
            }

            if (n.Length > 3 && n.Substring(n.Length - 3, 1) == ".")
            {
                n = n.Replace(",", "");
            }


            try
            {
                n = n.Replace(",", ".");
                decimal res = decimal.Parse(n, new CultureInfo("en-US"));
                return res;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Konwertuje object na decimal
        /// </summary>
        /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
        [Obsolete("Method is deprecated, please use int.Parse() instead.")]
        public static decimal ObjectToDecimal(object obj)
        {
            if (obj == null)
                return 0;
            return StringToDecimal(obj.ToString());
        }
        /// <summary>
        /// Konwertuje object na decimal
        /// </summary>
        /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
        /// <param name="d">domyślna wartość w przypadku błędu konwersji lub null</param>
        [Obsolete("Method is deprecated, please use int.Parse() instead.")]
        public static decimal ObjectToDecimal(object obj, decimal d)
        {
            if (obj == null)
                return d;
            return StringToDecimal(obj.ToString());
        }
        /// <summary>
        /// Konwertuje object na int
        /// </summary>
        /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
        public static int ObjectToInt(object obj)
        {
            if (obj == null)
                return 0;
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// Konwertuje object na int
        /// </summary>
        /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
        /// <param name="d">domyślna wartość w przypadku błędu konwersji lub null</param>
        [Obsolete("Method is deprecated, please use int.Parse() instead.")]
        public static int ObjectToInt(object obj, int d)
        {
            if (obj == null)
                return d;
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return d;
            }
        }
        public static uint ColorToUInt(Color color)
        {
            return (uint)((color.A << 24) | (color.R << 16) |
                          (color.G << 8) | (color.B << 0));
        }

        public static Color UIntToColor(uint color)
        {
            byte a = (byte)(color >> 24);
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return Color.FromArgb(a, r, g, b);
        }


        // INTEGRACJKA Z CLARIONEM
        /// <summary>
        /// Funkcja zwraca datę w formacie Clarion
        /// </summary>
        /// <param name="dt">Konwertowana data</param>
        /// <returns>Data w formacje Clarion</returns>
        public static int DateTimeToClarionDate(DateTime dt)
        {
            int ret = 0;

            DateTime start = new DateTime(1800, 12, 28);
            long elapsed = dt.Ticks - start.Ticks;
            TimeSpan diff = new TimeSpan(elapsed);
            ret = (int)diff.TotalDays;

            return ret;
        }
        /// <summary>
        /// Funkcja zwraca godzinę w formacie Clarion 
        /// </summary>
        /// <param name="dt">Konwertowany czas</param>
        /// <returns>Godzina w formacje Clarion</returns>
        public static int DateTimeToClarionTime(DateTime dt)
        {
            int ret = 0;

            ret = (dt.TimeOfDay.Seconds * 100) + (dt.TimeOfDay.Minutes * 6000) + (dt.TimeOfDay.Hours * 360000) + 1;

            return ret;
        }
        /// <summary>
        /// Konwersja daty i godz Clarion na format DateTime
        /// </summary>
        /// <param name="date">Data w formacie Clarion</param>
        /// <param name="time">Godzina w formacie Clarion</param>
        /// <returns></returns>
        public static DateTime ClarionDateTimeToDateTime(int date, int time)
        {
            DateTime ret = new DateTime(1800, 12, 28);
            ret = ret.AddDays((double)date);

            //kalkulacja czasu
            int t = time - 1; // bo w trakcie tworzenia czasu w formacie Clarion dodajemy 1
            int h = t / 360000;
            int m = (t % 360000) / 6000;
            int s = ((t % 360000) % 6000) / 100;

            return ret + new TimeSpan(h, m, s);
            ;
        }

        public static DateTime ParsujDate(string _data)
        {
            return ParsujDate(_data, DateTime.Now);
        }
        public static DateTime ParsujDate(string _data, DateTime _nearestDate)
        {

            char[] charSeparators = new char[] { ',', '-', '/', '.', ' ' };
            int dzien = 0;
            int miesiac = 0;
            int rok = 0;


            string[] words = _data.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (words.Count() > 2)
                    rok = XUtilConvert.StringToInt(words[2]);
                if (words.Count() > 1)
                    miesiac = XUtilConvert.StringToInt(words[1]);
                if (words.Count() > 0)
                    dzien = XUtilConvert.StringToInt(words[0]);


            }
            catch (Exception)
            {

                // throw;
            }
            if (rok == 0)
                rok = _nearestDate.Year;
            if (miesiac == 0)
                miesiac = _nearestDate.Month;
            if (dzien == 0)
                dzien = _nearestDate.Day;

            try
            {
                DateTime data = new DateTime(rok, miesiac, dzien);
                return data;
            }
            catch (Exception ex)
            {

                return DateTime.MinValue;
            }


        }


        public static string StripText(string title)
        {
            string output = title.Trim();
            string[,] znakiSpecjalne = {
    { "Ą", "A" },
    { "Ć", "C" },
    { "Ę", "E" },
    { "Ł", "L" },
    { "Ń", "N" },
    { "Ó", "O" }, { "Ś", "S" },
    { "Ź", "Z" }, { "Ż", "Z" },
    { "ą", "a" }, { "ć", "c" },
    { "ę", "e" }, { "ł", "l" },
    { "ń", "n" }, { "ó", "o" },
    { "ś", "s" }, { "ź", "z" },
    { "ż", "z" },{ "\"", " " },
    };
            for (int i = 0; i < znakiSpecjalne.GetLength(0); i++)
            {
                output = output.Replace(znakiSpecjalne[i, 0], znakiSpecjalne[i, 1]);
            }

            return output;
        }

    }
}
