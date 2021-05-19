using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PaperFactory.Data;
using PaperFactory.Controls;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        private const byte SEARCHSTEP = 3;

        private int PagePosition = 15;
        private ApplicationDataContext AppDbContext = new ApplicationDataContext();
        List<MaterialControl> MaterialControls = new List<MaterialControl>();
        List<string> Sorts = new List<string>
        {
            "Сортировка",
            "наименование А-Я",
            "наименование Я-А",
            "остаток на складе по возрастанию",
            "остаток на складе по убыванию",
            "стоимость по возрастанию",
            "стоимость по убыванию"
        };
        List<string> Filters = new List<string> { "Фильтрация", "Все типы" };
        public MaterialsPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PagePosition <= 0)
                {

                }
                else
                {
                    MaterialsListBox.Children.Clear();
                }
                PagePosition -= 15;
                for (int i = PagePosition + 15; i > PagePosition; i--)
                {
                    if (PagePosition >= MaterialControls.Count || PagePosition < 0 || i < 0 || i >= MaterialControls.Count)
                    {
                        PagePosition = 0;
                    }
                    else
                    {
                        MaterialsListBox.Children.Add(MaterialControls[i]);
                    }
                }
            }
            catch (ArgumentException)
            {

            }
        }

        private void GoForwardButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PagePosition <= 0)
                {

                }
                else
                {
                    MaterialsListBox.Children.Clear();
                }
                PagePosition += 15;
                for (int i = PagePosition - 15; i < PagePosition; i++)
                {
                    if (PagePosition >= MaterialControls.Count || PagePosition < 0 || i < 0 || i >= MaterialControls.Count)
                    {
                        PagePosition = 0;
                    }
                    else
                    {
                        MaterialsListBox.Children.Add(MaterialControls[i]);
                    }
                }
            }
            catch (ArgumentException)
            {

            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text != "" && SearchTextBox.Text != "Введите для поиска")
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = new List<MaterialControl>();

                foreach (var materialControl in MaterialControls)
                {
                    if (SearchAlhorithm(SearchTextBox.Text, materialControl.MaterialName) <= SEARCHSTEP)
                    {
                        materialControlsSorted.Add(materialControl);
                    }
                }

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)SortComboBox.SelectedItem == Sorts[0])
            {
                MaterialsListBox.Children.Clear();

                foreach (var materialControl in MaterialControls)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[1])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderBy(m => m.MaterialName);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[2])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderByDescending(m => m.MaterialName);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[3])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderBy(m => m.WhAmount);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[4])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderByDescending(m => m.WhAmount);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[5])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderBy(m => m.Price);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else if ((string)SortComboBox.SelectedItem == Sorts[6])
            {
                MaterialsListBox.Children.Clear();
                var materialControlsSorted = MaterialControls.OrderByDescending(m => m.Price);

                foreach (var materialControl in materialControlsSorted)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)FilterComboBox.SelectedItem == Filters[0] || (string)FilterComboBox.SelectedItem == Filters[1])
            {
                MaterialsListBox.Children.Clear();

                foreach (var materialControl in MaterialControls)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            else
            {
                MaterialsListBox.Children.Clear();
                var materialControlsFiltered = MaterialControls.Where(m => m.MaterialType == (string)FilterComboBox.SelectedItem).ToList();

                foreach (var materialControl in materialControlsFiltered)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            var dbMaterialTypes = AppDbContext.MaterialsTypes.Select(t => t.MaterialTypeName).ToList();

            foreach (string material in dbMaterialTypes)
            {
                Filters.Add(material);
            }

            foreach (string sort in Sorts)
            {
                SortComboBox.Items.Add(sort);
            }

            foreach (string filter in Filters)
            {
                FilterComboBox.Items.Add(filter);
            }
            SortComboBox.SelectedItem = Sorts[0];
            FilterComboBox.SelectedItem = Filters[0];

            List<Material> materials = new List<Material>();
            var dbMaterials = AppDbContext.Materials.Join(AppDbContext.MaterialsTypes, m => m.TypeOfMaterial, mt => mt.Id,
                (m, mt) => new 
                {
                    Name = m.NameOfMaterial, 
                    Type = mt.MaterialTypeName, 
                    Img = m.MaterialImage, 
                    MinWarehouseAmount = m.MinWarehouseAmount,
                    Price = m.Price,
                    Amount = m.WarehouseAmount
                });
            foreach (var dbMaterial in dbMaterials)
            {
                List<string> dbSuppliers;
                using (ApplicationDataContext db = new ApplicationDataContext())
                {
                    dbSuppliers = db.Suppliers.Where(s => s.NameOfMaterial == dbMaterial.Name).Select(s => s.PossibleSupplier).ToList();
                };

                if (dbSuppliers.Count == 0)
                {
                    dbSuppliers.Add("данные отсутствуют");
                }

                Material material = new Material
                {
                    TypeOfMaterial = dbMaterial.Type,
                    NameOfMaterial = dbMaterial.Name,
                    MinAmount = dbMaterial.MinWarehouseAmount,
                    Image = dbMaterial.Img,
                    WhAmount = dbMaterial.Amount,
                    Price = dbMaterial.Price,
                    Suppliers = dbSuppliers
                };

                materials.Add(material);
            }

            foreach (var material in materials)
            {
                MaterialControl materialControl = new MaterialControl
                (
                    material.Image,
                    material.TypeOfMaterial,
                    material.NameOfMaterial,
                    material.MinAmount,
                    material.WhAmount,
                    material.Price,
                    material.Suppliers
                );

                MaterialControls.Add(materialControl);
                MaterialsListBox.Children.Add(materialControl);
            }

            MaterialsListBox.Children.Clear();
            for (int i = 0; i <= PagePosition; i++)
            {
                MaterialsListBox.Children.Add(MaterialControls[i]);
            }
        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialWindow addMaterialWindow = new AddMaterialWindow();
            addMaterialWindow.Show();
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text != "" && SearchTextBox.Text != "Введите для поиска")
            {

            }
            else
            {
                SearchTextBox.Text = "";
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text != "")
            {

            }
            else
            {
                SearchTextBox.Text = "Введите для поиска";
                MaterialsListBox.Children.Clear();

                foreach (var materialControl in MaterialControls)
                {
                    MaterialsListBox.Children.Add(materialControl);
                }
            }
            
        }

        public static int SearchAlhorithm(string string1, string string2)
        {
            if (string1 == null) throw new ArgumentNullException(nameof(string1));
            if (string2 == null) throw new ArgumentNullException(nameof(string2));

            int diff;
            int[,] m = new int[string1.Length + 1, string2.Length + 1];

            for (int i = 0; i <= string1.Length; i++) { m[i, 0] = i; }
            for (int j = 0; j <= string2.Length; j++) { m[0, j] = j; }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;

                    m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1, m[i, j - 1] + 1), m[i - 1, j - 1] + diff);
                }
            }
            return m[string1.Length, string2.Length];
        }
    }

    class Material
    {
        public string TypeOfMaterial { get; set; }
        public string NameOfMaterial { get; set; }
        public decimal MinAmount { get; set; }
        public decimal WhAmount { get; set; }
        public decimal Price { get; set; }

        private string _Image = "";
        public string Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value == null || value == "NULL")
                    _Image = Environment.CurrentDirectory + @"..\..\..\..\Images\EmptyImage.png";
                else
                    _Image = Environment.CurrentDirectory + @"..\..\..\.." + value;
            }
        }
        public List<string> Suppliers { get; set; }

        public Material() { }
    }
}
