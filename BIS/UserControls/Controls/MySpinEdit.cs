using BIS.UI.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace BIS.UI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit:SpinEdit,IStatusBarAciklama
    {

        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;

            Properties.AllowNullInput =DefaultBoolean.False;

            //Spin işleminde sadece sayı olacak.
            Properties.Mask.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
