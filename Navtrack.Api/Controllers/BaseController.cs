﻿using System;
using System.Threading.Tasks;
using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Navtrack.Api.Services.RequestHandlers;

namespace Navtrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(IdentityServerConstants.LocalApi.PolicyName)]
    public class BaseController : ControllerBase
    {
        private readonly IServiceProvider serviceProvider;

        public BaseController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        private protected async Task<IActionResult> HandleCommand<T>(T input)
        {
            ICommandHandler<T> commandHandler =
                serviceProvider.GetRequiredService<ICommandHandler<T>>();
            
            await commandHandler.Authorize(input);

            if (!commandHandler.ApiResponse.IsValid)
            {
                return NotFound();
            }
            if (commandHandler.ApiResponse.HttpStatusCode.HasValue)
            {
                return new StatusCodeResult((int) commandHandler.ApiResponse.HttpStatusCode);
            }

            await commandHandler.Validate(input);

            if (!commandHandler.ApiResponse.IsValid)
            {
                return BadRequest(commandHandler.ApiResponse);
            }

            await commandHandler.Handle(input);

            return Ok();
        }

        private protected async Task<ActionResult<TResponse>> HandleCommand<TSource, TResponse>(TSource input)
        {
            IRequestHandler<TSource, TResponse> requestHandler =
                serviceProvider.GetRequiredService<IRequestHandler<TSource, TResponse>>();

            await requestHandler.Authorize(input);

            if (!requestHandler.ApiResponse.IsValid)
            {
                return NotFound();
            }
            if (requestHandler.ApiResponse.HttpStatusCode.HasValue)
            {
                return new StatusCodeResult((int) requestHandler.ApiResponse.HttpStatusCode);
            }

            await requestHandler.Validate(input);

            if (!requestHandler.ApiResponse.IsValid)
            {
                return BadRequest(requestHandler.ApiResponse);
            }
            
            TResponse response = await requestHandler.Handle(input);

            if (response != null)
            {
                return response;
            }

            return NotFound();
        }
    }
}