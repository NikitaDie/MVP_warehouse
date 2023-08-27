using ModelLayout.Models.Package;

namespace ServiceLayout.Services.GetPackage
{
    public interface IGetPackageService
    {
        UserPackage GetPackage(string id);
    }
}
