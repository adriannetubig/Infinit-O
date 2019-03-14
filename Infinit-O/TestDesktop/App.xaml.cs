using AutoMapper;
using System.Windows;
using TestData.Services;
using Unity;

namespace TestDesktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    IUnityContainer container = new UnityContainer();

        //    var config = new MapperConfiguration(cfg =>
        //    {
        //    });
        //    IMapper mapper = config.CreateMapper();
        //    container.RegisterType<IDataServiceSchools, DataServiceSchools>();
        //    var mapperConfiguration = new MapperConfiguration(cfg => {});
        //    container.RegisterType<IMapper, Mapper>();
        //    container.RegisterType<IBusinessServiceSchools, BusinessServiceSchools>();

        //    var window = container.Resolve<MainWindow>();
        //    window.Show();
        //}
    }
}
