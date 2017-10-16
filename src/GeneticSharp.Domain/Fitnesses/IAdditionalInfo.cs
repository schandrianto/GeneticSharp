using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticSharp.Domain.Fitnesses
{
    interface IAdditionalInfo
    {
        object Vehicle { get; set; }
        object Dc { get; set; }
        double[,] LstJarak { get; set; }
        IList<object> List { get; set; }
    }
}
