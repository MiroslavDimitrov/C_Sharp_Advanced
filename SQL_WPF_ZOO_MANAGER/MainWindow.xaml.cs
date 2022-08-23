using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace SQL_WPF_ZOO_MANAGER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["SQL_WPFY_ZOO_MANAGER.Properties.Settings.Database_Tutorial"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            ShowZoos();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "select * from ZOO";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

                using (adapter)
                {
                    DataTable zooTable = new DataTable();

                    adapter.Fill(zooTable);

                    Zoo_s_List.DisplayMemberPath = "Location";
                    Zoo_s_List.SelectedValuePath = "Id";
                    Zoo_s_List.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
