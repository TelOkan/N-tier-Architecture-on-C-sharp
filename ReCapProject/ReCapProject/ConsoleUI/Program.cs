using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {    //----------CONSOLEUI----------------------

            //Layer of the WinUI. We wrote inside of CarManager as a new that is InMemoryDal
            //and choosen an ORM type which is InMemoryDal.
            CarManager carManagerxyz = new CarManager(new InMemoryDal()); 

           //below was written method that is GetAll belong to  GetAll method of ICarService that is inherited to CarManager.
           //so this code will be bring to us that data which is saved inside of the InMemoryDal of car of Description.
            foreach (var cars in carManagerxyz.GetAll()) 
            {
                Console.WriteLine(cars.Description);
            }
        }
    }
}
