using System;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using Xunit;

namespace XUnitTestProjectSslStream
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MemoryStream stream = new MemoryStream();
            SslStream sslStream = new SslStream(stream);

            sslStream.BeginAuthenticateAsClient("google.com", null, SslProtocols.None, false, new AsyncCallback(ProcessInformation), null);
        }

        static void ProcessInformation(IAsyncResult result)
        {
        }
    }
}
