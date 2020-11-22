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
    public class AutomobiliViewModel : BaseViewModel
    {
        private readonly APIService _automobiliService = new APIService("Automobili");
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        

        public ObservableCollection<Model.Automobili> automobiliList { get; set; } = new ObservableCollection<Model.Automobili>();
        public ObservableCollection<Model.Ocjene> ocjeneList { get; set; } = new ObservableCollection<Model.Ocjene>();

        public ICommand InitCommand { get; set; }

        public AutomobiliViewModel()
        {
            Title = "Automobili";
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init(AutomobiliSearchRequest filterRequest = null)
        {

            filterRequest.Aktivno = true;

            var listaAutomobila = await _automobiliService.Get<List<Model.Automobili>>(filterRequest);

            automobiliList.Clear();

            foreach (var item in listaAutomobila)
            {
                OcjeneSearchRequest ocjeneRequest = new OcjeneSearchRequest()
                {
                    AutomobilId = item.AutomobilId
                };

                var listaOcjena = await _ocjeneService.Get<List<Model.Ocjene>>(ocjeneRequest);
                var brojOcjena = listaOcjena.Count;

                if (brojOcjena > 0)
                {
                    double suma = 0;

                    foreach (var ocjenaAutomobila in listaOcjena)
                    {
                        suma += ocjenaAutomobila.Ocjena;
                    }

                    double prosjecnaOcjenaAutomobila = suma / brojOcjena;

                    item.Model.Naziv += $", Ocjena: {prosjecnaOcjenaAutomobila.ToString("#.#")}";
                }

                automobiliList.Add(item);
            }
        }
    }
}
