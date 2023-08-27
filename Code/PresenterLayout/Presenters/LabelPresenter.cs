using ModelLayout.Models.Package;
using ModelLayout.Models.User;
using PresenterLayout.Common;
using ServiceLayout.Services.GetPackage;
using ServiceLayout.Services.Label;
using System.Windows.Forms;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class LabelPresenter : BasePresenter<ILabelView, ILabelService>
    {
        private ILabelService _labelService;
        public LabelPresenter(IApplicationController controller, ILabelView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
        }

        public override void Run(ILabelService argument)
        {
            _labelService = argument;
            ParentPresenter.LoadNewForm(View);
        }

        public void LoadData(UserPackage userPackage)
        {
            View.LoadData(userPackage);
            View.BigBarcodeImage = _labelService.GetBarcode(userPackage.ID, View.BigBarcodeSize);
            View.SmallBarcodeImage = _labelService.TurnBarcodeVerticaly(_labelService.GetBarcode(userPackage.ID, View.SmallBarcodeSize));
        }


    }

}
