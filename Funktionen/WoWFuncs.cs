using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Funktionen
{
    class WoWFuncs
    {
        public Boolean IsWoWFolder(String FolderPath)
        {
            if (FolderPath != null)
            {
                DirectoryInfo di = new DirectoryInfo(FolderPath);
                FileInfo[] WoWEXE = di.GetFiles("WoW*.exe");
                if (WoWEXE.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public Int16[] GetAddonVersion(String FolderPath)
        {            
            DirectoryInfo di = new DirectoryInfo(FolderPath);  
            FileInfo[] Files = di.GetFiles();
            string AddonName = Path.GetFileName(Path.GetDirectoryName(Files[0].FullName));
            
            FileInfo[] TOC = di.GetFiles(AddonName + ".toc");
            if (TOC.Length > 0)
            {
                string[] Inhalt = File.ReadAllLines(FolderPath + "\\" + AddonName + ".toc");

                for (int i = 0; i< Inhalt.Length; i++)
                {
                    if (Inhalt[i].Contains("Version"))
                    {
                        string Version = Inhalt[i];
                        Version = Version.Replace("#", "");
                        Version = Version.Replace("Version", "");
                        Version = Version.Replace(":", "");
                        Version = Version.Replace("v", "");
                        Version = Version.Replace(" ", "");

                        string[] VersionSubs = Version.Split(Convert.ToChar("."));

                        Int16[] VersionNumbers = new Int16[VersionSubs.Length];
                        for (int j = 0; j < VersionNumbers.Length; j++)
                        {
                            VersionNumbers[j] = Convert.ToInt16(VersionSubs[j]);
                        }
                        return VersionNumbers;
                    }
                }                
            }
            return null;
        }

        public Boolean IsNewerAddonVersion(Int16[] NewCheck, Int16[] OldCheck)
        {
            if (NewCheck.Length == OldCheck.Length && NewCheck.Length  > 0)
            {
                for (int i = 0; i < NewCheck.Length; i++)
                {
                    if (NewCheck[i] > OldCheck[i])
                    {
                        return true;
                    }
                }
            }            
            return false;
        }

        public string[] GetAddonList(string WoWPath)
        {
            string Pfad;

            if (IsWoWFolder(WoWPath))
            {
                Pfad = WoWPath + "\\Interface\\AddOns";
                string[] Addons = Directory.GetDirectories(Pfad);

                for(int i=0;i<Addons.Length;i++)
                {
                    DirectoryInfo di = new DirectoryInfo(Addons[i]);
                    FileInfo[] Files = di.GetFiles();
                    string AddonName = Path.GetFileName(Path.GetDirectoryName(Files[0].FullName));
                    Addons[i] = AddonName;
                }
               

                return Addons;
            }
            return null;
        }
    }
}
