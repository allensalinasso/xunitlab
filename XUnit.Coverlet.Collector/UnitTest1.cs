using DotNetLabs.Business;

namespace XUnit.Coverlet.Collector;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        IClientManager c = new ClientManger();
            
        int res = c.Create("Allen");

        Assert.True(res > 0);
    }
}