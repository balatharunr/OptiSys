using System;
using System.Windows;
using OptiSys.App.ViewModels.Dialogs;
using MessageBox = System.Windows.MessageBox;

namespace OptiSys.App.Views.Dialogs;

public partial class ProcessQuestionnaireWindow : Window
{
    public ProcessQuestionnaireWindow(ProcessQuestionnaireDialogViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
    }

    private void RunButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (DataContext is not ProcessQuestionnaireDialogViewModel viewModel)
        {
            return;
        }

        if (!viewModel.TryCommitAnswers(out var error))
        {
            var message = string.IsNullOrWhiteSpace(error) ? "Complete all required questions." : error;
            MessageBox.Show(message, "Process questionnaire", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        DialogResult = true;
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }
}
