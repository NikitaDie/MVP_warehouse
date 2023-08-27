using LightInject;
using PresenterLayout.Common;
using ServiceLayout.Services.GetPackage;
using ServiceLayout.Services.SuggestionService;
using System.Windows.Forms;
using Forms.MenuForms.Common;
using ModelLayout.Models.Package;
using ViewLayout;
using ViewLayout.Views;
using ServiceLayout.Services.Label;

namespace PresenterLayout.Presenters
{
    public class SearchPackagePresenter : BasePresenter<ISearchPackageView>, IParentPresenter
    {
        private readonly IApplicationController _parentController;
        private readonly IApplicationController _controller;
        private readonly ISuggestionService _suggestionService;
        private readonly IGetPackageService _packageService;
        public SearchPackagePresenter(IApplicationController controller, ISearchPackageView view, IParentPresenter parentPresenter, ISuggestionService suggestionService, IGetPackageService packageService) : base(controller, view, parentPresenter)
        {
            _parentController = controller;
            _controller = GetController();
            _suggestionService = suggestionService;
            _packageService = packageService;
        }

        public override void Run()
        {
            ParentPresenter.LoadNewForm(View);

            _controller.Run<LabelPresenter, ILabelService>(_parentController.GetInstance<ILabelService>(), new PerContainerLifetime());

            View.InputChanged += () => GetSuggestionIdCollection(View.InputText);
            View.GetPackageInfo += () => GetPackage(View.GetLabelID());
            GetPackage("0");
        }

        private void GetSuggestionIdCollection(string text)
        {
            // if numbers
            View.AutoCompleteSource = _suggestionService.GetIds(text);
        }

        private IApplicationController GetController()
        {
            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<ILabelView, PackageLabel>()
                .RegisterInstance<IParentPresenter>(this);

            return controller;
        }

        public void GetPackage(string packageId)
        {
            _controller.GetInstance<LabelPresenter>().LoadData(_packageService.GetPackage(packageId));
        }

        public void LoadNewForm(IView newForm)
        {
            View.LoadNewForm(newForm);
        }
    }
}
