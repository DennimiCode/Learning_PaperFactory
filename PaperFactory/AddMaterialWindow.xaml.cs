using System;
using System.Linq;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;
using PaperFactory.Data;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Data;

namespace PaperFactory
{
    /// <summary>
    /// Interaction logic for AddMaterialWindow.xaml
    /// </summary>
    public partial class AddMaterialWindow : Window
    {
        public string NameOfMaterial
        {
            get => MaterialNameTextBox.Text;
            set => MaterialNameTextBox.Text = value;
        }
        public string TypeOfMaterial
        {
            get => MaterialTypeTextBox.Text;
            set => MaterialTypeTextBox.Text = value;
        }
        public string Price
        {
            get => MaterialPriceTextBox.Text;
            set => MaterialPriceTextBox.Text = value;
        }
        public string MinWhAmount
        {
            get => MinWarehouseAmountTextBox.Text;
            set => MinWarehouseAmountTextBox.Text = value;
        }
        public string WhAmount
        {
            get => CurrentWarehouseAmountTextBox.Text;
            set => CurrentWarehouseAmountTextBox.Text = value;
        }
        public string InPackAmount
        {
            get => AmountInPackTextBox.Text;
            set => AmountInPackTextBox.Text = value;
        }
        public string MetricType
        {
            get => MetricTypeTextBox.Text;
            set => MetricTypeTextBox.Text = value;
        }
        public string Image
        {
            get => ImageTextBox.Text;
            set => ImageTextBox.Text = value;
        }

        ApplicationDataContext AppDbContext = new ApplicationDataContext();
        public AddMaterialWindow()
        {
            InitializeComponent();
            Manager.AddMaterialWindows.Add(this);
            PreviewImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"..\..\..\..\Images\EmptyImage.png", UriKind.Absolute));
            var dbSuppliers = AppDbContext.Suppliers.Select(s => s.PossibleSupplier).ToList();
            List<Item> items = new List<Item>();
            foreach (string i in dbSuppliers)
            {
                Item item = new Item();
                item.Supplier = i;
                items.Add(item);
            }
            SuppliersDataGrid.ItemsSource = items;
        }
        private void OnChecked(object sender, RoutedEventArgs e)
        {

        }

        private void OpenPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog()
            {
                Filter = "png files (.png)|*.png|jpg files (.jpg)|*.jpg|jpeg files (.jpeg)|*.jpeg"
            };

            if (fd.ShowDialog() == true)
            {
                ImageTextBox.Text = fd.SafeFileName;
                PreviewImage.Source = new BitmapImage(new Uri(fd.FileName, UriKind.Absolute));
            }
        }

        private void DefaultPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            ImageTextBox.Text = "Фото";
            PreviewImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"..\..\..\..\Images\EmptyImage.png", UriKind.Absolute));
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (MaterialNameTextBox.Text == "Название материала" || MaterialTypeTextBox.Text == "Тип материала" || 
                MaterialPriceTextBox.Text == "Цена" || MinWarehouseAmountTextBox.Text == "Минимальное количество" || 
                CurrentWarehouseAmountTextBox.Text == "Количество на складе" || AmountInPackTextBox.Text == "Количество в упаковке" || MetricTypeTextBox.Text == "Единица измерения")
            {
                MessageBox.Show("Все поля обязательны для заполнения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int materialTypeId = 0;
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                var dbMaterialTypes = db.MaterialsTypes.Select(mt => mt.MaterialTypeName).ToList();
                if (dbMaterialTypes.Contains($"{MaterialTypeTextBox.Text}"))
                {
                    int dbMaterialType = db.MaterialsTypes.Where(mt => mt.MaterialTypeName == MaterialTypeTextBox.Text).Select(mt => mt.Id).First();
                    materialTypeId = dbMaterialType;
                }
                else
                {
                    MaterialsTypes materialType = new MaterialsTypes
                    {
                        MaterialTypeName = MaterialTypeTextBox.Text
                    };

                    materialTypeId = materialType.Id;

                    db.Add(materialType);
                    db.SaveChanges();
                }
            };

            int metricId = 0;
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                var dbMetrics = db.Metrics.Select(m => m.MetricName).ToList();
                if (dbMetrics.Contains($"{MetricTypeTextBox.Text}"))
                {
                    int dbMetricTypeId = db.Metrics.Where(m => m.MetricName == MetricTypeTextBox.Text).Select(mti => mti.Id).First();
                    metricId = dbMetricTypeId;
                }
                else
                {
                    Metrics metric = new Metrics
                    {
                        MetricName = MetricTypeTextBox.Text
                    };

                    metricId = metric.Id;

                    db.Add(metric);
                    db.SaveChanges();
                }
            };

            string image = "";
            if (ImageTextBox.Text == "Фото")
            {
                image = null;
            }
            else
            {
                image = @$"\Materials\{ImageTextBox.Text}";
            }

            Materials material = new Materials
            {
                TypeOfMaterial = materialTypeId,
                NameOfMaterial = MaterialNameTextBox.Text,
                AmountInPack = Convert.ToDecimal(AmountInPackTextBox.Text.Replace(',', '.')),
                WarehouseAmount = Convert.ToDecimal(CurrentWarehouseAmountTextBox.Text.Replace(',', '.')),
                MinWarehouseAmount = Convert.ToDecimal(MinWarehouseAmountTextBox.Text.Replace(',', '.')),
                Price = Convert.ToDecimal(MaterialPriceTextBox.Text.Replace(',', '.')),
                TypeOfMetric = metricId,
                MaterialImage = image
            };
            AppDbContext.Add(material);
            AppDbContext.SaveChanges();
        }

        #region 'PlaceHolders for TextBoxes'
        private void MaterialNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MaterialNameTextBox.Text = "";
        }

        private void MaterialNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            MaterialNameTextBox.Text = "Название материала";
        }

        private void MaterialTypeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MaterialTypeTextBox.Text = "";
        }

        private void MaterialTypeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            MaterialTypeTextBox.Text = "Тип материала";
        }

        private void MaterialPriceTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MaterialPriceTextBox.Text = "";
        }

        private void MaterialPriceTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            MaterialPriceTextBox.Text = "Цена";
        }

        private void MinWarehouseAmountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MinWarehouseAmountTextBox.Text = "";
        }

        private void MinWarehouseAmountTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            MinWarehouseAmountTextBox.Text = "Минимальное количество";
        }

        private void CurrentWarehouseAmountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            CurrentWarehouseAmountTextBox.Text = "";
        }

        private void CurrentWarehouseAmountTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            CurrentWarehouseAmountTextBox.Text = "Количество на складе";
        }

        private void AmountInPackTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AmountInPackTextBox.Text = "";
        }

        private void AmountInPackTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            AmountInPackTextBox.Text = "Количество в упаковке";
        }

        private void MetricTypeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MetricTypeTextBox.Text = "";
        }

        private void MetricTypeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            MetricTypeTextBox.Text = "Единица измерения";
        }
        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?\nЕсли вы выйдите, то данные заполненных вами полей будут утеряны!", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ImageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ImageTextBox.Text != "Фото")
            {
                PreviewImage.Source = new BitmapImage(new Uri(ImageTextBox.Text, UriKind.Absolute));
            }
        }
    }
    class Item
    {
        public string Supplier { get; set; }
        public Item() { }
    }
}
