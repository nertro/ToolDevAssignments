
namespace LevelEditor.View
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;

    using LevelEditor.Control;
    /// <summary>
    /// Interaction logic for NewMapWindow.xaml
    /// </summary>
    public partial class NewMapWindow
    {
        private readonly App controller;

        public string SelectedMapTileType;

        public NewMapWindow()
        {
            InitializeComponent();

            this.controller = (App)Application.Current;
        }

        private void NewMapButton_Click(object sender, RoutedEventArgs e)
        {
            this.controller.CreateNewMap();
        }

        public void SetMapTileTypes(IEnumerable<string> mapTileTypes)
        {
            foreach (var mapTileType in mapTileTypes)
            {
                RadioButton rButton = new RadioButton();
                rButton.Content = mapTileType;
                rButton.GroupName = "MapTileTypes";
                rButton.Checked += OnMapTileSelected;

                this.DefaultTilePanel.Children.Add(rButton);
            }

            RadioButton firstButton = (RadioButton)this.DefaultTilePanel.Children[0];
            firstButton.IsChecked = true;
        }

        void OnMapTileSelected(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            this.SelectedMapTileType = radioButton.Content.ToString();
        }
    }
}
