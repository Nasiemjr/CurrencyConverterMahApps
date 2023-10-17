using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyConverterMahApps;

public class MainVM : ObservableObject
{
	public enum COUNTRIES
	{
		[Description("Indian Rupee")]
		INR,
		[Description("United States Dollar")]
        USD,
        [Description("Euro")]
        EUR,
        [Description("Saudi Riyal")]
        SAR,
        [Description("Pound")]
        POUND,
        [Description("Deutchmark")]
        DEM
    }

	public MainVM()
	{
        _convertCmd = new RelayCommand(ConvertCurrency, CanConvert);
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


    public void ConvertCurrency()
    {
        var selectedCount = SelectedCountry;
    }

    public bool CanConvert()
    {
        return true;
    }


	public List<String> Countries { get; }

    public COUNTRIES SelectedCountry
    { 
        get => _selectedCountry;

        set {
                if (_selectedCountry != value)
                {
                    SetProperty(ref _selectedCountry, value);
                }
            }
    }

    public int SelectedCountryIndex
    {
        get => _selectedCountryIndex;

        set
        {
            SetProperty(ref _selectedCountryIndex, value);
        }
    }

    public COUNTRIES SelectedToCountry
    {
        get => _selectedToCountry;

        set
        {
            if (_selectedToCountry != value)
            {
                SetProperty(ref _selectedToCountry, value);
            }
        }
    }

    public int SelectedToCountryIndex
    {
        get => _selectedToCountryIndex;

        set
        {
            SetProperty(ref _selectedToCountryIndex, value);
        }
    }

    public ICommand ConvertCommand
    {
        get => _convertCmd;
        set
        {
            SetProperty(ref _convertCmd, value);
        }
    }

    private ICommand _convertCmd;
    private COUNTRIES _selectedCountry;
    private int _selectedCountryIndex = -1; 
    private COUNTRIES _selectedToCountry;
    private int _selectedToCountryIndex = -1;

}
