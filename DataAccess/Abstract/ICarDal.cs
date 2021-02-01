using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal  // kendime söz verdiğim gibi:)
    {
        /// <summary>
        /// Veri kaynağından aldığımız tüm arabaları listeler
        /// </summary>
        /// <returns>Araba listesi döndürür.</returns>
        List<Car> GetAll();

        /// <summary>
        /// Veri kaynağına araba eklemeye yapar
        /// </summary>
        /// <param name="car">Eklenecek araba</param>
        void Add(Car car);

        /// <summary>
        /// Veri kaynağınadaki arabayı Günceller.
        /// </summary>
        /// <param name="car">Güncel araba bilgileri</param>
        void Update(Car car);

        /// <summary>
        /// Veri kaynağınan arabayı Siler
        /// </summary>
        /// <param name="car">Silinecek Araba</param>
        void Delete(Car car);

        /// <summary>
        /// Veri kaynağından, Araba Id'sine göre araba getirir.
        /// </summary>
        /// <param name="CarId">Çağrılan arabanın id'si</param>
        /// <returns>Bir araba döndürür.</returns>
        Car GetById(int CarId);
    }

}
