using ERV.Models;
using System.Collections.ObjectModel;
using Template10.Mvvm;

namespace ERV.ViewModels
{
    public class PresencePreviewViewModel : ViewModelBase

    {
        public PresencePreviewViewModel()
        {
            PresenceEmployees = new ObservableCollection<PresencePreviewModel>
            {
                new PresencePreviewModel(true,"Adam"),
                new PresencePreviewModel(true,"Pera"),
                new PresencePreviewModel { IsPresence=true, PresenceEmpName="Slobodan" },
                new PresencePreviewModel(true,"Ceda"),
                new PresencePreviewModel(true,"Tuba"),
                new PresencePreviewModel { IsPresence=true, PresenceEmpName="Zex" }



            };
        }

        public ObservableCollection<PresencePreviewModel> PresenceEmployees { get; set; }
    }
}