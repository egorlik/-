using Baraholka.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraholka.Data.interfaces
{
    public interface IAllPajalniki
    {
        IEnumerable<Pajalki> Pajalniki { get; set; }
        IEnumerable<Pajalki> getFavPajalki { get; set; }
        Pajalki getObjectPajalki(int pajalkiID);
    }
}
