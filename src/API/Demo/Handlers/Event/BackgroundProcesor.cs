using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Event
{
    public interface IBackgroundProcesor
    {
        void Run<T>(Action<T> action);
    }

    public class BackgroundProcesor : IBackgroundProcesor
    {
        private readonly IServiceProvider serviceProvider;

        public void Run<T>(Action<T> action)
        {
            Task.Factory.StartNew(delegate
            {
                var service = (T)serviceProvider.GetService(typeof(T));
                action(service);
            });
        }

    }


}
