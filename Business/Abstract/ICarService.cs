using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        /// <summary>
        /// Arabaları listeler.
        /// </summary>
        /// <returns>Araba listesi döndürür.</returns>
        List<Car> GetAll();
    }
}
