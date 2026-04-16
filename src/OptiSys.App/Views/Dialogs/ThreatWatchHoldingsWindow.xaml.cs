using System.Windows;
using OptiSys.App.ViewModels.Dialogs;

namespace OptiSys.App.Views.Dialogs;

public partial class ThreatWatchHoldingsWindow : Window
{
    public ThreatWatchHoldingsWindow(ThreatWatchHoldingsDialogViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void CloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }
}
