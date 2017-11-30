using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Funktionen
{   
    class GeneralFuncs
    {
        public string OpenFileDialog()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }

            return "";
        }

        public void CopyFolder(string From_Path, string To_Path)
        {
            foreach (string newPath in Directory.GetFiles(From_Path, "*.*", SearchOption.AllDirectories)) File.Copy(newPath, newPath.Replace(From_Path, To_Path), true);
        }
    }
}
