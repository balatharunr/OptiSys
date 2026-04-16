using OptiSys.App.ViewModels;

namespace OptiSys.App.ViewModels.Preview;

public interface IPreviewFilter
{
    bool Matches(CleanupPreviewItemViewModel item);
}
