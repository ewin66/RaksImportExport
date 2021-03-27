using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksWaluta : XPCustomObject
    {
        public RaksWaluta(Session session) : base(session)
        { }


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
    }
}
