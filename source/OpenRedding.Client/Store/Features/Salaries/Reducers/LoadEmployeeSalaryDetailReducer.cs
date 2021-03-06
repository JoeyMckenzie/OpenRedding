﻿namespace OpenRedding.Client.Store.Features.Salaries.Reducers
{
    using Fluxor;
    using OpenRedding.Client.Store.Features.Salaries.Actions.LoadEmployeeSalaryDetail;
    using OpenRedding.Client.Store.State;

    public static class LoadEmployeeSalaryDetailReducer
    {
        [ReducerMethod]
        public static SalariesState ReduceLoadEmployeeSalaryDetailAction(SalariesState state, LoadEmployeeSalaryDetailAction action) =>
            new SalariesState(true, null, false, state.SalaryResults, null, state.SearchRequest);

        [ReducerMethod]
        public static SalariesState ReduceLoadEmployeeSalaryDetailFromLinkAction(SalariesState state, LoadEmployeeSalaryDetailFromLinkAction action) =>
            new SalariesState(true, null, false, state.SalaryResults, null, state.SearchRequest);

        [ReducerMethod]
        public static SalariesState ReducerLoadEmployeeSalaryDetailFromLinkSuccessAction(SalariesState state, LoadEmployeeSalaryDetailSuccessAction action) =>
            new SalariesState(false, null, false, state.SalaryResults, action.SalaryDetail, state.SearchRequest);

        [ReducerMethod]
        public static SalariesState ReducerLoadEmployeeSalaryDetailFromLinkFailureAction(SalariesState state, LoadEmployeeSalaryDetailFailureAction action) =>
            new SalariesState(false, action.ErrorMessage, false, state.SalaryResults, null, state.SearchRequest);
    }
}
