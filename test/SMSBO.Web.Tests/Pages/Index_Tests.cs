using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SMSBO.Pages;

public class Index_Tests : SMSBOWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
