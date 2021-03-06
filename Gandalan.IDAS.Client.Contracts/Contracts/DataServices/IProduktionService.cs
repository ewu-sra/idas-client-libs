﻿using Gandalan.IDAS.WebApi.Data.DTOs.Produktion;
using Gandalan.IDAS.WebApi.DTO;
using System.Threading.Tasks;

namespace Gandalan.Client.Contracts.DataServices
{

    public interface IProduktionService
    {
        Task<BerechnungResultDTO> GetDaten(BerechnungParameterDTO parameter);
        bool CanHandle(string variantenName);
        string TempFolder { get; set; }
    }
}
