using BIS.BLL.General;
using BIS.Common.Enums;
using BIS.UI.Forms.BaseForms;
using BIS.UI.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using System.Linq;

namespace BIS.UI.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        #region Değişkenler CTRL K + S
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid; 
        #endregion


        public FiltreListForm(params object[] prm)
        {
       
            InitializeComponent();

            Bll = new FiltreService();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            //Bunlar gizlenecek
            HideItems = new BarItem[] 
            {   btnFiltrele,btnKolonlar,btnYazdir,
                btnGonder,barFiltrele,barFiltreleAciklama,
                barKolonlar,barKolonlarAciklama,barYazdir,barYazdirAciklama,barGonder,barGonderAciklama 
            };
        }

        //protected override void DegiskenleriDoldur()
        //{
        //    Tablo = tablo;
        //    BaseKartTuru = KartTuru.Filtre;
        //    Navigator = longNavigator1.Navigator;

        //}

        protected override void Listele()
        {
            //Hangi kartın türüne eşit ise onu getir
            Tablo.GridControl.DataSource = ((FiltreService)Bll).List(x=>x.KartTuru == _filtreKartTuru).ToList();
        }

        protected override void ShowEditForm(long id)
        {
            //ShowDialogEditForm static olduğu için new 'lemeden kullandık
            var result =ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id,_filtreKartTuru,_filtreGrid);
            //Burada işlem yapılacak ... 
            ShowEditFormDefault(result);
        }



    }
}