﻿using Gandalan.IDAS.WebApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalan.IDAS.Client.Contracts.Contracts.ProduktionsServices
{
    public interface ICalcAblageFachBedarf
    {        
        int CalcBedarf(BelegPositionAVDTO position);
    }
}
