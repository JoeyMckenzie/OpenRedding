﻿namespace OpenRedding.Client.Store.Features.Salaries.Effects.LoadEmployeeSalaries
{
	using System;
	using System.Threading.Tasks;
	using Fluxor;
	using Microsoft.Extensions.Logging;
	using OpenRedding.Client;
	using OpenRedding.Client.Store.Features.Salaries.Actions.LoadEmployeeSalaries;
	using OpenRedding.Client.Store.Features.Salaries.Actions.LoadEmployeeSalariesFromLink;

	public class LoadEmployeeSalariesFromLinkEffect : Effect<LoadEmployeeSalariesFromLinkAction>
	{
		private readonly OpenReddingApiService _apiService;
		private readonly ILogger<LoadEmployeeSalariesFromLinkEffect> _logger;

		public LoadEmployeeSalariesFromLinkEffect(OpenReddingApiService apiService, ILogger<LoadEmployeeSalariesFromLinkEffect> logger) =>
			(_apiService, _logger) = (apiService, logger);

		protected override async Task HandleAsync(LoadEmployeeSalariesFromLinkAction action, IDispatcher dispatcher)
		{
			try
			{
				var employeeSalaries = await _apiService.GetEmployeesSalariesFromLinkAsync(action.Link);

				_logger.LogInformation("Employee salaries load was successful");
				dispatcher.Dispatch(new LoadEmployeeSalariesSuccessAction(employeeSalaries));
			}
			catch (Exception e)
			{
				_logger.LogError($"Employee salaries failed to load, reason: ${e.Message}");
				dispatcher.Dispatch(new LoadEmployeeSalariesFailureAction());
			}
		}
	}
}