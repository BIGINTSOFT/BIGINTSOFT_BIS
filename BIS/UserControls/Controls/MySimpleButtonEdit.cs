using BIS.UI.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace BIS.UI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButtonEdit:SimpleButton,IStatusBarAciklama
    {

        public MySimpleButtonEdit()
        {
            Appearance.ForeColor = Color.Maroon;
                 
        }

        public string StatusBarAciklama { get;set; }
    }
}
