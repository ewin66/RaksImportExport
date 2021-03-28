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
    public class RaksClass : XPCustomObject
    {
        public RaksClass(Session session) : base(session)
        { }
        int id;
        /// <summary>
        /// 
        /// <summary>
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        string nazwa;
        /// <summary>
        /// Nazwa metody płatności.
        /// <summary>
        [Size(50)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }
        string analitykafk;
        /// <summary>
        /// Analityka księgowa metody płatności.
        /// <summary>
        [Size(20)]
        public string AnalitykaFk
        {
            get => analitykafk;
            set => SetPropertyValue(nameof(AnalitykaFk), ref analitykafk, value);
        }
        // by Kashiash generator                                                   



    }

}
