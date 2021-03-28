using DevExpress.ExpressApp;

using JK.XAF.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JK.XAF.Module.Controllers
{
    public class FilteringCriterionDetailController : EventsObjectViewController<DetailView, FilteringCriterion>
    {
        protected override Dictionary<string, string> ParyNazwaWlasnosciNazwaMetodyValueStored => new Dictionary<string, string>
        {
            { nameof(FilteringCriterion.ObjectType), nameof(ObjectType_ValueStored) }
        };

        private void ObjectType_ValueStored(object sender, EventArgs e)
        {
            ViewCurrentObject.Criterion = string.Empty;
        }
    }
}
