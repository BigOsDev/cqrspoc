using CQRS.Common.Interfaces;
using Demo.Handlers.Event;
using Demo.Models.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DemoTests
{
    public class BackgroundProcesorTests
    {
        private IServiceProvider serviceProvider;

        public BackgroundProcesorTests()
        {
            ConfigureServices();
        }
        
        [Fact]
        public void Test1()
        {
           var procesor =  serviceProvider.GetService<IBackgroundProcesor>();
            procesor.Run<IEventHandler<IEvent>>(p => p.Handle(null));

        }


        public void ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IBackgroundProcesor, BackgroundProcesor>();
            services.AddTransient<IEventHandler<IEvent>, EventHandlerBase>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}
