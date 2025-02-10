using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WajnayaTema.Windows;

namespace WajnayaTema
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BDEntities entities;
        public MainWindow()
        {
            InitializeComponent();
            entities = new BDEntities();
            LoadData();
            //NameMat. = entities.Materials;
        }
        private void LoadData()
        {
            // Загружаем данные из базы
            var materials = entities.Materials.ToList();

            // Устанавливаем DataContext для DataGrid
            DataContext = materials;
        }
        public BDEntities Entities;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowStaff windowStaff = new WindowStaff();
            windowStaff.Show();
            this.Close();
        }
    }
}
