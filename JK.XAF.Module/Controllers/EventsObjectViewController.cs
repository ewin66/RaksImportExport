using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JK.XAF.Module.Controllers
{
    public abstract class EventsObjectViewController<ViewType, ObjectType> : ObjectViewController<ViewType, ObjectType>
        where ViewType : ObjectView
    {
        private readonly EventInfo _controlValueChangedEventInfo = typeof(PropertyEditor).GetEvent(nameof(PropertyEditor.ControlValueChanged));
        private ModificationsController _modificationsController;
        private readonly Dictionary<PropertyEditor, Delegate> _paryPropertyEditorControlValueChangedDelegate = new Dictionary<PropertyEditor, Delegate>();
        private readonly Dictionary<PropertyEditor, Delegate> _paryPropertyEditorValueStoredDelegate = new Dictionary<PropertyEditor, Delegate>();
        private RefreshController _refreshController;
        private readonly EventInfo _valueStoredEventInfo = typeof(PropertyEditor).GetEvent(nameof(PropertyEditor.ValueStored));

        protected virtual Dictionary<string, string> ParyNazwaWlasnosciNazwaMetodyControlValueChanged { get; } = new Dictionary<string, string>();

        protected virtual Dictionary<string, string> ParyNazwaWlasnosciNazwaMetodyValueStored { get; } = new Dictionary<string, string>();

        protected override void OnActivated()
        {
            base.OnActivated();
            SubscribeToEventsFromDictionaries();
            SubscribeToEvents();

            _refreshController = Frame.GetController<RefreshController>();
            if(_refreshController != null)
            {
                _refreshController.RefreshAction.Executed += RefreshAction_Executed;
            }

            _modificationsController = Frame.GetController<ModificationsController>();
            if(_modificationsController != null)
            {
                _modificationsController.CancelAction.Executed += CancelAction_Executed;
            }

            PrepareView();
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
            UnsubscribeFromEvents();
            UnsubscribeFromEventsFromDictionary(_paryPropertyEditorControlValueChangedDelegate);
            UnsubscribeFromEventsFromDictionary(_paryPropertyEditorValueStoredDelegate);

            if(_refreshController != null)
            {
                _refreshController.RefreshAction.Executed -= RefreshAction_Executed;
            }

            if(_modificationsController != null)
            {
                _modificationsController.CancelAction.Executed -= CancelAction_Executed;
            }
        }

        protected virtual void PrepareView()
        {
        }

        protected virtual void SubscribeToEvents()
        {
        }

        protected virtual void UnsubscribeFromEvents()
        {
        }

        private void CancelAction_Executed(object sender, ActionBaseEventArgs e)
        {
            PrepareView();
        }

        private void RefreshAction_Executed(object sender, ActionBaseEventArgs e)
        {
            PrepareView();
        }

        private void SubscribeToEventsFromDictionaries()
        {
            SubscribeToEventsFromDictionary(ParyNazwaWlasnosciNazwaMetodyControlValueChanged,
                                            _controlValueChangedEventInfo,
                                            _paryPropertyEditorControlValueChangedDelegate);
            SubscribeToEventsFromDictionary(ParyNazwaWlasnosciNazwaMetodyValueStored, _valueStoredEventInfo, _paryPropertyEditorValueStoredDelegate);
        }

        private void SubscribeToEventsFromDictionary(Dictionary<string, string> paryNazwaWlasnosciNazwaMetody,
                                                     EventInfo eventInfo,
                                                     Dictionary<PropertyEditor, Delegate> paryPropertyEditorDelegate)
        {
            foreach(KeyValuePair<string, string> para in paryNazwaWlasnosciNazwaMetody)
            {
                if(View.FindItem(para.Key) is PropertyEditor propertyEditor)
                {
                    MethodInfo metoda = GetType().GetMethod(para.Value, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                    Delegate delegat = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, metoda);
                    eventInfo.AddEventHandler(propertyEditor, delegat);

                    paryPropertyEditorDelegate.Add(propertyEditor, delegat);
                }
            }
        }

        private void UnsubscribeFromEventsFromDictionary(Dictionary<PropertyEditor, Delegate> paryPropertyEditorDelegate)
        {
            foreach(KeyValuePair<PropertyEditor, Delegate> para in paryPropertyEditorDelegate.ToList())
            {
                _controlValueChangedEventInfo.RemoveEventHandler(para.Key, para.Value);

                paryPropertyEditorDelegate.Remove(para.Key);
            }
        }
    }
}
