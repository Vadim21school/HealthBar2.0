using UnityEngine;

public class ManagerHealth : MonoBehaviour
{
    private float _healthPlayer = 0f;
    private float _amountHealth = 10f;
    private float _minAmountOfHealth = 0f;
    private float _currentValue;
    private AmounOfHealtText _amountOfHealthText;
    private SliderValue _sliderValue;


    private void Start()
    {
        _healthPlayer = _minAmountOfHealth;
        _sliderValue =  GetComponent<SliderValue>();
        _amountOfHealthText = FindObjectOfType<AmounOfHealtText>();
    }

    public void IncreaseHealth()
    {
        _currentValue = _healthPlayer + _amountHealth;

        if (_healthPlayer < 100)
        {
            _healthPlayer = _currentValue;
            _sliderValue.ChangeAmount(_healthPlayer);
            _amountOfHealthText.ChangeText();
        }
    }

    public void ReduceHealth()
    {
        if (_healthPlayer > 0)
        {
            _healthPlayer-= _amountHealth;
            _sliderValue.ChangeAmount(_healthPlayer);
            _amountOfHealthText.ChangeText();
        }
    }

    public float GetHealthPlayer()
    {
        return _healthPlayer;
    }
}
