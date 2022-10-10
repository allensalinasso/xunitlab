using DotNetLabs.Business;

namespace XUnit.Coverlet.Collector;

public class ClientManagerTest
{
    readonly ClientManger _service;

    public ClientManagerTest() => _service = new ClientManger();

    [
        Theory,
        InlineData("Allen"), InlineData("Santiago")
    ]
    public void Test1(string name)
    {            
        int res = _service.Create(name);

        Assert.True(res > 0, "Invalid name");
    }
}