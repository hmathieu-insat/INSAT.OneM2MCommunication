using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSAT.OneM2MCommunication
{
    public class OM2MClient : IDisposable
    {
        readonly RestClient _client;

        public OM2MClient(string baseUrl, string baseResourceIndicator, string originator)
        {

        }

        public void Dispose()
        {
            _client.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
