
namespace LevelEditor.View
{
    using System.Windows;
    using System.Windows.Input;

    using LevelEditor.Control;
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly App controller;

        public MainWindow()
        {
            InitializeComponent();

            this.controller = (App)Application.Current;
        }

        private void CommandCanExecuteClose(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.controller.CanExecuteClose();
        }

        private void CommandCanExecuteHelp(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.controller.CanExecuteHelp();
        }

        private void CommandCanExecuteNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.controller.CanExecuteNew();
        }

        private void CommandExecutedClose(object sender, ExecutedRoutedEventArgs e)
        {
            this.controller.ExecuteClose();
        }

        private void CommandExecutedHelp(object sender, ExecutedRoutedEventArgs e)
        {
            this.controller.ExecuteHelp();
        }

        private void CommandExecutedNew(object sender, ExecutedRoutedEventArgs e)
        {
            this.controller.ExecuteNew();
        }
    }
}
