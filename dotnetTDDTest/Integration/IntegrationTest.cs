using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using dotnetTDDApi;
public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    private readonly WebApplicationFactory<Startup> _factory;
    public IntegrationTests(WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CanGet()
    {
        // The endpoint or route of the controller action.
        var httpResponse = await _client.GetAsync("/api/Info/test");

        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
    }
}