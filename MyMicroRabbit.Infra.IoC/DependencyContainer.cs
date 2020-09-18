﻿using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MyMicroRabbit.Domain.Core.Bus;
using MyMicroRabbit.Infrastructure.Bus;
using MyMicroRabbit.Banking.Application.Interfaces;
using MyMicroRabbit.Banking.Application.Services;
using MyMicroRabbit.Banking.Domain.Interfaces;
using MyMicroRabbit.Banking.Data.Repository;
using MyMicroRabbit.Banking.Data.Context;

namespace MyMicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
