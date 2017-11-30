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

            if (GermanToEnglish)
            {
                GerToEng(WTFPath, SpellList);
            }
            else
            {
                EngToGer(WTFPath, SpellList);
            }
        }

        private void GerToEng(string WTFPath, string[] SpellList)
        {
            List<string> FileList = GF.GetAllFilePathsInFolderAndSubfolders(MacroFileName, WTFPath);

            foreach (string s in FileList)
            {
                string[] Inhalt = File.ReadAllLines(s);

                for (int i = 0; i < Inhalt.Length; i++)
                {
                    for (int j = 0; j < SpellList.Length; j++)
                    {
                        if (Inhalt[i].Contains(SpellList[j].Split(System.Convert.ToChar(":"))[0]))
                        {
                            Inhalt[i] = Inhalt[i].Replace(SpellList[j].Split(System.Convert.ToChar(":"))[0], SpellList[j].Split(System.Convert.ToChar(":"))[1]);
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
                string[] Inhalt = File.ReadAllLines(s);

                for (int i = 0; i < Inhalt.Length; i++)
                {
                    for (int j = 0; j < SpellList.Length; j++)
                    {
                        if (Inhalt[i].Contains(SpellList[j].Split(System.Convert.ToChar(":"))[1]))
                        {
                            Inhalt[i] = Inhalt[i].Replace(SpellList[j].Split(System.Convert.ToChar(":"))[1], SpellList[j].Split(System.Convert.ToChar(":"))[0]);
                        }
                        if (Inhalt[i].Contains("/benutzen"))
                        {
                            Inhalt[i] = Inhalt[i].Replace("/benutzen", "/use");
                        }
                    }
                }

                File.WriteAllLines(s, Inhalt);
            }
        }
    }
}
