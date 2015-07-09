using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using YTtoPlayer.Core.Models;

namespace YTtoPlayer.View.Helpers
{
    public class WpfLocationPicker : ILocationPicker
    {
        public string ChooseLocation()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string selectedPath = folderBrowserDialog.SelectedPath;

            return selectedPath;
        }
    }
}
