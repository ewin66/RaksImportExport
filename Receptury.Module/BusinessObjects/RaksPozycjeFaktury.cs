using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksPozycjeFaktury : XPCustomObject
    {
        public RaksPozycjeFaktury(Session session) : base(session)
        { }

        //        _NAZWA,_TYP,_SZEROKOSC,_OPIS,_WYMAGANE
        //ID, Integer,0, Identyfikator rekordu,Nie
        //  ID_WZ, Integer,0, Identyfikator WZ dla towarów i licencji z sekcji WYDANIA_ZEWNETRZNE, Tak
        //ID_ARTYKULU,Integer,0,Identyfikator artykułu z sekcji ARTYKULY,Tak
        //INDEKS_ARTYKULU, String,25,"Indeks artykułu, używany, jeśli plik z importem nie zawiera informacji o danym artykule lub nie został on wsześniej zaimportowany", Tak
        //TYP_ARTYKULU,String,12,"Rodzaj artykułu ('Towar', 'Usługa', 'Opk. zwrotne', 'Koszt', 'Licencja')",Tak
        //INDEKS_WG_PLATNIKA, String,25, Indeks atykułu wg.nabywcy, Tak
        //  NAZWA_WG_PLATNIKA, String,250, Nazwa atykułu wg.nabywcy, Tak
        //  ID_JEDNOSTKI_MIARY, Integer,0, Identyfikator jednostki miary (kontrahenta), Tak
        //  SKROT_JEDNOSTKI_MIARY, String,5, Skrót jednostki miary (kontrahenta), Tak
        //  NAZWA_JEDNOSTKI_MIARY, String,25, Nazwa jednostki miary (kontrahenta), Tak
        //  WSPOLCZYNNIK_JEDNOSTEK, Float,0, Stosunek jednostki kontrahenta do jednostki własnej, Tak
        //  ILOSC, Float,0, Ilość sprzedanego towaru (w jednostkach kontrahenta),Tak
        //    ID_RODZAJU_CENY_SPRZEDAZY, Integer,0, Identyfikator rodzaju ceny sprzedaży z sekcji CENY_SPRZEDAZY, Tak
        //NAZWA_RODZAJU_CENY_SPRZEDAZY,String,25,"Nazwa rodzaju ceny sprzedaży, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_CENY_SPRZEDAZY nie powiedzie się",Nie
        //ID_RODZAJU_RABATU, Integer,0, Identyfikator rodzaju rabatu z sekcji RODZAJE_RABATOW,Tak
        //  NAZWA_RODZAJU_RABATU, String,50,"Nazwa rodzaju rabatu, używana jeśli odnalezienie po ID_RODZAJU_RABATU się nie powiedzie", Nie
        //CENA_NETTO_PRZED_RABATEM,Float,0,"Cena sprzedaży artykułu netto przed udzieleniem rabatu, w walucie dokumentu (czyli wynik przeliczenia ceny katalogowej na walutę dokumentu) (w jednostkach kontrahenta)",Tak
        //CENA_BRUTTO_PRZED_RABATEM, Float,0,"Cena sprzedaży artykułu brutto przed udzieleniem rabatu, w walucie dokumentu (czyli wynik przeliczenia ceny katalogowej na walutę dokumentu) (w jednostkach kontrahenta)", Nie
        //RABAT,Float,0,Wartość udzielonego rabatu w procentach,Tak
        //CENA_NETTO_PO_RABACIE, Float,0, Cena netto sprzedaży artykułu w walucie dokumentu po udzieleniu rabatu(w jednostkach kontrahenta),Tak
        // ID_STAWKI_SPRZEDAZY, Integer,0, Identyfikator stawki podatku VAT z sekcji STAWKI_VAT, Tak
        //STAWKA_SPRZEDAZY,Float,0,Wartość procentowa stawki podatku VAT(np. 22 to stawka 22%),Tak
        //TYP_STAWKI_SPRZEDAZY, Integer,0,"Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        //1 - stawka 22%
        //2 - stawka 7%
        //6 - stawka zwolniona
        //7 - stawka ""nie podlega"" (nie uwzględniana w rejestrach VAT)
        //8 - stawka 0% dla sprzedaży krajowej i eksportowej
        //9 - stawka 3%
        //10- stawka 5% dla rolników ryczałtowych
        //11- stawka 6% dla rolników ryczałtowych
        //Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane)",Tak
        //CENA_BRUTTO_PO_RABACIE,Float,0,Cena brutto sprzedaży artykułu po rabacie w walucie dokumentu(w jednostkach kontrahenta),Tak
        //CENA_ZLOTOWKOWA_NETTO, Float,0, Cene netto sprzedaży artykułu w złotówkach(w jednostkach kontrahenta),Tak
        //CENA_ZLOTOWKOWA_BRUTTO, Float,0, Cene brutto sprzedaży artykułu w złotówkach(w jednostkach kontrahenta),Tak
        // WARTOSC_NETTO, Float,0, Wartość pozycji w cenach sprzedaży netto po rabacie(w walucie dokumentu) (w jednostkach kontrahenta), Tak
        //KWOTA_VAT,Float,0,Kwota VAT należnego z pozycji(w jednostkach kontrahenta),Tak
        //WARTOSC_BRUTTO, Float,0, Wartość pozycji w cenach sprzedaży brutto po rabacie(w walucie dokumentu) (w jednostkach kontrahenta), Tak
        //WARTOSC_NETTO_PLN,Float,0,Wartość pozycji w cenach sprzedaży netto po rabacie(w złotówkach) (w jednostkach kontrahenta), Tak
        //KWOTA_VAT_PLN,Float,0,Kwota podatku VAT należnego z pozycji w cenach sprzedaży netto po rabacie(w złotówkach) (w jednostkach kontrahenta), Tak
        //WARTOSC_BRUTTO_PLN,Float,0,Wartość pozycji w cenach sprzedaży brutto po rabacie(w złotówkach) (w jednostkach kontrahenta), Tak
        //NUMER_SERYJNY,String,100,Numer seryjny/licencji dostawcy, Nie
        //NUMER_SERYJNY_SPRZEDAZY,String,100,Numer seryjny/licencji sprzedaży, Nie
        //ID_OPAKOWANIA,Integer,0,Identyfikator opakowania zbiorczego z sekcji OPAKOWANIA_ZBIORCZE, Nie
        //SKROT_OPAKOWANIA,String,5,"Skrót opakowania zbiorczego; użytane do wyszukiwania, jeśli szukanie po ID_OPAKOWANIA nie powiedzie się",Nie
        //ILOSC_OPAKOWAN, Float,0, Ilość opakowań zbiorczych, Tak
        //WAGA_NETTO,Float,0,Waga netto pozycji,Tak
        //WAGA_BRUTTO, Float,0, Waga brutto pozycji, Tak
        //WAGA_OPAKOWAN,Float,0,Waga opakowań zbiorczych w pozycji,Tak
        //PROWIZJA_AKWIZYTORA, Float,0, Prowizja akwizytora,Nie
        //  UWAGI, String,8190, Uwagi na temat pozycji(maks.długośc 8190 znaków),Nie
        //  ZNACZNIKI,BLOB.text,0,Znaczniki pozycji, Nie
        //CECHY,String,25,Cechy artykułu(używane do wyszukiwania w odpowiedniej subsekcji w artykułach),Nie
        //DATA_WYDANIA, Date,0,, Nie
        //KURS,Float,0,Kurs walutowy pozycji,Tak

        
        [Size(SizeAttribute.Unlimited)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }

        string uwagi;
        RaksFaktura faktura;

        [Association("RaksFaktura-Pozycje")]
        public RaksFaktura Faktura
        {
            get => faktura;
            set => SetPropertyValue(nameof(Faktura), ref faktura, value);
        }

    }
}
