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
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = UserNameText.Text;
            string password = passwordText.Password;
            string statement = $"select Password from SystemUser where UserName=\'{userName}\'";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            if (sqlDataReader.Read() == true && sqlDataReader.GetString(0) == password)
            {
                MessageBox.Show("登录成功！", "提示");

                MainWindow mainWindow = new MainWindow();
                App.mainWindow = mainWindow;
                App.SystemUser = CreateUser(userName);
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "警告");
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private User CreateUser(string userName)
        {
            string statement = $"select Number,Permission from SystemUser where UserName=\'{userName}\'";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            sqlDataReader.Read();
            string number = sqlDataReader.GetString(0);
            string permission = sqlDataReader.GetString(1);
            if (permission == "Accountant")
            {
                Accountant accountant = new Accountant(number, userName);
                return accountant;
            }
            else if (permission == "AssetCentralAdminstrator")
            {
                AssetCentralAdminstrator assetCentralAdminstrator = new AssetCentralAdminstrator(number, userName);
                return assetCentralAdminstrator;
            }
            else if (permission == "AssetDisposalAdminstrator")
            {
                AssetDisposalAdminstrator assetDisposalAdminstrator = new AssetDisposalAdminstrator(number, userName);
                return assetDisposalAdminstrator;
            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            else if (permission == "UniversityAssetsAdminstrtor")
            {
                UniversityAssetsAdminstrtor universityAssetsAdminstrtor = new UniversityAssetsAdminstrtor(number, userName);
                return universityAssetsAdminstrtor;
            }
            else if (permission == "")
            {

            }
            else if (permission == "")
            {

            }
            return null;
        }
    }
}
