using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.ComponentModel;

namespace JK.XAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("Action_Filter")]
    [NavigationItem("Administracyjne")]
    [XafDisplayName("Filtr")]

    public class FilteringCriterion : BaseObject
    {
        public FilteringCriterion(Session session) : base(session) { }

        [XafDisplayName("Kryterium")]
        [CriteriaOptions(nameof(ObjectType))]
        [Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        public string Criterion
        {
            get => GetPropertyValue<string>(nameof(Criterion));
            set => SetPropertyValue(nameof(Criterion), value);
        }

        [XafDisplayName("Opis")]
        [RuleRequiredField("DescriptionIsRequiredinFilterCriteria", DefaultContexts.Save, CustomMessageTemplate = "Wpisz nazwę filtra")]
        public string Description
        {
            get => GetPropertyValue<string>(nameof(Description));
            set => SetPropertyValue(nameof(Description), value);
        }

        [XafDisplayName("Typ obiektu")]
        [ValueConverter(typeof(TypeToStringConverter))]
        [ImmediatePostData]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        public Type ObjectType
        {
            get => GetPropertyValue<Type>(nameof(ObjectType));
            set => SetPropertyValue(nameof(ObjectType), value);
        }

        bool allowPublic;
        [XafDisplayName("Widoczny dla wszystkich")]
        public bool AllowPublic
        {
            get => allowPublic;
            set => SetPropertyValue(nameof(AllowPublic), ref allowPublic, value);
        }


        [MemberDesignTimeVisibility(false)]
        PermissionPolicyUser owner;
        public PermissionPolicyUser Owner
        {
            get => owner;
            set => SetPropertyValue(nameof(Owner), ref owner, value);
        }

    }
}
