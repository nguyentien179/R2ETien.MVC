using System;
using R2ETien.MVC.Models;

namespace R2ETien.MVC.Interface;

public interface IPersonService
{
    void Create(Person person);
    void Update(Person person);
    void Delete(int id);
    List<Person> GetAll();
    Person GetById(int id);
}
