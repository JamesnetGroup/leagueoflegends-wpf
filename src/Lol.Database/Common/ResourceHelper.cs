namespace Lol.Database.Common
{
    internal class ResourceHelper
    {
        internal static string ImgResource(string fullName)
        {
            string folder = "";
            string name = "";

            if (fullName != null)
            {
                string[] strs = fullName.Split(',');

                if (strs.Count() < 2)
                    return fullName;

                folder = strs[0];
                name = strs[1];
            }

            string[] folderPath = System.Environment.CurrentDirectory.Split("Leagueoflegends");
            string imagePath = Path.Combine(folderPath[0], @"Lol.Resources\Images", folder);
            DirectoryInfo di = new DirectoryInfo(imagePath);

            foreach (FileInfo row in di.GetFiles())
            {
                if (name == Path.GetFileNameWithoutExtension(row.Name))
                {
                    return $"/Lol.Resources;component/Images/{folder}/{row.Name}";
                }
            }
            return "";
        }
    }
}
