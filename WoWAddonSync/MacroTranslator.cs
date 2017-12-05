using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WoWUtility
{
    class MacroTranslator
    {
        GeneralFuncs GF;
        WoWFuncs WF;
        string MacroFileName = "macros-cache.txt";

        public MacroTranslator(Boolean GermanToEnglish, string WTFPath, string[] SpellList)
        {
            GF = new GeneralFuncs();
            WF = new WoWFuncs();
            if (WTFPath != null)
            {
                if (GermanToEnglish)
                {
                    GerToEng(WTFPath, SpellList);
                }
                else
                {
                    EngToGer(WTFPath, SpellList);
                }
            }            
        }

        private void GerToEng(string WTFPath, string[] SpellList)
        {
            List<string> FileList = GF.GetAllFilePathsInFolderAndSubfolders(MacroFileName, WTFPath);

            foreach (string s in FileList)
            {
                string[] Inhalt = File.ReadAllLines(s,Encoding.UTF8);
                byte[] Data = File.ReadAllBytes(s);

                for (int i = 0; i < Inhalt.Length; i++)
                {
                    for (int j = 0; j < SpellList.Length; j++)
                    {
                        SpellList[j] = SpellList[j].Replace("Ä", "ä");
                        SpellList[j] = SpellList[j].Replace("Ö", "ö");
                        SpellList[j] = SpellList[j].Replace("Ü", "ü");

                        string[] GerToEng = SpellList[j].Split(System.Convert.ToChar(":"));

                        if (GerToEng.Length > 1)
                        {
                            GerToEng[0] = GerToEng[0].Replace(";", ":");
                            GerToEng[1] = GerToEng[1].Replace(";", ":");



                            if (Inhalt[i].ToLower().Contains(GerToEng[0].ToLower()))
                            {
                                if (GerToEng[1] == "")
                                {
                                    GerToEng[1] = GerToEng[0];
                                }

                                Inhalt[i] = Inhalt[i].Replace(GerToEng[0], GerToEng[1]);
                            }
                        }                        
                    }
                }
                File.WriteAllLines(s, Inhalt);
            }
        }

        private void EngToGer(string WTFPath, string[] SpellList)
        {
            List<string> FileList = GF.GetAllFilePathsInFolderAndSubfolders(MacroFileName, WTFPath);

            foreach (string s in FileList)
            {
                string[] Inhalt = File.ReadAllLines(s, Encoding.UTF8);

                for (int i = 0; i < Inhalt.Length; i++)
                {
                    for (int j = 0; j < SpellList.Length; j++)
                    {
                        SpellList[j] = SpellList[j].Replace("Ä", "ä");
                        SpellList[j] = SpellList[j].Replace("Ö", "ö");
                        SpellList[j] = SpellList[j].Replace("Ü", "ü");

                        string[] GerToEng = SpellList[j].Split(System.Convert.ToChar(":"));

                        if (GerToEng.Length > 1)
                        {
                            GerToEng[0] = GerToEng[0].Replace(";", ":");
                            GerToEng[1] = GerToEng[1].Replace(";", ":");

                            if (Inhalt[i].ToLower().Contains(GerToEng[1].ToLower()))
                            {
                                if (GerToEng[1] == "")
                                {
                                    GerToEng[1] = GerToEng[0];
                                }

                                Inhalt[i] = Inhalt[i].Replace(GerToEng[1], GerToEng[0]);
                            }
                            if (Inhalt[i].Contains("/benutzen"))
                            {
                                Inhalt[i] = Inhalt[i].Replace("/benutzen", "/use");
                            }
                            if (Inhalt[i].Contains("/wirken"))
                            {
                                Inhalt[i] = Inhalt[i].Replace("/wirken", "/cast");
                            }
                        }
                    }
                }
                File.WriteAllLines(s, Inhalt);
            }
        }
    }
}
