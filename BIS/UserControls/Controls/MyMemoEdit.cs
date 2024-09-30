using BIS.UI.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.UI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit:MemoEdit,IStatusBarAciklama
    {

        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            //Not Tutulan Alan Olacaktır ....

            Properties.MaxLength = 500;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz. ";
    }
}
