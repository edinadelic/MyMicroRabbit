using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MyMicroRabbit.Domain.Core.Bus;
using MyMicroRabbit.Infrastructure.Bus;

namespace MyMicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
