using System.Resources;

namespace CircleInnovation.Helper.Resources
{
    public class ResourceHelper
    {
        public static string GetMessage(string keyName)
        {
            ResourceManager rm = new ResourceManager(typeof(Message));
            string message = rm.GetString(keyName);
            return message;
        }
    }
}
