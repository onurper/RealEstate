namespace Api.Repositories.StatisticsRep
{
    public interface IStatisticsRep
    {
        Task<int> CategoryCountAsync();
        Task<int> ActiveEmployeeCountAsync();
        Task<int> ActiveCategoryCountAsync();
        Task<int> PassiveCategoryCountAsync();
        Task<int> ProductCountAsync();
        Task<int> ApartmentCountAsync();
        Task<int> DiffCityCountAsync();
        Task<int> AvgRoomCountAsync();
        Task<string> EmployeeNameByMaxProductCountAsync();
        Task<string> CategoryNameByMaxProductCountAsync();
        Task<decimal> AvgProductPriceByRentAsync();
        Task<decimal> AvgProductPriceBySaleAsync();
        Task<decimal> LastProductPriceAsync();
        Task<string> CityNameByMaxProductCountAsync();
        Task<string> NewestBuildingYearAsync();
        Task<string> OldestBuildingYearAsync();
    }
}