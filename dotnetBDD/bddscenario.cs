using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using dotnetTDDApi;


namespace dotnetBDD
{
    using Microsoft.AspNetCore.Mvc.Testing;
    using System.Linq;
    using Xbehave;

    public class BehaveIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient client;
        private readonly WebApplicationFactory<Startup> _factory;
        public BehaveIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            client = factory.CreateClient();
        }

        [Scenario]
        public async Task Behave_API(string First, HttpClient client, HttpStatusCode answer)
        {
            HttpResponseMessage httpResponse = null;
            
            "Given the Name test"
                .x(() => First="test");


            "And Create Client for API"
                .x(() => client = _factory.CreateClient());

            "When I send First name to API"
                .x(async () =>
                {
                    httpResponse = await this.client.GetAsync("/api/Info/test");

                    // Must be successful.
                    httpResponse.EnsureSuccessStatusCode();
                    answer = httpResponse.StatusCode;
                });

            "Then the responsce should be 200"
                .x(() => Xunit.Assert.Equal(HttpStatusCode.OK, answer));

        }


        [Scenario]
        public async Task Behave_API_scenario2(string First, HttpClient client, HttpStatusCode answer)
        {
            HttpResponseMessage httpResponse = null;

            "Given the location"
                .x(() => First = "test");


            "And Create Client for API"
                .x(() => client = _factory.CreateClient());

            "When I send location to API"
                .x(async () =>
                {
                    httpResponse = await this.client.GetAsync("/api/Weather/Louisville");

                    // Must be successful.
                    httpResponse.EnsureSuccessStatusCode();
                    answer = httpResponse.StatusCode;
                    
                });

            "Then the responsce should be 200 and weather info"
                .x(async () => {
                    var responsce = await httpResponse.Content.ReadAsStringAsync();
                    Xunit.Assert.Equal(HttpStatusCode.OK, answer);
                    Assert.Contains("Temperature", responsce);
                }) ;

        }
    }
}
