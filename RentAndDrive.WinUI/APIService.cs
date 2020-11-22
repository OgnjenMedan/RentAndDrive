using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using RentAndDrive.Model;

namespace RentAndDrive.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;
        private readonly string _endpoint = $"{Properties.Settings.Default.APIUrl}";

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search = null)
        {
            var query = "";
            var url = $"{_endpoint}/{_route}";

            if (search != null)
            {
                query += "?";
                query += await search?.ToQueryString();
            }

            var list = await $"{url}{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_endpoint}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_endpoint}/{_route}";

            try
            {
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
                var url = $"{_endpoint}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            } catch (FlurlHttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
