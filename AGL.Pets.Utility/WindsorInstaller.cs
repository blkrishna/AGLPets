using AGL.Pets.Common.Interfaces;
using AGL.Pets.Utility.Data;
using AGL.Pets.Utility.Repositories;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace AGL.Pets.Utility
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<IPersonRepository>().ImplementedBy<PersonRepository>());
#if DEBUG
            container.Register(Component.For<IDataContext>().ImplementedBy<FakeDataContext>());
#else
            container.Register(Component.For<IDataContext>().ImplementedBy<DataContext>());
#endif
        }
    }
}
