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

        int id;
        //Identyfikator rekordu
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        int idwz;
        //Identyfikator WZ dla towarów i licencji z sekcji WYDANIA_ZEWNETRZNE
        public int IdWz
        {
            get => idwz;
            set => SetPropertyValue(nameof(IdWz), ref idwz, value);
        }
        int idartykulu;
        //Identyfikator artykułu z sekcji ARTYKULY
        public int IdArtykulu
        {
            get => idartykulu;
            set => SetPropertyValue(nameof(IdArtykulu), ref idartykulu, value);
        }
        string indeksartykulu;
        //Indeks artykułu, używany, jeśli plik z importem nie zawiera informacji o danym artykule lub nie został on wsześniej zaimportowany
        [Size(25)]
        public string IndeksArtykulu
        {
            get => indeksartykulu;
            set => SetPropertyValue(nameof(IndeksArtykulu), ref indeksartykulu, value);
        }
        string typartykulu;
        //Rodzaj artykułu ('Towar', 'Usługa', 'Opk. zwrotne', 'Koszt', 'Licencja')
        [Size(12)]
        public string TypArtykulu
        {
            get => typartykulu;
            set => SetPropertyValue(nameof(TypArtykulu), ref typartykulu, value);
        }
        string indekswgplatnika;
        //Indeks atykułu wg. nabywcy
        [Size(25)]
        public string IndeksWgPlatnika
        {
            get => indekswgplatnika;
            set => SetPropertyValue(nameof(IndeksWgPlatnika), ref indekswgplatnika, value);
        }
        string nazwawgplatnika;
        //Nazwa atykułu wg. nabywcy
        [Size(250)]
        public string NazwaWgPlatnika
        {
            get => nazwawgplatnika;
            set => SetPropertyValue(nameof(NazwaWgPlatnika), ref nazwawgplatnika, value);
        }
        int idjednostkimiary;
        //Identyfikator jednostki miary (kontrahenta)
        public int IdJednostkiMiary
        {
            get => idjednostkimiary;
            set => SetPropertyValue(nameof(IdJednostkiMiary), ref idjednostkimiary, value);
        }
        string skrotjednostkimiary;
        //Skrót jednostki miary (kontrahenta)
        [Size(5)]
        public string SkrotJednostkiMiary
        {
            get => skrotjednostkimiary;
            set => SetPropertyValue(nameof(SkrotJednostkiMiary), ref skrotjednostkimiary, value);
        }
        string nazwajednostkimiary;
        //Nazwa jednostki miary (kontrahenta)
        [Size(25)]
        public string NazwaJednostkiMiary
        {
            get => nazwajednostkimiary;
            set => SetPropertyValue(nameof(NazwaJednostkiMiary), ref nazwajednostkimiary, value);
        }
        decimal wspolczynnikjednostek;
        //Stosunek jednostki kontrahenta do jednostki własnej
        public decimal WspolczynnikJednostek
        {
            get => wspolczynnikjednostek;
            set => SetPropertyValue(nameof(WspolczynnikJednostek), ref wspolczynnikjednostek, value);
        }
        decimal ilosc;
        //Ilość sprzedanego towaru (w jednostkach kontrahenta)
        public decimal Ilosc
        {
            get => ilosc;
            set => SetPropertyValue(nameof(Ilosc), ref ilosc, value);
        }
        int idrodzajucenysprzedazy;
        //Identyfikator rodzaju ceny sprzedaży z sekcji CENY_SPRZEDAZY
        public int IdRodzajuCenySprzedazy
        {
            get => idrodzajucenysprzedazy;
            set => SetPropertyValue(nameof(IdRodzajuCenySprzedazy), ref idrodzajucenysprzedazy, value);
        }
        string nazwarodzajucenysprzedazy;
        //Nazwa rodzaju ceny sprzedaży, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_CENY_SPRZEDAZY nie powiedzie się
        [Size(25)]
        public string NazwaRodzajuCenySprzedazy
        {
            get => nazwarodzajucenysprzedazy;
            set => SetPropertyValue(nameof(NazwaRodzajuCenySprzedazy), ref nazwarodzajucenysprzedazy, value);
        }
        int idrodzajurabatu;
        //Identyfikator rodzaju rabatu z sekcji RODZAJE_RABATOW
        public int IdRodzajuRabatu
        {
            get => idrodzajurabatu;
            set => SetPropertyValue(nameof(IdRodzajuRabatu), ref idrodzajurabatu, value);
        }
        string nazwarodzajurabatu;
        //Nazwa rodzaju rabatu, używana jeśli odnalezienie po ID_RODZAJU_RABATU się nie powiedzie
        [Size(50)]
        public string NazwaRodzajuRabatu
        {
            get => nazwarodzajurabatu;
            set => SetPropertyValue(nameof(NazwaRodzajuRabatu), ref nazwarodzajurabatu, value);
        }
        decimal cenanettoprzedrabatem;
        //Cena sprzedaży artykułu netto przed udzieleniem rabatu, w walucie dokumentu (czyli wynik przeliczenia ceny katalogowej na walutę dokumentu) (w jednostkach kontrahenta)
        public decimal CenaNettoPrzedRabatem
        {
            get => cenanettoprzedrabatem;
            set => SetPropertyValue(nameof(CenaNettoPrzedRabatem), ref cenanettoprzedrabatem, value);
        }
        decimal cenabruttoprzedrabatem;
        //Cena sprzedaży artykułu brutto przed udzieleniem rabatu, w walucie dokumentu (czyli wynik przeliczenia ceny katalogowej na walutę dokumentu) (w jednostkach kontrahenta)
        public decimal CenaBruttoPrzedRabatem
        {
            get => cenabruttoprzedrabatem;
            set => SetPropertyValue(nameof(CenaBruttoPrzedRabatem), ref cenabruttoprzedrabatem, value);
        }
        decimal rabat;
        //Wartość udzielonego rabatu w procentach
        public decimal Rabat
        {
            get => rabat;
            set => SetPropertyValue(nameof(Rabat), ref rabat, value);
        }
        decimal cenanettoporabacie;
        //Cena netto sprzedaży artykułu w walucie dokumentu po udzieleniu rabatu (w jednostkach kontrahenta)
        public decimal CenaNettoPoRabacie
        {
            get => cenanettoporabacie;
            set => SetPropertyValue(nameof(CenaNettoPoRabacie), ref cenanettoporabacie, value);
        }
        int idstawkisprzedazy;
        //Identyfikator stawki podatku VAT z sekcji STAWKI_VAT
        public int IdStawkiSprzedazy
        {
            get => idstawkisprzedazy;
            set => SetPropertyValue(nameof(IdStawkiSprzedazy), ref idstawkisprzedazy, value);
        }
        decimal stawkasprzedazy;
        //Wartość procentowa stawki podatku VAT (np. 22 to stawka 22%)
        public decimal StawkaSprzedazy
        {
            get => stawkasprzedazy;
            set => SetPropertyValue(nameof(StawkaSprzedazy), ref stawkasprzedazy, value);
        }
        int typstawkisprzedazy;
        //Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        //1 - stawka 22%
        //2 - stawka 7%
        //6 - stawka zwolniona
        //7 - stawka "nie podlega" (nie uwzględniana w rejestrach VAT)
        //8 - stawka 0% dla sprzedaży krajowej i eksportowej
        //9 - stawka 3%
        //10- stawka 5% dla rolników ryczałtowych
        //11- stawka 6% dla rolników ryczałtowych
        //Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane)
        public int TypStawkiSprzedazy
        {
            get => typstawkisprzedazy;
            set => SetPropertyValue(nameof(TypStawkiSprzedazy), ref typstawkisprzedazy, value);
        }
        decimal cenabruttoporabacie;
        //Cena brutto sprzedaży artykułu po rabacie w walucie dokumentu (w jednostkach kontrahenta)
        public decimal CenaBruttoPoRabacie
        {
            get => cenabruttoporabacie;
            set => SetPropertyValue(nameof(CenaBruttoPoRabacie), ref cenabruttoporabacie, value);
        }
        decimal cenazlotowkowanetto;
        //Cene netto sprzedaży artykułu w złotówkach (w jednostkach kontrahenta)
        public decimal CenaZlotowkowaNetto
        {
            get => cenazlotowkowanetto;
            set => SetPropertyValue(nameof(CenaZlotowkowaNetto), ref cenazlotowkowanetto, value);
        }
        decimal cenazlotowkowabrutto;
        //Cene brutto sprzedaży artykułu w złotówkach (w jednostkach kontrahenta)
        public decimal CenaZlotowkowaBrutto
        {
            get => cenazlotowkowabrutto;
            set => SetPropertyValue(nameof(CenaZlotowkowaBrutto), ref cenazlotowkowabrutto, value);
        }
        decimal wartoscnetto;
        //Wartość pozycji w cenach sprzedaży netto po rabacie (w walucie dokumentu) (w jednostkach kontrahenta)
        public decimal WartoscNetto
        {
            get => wartoscnetto;
            set => SetPropertyValue(nameof(WartoscNetto), ref wartoscnetto, value);
        }
        decimal kwotavat;
        //Kwota VAT należnego z pozycji (w jednostkach kontrahenta)
        public decimal KwotaVat
        {
            get => kwotavat;
            set => SetPropertyValue(nameof(KwotaVat), ref kwotavat, value);
        }
        decimal wartoscbrutto;
        //Wartość pozycji w cenach sprzedaży brutto po rabacie (w walucie dokumentu) (w jednostkach kontrahenta)
        public decimal WartoscBrutto
        {
            get => wartoscbrutto;
            set => SetPropertyValue(nameof(WartoscBrutto), ref wartoscbrutto, value);
        }
        decimal wartoscnettopln;
        //Wartość pozycji w cenach sprzedaży netto po rabacie (w złotówkach) (w jednostkach kontrahenta)
        public decimal WartoscNettoPln
        {
            get => wartoscnettopln;
            set => SetPropertyValue(nameof(WartoscNettoPln), ref wartoscnettopln, value);
        }
        decimal kwotavatpln;
        //Kwota podatku VAT należnego z pozycji w cenach sprzedaży netto po rabacie (w złotówkach) (w jednostkach kontrahenta)
        public decimal KwotaVatPln
        {
            get => kwotavatpln;
            set => SetPropertyValue(nameof(KwotaVatPln), ref kwotavatpln, value);
        }
        decimal wartoscbruttopln;
        //Wartość pozycji w cenach sprzedaży brutto po rabacie (w złotówkach) (w jednostkach kontrahenta)
        public decimal WartoscBruttoPln
        {
            get => wartoscbruttopln;
            set => SetPropertyValue(nameof(WartoscBruttoPln), ref wartoscbruttopln, value);
        }
        string numerseryjny;
        //Numer seryjny/licencji dostawcy
        [Size(100)]
        public string NumerSeryjny
        {
            get => numerseryjny;
            set => SetPropertyValue(nameof(NumerSeryjny), ref numerseryjny, value);
        }
        string numerseryjnysprzedazy;
        //Numer seryjny/licencji sprzedaży
        [Size(100)]
        public string NumerSeryjnySprzedazy
        {
            get => numerseryjnysprzedazy;
            set => SetPropertyValue(nameof(NumerSeryjnySprzedazy), ref numerseryjnysprzedazy, value);
        }
        int idopakowania;
        //Identyfikator opakowania zbiorczego z sekcji OPAKOWANIA_ZBIORCZE
        public int IdOpakowania
        {
            get => idopakowania;
            set => SetPropertyValue(nameof(IdOpakowania), ref idopakowania, value);
        }
        string skrotopakowania;
        //Skrót opakowania zbiorczego; użytane do wyszukiwania, jeśli szukanie po ID_OPAKOWANIA nie powiedzie się
        [Size(5)]
        public string SkrotOpakowania
        {
            get => skrotopakowania;
            set => SetPropertyValue(nameof(SkrotOpakowania), ref skrotopakowania, value);
        }
        decimal iloscopakowan;
        //Ilość opakowań zbiorczych
        public decimal IloscOpakowan
        {
            get => iloscopakowan;
            set => SetPropertyValue(nameof(IloscOpakowan), ref iloscopakowan, value);
        }
        decimal waganetto;
        //Waga netto pozycji
        public decimal WagaNetto
        {
            get => waganetto;
            set => SetPropertyValue(nameof(WagaNetto), ref waganetto, value);
        }
        decimal wagabrutto;
        //Waga brutto pozycji
        public decimal WagaBrutto
        {
            get => wagabrutto;
            set => SetPropertyValue(nameof(WagaBrutto), ref wagabrutto, value);
        }
        decimal wagaopakowan;
        //Waga opakowań zbiorczych w pozycji
        public decimal WagaOpakowan
        {
            get => wagaopakowan;
            set => SetPropertyValue(nameof(WagaOpakowan), ref wagaopakowan, value);
        }
        decimal prowizjaakwizytora;
        //Prowizja akwizytora
        public decimal ProwizjaAkwizytora
        {
            get => prowizjaakwizytora;
            set => SetPropertyValue(nameof(ProwizjaAkwizytora), ref prowizjaakwizytora, value);
        }

        string znaczniki;
        //Znaczniki pozycji
        public string Znaczniki
        {
            get => znaczniki;
            set => SetPropertyValue(nameof(Znaczniki), ref znaczniki, value);
        }
        string cechy;
        //Cechy artykułu (używane do wyszukiwania w odpowiedniej subsekcji w artykułach)
        [Size(25)]
        public string Cechy
        {
            get => cechy;
            set => SetPropertyValue(nameof(Cechy), ref cechy, value);
        }
        DateTime datawydania;
        //
        public DateTime DataWydania
        {
            get => datawydania;
            set => SetPropertyValue(nameof(DataWydania), ref datawydania, value);
        }
        decimal kurs;
        //Kurs walutowy pozycji
        public decimal Kurs
        {
            get => kurs;
            set => SetPropertyValue(nameof(Kurs), ref kurs, value);
        }


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
