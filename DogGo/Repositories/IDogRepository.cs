using System;
using DogGo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        List<Dog> GetDogByOwnerId(int ownerId);
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int dogId);

    }
}
