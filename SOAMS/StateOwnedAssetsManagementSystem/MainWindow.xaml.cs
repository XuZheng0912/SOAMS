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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using StateOwnedAssetsManagementSystem;
using StateOwnedAssetsManagementSystem.Class;
using StateOwnedAssetsManagementSystem.Class.document;
using StateOwnedAssetsManagementSystem.Class.Entity;
using StateOwnedAssetsManagementSystem.Class.SystemRole;
using StateOwnedAssetsManagementSystem.Interface;

namespace StateOwnedAssetsManagementSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
            DoneDataGrid.ItemsSource = 
        }

        private void AssetWarehouseButton_Click(object sender, RoutedEventArgs e)
        {
            AssetWarehouseWindow assetWarehouseWindow = new AssetWarehouseWindow();
            assetWarehouseWindow.ShowDialog();
        }

        private void BriefBacklog_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private List<string> InitializeDoneDataGrid()
        {
            List<string> list = new List<string>();

            string statement = $"SELECT Name,Date,AssetCentralAdminstrator,Accountant FROM WarehouseEntry WHERE Initiator='adminstrator'";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            
        }
    }

    public class BriefDocument
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string stage { get; set; }
    }
}
