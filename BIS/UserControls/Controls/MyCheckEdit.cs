using BIS.UI.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace BIS.UI.UserControls.Controls
{
    [ToolboxItem(true)]
    //Buton özelliği olmayanlar IStatusBarAciklama'dan implemente oluyor ...
    public class MyCheckEdit : CheckEdit,IStatusBarAciklama
    {

        public MyCheckEdit()
        {
            Properties.Appearance.BackColor =Color.Transparent;
        }


        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
