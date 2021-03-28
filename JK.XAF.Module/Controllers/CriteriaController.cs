
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using JK.XAF.Module.BusinessObjects;

using System;
using System.Collections.Generic;
using System.Linq;

namespace JK.XAF.Module.Controllers
{
    public class CriteriaController : ViewController<ListView>
    {
        private const string CHOICE_ACTION_ITEM_ALL = "ALL";

        private readonly SingleChoiceAction filteringCriterionAction;
        private readonly SimpleAction saveGridFilterAction;

        public CriteriaController()
        {
            filteringCriterionAction = new SingleChoiceAction(this, "FilteringCriterion", PredefinedCategory.Filters);
            filteringCriterionAction.Caption = "Filtruj";
            filteringCriterionAction.ToolTip = "Ustaw predefiniowany filtr na liscie";
            filteringCriterionAction.Execute += new SingleChoiceActionExecuteEventHandler(FilteringCriterionAction_Execute);

            saveGridFilterAction = new SimpleAction(this, "SaveGridFilter", PredefinedCategory.Filters);
            saveGridFilterAction.Caption = "Zapisz filtr";
            saveGridFilterAction.ToolTip = "Zapisz filtr zastosowany na liście w celu powtórnego wykorzystania";
            saveGridFilterAction.ImageName = "EditFilter";
            saveGridFilterAction.Execute += SaveGridFilterAction_Execute;
        }

        public void RefreshFilter(string activeFilterString)
        {
            if (View.Model.Filter == activeFilterString)
            {
                return;
            }

            RefreshActionItems();
            if (string.IsNullOrEmpty(activeFilterString))
            {
                SetAllItem();
            }
        }

        protected override void OnActivated()
        {
            //if(((IModelAllowFilteringCriterion)Application.Model.Options).WlaczFiltry)
            //{
          //  Frame.GetController<FilterController>().SetFilterAction.Active.SetItemValue("Visible", false);

            RefreshActionItems();

            if (string.IsNullOrEmpty(View.Model.Filter))
            {
                SetAllItem();
            }
        }

        private void FilteringCriterionAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {
            string data = e.SelectedChoiceActionItem.Data as string;
            View.Model.Filter = data;
            View.LoadModel(true);
        }

        private void RefreshActionItems()
        {
            filteringCriterionAction.Items.Clear();


            IEnumerable<FilteringCriterion> criterions = ObjectSpace.GetObjects<FilteringCriterion>();
            criterions = from FilteringCriterion cl in criterions orderby cl.Description select cl;

            //foreach (FilteringCriterion criterion in criterions)
            //{
            //    try
            //    {
            //        if (criterion.Objekt.IsAssignableFrom(View.ObjectTypeInfo.Type) &&
            //       (criterion.Public || criterion.User.UserName == SecuritySystem.CurrentUserName))
            //        {
            //            filteringCriterionAction.Items.Add(
            //                new ChoiceActionItem(criterion.Beschreibung, criterion.FilterKriterium));
            //        }
            //    }
            //    catch { }
            //}

            foreach (FilteringCriterion criterion in criterions)
            {
                if (criterion.ObjectType != null && criterion.ObjectType.IsAssignableFrom(View.ObjectTypeInfo.Type) && (criterion.AllowPublic || criterion.Owner.UserName == SecuritySystem.CurrentUserName))
                {
                    filteringCriterionAction.Items.Add(new ChoiceActionItem(criterion.Description, criterion.Criterion));
                }
            }

            //foreach (ChoiceActionItem filter in Frame.GetController<FilterController>().SetFilterAction.Items)
            //{
            //    if (filter.Data != null)
            //    {
            //        filteringCriterionAction.Items.Add(new ChoiceActionItem(filter.Caption, filter.Data));
            //    }
            //}

            if (filteringCriterionAction?.Items?.Count > 0)
            {
                filteringCriterionAction.Items.Add(new ChoiceActionItem(CHOICE_ACTION_ITEM_ALL, "Wszystkie", null));
            }
        }

        private void SaveGridFilterAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            ISupportFilter editor = View.Editor as ISupportFilter;
            if (editor != null && !string.IsNullOrEmpty(editor.Filter))
            {
                IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(FilteringCriterion));
                FilteringCriterion filteringCriterion = objectSpace.CreateObject<FilteringCriterion>();
                filteringCriterion.ObjectType = View.ObjectTypeInfo.Type;
                filteringCriterion.Criterion = editor.Filter;

                filteringCriterion.AllowPublic = true;
                filteringCriterion.Owner = objectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName));


                string FilteringDetailId = Application.FindDetailViewId(typeof(FilteringCriterion));
                DetailView view = Application.CreateDetailView(objectSpace, FilteringDetailId, true, filteringCriterion);
                e.ShowViewParameters.CreatedView = view;
                e.ShowViewParameters.Context = TemplateContext.View;
                e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow;

                view.ModelSaved += View_ModelSaved;



            }
        }

        private void SetAllItem()
        {
            ChoiceActionItem allchoiceActionItem = filteringCriterionAction.Items.FindItemByID(CHOICE_ACTION_ITEM_ALL);
            filteringCriterionAction.SelectedItem = allchoiceActionItem;
        }

        private void View_ModelSaved(object sender, EventArgs e)
        {
            RefreshActionItems();
        }
    }
}
