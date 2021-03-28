using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using Receptury.Module;
using Receptury.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RaksRecepturyImport
{
    public class ChilkatReader
    {
        IObjectSpace objectSpace;
        public ChilkatReader(IObjectSpace objectSpace)
        {
            this.objectSpace = objectSpace;
        }

        public void ReadXml()
        {

            Chilkat.Xml xml = new Chilkat.Xml();
            string fileName = @"d:/apps/RECEPTURY LEKÓW CYTOSTATYCZNYCH_RAKS.xml";
            bool success = xml.LoadXmlFile(fileName);

            string POLE_NAZWA;
            string POLE_TYP;
            string POLE_SZEROKOSC;
            string POLE_OPIS;
            string POLE_WYMAGANE;
            string WIERSZ_ID;
            string WIERSZ_KOD_KRESKOWY;
            string WIERSZ_NAZWA;
            string WIERSZ_ID_ARTYKULU;
            string WIERSZ_INDEKS_ARTYKULU;
            string WIERSZ_UWAGI;
            string WIERSZ_CECHY;
            string WIERSZ_NEW_ID;
            int j;
            int count_j;
            string WIERSZ_ILOSC;
            string WIERSZ_ID_OPAKOWANIA;
            string WIERSZ_OPAKOWANIA;
            string WIERSZ_ILOSC_OPAKOWAN;
            string WIERSZ_ID_GRUPY;
            string WIERSZ_RODZAJ;
            string WIERSZ_LICENCJA;
            string WIERSZ_INDEKS;
            string WIERSZ_INDEKS2;
            string WIERSZ_PKWIU;
            string WIERSZ_ID_STAWKI_VAT;
            string WIERSZ_STAWKA_VAT;
            string WIERSZ_TYP_STAWKI_VAT;
            string WIERSZ_ID_JEDNOSTKI_MIARY;
            string WIERSZ_SKROT_JEDNOSTKI_MIARY;
            string WIERSZ_NAZWA_JEDNOSTKI_MIARY;
            string WIERSZ_PODZIELNOSC;
            string WIERSZ_ANALITYKA_FK;
            string WIERSZ_SZTUK_W_OPAKOWANIU;
            string WIERSZ_GTIN;
            string WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI;
            string WIERSZ_OZNACZENIE_GTU_VAT;
            string WIERSZ_ID_DOMYSLNEGO_RABATU;
            string WIERSZ_NAZWA_DOMYSLNEGO_RABATU;
            string WIERSZ_OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU;
            string WIERSZ_WAGA_NETTO;
            string WIERSZ_WAGA_BRUTTO;
            string WIERSZ_PROWIZJA_AKWIZYTORA;
            string WIERSZ_DNI_PRZYDATNOSCI;
            string WIERSZ_STAN_MINIMALNY;
            string WIERSZ_STAN_MAKSYMALNY;
            string WIERSZ_ID_DOSTAWCY;
            string WIERSZ_NIP_DOSTAWCY;
            string WIERSZ_NAZWA_SKROCONA_DOSTAWCY;
            string WIERSZ_ID_PRODUCENTA;
            string WIERSZ_NIP_PRODUCENTA;
            string WIERSZ_NAZWA_SKROCONA_PRODUCENTA;
            string WIERSZ_KOD_CN;
            string WIERSZ_KOD_CN_NAZWA;
            string WIERSZ_JM_CN;
            string WIERSZ_SKROT_JEDNOSTKI_MIARY_CN;
            string WIERSZ_NAZWA_JEDNOSTKI_MIARY_CN;
            string WIERSZ_PRZELICZNIK_CN;
            string WIERSZ_BEZ_MASY;
            string WIERSZ_INTRASTAT;
            string WIERSZ_PCN;
            string WIERSZ_MASKA_KODU_KRESKOWEGO;
            string WIERSZ_MIN_ILOSC_PSP;
            string WIERSZ_MIN_ILOSC_ZD;
            string WIERSZ_MIN_ILOSC_ZO;
            string WIERSZ_MIN_ILOSC_PR;
            string WIERSZ_FUNDUSZ_PROMOCJI;
            string WIERSZ_SKROT_OPAKOWANIA;
            string WIERSZ_POJEMNOSC;
            string WIERSZ_DOMYSLNE;
            string WIERSZ_ID_NADRZEDNEJ;

            string EXPORT_ID = xml.ChilkatPath("EXPORT|(ID)");
            string EXPORT_DATA_EKSPORTU = xml.ChilkatPath("EXPORT|(DATA_EKSPORTU)");
            string EXPORT_EKSPORTUJACY = xml.ChilkatPath("EXPORT|(EKSPORTUJACY)");
            string EXPORT_WERSJA = xml.ChilkatPath("EXPORT|(WERSJA)");
            int i = 0;
            int count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|RECEPTURY|SKLADNIKI|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|DODATKOWE|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|ARTYKULY|KODY_OPAKOWANIA|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE");
            while (i < count_i)
            {
                xml.I = i;
                POLE_NAZWA = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE[i]|(NAZWA)");
                POLE_TYP = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE[i]|(TYP)");
                POLE_SZEROKOSC = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE[i]|(SZEROKOŚĆ)");
                POLE_OPIS = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE[i]|(OPIS)");
                POLE_WYMAGANE = xml.ChilkatPath("EXPORT|METADANE|RAKS_R3|GRUPY_ARTYKULOW|POLE[i]|(WYMAGANE)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|RECEPTURY|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(ID)");
                WIERSZ_KOD_KRESKOWY = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(KOD_KRESKOWY)");
                WIERSZ_NAZWA = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(NAZWA)");
                WIERSZ_ID_ARTYKULU = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(ID_ARTYKULU)");
                WIERSZ_INDEKS_ARTYKULU = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(INDEKS_ARTYKULU)");
                WIERSZ_UWAGI = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(UWAGI)");
                WIERSZ_CECHY = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(CECHY)");
                WIERSZ_NEW_ID = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|(NEW_ID)");
                j = 0;

                var receptura = objectSpace.FindObject<RaksReceptura>(new BinaryOperator(nameof(RaksReceptura.Id), WIERSZ_ID));
                if (receptura == null)
                {
                    receptura = objectSpace.CreateObject<RaksReceptura>();
                    receptura.Id = int.Parse(WIERSZ_ID);

                    count_j = xml.NumChildrenHavingTag("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ");
                    while (j < count_j)
                    {
                        xml.J = j;
                        WIERSZ_ID_ARTYKULU = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(ID_ARTYKULU)");
                        WIERSZ_INDEKS_ARTYKULU = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(INDEKS_ARTYKULU)");
                        WIERSZ_CECHY = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(CECHY)");
                        WIERSZ_ILOSC = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(ILOSC)");
                        WIERSZ_ID_OPAKOWANIA = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(ID_OPAKOWANIA)");
                        WIERSZ_OPAKOWANIA = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(OPAKOWANIA)");
                        WIERSZ_ILOSC_OPAKOWAN = xml.ChilkatPath("EXPORT|RECEPTURY|WIERSZ[i]|SKLADNIKI|WIERSZ[j]|(ILOSC_OPAKOWAN)");
                        j = j + 1;

                        var skladnik = objectSpace.CreateObject<RaksSkladnikReceptury>();
                        skladnik.Receptura = receptura;
                        skladnik.IdArtykulu = int.Parse(WIERSZ_ID_ARTYKULU);
                        skladnik.IndeksArtykulu = WIERSZ_INDEKS_ARTYKULU;
                        skladnik.Ilosc = decimal.Parse(WIERSZ_ILOSC);
                        skladnik.Artykul = objectSpace.FindObject<RaksArtykul>(new BinaryOperator(nameof(RaksArtykul.Indeks), WIERSZ_INDEKS_ARTYKULU));


                    }

                }
                receptura.IdArtykulu = int.Parse(WIERSZ_ID_ARTYKULU);
                receptura.Id = int.Parse(WIERSZ_ID);
                receptura.Nazwa = WIERSZ_NAZWA;
                receptura.Uwagi = WIERSZ_UWAGI;
                receptura.Cechy = WIERSZ_CECHY;
                receptura.IndeksArtykulu = WIERSZ_INDEKS_ARTYKULU;



                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|ARTYKULY|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ID)");
                WIERSZ_ID_GRUPY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ID_GRUPY)");
                WIERSZ_RODZAJ = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(RODZAJ)");
                WIERSZ_LICENCJA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(LICENCJA)");
                WIERSZ_INDEKS = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(INDEKS)");
                WIERSZ_NAZWA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(NAZWA)");
                WIERSZ_INDEKS2 = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(INDEKS2)");
                WIERSZ_PKWIU = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(PKWIU)");
                WIERSZ_ID_STAWKI_VAT = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ID_STAWKI_VAT)");
                WIERSZ_STAWKA_VAT = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(STAWKA_VAT)");
                WIERSZ_TYP_STAWKI_VAT = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(TYP_STAWKI_VAT)");
                WIERSZ_ID_JEDNOSTKI_MIARY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ID_JEDNOSTKI_MIARY)");
                WIERSZ_SKROT_JEDNOSTKI_MIARY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(SKROT_JEDNOSTKI_MIARY)");
                WIERSZ_NAZWA_JEDNOSTKI_MIARY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(NAZWA_JEDNOSTKI_MIARY)");
                WIERSZ_PODZIELNOSC = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(PODZIELNOSC)");
                WIERSZ_ANALITYKA_FK = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ANALITYKA_FK)");
                WIERSZ_ID_OPAKOWANIA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(ID_OPAKOWANIA)");
                WIERSZ_SZTUK_W_OPAKOWANIU = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(SZTUK_W_OPAKOWANIU)");
                WIERSZ_NEW_ID = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(NEW_ID)");
                WIERSZ_GTIN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(GTIN)");
                WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(MECHANIZM_PODZIELONEJ_PLATNOSCI)");
                WIERSZ_OZNACZENIE_GTU_VAT = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|(OZNACZENIE_GTU_VAT)");
                WIERSZ_ID_DOMYSLNEGO_RABATU = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(ID_DOMYSLNEGO_RABATU)");
                WIERSZ_NAZWA_DOMYSLNEGO_RABATU = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_DOMYSLNEGO_RABATU)");
                WIERSZ_OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU)");
                WIERSZ_WAGA_NETTO = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(WAGA_NETTO)");
                WIERSZ_WAGA_BRUTTO = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(WAGA_BRUTTO)");
                WIERSZ_UWAGI = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(UWAGI)");
                WIERSZ_PROWIZJA_AKWIZYTORA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(PROWIZJA_AKWIZYTORA)");
                WIERSZ_DNI_PRZYDATNOSCI = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(DNI_PRZYDATNOSCI)");
                WIERSZ_STAN_MINIMALNY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(STAN_MINIMALNY)");
                WIERSZ_STAN_MAKSYMALNY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(STAN_MAKSYMALNY)");
                WIERSZ_ID_DOSTAWCY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(ID_DOSTAWCY)");
                WIERSZ_NIP_DOSTAWCY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NIP_DOSTAWCY)");
                WIERSZ_NAZWA_SKROCONA_DOSTAWCY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_SKROCONA_DOSTAWCY)");
                WIERSZ_ID_PRODUCENTA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(ID_PRODUCENTA)");
                WIERSZ_NIP_PRODUCENTA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NIP_PRODUCENTA)");
                WIERSZ_NAZWA_SKROCONA_PRODUCENTA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_SKROCONA_PRODUCENTA)");
                WIERSZ_KOD_CN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_CN)");
                WIERSZ_KOD_CN_NAZWA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_CN_NAZWA)");
                WIERSZ_JM_CN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(JM_CN)");
                WIERSZ_SKROT_JEDNOSTKI_MIARY_CN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(SKROT_JEDNOSTKI_MIARY_CN)");
                WIERSZ_NAZWA_JEDNOSTKI_MIARY_CN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_JEDNOSTKI_MIARY_CN)");
                WIERSZ_PRZELICZNIK_CN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(PRZELICZNIK_CN)");
                WIERSZ_BEZ_MASY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(BEZ_MASY)");
                WIERSZ_INTRASTAT = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(INTRASTAT)");
                WIERSZ_PCN = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(PCN)");
                WIERSZ_KOD_KRESKOWY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_KRESKOWY)");
                WIERSZ_MASKA_KODU_KRESKOWEGO = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(MASKA_KODU_KRESKOWEGO)");
                WIERSZ_MIN_ILOSC_PSP = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_PSP)");
                WIERSZ_MIN_ILOSC_ZD = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_ZD)");
                WIERSZ_MIN_ILOSC_ZO = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_ZO)");
                WIERSZ_MIN_ILOSC_PR = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_PR)");
                WIERSZ_FUNDUSZ_PROMOCJI = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|DODATKOWE|WIERSZ|(FUNDUSZ_PROMOCJI)");
                WIERSZ_ID_OPAKOWANIA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(ID_OPAKOWANIA)");
                WIERSZ_SKROT_OPAKOWANIA = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(SKROT_OPAKOWANIA)");
                WIERSZ_KOD_KRESKOWY = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(KOD_KRESKOWY)");
                WIERSZ_POJEMNOSC = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(POJEMNOSC)");
                WIERSZ_DOMYSLNE = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(DOMYSLNE)");
                WIERSZ_UWAGI = xml.ChilkatPath("EXPORT|ARTYKULY|WIERSZ[i]|KODY_OPAKOWANIA|WIERSZ|(UWAGI)");
                i = i + 1;

                var artykul = objectSpace.FindObject<RaksArtykul>(new BinaryOperator(nameof(RaksGrupaArtykulow.Id), WIERSZ_ID));
                if (artykul == null)
                {
                    artykul = objectSpace.CreateObject<RaksArtykul>();
                    artykul.Id = int.Parse(WIERSZ_ID);
                }
                artykul.Rodzaj = WIERSZ_RODZAJ;
                artykul.IdGrupy = int.Parse(WIERSZ_ID_GRUPY);
                artykul.Indeks = WIERSZ_INDEKS;
                artykul.Indeks2 = WIERSZ_INDEKS2;
                artykul.Nazwa = WIERSZ_NAZWA;
                artykul.Pkwiu = WIERSZ_PKWIU;
                artykul.IdStawki = int.Parse(WIERSZ_ID_STAWKI_VAT);
                artykul.StawkaVat = decimal.Parse(WIERSZ_STAWKA_VAT);
                artykul.TypStawki = int.Parse(WIERSZ_TYP_STAWKI_VAT);
                artykul.IdJednostkiMiary = int.Parse(WIERSZ_ID_JEDNOSTKI_MIARY);
                artykul.Gtin = WIERSZ_GTIN;
                artykul.SkrotJednostkiMiary = WIERSZ_SKROT_JEDNOSTKI_MIARY;
                artykul.NazwaJednostkiMiary = WIERSZ_NAZWA_JEDNOSTKI_MIARY;
                artykul.KodKreskowy = WIERSZ_KOD_KRESKOWY;
                artykul.IdDostawcy = int.Parse(WIERSZ_ID_DOSTAWCY);
                artykul.NipDostawcy = WIERSZ_NIP_DOSTAWCY;
                artykul.NazwaDostawcy = WIERSZ_NAZWA_SKROCONA_DOSTAWCY;

                artykul.IdProducenta = WIERSZ_ID_PRODUCENTA == "" ? 0 : int.Parse(WIERSZ_ID_PRODUCENTA);
                artykul.NipProducenta = WIERSZ_NIP_PRODUCENTA;
                artykul.NazwaProducenta = WIERSZ_NAZWA_SKROCONA_PRODUCENTA;

                artykul.IdJednostkiMiary = WIERSZ_ID_JEDNOSTKI_MIARY == "" ? 0 : int.Parse(WIERSZ_ID_JEDNOSTKI_MIARY);
                artykul.NazwaJednostkiMiary = WIERSZ_NAZWA_JEDNOSTKI_MIARY;
                artykul.SkrotJednostkiMiary = WIERSZ_SKROT_JEDNOSTKI_MIARY;


                //string WIERSZ_STAWKA_VAT;
                //string WIERSZ_TYP_STAWKI_VAT;
                //string WIERSZ_ID_JEDNOSTKI_MIARY;
                //string WIERSZ_SKROT_JEDNOSTKI_MIARY;
                //string WIERSZ_NAZWA_JEDNOSTKI_MIARY;
                //string WIERSZ_PODZIELNOSC;
                //string WIERSZ_ANALITYKA_FK;
                //string WIERSZ_SZTUK_W_OPAKOWANIU;
                //string WIERSZ_GTIN;
                //string WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI;
                //string WIERSZ_OZNACZENIE_GTU_VAT;
                //string WIERSZ_ID_DOMYSLNEGO_RABATU;
                //string WIERSZ_NAZWA_DOMYSLNEGO_RABATU;
                //string WIERSZ_OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU;
                //string WIERSZ_WAGA_NETTO;
                //string WIERSZ_WAGA_BRUTTO;
                //string WIERSZ_PROWIZJA_AKWIZYTORA;
                //string WIERSZ_DNI_PRZYDATNOSCI;
                //string WIERSZ_STAN_MINIMALNY;
                //string WIERSZ_STAN_MAKSYMALNY;
                //string WIERSZ_ID_DOSTAWCY;
                //string WIERSZ_NIP_DOSTAWCY;
                //string WIERSZ_NAZWA_SKROCONA_DOSTAWCY;
                //string WIERSZ_ID_PRODUCENTA;
                //string WIERSZ_NIP_PRODUCENTA;
                //string WIERSZ_NAZWA_SKROCONA_PRODUCENTA;
                //string WIERSZ_KOD_CN;
                //string WIERSZ_KOD_CN_NAZWA;
                //string WIERSZ_JM_CN;
                //string WIERSZ_SKROT_JEDNOSTKI_MIARY_CN;
                //string WIERSZ_NAZWA_JEDNOSTKI_MIARY_CN;
                //string WIERSZ_PRZELICZNIK_CN;
                //string WIERSZ_BEZ_MASY;
                //string WIERSZ_INTRASTAT;
                //string WIERSZ_PCN;
                //string WIERSZ_MASKA_KODU_KRESKOWEGO;
                //string WIERSZ_MIN_ILOSC_PSP;
                //string WIERSZ_MIN_ILOSC_ZD;
                //string WIERSZ_MIN_ILOSC_ZO;
                //string WIERSZ_MIN_ILOSC_PR;
                //string WIERSZ_FUNDUSZ_PROMOCJI;
                //string WIERSZ_SKROT_OPAKOWANIA;
                //string WIERSZ_POJEMNOSC;
                //string WIERSZ_DOMYSLNE;
                //string WIERSZ_ID_NADRZEDNEJ;

            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("EXPORT|GRUPY_ARTYKULOW|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID = xml.ChilkatPath("EXPORT|GRUPY_ARTYKULOW|WIERSZ[i]|(ID)");
                WIERSZ_ID_NADRZEDNEJ = xml.ChilkatPath("EXPORT|GRUPY_ARTYKULOW|WIERSZ[i]|(ID_NADRZEDNEJ)");
                WIERSZ_NAZWA = xml.ChilkatPath("EXPORT|GRUPY_ARTYKULOW|WIERSZ[i]|(NAZWA)");
                WIERSZ_ANALITYKA_FK = xml.ChilkatPath("EXPORT|GRUPY_ARTYKULOW|WIERSZ[i]|(ANALITYKA_FK)");
                WIERSZ_NEW_ID = xml.ChilkatPath("EXPORT|GRUPY_ARTYKULOW|WIERSZ[i]|(NEW_ID)");
                i = i + 1;

                DodajGrupe(WIERSZ_ID, WIERSZ_ID_NADRZEDNEJ, WIERSZ_NAZWA, WIERSZ_ANALITYKA_FK);
            }



        }

        private void DodajGrupe(string wIERSZ_ID, string wIERSZ_ID_NADRZEDNEJ, string wIERSZ_NAZWA, string wIERSZ_ANALITYKA_FK)
        {
            var grupa = objectSpace.FindObject<RaksGrupaArtykulow>(new BinaryOperator(nameof(RaksGrupaArtykulow.Id), wIERSZ_ID));
            if (grupa == null)
            {
                grupa = objectSpace.CreateObject<RaksGrupaArtykulow>();
                grupa.Id = int.Parse(wIERSZ_ID);
            }

            grupa.IdNadrzednej = int.Parse(wIERSZ_ID_NADRZEDNEJ);
            grupa.Nazwa = wIERSZ_NAZWA;
            grupa.Analityka = wIERSZ_ANALITYKA_FK;
        }



        public void ImportRaksKontakty()
        {
            int licznik = 0;
            Directory.CreateDirectory("xml");
            string fileName = @"d:/apps/faktury.xml";
            using (var xr = XmlReader.Create(fileName))
            {
                int lk = 0;
                while (xr.Read())
                {
                    if (xr.NodeType != XmlNodeType.Element)
                        continue;
                    if (xr.Name == "KONTAKTY")
                    // ReadSubtree() positions the reader at the EndElement of the element read, so the 
                    // next call to Read() moves to the next node.
                    {
                        if (lk == 1)
                        {
                            using (var subReader = xr.ReadSubtree())
                            {
                                var doc = XDocument.Load(subReader);
                                var reader = new FakturyReader(objectSpace);
                                reader.ReadKontakty(doc.ToString());
                                Console.WriteLine($"{licznik}");

                                licznik++;
                            }
                        }
                        else
                        {
                            lk++;
                        }

                    }
                }
            }
        }
        public void ImportRaksArtykuly()
        {
            int licznik = 0;
            Directory.CreateDirectory("xml");
            string fileName = @"d:/apps/faktury.xml";
            using (var xr = XmlReader.Create(fileName))
            {
                int lk = 0;
                while (xr.Read())
                {
                    if (xr.NodeType != XmlNodeType.Element)
                        continue;
                    if (xr.Name == "ARTYKULY")
                    // ReadSubtree() positions the reader at the EndElement of the element read, so the 
                    // next call to Read() moves to the next node.
                    {
                        if (lk == 1)
                        {
                            using (var subReader = xr.ReadSubtree())
                            {
                                var doc = XDocument.Load(subReader);
                                var reader = new FakturyReader(objectSpace);
                                reader.ReadArtykuly(doc.ToString());
                                Console.WriteLine($"{licznik}");

                                licznik++;
                            }
                        }
                        else
                        {
                            lk++;
                        }

                    }
                }
            }
        }

        public void ImportRaksFaktury()
        {
            int licznik = 0;
            Directory.CreateDirectory("xml");
            string fileName = @"d:/apps/faktury.xml";
            using (var xr = XmlReader.Create(fileName))
            {
                int lk = 0;
                while (xr.Read())
                {
                    if (xr.NodeType != XmlNodeType.Element)
                        continue;
                    if (xr.Name == "FAKTURY_SPRZEDAZY")
                    // ReadSubtree() positions the reader at the EndElement of the element read, so the 
                    // next call to Read() moves to the next node.
                    {
                        if (lk == 1)
                        {
                            using (var subReader = xr.ReadSubtree())
                            {
                                var doc = XDocument.Load(subReader);
                                var reader = new FakturyReader(objectSpace);
                                reader.ReadFaktury(doc.ToString());
                                Console.WriteLine($"{licznik}");

                                licznik++;
                            }
                        }
                        else
                        {
                            lk++;
                        }

                    }
                }
            }
        }
    }
}
