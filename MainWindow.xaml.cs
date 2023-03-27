using Recipe_book_ExamWPF_Karvatyuk.Model;
using Recipe_book_ExamWPF_Karvatyuk.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace Recipe_book_ExamWPF_Karvatyuk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel = null;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();

            LoadRecipesFromXmlFile();

            CreateCountryList();

            DataContext = viewModel;
        }

        public void LoadRecipesFromXmlFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Recipe>));
                using (StreamReader sr = new StreamReader("recipes.xml"))
                {
                    viewModel.Recipes = (ObservableCollection<Recipe>)serializer.Deserialize(sr);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void CreateCountryList()
        {
            viewModel.Countries.Clear();
            var uniqCountries = new ObservableCollection<Recipe>(viewModel.Recipes.GroupBy(r => r.Country).Select(r => r.FirstOrDefault()));
            viewModel.Countries.Add("All");
            foreach (Recipe country in uniqCountries)
            {
                if (country.Country != string.Empty)
                    viewModel.Countries.Add(country.Country);
            }

            cbCountries.SelectedIndex = viewModel.Countries.IndexOf("All");
        }

        // Open AddEdit form for adding new recipe
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEdit addEdit = new AddEdit(true);
            addEdit.DataContext = viewModel;
            addEdit.ShowDialog();
        }

        // Open AddEdit form for editing selected recipe
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedIndex == -1) return;

            AddEdit addEdit = new AddEdit(false);
            addEdit.DataContext = viewModel;
            addEdit.ShowDialog();
        }

        // Save Recipes to XML file
        private void Window_Closing(object sender, System.EventArgs e)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Recipe>));
                using (StreamWriter sw = new StreamWriter("recipes.xml"))
                {
                    xmlSerializer.Serialize(sw, viewModel.Recipes);
                    sw.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        // Filter searche in ListView on text changed in TextBox
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            listView.Items.Filter = new Predicate<object>(NameFilter);
        }

        // Filtering by recipes name and country
        private bool NameFilter(object obj)
        {
            Recipe recipe = obj as Recipe;
            bool name = recipe.Title.ToLower().Contains(tbFilter.Text.ToLower());
            bool country = recipe.Country == cbCountries.SelectedItem.ToString();
            if (cbCountries.SelectedItem.ToString() == "All") country = true;

            return name && country;
        }

        // Filtering by country
        private void cbCountries_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            listView.Items.Filter = new Predicate<object>(CountryFilter);
        }

        private bool CountryFilter(object obj)
        {
            Recipe recipe = obj as Recipe;
            if (cbCountries.SelectedItem == null) return false;
            if (cbCountries.SelectedItem.ToString() == "All") return true;

            return recipe.Country == cbCountries.SelectedItem.ToString();
        }
    }
}
