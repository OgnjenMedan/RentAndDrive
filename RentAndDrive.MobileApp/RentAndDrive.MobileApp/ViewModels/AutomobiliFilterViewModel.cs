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
    public class AutomobiliFilterViewModel : BaseViewModel
    {
        private APIService _proizvodjaciService = new APIService("Proizvodjaci");
        private APIService _modeliService = new APIService("Modeli");

        string _cijenaOd = string.Empty;
        public string CijenaOd
        {
            get { return _cijenaOd; }
            set { SetProperty(ref _cijenaOd, value); }
        }

        string _cijenaDo = string.Empty;
        public string CijenaDo
        {
            get { return _cijenaDo; }
            set { SetProperty(ref _cijenaDo, value); }
        }

        int _selectedBrojVrata;
        public int SelectedBrojVrata
        {
            get { return _selectedBrojVrata; }
            set { SetProperty(ref _selectedBrojVrata, value); }
        }

        string _tipGorivaSelected = string.Empty;
        public string SelectedTipGoriva
        {
            get { return _tipGorivaSelected; }
            set { SetProperty(ref _tipGorivaSelected, value); }
        }

        Model.Proizvodjaci _selectedProizvodjac = null;
        public Model.Proizvodjaci SelectedProizvodjac
        {
            get { return _selectedProizvodjac; }
            set { SetProperty(ref _selectedProizvodjac, value); }
        }

        Model.Modeli _selectedModel = null;
        public Model.Modeli SelectedModel
        {
            get { return _selectedModel; }
            set { SetProperty(ref _selectedModel, value); }
        }

        public AutomobiliFilterViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Title = "Filter automobila";
        }

        public ICommand InitCommand { get; set; }
        public ObservableCollection<int> BrojVrataList { get; set; } = new ObservableCollection<int>() { 3, 5 };
        public ObservableCollection<string> TipGorivaList { get; set; } = new ObservableCollection<string>() { "Benzin", "Dizel" };
        public ObservableCollection<Model.Proizvodjaci> ProizvodjaciList { get; set; } = new ObservableCollection<Model.Proizvodjaci>();
        public ObservableCollection<Model.Modeli> ModeliList { get; set; } = new ObservableCollection<Model.Modeli>();


        public async Task Init()
        {
            await FillProizvodjaciList();
            await FillModeliList();
        }

        private async Task FillProizvodjaciList()
        {
            var response = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>(null);

            if (response.Count > 0)
            {
                foreach (var proizvodjac in response)
                {
                    ProizvodjaciList.Add(proizvodjac);
                }
            }
        }

        public async Task FillModeliList(int proizvodjacId = 0)
        {
            List<Model.Modeli> response = new List<Model.Modeli>();

            ModeliList.Clear();

            if (proizvodjacId > 0)
            {
                ModeliSearchRequest request = new ModeliSearchRequest()
                {
                    ProizvodjacId = proizvodjacId
                };

                response = await _modeliService.Get<List<Model.Modeli>>(request);
            } else
            {
                response = await _modeliService.Get<List<Model.Modeli>>(null);
            }


            if (response.Count > 0)
            {
                foreach (var model in response)
                {
                    ModeliList.Add(model);
                }
            }
        }


    }
}
