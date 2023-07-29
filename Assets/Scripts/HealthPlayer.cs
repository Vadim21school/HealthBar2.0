using UnityEngine;

[RequireComponent(typeof(SliderValue))]
public class HealthPlayer : MonoBehaviour
{
    private float _amount = 0f;
    private float _amountOfChange = 10f;
    private float _minAmount = 0f;
    private float _currentValue;
    private float _maxAmount = 100f;
    [SerializeField] private AmounOfHealtText _text;
    private SliderValue _sliderValue;


    private void Start()
    {
        _amount = _minAmount;
        _sliderValue = GetComponent<SliderValue>();
    }

    public void IncreaseHealth()
    {
        _currentValue = _amount + _amountOfChange;

        _amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
        _sliderValue.ChangeAmount(_amount);
        _text.ChangeText();
    }

    public void ReduceHealth()
    {
        _currentValue = _amount - _amountOfChange;
        _amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
        _sliderValue.ChangeAmount(_amount);
        _text.ChangeText();
    }

    public float GetHealthPlayer()
    {
        return _amount;
    }
}
