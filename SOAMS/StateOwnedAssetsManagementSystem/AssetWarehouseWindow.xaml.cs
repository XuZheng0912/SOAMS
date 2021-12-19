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
using System.Windows.Shapes;
using StateOwnedAssetsManagementSystem;
using StateOwnedAssetsManagementSystem.Class;
using StateOwnedAssetsManagementSystem.Class.document;
using StateOwnedAssetsManagementSystem.Class.Entity;
using StateOwnedAssetsManagementSystem.Class.SystemRole;
using StateOwnedAssetsManagementSystem.Interface;

namespace StateOwnedAssetsManagementSystem
{
    /// <summary>
    /// AssetWarehouseWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AssetWarehouseWindow : Window
    {
        public AssetWarehouseWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            BusinessInitiatorLabel.Content = App.SystemUser.Name;
            BusinessDateLabel.Content = DateTime.Now.ToString();
            List<string> assetTypeList = new List<string>();
            assetTypeList.Add("固定资产");
            assetTypeList.Add("无形资产");
            AssetTypeComboBox.ItemsSource = assetTypeList;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            WarehouseEntry warehouseEntry = App.SystemUser.InitiateAssetWarehouse(AssetTypeComboBox.Text, AssetNameText.Text, Double.Parse(AssetValueText.Text), AssetKeeperText.Text);
            string statement = $"insert into WarehouseEntry values(\'{warehouseEntry.Number}\',\'{warehouseEntry.Initiator}\',\'{warehouseEntry.Date}\',\'{warehouseEntry.Type}\',\'{warehouseEntry.Name}\',\'{warehouseEntry.Value}\',\'{warehouseEntry.Keeper}\',\'\',\'false\',\'false\')";
            DataBase.StatementExecute(statement);
            MessageBox.Show("入库单已登记，请等待审核", "提示");
            Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
