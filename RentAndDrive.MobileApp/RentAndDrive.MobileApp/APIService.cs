using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using RentAndDrive.Model;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int KupacId { get; set; }

        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

#if DEBUG
        private string _apiUrl = "http://localhost:52223/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api";     
#endif

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            } catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešno korisničko ime ili lozinka.", "U redu");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (request is Model.Requests.KupciUpsertRequest)
                    return await url.PostJsonAsync(request).ReceiveJson<T>();
                else
                    return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            } catch (FlurlHttpException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            } catch (FlurlHttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
