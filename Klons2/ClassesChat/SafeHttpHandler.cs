using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KlonsF.ClassesChat
{
    public class SafeHttpHandler : DelegatingHandler
    {
        public SafeHttpHandler(HttpMessageHandler innerHandler)
            : base(innerHandler) { }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            try
            {
                return await base.SendAsync(request, cancellationToken);
            }
            catch (SocketException ex)
            {
                // Create an artificial 503 response
                return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable)
                {
                    ReasonPhrase = "SocketException: " + ex.Message,
                    Content = new StringContent(ex.ToString()),
                    RequestMessage = request
                };
            }
            catch (HttpRequestException ex) when (ex.InnerException is SocketException)
            {
                return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable)
                {
                    ReasonPhrase = "SocketException: " + ex.InnerException?.Message,
                    Content = new StringContent(ex.ToString()),
                    RequestMessage = request
                };
            }
        }
    }

}
