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
    public class RaksStawkaVat : XPCustomObject
    {
        public RaksStawkaVat(Session session) : base(session)
        { }

        int id;
        /// <summary>
        /// Identyfikator stawki VAT, wartości 1 do 200 są zarezerwowane dla stawek standardowych
        /// <summary>
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        decimal wartoscprocentowa;
        /// <summary>
        /// Wartość stawki VAT w procentach
        /// <summary>
        public decimal WartoscProcentowa
        {
            get => wartoscprocentowa;
            set => SetPropertyValue(nameof(WartoscProcentowa), ref wartoscprocentowa, value);
        }
        bool czypokazywacwdeklaracjivat;
        /// <summary>
        /// Czy stawka ma się pokazywać w deklaracji VAT
        /// <summary>
        public bool CzyPokazywacWDeklaracjiVat
        {
            get => czypokazywacwdeklaracjivat;
            set => SetPropertyValue(nameof(CzyPokazywacWDeklaracjiVat), ref czypokazywacwdeklaracjivat, value);
        }
        int pozycjadeklaracjivat;
        /// <summary>
        /// Numer kolumny w deklaracji VAT
        /// <summary>
        public int PozycjaDeklaracjiVat
        {
            get => pozycjadeklaracjivat;
            set => SetPropertyValue(nameof(PozycjaDeklaracjiVat), ref pozycjadeklaracjivat, value);
        }
        string nazwawyswietlana;
        /// <summary>
        /// Nazwa stawki VAT drukowana na dokumentach
        /// <summary>
        [Size(7)]
        public string NazwaWyswietlana
        {
            get => nazwawyswietlana;
            set => SetPropertyValue(nameof(NazwaWyswietlana), ref nazwawyswietlana, value);
        }
        string opisstawki;
        /// <summary>
        /// Opis stawki VAT
        /// <summary>
        [Size(255)]
        public string OpisStawki
        {
            get => opisstawki;
            set => SetPropertyValue(nameof(OpisStawki), ref opisstawki, value);
        }
        int typstawkivat;
        /// <summary>
        /// Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        ///1 - stawka 22%
        ///2 - stawka 7%
        ///6 - stawka zwolniona
        ///7 - stawka "nie podlega" (nie uwzględniana w rejestrach VAT)
        ///8 - stawka 0% dla sprzedaży krajowej i eksportowej
        ///9 - stawka 3%
        ///10- stawka 5% dla rolników ryczałtowych
        ///11- stawka 6% dla rolników ryczałtowych
        ///Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane)
        /// <summary>
        public int TypStawkiVat
        {
            get => typstawkivat;
            set => SetPropertyValue(nameof(TypStawkiVat), ref typstawkivat, value);
        }
        int newid;
        /// <summary>
        /// Zarezerwowane, wpisywać zawsze 0
        /// <summary>
        public int NewId
        {
            get => newid;
            set => SetPropertyValue(nameof(NewId), ref newid, value);
        }
        // by Kashiash generator  
    }
}
