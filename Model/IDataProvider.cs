using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDied.model;

namespace WpfAppDied.Model
{
    interface IDataProvider
    {
        IEnumerable<Train> GetTrains();
    }
}
