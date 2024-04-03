using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnitConverter.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    private double _celsiusValue;
    private double _fahrenheitValue;

    public event PropertyChangedEventHandler PropertyChanged;

    public double CelsiusValue
    {
        get { return _celsiusValue; }
        set
        {
            if (_celsiusValue != value)
            {
                _celsiusValue = value;
                OnPropertyChanged();
                UpdateFahrenheit();
            }
        }
    }

    public double FahrenheitValue
    {
        get { return _fahrenheitValue; }
        set
        {
            if (_fahrenheitValue != value)
            {
                _fahrenheitValue = value;
                OnPropertyChanged();
                UpdateCelsius();
            }
        }
    }

    private void UpdateFahrenheit()
    {
        FahrenheitValue = new TemperatureConverter().CelsiusToFahrenheit(CelsiusValue);
    }

    private void UpdateCelsius()
    {
        CelsiusValue = new TemperatureConverter().FahrenheitToCelsius(FahrenheitValue);
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

