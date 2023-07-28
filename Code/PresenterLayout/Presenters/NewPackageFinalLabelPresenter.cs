using System.Runtime.InteropServices.JavaScript;
using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ServiceLayout.Services.Label;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackageFinalLabelPresenter : BasePresenter<INewPackageFinalLabelView>
    {
        private readonly ILabelService _labelService;
        private readonly UserPackage _userPackage;
        public NewPackageFinalLabelPresenter(IApplicationController controller, INewPackageFinalLabelView view, IBaseView baseView, ILabelService labelService, UserPackage userPackage) : base(controller, view, baseView)
        {
            _userPackage = userPackage;
            _labelService = labelService;
        }

        public override void Run()
        {
            View.BigBarcodeImage = _labelService.GetBarcode(_userPackage.ID.ToString(), View.BigBarcodeSize);
            View.SmallBarcodeImage = _labelService.TurnBarcodeVerticaly(_labelService.GetBarcode(_userPackage.ID.ToString(), View.SmallBarcodeSize));
            if (BaseView is INewPackageContainerView view)
                view.SetProgressBar(4);
            BaseView.LoadNewForm(View);
        }

        private void NewPackage()
        {
            //Package.
        }
    }
}
