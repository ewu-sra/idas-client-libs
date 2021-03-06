﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.WebApi.DTO;

namespace Gandalan.Client.Contracts.ProduktionsServices
{
    public interface IMaterialSortierung
    {
        IList<MaterialbedarfDTO> AblageFachSortierung(SerieDTO serie);

        IList<MaterialbedarfDTO> AblageFachSortierung(IList<MaterialbedarfDTO> materialListe);

        IList<MaterialbedarfDTO> EtikettenDruckSortierung(SerieDTO serie);

        IList<MaterialbedarfDTO> EtikettenDruckSortierung(IList<MaterialbedarfDTO> materialListe);
    }
}
