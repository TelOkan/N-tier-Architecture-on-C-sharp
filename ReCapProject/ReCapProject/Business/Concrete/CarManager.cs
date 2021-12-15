using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
         ICarDal _carDal;
        //what was written inside of the carDal variable ,
        //it will be decision of the ORM that will work to communucation to database.

        public CarManager(ICarDal carDal)     
        {
            _carDal = carDal;
        }
        #region Turkish description
        //Burada IcarService'i değil , IcarDal'ı tanımladık ve constracture içerisine de dışarıdan veri gelicek şekilde
        //yapıyı oluşturduk. Biz WinUI katmanında neyi seçersek ORM tipi olarak onu kullanacağız.
        //Elimizde şuan InMemoryDal var. Bu EntityFrameWork'de olabilirdi.
        //WinUI tarafında bunu seçeceğiz. _carDal, InMemoryDal class'ına eşit olmuş olacak. Ve bizde bir alt metottda
        //InMemoryDal içerisinde ki GetAll metodunu çağırmış olacağız.
        #endregion

        /// <summary>
        /// indeed we wrote two times GetAll method. One of them inside of the Dal layer. 
        /// Another one is inside of the ICarService. Because We want to work as N-Tier Architecture.
        /// This way requires separating tiers from each others.
        /// Thus i can say like that i am binding every tier with each other.
        /// </summary>
        /// <returns></returns>
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
