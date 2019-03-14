using AutoMapper;
using System.Threading.Tasks;
using System.Windows;
using TestData.Models;
using TestData.Services;

namespace TestDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBusinessServiceSchools _iBusinessServiceSchools;
        private School selectedSchool;
        public MainWindow()
        {
            InitializeComponent();
            //ToDo use IoC
            var _iDataServiceSchools = new DataServiceSchools();
            var mapperConfiguration = new MapperConfiguration(cfg => {});
            IMapper mapper = new Mapper(mapperConfiguration);
            _iBusinessServiceSchools = new BusinessServiceSchools(_iDataServiceSchools, mapper);
        }

        private void RefreshDataGrid()
        {
            selectedSchool = new School();
            dgSchools.ItemsSource = Task.Run(() => _iBusinessServiceSchools.Read()).Result;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }

        private void DgSchools_SelectedCellsChanged(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            if (dgSchools.SelectedItem != null)
                selectedSchool = (School)dgSchools.SelectedItem;

            txtSchoolAddress.Text = selectedSchool.SchoolAddress;
            txtSchoolName.Text = selectedSchool.SchoolName;
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => _iBusinessServiceSchools.Create(selectedSchool)).Wait();
            RefreshDataGrid();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => _iBusinessServiceSchools.Update(selectedSchool)).Wait();
            RefreshDataGrid();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => _iBusinessServiceSchools.Delete(selectedSchool.SchoolId)).Wait();
            RefreshDataGrid();
        }

        private void TxtSchoolAddress_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            selectedSchool.SchoolAddress = txtSchoolAddress.Text;
        }

        private void TxtSchoolName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            selectedSchool.SchoolName = txtSchoolName.Text;
        }
    }
}
