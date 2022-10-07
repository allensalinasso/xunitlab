namespace DotNetLabs.Business;
public class ClientManger : IClientManager
{
    public int Create(string name)
    {
        if (name == "Allen")
        {
            return 1;
        }

        return 0;
    }
}

