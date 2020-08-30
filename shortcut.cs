using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    class shortcut
    {


        string location1 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Favorites) + "\\酷我.lnk";

        string location2 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\酷我.lnk";

        string location3 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Programs) + "\\酷我.lnk";

        public void appshortcut()
        {

            // Create a Windows Script Host Shell class
           
            IWshShell_Class shell = new IWshShell_Class();

            // Define the shortcut file
            
            //IWshURLShortcut shortcut = shell.CreateShortcut(location1) as IWshURLShortcut;

            IWshShortcut_Class shortcut = shell.CreateShortcut(location2) as IWshShortcut_Class;

            
            shortcut.WorkingDirectory = @"E:\Program Files (x86)\KuGou\KGMusic";
            shortcut.TargetPath = @"E:\Program Files (x86)\KuGou\KGMusic\KuGou.exe";
            // Save it

            shortcut.Save();

        }
    }
}