using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDied.model;

namespace WpfAppDied.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Train> GetTrains()
        {
            return new Train[]{ 
                new Train{Type="Скоростной", Number=1, Speed=10.5F, TimeFrom=new DateTime(2021,05,25) },
            new Train{Type="Грузовой", Number=2, Speed=5.7F,TimeFrom=new DateTime(2021,05,16)},
            new Train{Type="Пассажирский",Number=3,Speed=6.1F,TimeFrom=new DateTime(2021,05,20)} };
          
         
         
        }

        
                             
    }
}
