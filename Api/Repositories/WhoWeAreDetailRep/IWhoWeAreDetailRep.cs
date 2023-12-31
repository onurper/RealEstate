﻿using Api.Dtos.WhoWeAreDetailDtos;

namespace Api.Repositories.WhoWeAreRep
{
    public interface IWhoWeAreDetailRep
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();

        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);

        void DeleteWhoWeAreDetail(int id);

        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);

        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}