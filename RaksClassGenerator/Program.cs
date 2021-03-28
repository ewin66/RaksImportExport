using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Globalization;
using CommonLibs;

namespace RaksClassGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string str = Clipboard.GetText(TextDataFormat.Text);
                XDocument doc = XDocument.Parse(str);
                var descendants = doc.Descendants();

                foreach (var node in descendants)
                {



                    var list = from fields in node.Descendants()
                               select new
                               {
                                   Nazwa = fields.Attribute("NAZWA").Value.Replace("_", " ").ToTitleCase().Replace(" ", ""),
                                   Typ = fields.Attribute("TYP").Value,
                                   Opis = fields.Attribute("OPIS").Value,
                                   Szerokosc = fields.Attribute("SZEROKOSC").Value,
                                   Wymagane = fields.Attribute("WYMAGANE").Value
                               };

                    //     var elements = node.Elements();


                    if (list?.Count() > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        GenerateClassHeader(sb);
                        foreach (var element in list)
                        {

                            GenerateClassProperty(sb, element.Nazwa, element.Typ, element.Opis, element.Szerokosc);
                        }
                        GenerateClassFooter(sb);
                        Clipboard.SetText(sb.ToString());
                        Console.WriteLine(sb);
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        private static void GenerateClassProperty(StringBuilder sb, string nazwa, string typ, string opis, string szerokosc)
        {
            sb.AppendLine($"        {Raks2Type(typ)} {nazwa.ToLower()};");
            sb.AppendLine($"/// <summary>");
            sb.AppendLine($"/// {opis.Replace("\n","\n///")}");
            sb.AppendLine($"/// <summary>");
            if (nazwa == "Id")
            {
                sb.AppendLine($"        [Key(false)]");
            }
            if (typ == "String")
            {
                sb.AppendLine($"[Size({szerokosc})]");
            }
            sb.AppendLine($"        public {Raks2Type(typ)} {nazwa}");
            sb.AppendLine($"        {{");
            sb.AppendLine($"            get => {nazwa.ToLower()};");
            sb.AppendLine($"            set => SetPropertyValue(nameof({nazwa}), ref {nazwa.ToLower()}, value);");
            sb.AppendLine($"        }}");
        }

        private static object Raks2Type(string typ)
        {
            switch (typ)
            {
                case "Date":
                    return "DateTime";
                case "Integer":
                    return "int";
                case "Float":
                    return "decimal";
                case "Boolean":
                    return "bool";
                default:
                    return "string";

            }
        }

        private static void GenerateClassHeader(StringBuilder sb)
        {
            sb.AppendLine("	[DefaultClassOptions]                                                     ");
            sb.AppendLine("    public class RaksClass : XPCustomObject                                ");
            sb.AppendLine("    {                                                                      ");
            sb.AppendLine("        public RaksClass(Session session) : base(session)                  ");
            sb.AppendLine("        { }                                                                ");
        }

        private static void GenerateClassFooter(StringBuilder sb)
        {
            sb.AppendLine("	// by Kashiash generator                                                   ");
            sb.AppendLine("                                  ");
            sb.AppendLine("                                  ");
            sb.AppendLine("                                  ");
            sb.AppendLine("}                                 ");
        }
    }
}
