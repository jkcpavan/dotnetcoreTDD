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

    public class Calculator
    {
        public int Add(int x, int y) => x + y;
    }

    public class CalculatorFeature
    {
        [Scenario]
        public void Addition(int x, int y, Calculator calculator, int answer)
        {
            "Given the number 1"
                .x(() => x = 1);

            "And the number 2"
                .x(() => y = 2);

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Xunit.Assert.Equal(3, answer));
        }

    }

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
    }
}
