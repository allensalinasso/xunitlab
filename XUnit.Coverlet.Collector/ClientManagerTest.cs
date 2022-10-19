using DotNetLabs.Business;

namespace XUnit.Coverlet.Collector;

public class ClientManagerTest
{
    readonly ClientManager _service;

    public ClientManagerTest() => _service = new ClientManager();

    [
        Theory,
        InlineData("Allen"), InlineData("Andrea")
    ]
    public void CreateUser_NameStartsWithA_Returns1(string name)
    {            
        int res = _service.Create(name);

        Assert.True(res == 1, "Invalid name");
    }
}