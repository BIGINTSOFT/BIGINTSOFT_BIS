using BIS.UI.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.UI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl:FilterControl,IStatusBarAciklama
    {

        public MyFilterControl()
        {
            // Gruplama yaparken icon' çıkmasını sağlar , default False'dir
            ShowGroupCommandsIcon = true;

        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";

    }
}
