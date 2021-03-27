using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class StawkaVat : XPCustomObject
    {
        public StawkaVat(Session session) : base(session)
        { }

        //ID_STAWKI_VAT, Integer,0, Identyfikator stawki VAT z sekcji STAWKI_VAT,Tak
        //  STAWKA_VAT, Float,0, Wartość procentowa stawki VAT(np. 22 to stawka 22%),Tak
        //   TYP_STAWKI_VAT, Integer,0,"Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        //1 - stawka 22%
        //2 - stawka 7%
        //6 - stawka zwolniona
        //7 - stawka ""nie podlega"" (nie uwzględniana w rejestrach VAT)
        //8 - stawka 0% dla sprzedaży krajowej i eksportowej
        //9 - stawka 3%
        //10- stawka 5% dla rolników ryczałtowych
        //11- stawka 6% dla rolników ryczałtowych

        int typStawki;
        decimal wartosc;
        string nazwa;
        int id;
        [Key(false)]
        public int Id

        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }

        public decimal Wartosc
        {
            get => wartosc;
            set => SetPropertyValue(nameof(Wartosc), ref wartosc, value);
        }

        //Pole określa typ standardowej stawki VAT. Możliwe wartości to: ;1 - stawka 22% ;2 - stawka 7% ;6 - stawka zwolniona ;7 - stawka &quot;nie podlega&quot; (nie uwzględniana w rejestrach VAT) ;8 - stawka 0% dla sprzedaży krajowej i eksportowej ;9 - stawka 3% ;10- stawka 5% dla rolników ryczałtowych ;11- stawka 6% dla rolników ryczałtowych ;Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane
					    
        public int TypStawki
        {
            get => typStawki;
            set => SetPropertyValue(nameof(TypStawki), ref typStawki, value);
        }
    }
}
