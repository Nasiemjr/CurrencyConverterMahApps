using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterMahApps;

public class MainVM : ObservableObject
{
	public MainVM()
	{
		Countries = new();
		GetCountries();
	}

	/// <summary>
	/// Returns the list of countries for the from option
	/// </summary>
	private void GetCountries()
	{
       // Countries.Add("--SELECT--");
        Countries.Add("INR");
        Countries.Add("USD");
        Countries.Add("EUR");
        Countries.Add("SAR");
        Countries.Add("POUND");
        Countries.Add("DEM");
    }

	public List<String> Countries { get; }

}
