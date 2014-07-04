
namespace LevelEditor.Control
{
    using System;
    using System.Windows;
    using System.Collections.Generic;

    using LevelEditor.View;
    using LevelEditor.Model;
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App
    {
        private AboutWindow aboutWindow;
        private NewMapWindow newMapWindow;
        private Map map;
        private Dictionary<string, MapTileType> tileTypes;

        private void OnStartup(object sender, StartupEventArgs e)
        {
            tileTypes = new Dictionary<string, MapTileType>();

            MapTileType grass = new MapTileType("Grass", 1);
            MapTileType desert = new MapTileType("Desert", 3);
            MapTileType water = new MapTileType("Water", 5);

            tileTypes.Add(grass.Name, grass);
            tileTypes.Add(desert.Name, desert);
            tileTypes.Add(water.Name, water);
        }

        public bool CanExecuteHelp()
        {
            return true;
        }

        public bool CanExecuteNew()
        {
            return true;
        }

        public bool CanExecuteClose()
        {
            return true;
        }

        public void ExecuteHelp()
        {

            if (this.aboutWindow == null || !this.aboutWindow.IsLoaded)
            {
                this.aboutWindow = new AboutWindow();
            }
            aboutWindow.Show();
        }

        public void ExecuteClose()
        {
            this.Shutdown();
        }

        public void ExecuteNew()
        {
            if (this.newMapWindow == null || !this.newMapWindow.IsLoaded)
            {
                this.newMapWindow = new NewMapWindow();
            }
            newMapWindow.Show();
        }

        public void CreateNewMap()
        {
            int width;
            int height;

            try
            {
                width = int.Parse(this.newMapWindow.TextBoxMapWidth.Text);
            }
            catch (FormatException)
            {
                ShowErrorMessage("Incorrect Width", "Please type in Width");
                return;
            }

            try
            {
                height = int.Parse(this.newMapWindow.TextBoxMapHeight.Text);
            }
            catch (FormatException)
            {
                ShowErrorMessage("Incorrect Height", "Please type in Height");
                return;
            }

            try
            {
                map = new Map(width, height);
            }
            catch (ArgumentOutOfRangeException e)
            {
                ShowErrorMessage("Incorrect Map Size", e.Message);
                return;
            }

            this.newMapWindow.Close();
        }

        private void ShowErrorMessage(string title, string text)
        {
            MessageBox.Show(title, text, MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
        }
    }
}
