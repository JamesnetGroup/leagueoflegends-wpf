namespace Lol.YamlDatabase.Common
{
    internal class ResourceHelper
    {
        internal static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        internal static string ImgResourceJpg(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.jpg";
        }

        internal static string ImgResource(string pullName)
        {
            string folder = "";
            string name = "";
            if (pullName != null)
            {
                string[] strs = pullName.Split(',');
                folder = strs[0];
                name = strs[1];
            }
            return ImgResource(folder, name);
        }

        internal static string ImgResourceJpg(string pullName)
        {
            string folder = "";
            string name = "";
            if (pullName != null)
            {
                string[] strs = pullName.Split(',');
                folder = strs[0];
                name = strs[1];
            }
            return ImgResourceJpg(folder, name);
        }
    }
}
