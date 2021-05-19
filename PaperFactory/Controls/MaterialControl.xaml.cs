using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace PaperFactory.Controls
{
    /// <summary>
    /// Interaction logic for MaterialControl.xaml
    /// </summary>
    public partial class MaterialControl : UserControl
    {
        public string MaterialImageSource { get; set; }
        public string MaterialType { get; set; }
        public string MaterialName { get; set; }
        public decimal MinWhAmount { get; set; }
        public decimal WhAmount { get; set; }
        public decimal Price { get; set; }

        public List<string> MaterialSuppliers = new List<string>();
        public MaterialControl(string image, string type, string name, decimal minAmount, decimal amount, decimal price, List<string> suppliers)
        {
            InitializeComponent();

            MaterialImageSource = image;
            MaterialType = type;
            MaterialName = name;
            MinWhAmount = minAmount;
            WhAmount = amount;
            Price = price;
            MaterialSuppliers = suppliers;

            if (WhAmount < MinWhAmount)
            {
                ControlGrid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f19292"));
            }
            else if (WhAmount == Math.Round(MinWhAmount / 100 * 300))
            {
                ControlGrid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffba01"));
            }

            MaterialImage.Source = new BitmapImage(new Uri(MaterialImageSource, UriKind.Absolute));
            MinAmountLable.Content += $"{MinWhAmount} шт";
            AmountLable.Content += $"{WhAmount} шт";
            TypeNameMaterialLable.Content = $"{MaterialType} | {MaterialName}";
            PriceLable.Content += $"{Price} руб.";

            foreach (string supplier in MaterialSuppliers)
            {
                SuppliersLable.Content += $"{supplier}, ";
            }

            string suppliersCleared = SuppliersLable.Content.ToString().Remove(SuppliersLable.Content.ToString().Length - 2);
            SuppliersLable.Content = suppliersCleared;
        }
    }
}
