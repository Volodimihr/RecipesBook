using Recipe_book_ExamWPF_Karvatyuk.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Recipe_book_ExamWPF_Karvatyuk.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Recipe selectedRecipe = null;
        private Recipe newRecipe = null;
        private Recipe tempRecipe = null;
        private DelegateCommand delCommand = null;
        private DelegateCommand addCommand = null;
        private DelegateCommand refCountries = null;
        private ObservableCollection<Recipe> recipes = null;
        private ObservableCollection<string> countries = null;

        private int cbIndex = 0;

        public MainWindowViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            Countries = new ObservableCollection<string>();
            NewRecipe = new Recipe();
        }

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Prop for ComboBox SelectedIndex
        public int CbIndex
        {
            get => cbIndex;
            set
            {
                if (cbIndex != value)
                {
                    cbIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        // Recipes Collection
        public ObservableCollection<Recipe> Recipes
        {
            get => recipes;
            set
            {
                if (recipes != value)
                {
                    recipes = value;
                    OnPropertyChanged();
                }
            }
        }

        // Recipes Countries Collection
        public ObservableCollection<string> Countries
        {
            get => countries;
            set
            {
                if (countries != value)
                {
                    countries = value;
                    OnPropertyChanged();
                }
            }
        }

        public Recipe SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                if (selectedRecipe != value)
                {
                    selectedRecipe = value;
                    OnPropertyChanged();
                }
            }
        }

        public Recipe NewRecipe
        {
            get => newRecipe;
            set
            {
                if (newRecipe != value)
                {
                    newRecipe = value;
                    OnPropertyChanged();
                }
            }
        }

        // Temporary recipe for AddEdit form
        public Recipe TempRecipe
        {
            get => tempRecipe;
            set
            {
                if (tempRecipe != value)
                {
                    tempRecipe = value;
                    OnPropertyChanged();
                }
            }
        }

        // Delete recipe command
        public DelegateCommand DelCommand
        {
            get => delCommand ?? (delCommand = new DelegateCommand((obj) =>
            {
                Recipes.Remove(SelectedRecipe);
                if (RefCountries.CanExecute(null))
                    RefCountries.Execute(null);
            }));
        }

        // Add recipe command (unused)
        public DelegateCommand AddCommand
        {
            get => addCommand ?? (addCommand = new DelegateCommand((obj) =>
            {
                if (!Recipes.Contains(NewRecipe))
                {
                    Recipes.Add(NewRecipe);
                }
            }));
        }

        // Refresh countries collection command
        public DelegateCommand RefCountries
        {
            get => refCountries ?? (refCountries = new DelegateCommand((obj) =>
            {
                Countries.Clear();
                var uniqCountries = new ObservableCollection<Recipe>(Recipes.GroupBy(r => r.Country).Select(r => r.FirstOrDefault()));
                Countries.Add("All");
                foreach (Recipe country in uniqCountries)
                {
                    if (country.Country != string.Empty)
                        Countries.Add(country.Country);
                }
                CbIndex = 0;
            }));
        }
    }
}
