using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksRozliczenieRozrachunkow : XPObject
    {
        public RaksRozliczenieRozrachunkow(Session session) : base(session)
        { }



        RaksRozrachunek rozrachunek;
        DateTime dataPlatnosci;
        DateTime dataOperacji;
        decimal kwotaRozrachunkuWal;
        decimal kwotaRozrachunku;
        decimal kwotaWal;
        decimal kwota;
        int id;

        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }

        public decimal Kwota
        {
            get => kwota;
            set => SetPropertyValue(nameof(Kwota), ref kwota, value);
        }
        //        KWOTA,Float,0,Kwota rozliczenia, Tak


        public decimal KwotaWal
        {
            get => kwotaWal;
            set => SetPropertyValue(nameof(KwotaWal), ref kwotaWal, value);
        }
        //KWOTA_WAL,Float,0,Kwota rozliczenia w walucie, Tak
        //KWOTA_ORG,Float,0,Kwota oryginalna rozrachunku z którym rozliczamy, Tak

        public decimal KwotaRozrachunku
        {
            get => kwotaRozrachunku;
            set => SetPropertyValue(nameof(KwotaRozrachunku), ref kwotaRozrachunku, value);
        }
        //KWOTA_ORG_WAL,Float,0,Kwota oryginalna rozrachunku z którym rozliczamy w walucie, Tak

        public decimal KwotaRozrachunkuWal
        {
            get => kwotaRozrachunkuWal;
            set => SetPropertyValue(nameof(KwotaRozrachunkuWal), ref kwotaRozrachunkuWal, value);
        }
        //DATA_OPER,Date,0,Data operacji rozrachunku z którym rozliczamy, Tak
        //DATA_PLAT,Date,0,Data płatności rozrachunku z którym rozliczamy, Nie

        public DateTime DataOperacji
        {
            get => dataOperacji;
            set => SetPropertyValue(nameof(DataOperacji), ref dataOperacji, value);
        }


        public DateTime DataPlatnosci
        {
            get => dataPlatnosci;
            set => SetPropertyValue(nameof(DataPlatnosci), ref dataPlatnosci, value);
        }


        
        [Association("RaksRozrachunek-RaksRozliczeniaRozrachunkow")]
        public RaksRozrachunek Rozrachunek
        {
            get => rozrachunek;
            set => SetPropertyValue(nameof(Rozrachunek), ref rozrachunek, value);
        }
    }
}
