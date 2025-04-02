using System;
using R2ETien.MVC.Data;
using R2ETien.MVC.Entities;
using R2ETien.MVC.Interface;

namespace R2ETien.MVC.Service;

public class PersonService : IPersonService
{
    private readonly Context _context;

    public PersonService(Context context)
    {
        _context = context;
    }

    public List<Person> GetAll()
    {
        return _context.Person.ToList();
    }

    public Person GetById(int id)
    {
        return _context.Person.Find(id)
            ?? throw new KeyNotFoundException($"Person with ID {id} not found.");
    }

    public void Create(Person person)
    {
        _context.Person.Add(person);
        _context.SaveChanges();
    }

    public void Update(Person person)
    {
        var existingPerson = _context.Person.FirstOrDefault(p => p.Id == person.Id);
        if (existingPerson == null)
        {
            throw new KeyNotFoundException($"Person with ID {person.Id} not found.");
        }
        _context.Entry(existingPerson).CurrentValues.SetValues(person);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var person = _context.Person.Find(id);
        if (person == null)
        {
            throw new KeyNotFoundException($"Person with ID {id} not found.");
        }
        _context.Person.Remove(person);
        _context.SaveChanges();
    }
}
