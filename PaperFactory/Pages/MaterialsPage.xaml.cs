using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PaperFactory.Data;
using PaperFactory.Controls;
using System;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        ApplicationDataContext AppDbContext = new ApplicationDataContext();
        List<string> Sorts = new List<string>()
        {
            "Сортировка",
            "наименование А-Я",
            "наименование Я-А",
            "остаток на складе по возрастанию",
            "остаток на складе по убыванию",
            "стоимость по возрастанию",
            "стоимость по убыванию"
        };
        List<string> Filters = new List<string>() { "Фильтрация", "Все типы" };
        public MaterialsPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoForwardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Initialized(object sender, System.EventArgs e)
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
                    dbSuppliers.Add("отсутствуют");
                }

                Material material = new Material
                {
                    TypeOfMaterial = dbMaterial.Type,
                    NameOfMaterial = dbMaterial.Name,
                    MinAmount = dbMaterial.MinWarehouseAmount,
                    Image = dbMaterial.Img,
                    WhAmount = dbMaterial.Amount,
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
                    material.Suppliers
                );

                MaterialsListBox.Children.Add(materialControl);
            }
        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialWindow addMaterialWindow = new AddMaterialWindow();
            addMaterialWindow.Show();
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "Введите для поиска";
        }
    }

    class Material
    {
        public string TypeOfMaterial { get; set; }
        public string NameOfMaterial { get; set; }
        public decimal MinAmount { get; set; }
        public decimal WhAmount { get; set; }

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
