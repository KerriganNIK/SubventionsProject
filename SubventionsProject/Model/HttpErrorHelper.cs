using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject.Model
{
    public class HttpErrorHelper
    {
        public static string GetErrorMessage(HttpResponseMessage httpResponseMessage)
        {
            var deserializedError = JsonConvert.DeserializeObject<HttpError>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            return deserializedError.Title;
        }
    }
}
