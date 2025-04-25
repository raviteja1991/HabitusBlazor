using System;

namespace HabitusBlazor.Services
{
    public class StateService
    {
        // Current value displayed at the parent level
        private int _currentValue = 0;

        // Event that will notify subscribers when the value changes
        public event Action<int> OnValueChanged;

        // Property to get the current value
        public int CurrentValue => _currentValue;

        // Method to update the value and notify subscribers
        public void UpdateValue(int newValue)
        {
            _currentValue = newValue;
            OnValueChanged?.Invoke(_currentValue);
        }
    }
}