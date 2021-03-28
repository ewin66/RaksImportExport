using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JK.XAF.Module.BusinessObjects.Common
{
    [DefaultClassOptions]
    [NavigationItem("Konfiguracja")]
    [XafDisplayName("Dodatkowe reguły wyglądu")]
    public class CustomApperance : XPObject, IAppearanceRuleProperties, ICheckedListBoxItemsProvider
    {
        private AppearanceContext _appearanceContext;
        private ViewItemVisibility? _itemVisibility;
        private string _selectedProperties;

        public CustomApperance(Session session) : base(session)
        {
        }

        public event EventHandler ItemsChanged;

        [Index(2)]
        [XafDisplayName("Kolor tła")]
        [ValueConverter(typeof(ColorValueConverter))]
        public Color? BackColor
        {
            get { return GetPropertyValue<Color?>(nameof(BackColor)); }
            set { SetPropertyValue(nameof(BackColor), value); }
        }

        [Index(3)]
        [ValueConverter(typeof(ColorValueConverter))]
        [XafDisplayName("Kolor czcionki")]
        public Color? ForeColor
        {
            get { return GetPropertyValue<Color?>(nameof(ForeColor)); }
            set { SetPropertyValue(nameof(ForeColor), value); }
        }

        [Index(1)]
        [XafDisplayName("Typ obiektu")]
        [ValueConverter(typeof(TypeToStringConverter))]
        [ImmediatePostData]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        public Type DataType
        {
            get { return GetPropertyValue<Type>(nameof(DataType)); }
            set
            {
                bool modified = SetPropertyValue(nameof(DataType), value);
                if (!IsSaving && !IsLoading && modified)
                {
                    OnItemsChanged();
                }
            }
        }

        [CriteriaOptions(nameof(DataType))]
        [Size(SizeAttribute.Unlimited)]
        [XafDisplayName("Warunek")]
        [EditorAlias(EditorAliases.CriteriaPropertyEditor)]
        public string Criterion
        {
            get { return GetPropertyValue<string>(nameof(Criterion)); }
            set { SetPropertyValue(nameof(Criterion), value); }
        }

        [Index(5)]
        [Size(SizeAttribute.Unlimited)]
        [XafDisplayName("Wybrane pola")]
        [EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string SelectedProperties
        {
            get { return _selectedProperties; }
            set { SetPropertyValue(nameof(SelectedProperties), ref _selectedProperties, value); }
        }

        [XafDisplayName("Widoczność")]
        public ViewItemVisibility? ItemVisibility
        {
            get { return _itemVisibility; }
            set { SetPropertyValue(nameof(ItemVisibility), ref _itemVisibility, value); }
        }

        [XafDisplayName("Kontekst")]
        [Index(6)]
        public AppearanceContext AppearanceContext
        {
            get { return _appearanceContext; }
            set { SetPropertyValue(nameof(AppearanceContext), ref _appearanceContext, value); }
        }

        [Index(4)]
        [XafDisplayName("Syl czcionki")]
        public FontStyle? FontStyle
        {
            get { return GetPropertyValue<FontStyle?>(nameof(FontStyle)); }
            set { SetPropertyValue(nameof(FontStyle), value); }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public string TargetItems
        {
            get { return string.IsNullOrEmpty(SelectedProperties) ? "*" : SelectedProperties; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public string AppearanceItemType
        {
            get { return nameof(DevExpress.ExpressApp.ConditionalAppearance.AppearanceItemType.ViewItem); }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public string Criteria
        {
            get { return string.IsNullOrEmpty(Criterion) ? "True" : Criterion; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public string Method
        {
            get { return string.Empty; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public string Context
        {
            get { return AppearanceContext.ToString(); }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        public Type DeclaringType => DataType;

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public int Priority
        {
            get { return 5; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public Color? FontColor
        {
            get { return ForeColor; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public ViewItemVisibility? Visibility
        {
            get { return ItemVisibility; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        [NonPersistent]
        public bool? Enabled
        {
            get { return null; }
            set
            {
            }
        }

        public Dictionary<object, string> GetCheckedListBoxItems(string targetMemberName)
        {
            Dictionary<object, string> properties = new Dictionary<object, string>();
            if (targetMemberName == nameof(SelectedProperties) && DataType != null)
            {
                ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(DataType);
                foreach (IMemberInfo memberInfo in typeInfo.Members)
                {
                    if (memberInfo.IsVisible)
                    {
                        properties.Add(memberInfo.Name, CaptionHelper.GetMemberCaption(typeInfo, memberInfo.Name));
                    }
                }
            }
            return properties;
        }

        protected void OnItemsChanged() { ItemsChanged?.Invoke(this, new EventArgs()); }

        [MemberDesignTimeVisibility(false)]
        Color? IAppearance.BackColor
        {
            get { return BackColor; }
            set
            {
            }
        }

        [MemberDesignTimeVisibility(false)]
        FontStyle? IAppearance.FontStyle
        {
            get { return FontStyle; }
            set
            {
            }
        }
    }
}
