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
          
            File.WriteAllLines(localeFilePath,Text,Encoding.UTF8);           
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


        public string wowPath1, wowPath2;

        public void SaveSettings()
        {
            string[] Text;

            Text = new string[2];

            Text[0] = "wowPath1=" + wowPath1;
            Text[1] = "wowPath2=" + wowPath2;

            File.WriteAllLines(settingsFilePath, Text, Encoding.UTF8);
        }

        public void LoadSettings()
        {
            string[] Text = File.ReadAllLines(settingsFilePath, Encoding.UTF8);

            wowPath1 = Text[0].Replace("wowPath1=", "");
            wowPath2 = Text[1].Replace("wowPath2=", "");
        }
    }
}
