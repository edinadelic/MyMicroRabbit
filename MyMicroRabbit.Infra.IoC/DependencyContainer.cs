using System;
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
using MyMicroRabbit.Banking.Domain.Commands;
using MediatR;
using MyMicroRabbit.Banking.Domain.CommandHandlers;
using MyMicroRabbit.Transfer.Application.Interfaces;
using MyMicroRabbit.Transfer.Application.Services;
using MyMicroRabbit.Transfer.Domain.Interfaces;
using MyMicroRabbit.Transfer.Data.Repository;
using MyMicroRabbit.Transfer.Data.Context;
using MyMicroRabbit.Transfer.Domain.Events;
using MyMicroRabbit.Transfer.Domain.EventHandlers;

namespace MyMicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Application
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Domain Transfer
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>,TransferCommandHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

        }
    }
}
