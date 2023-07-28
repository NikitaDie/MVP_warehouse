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
        public NewPackageFinalLabelPresenter(IApplicationController controller, INewPackageFinalLabelView view, IParentPresenter parentPresenter, ILabelService labelService, UserPackage userPackage) : base(controller, view, parentPresenter)
        {
            _userPackage = userPackage;
            _labelService = labelService;

            View.NewPackage += NewPackage;
        }

        public override void Run()
        {
            View.BigBarcodeImage = _labelService.GetBarcode(_userPackage.ID, View.BigBarcodeSize);
            View.SmallBarcodeImage = _labelService.TurnBarcodeVerticaly(_labelService.GetBarcode(_userPackage.ID, View.SmallBarcodeSize));
            
            (ParentPresenter as NewPackageContainerPresenter)?.SetProgressBar(4);
            ParentPresenter.LoadNewForm(View);
        }

        private void NewPackage()
        {
            View.Close();
            (ParentPresenter as NewPackageContainerPresenter)?.NewPackage();
        }
    }
}
