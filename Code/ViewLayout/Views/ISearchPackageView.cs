using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface ISearchPackageView : IBaseView
    {
        List<string> AutoCompleteSource { set; }
        string InputText { get; }

        event Action InputChanged;
        event Action GetPackageInfo;

        string GetLabelID();
    }
}
