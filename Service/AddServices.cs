﻿using Microsoft.Extensions.DependencyInjection;
using Service.Implementation;
using Service.Interface;
using SportEvents.Domain;

namespace Service;

public static class AddServices
{
    public static void AddServiceServices(this IServiceCollection services)
    {
        services.AddScoped<IEventService, EventService>();
        services.AddScoped<IOrganizerService, OrganizerService>();
        services.AddScoped<IParticipantService, ParticipantService>();
        services.AddScoped<IRegistrationService, RegistrationService>();
        services.AddScoped<ITeamService, TeamService>();
        services.AddScoped<ITicketService, TicketService>();
        services.AddScoped<IShoppingCartService, ShoppingCartService>();
        services.AddScoped<IOrderService, OrderService>();
    }
}