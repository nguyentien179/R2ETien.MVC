using System;
using Maddalena;
using R2ETien.MVC.Interface;

namespace R2ETien.MVC.Service;

public class CountryService : ICountryService
{
    public List<string> GetAllCountryNames()
    {
        return Country.All.Select(c => c.CommonName).OrderBy(c => c).ToList();
    }
}
