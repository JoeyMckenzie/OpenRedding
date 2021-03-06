﻿namespace OpenRedding.Client.Store.Features.Salaries.Reducers
{
    using Fluxor;
    using OpenRedding.Client.Store.Features.Salaries.Actions.DownloadSalaryCsv;
    using OpenRedding.Client.Store.State;

    public static class DownloadEmployeeCsvReducer
    {
        [ReducerMethod]
        public static SalariesState ReduceDownloadSalaryCsvAction(SalariesState state, DownloadSalaryCsvAction action) =>
            new SalariesState(state.IsLoading, null, state.IsTableRefresh, state.SalaryResults, state.SalaryDetail, state.SearchRequest);

        [ReducerMethod]
        public static SalariesState ReduceDownloadSalaryCsvSuccessAction(SalariesState state, DownloadSalaryCsvSuccessAction action) =>
            new SalariesState(state.IsLoading, null, state.IsTableRefresh, state.SalaryResults, state.SalaryDetail, state.SearchRequest);

        [ReducerMethod]
        public static SalariesState ReduceDownloadSalaryCsvFailureAction(SalariesState state, DownloadSalaryCsvFailureAction action) =>
            new SalariesState(state.IsLoading, action.ErrorMessage, state.IsTableRefresh, state.SalaryResults, state.SalaryDetail, state.SearchRequest);
    }
}
