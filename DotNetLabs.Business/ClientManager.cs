namespace DotNetLabs.Business;
public class ClientManger : IClientManager
{
    public int Create(string name)
    {
        if (name.StartsWith("A"))
        {
            return 1;
        }else if (name.StartsWith("B"))
        {
            return 2;
        }

        return 0;
    }
}

