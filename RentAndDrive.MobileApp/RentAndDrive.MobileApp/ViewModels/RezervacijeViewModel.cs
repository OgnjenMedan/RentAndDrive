using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class RezervacijeViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private bool _statusRezervacije = false;
        public RezervacijeViewModel()
        {
        }

        public RezervacijeViewModel(bool statusRezervacije = false)
        {
            _statusRezervacije = statusRezervacije;
            _naslov = _statusRezervacije ? "Završene rezervacije" : "Aktivne rezervacije";
            InitCommand = new Command(async () => await Init());
        }

        string _naslov = string.Empty;

        public string Naslov 
        {
            get { return _naslov; } 
            set { SetProperty(ref _naslov, value); }
        }

        public ObservableCollection<Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Rezervacije>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            RezervacijeSearchRequest request = new RezervacijeSearchRequest()
            {
                Status = _statusRezervacije,
                KupacId = APIService.KupacId
            };

            var list = await _rezervacijeService.Get<List<Model.Rezervacije>>(request);

            RezervacijeList.Clear();

            foreach (var item in list)
            {
                RezervacijeList.Add(item);
            }

        }
    }
}
