using dotnetTDDApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace dotnetTDDTest.Contract
{
    public class ContractTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly WebApplicationFactory<Startup> _factory;
        public ContractTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Contract_Test_Swagger_avilable()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
            var responsce = await httpResponse.Content.ReadAsStringAsync();
            Assert.Contains("Swagger",responsce);
        }
    }
}