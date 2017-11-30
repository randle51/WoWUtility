using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace WoWUtility
{
    public class Settings
    {
        string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        string settingsFileName = "Settings.ini";
        string settingsFilePath;

        string localeFileName = "locale.ini";
        string localeFilePath;

        string[] Spells;

        public Settings(string Path = "")
        {
            if (Path != "")
            {
                currentPath = Path;
            }

            if (currentPath != null)
            {
                settingsFilePath = currentPath + "\\" + settingsFileName;
                localeFilePath = currentPath + "\\" + localeFileName;
            }
            CreateIniFiles();
            FillSpellList(localeFilePath);

        }

        private void CreateIniFiles()
        {
            if (!File.Exists(settingsFilePath))
            {
                File.Create(settingsFilePath);
            }

            if (!File.Exists(localeFilePath))
            {
                WriteSampleLocale();
            }
        }

        private void WriteSampleLocale()
        {
            string[] Text;
            Text = new string[2];

            Text[0] = "German:English";
            Text[1] = "Fluch der Sprachen:Curse of Tongues";
          
            File.WriteAllLines(localeFilePath,Text);           
        }

        private void FillSpellList(string LocaleFileName = "")
        {
            Spells = File.ReadAllLines(LocaleFileName);
            for(int i = 0; i < Spells.Length;i++)
            {
                if (Spells[i].StartsWith("-"))
                {
                    Spells[i] = "";
                }
            }
        }

        public string[] GetSpellList()
        {
            FillSpellList(localeFilePath);
            return Spells;
        }
    }
}
