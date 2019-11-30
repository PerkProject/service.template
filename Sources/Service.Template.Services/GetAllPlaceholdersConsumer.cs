﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MassTransit;
using Service.Template.Core;

namespace Service.Template.Services
{
    public class GetAllPlaceholdersConsumer : IConsumer<GetAllPlaceholdersCommand>
    {
        private readonly IPlaceholderService service;

        public GetAllPlaceholdersConsumer(IPlaceholderService service)
        {
            this.service = service;
        }

        public async Task Consume(ConsumeContext<GetAllPlaceholdersCommand> context)
        {
            List<Placeholder> result = this.service.Get();

            await context.RespondAsync<GetAllPlaceholderResponse>(result);
        }
    }
}

