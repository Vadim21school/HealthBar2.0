using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(HealthBar))]
public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private UnityEvent _changed;
    [SerializeField] private float _amountOfChange;
    [SerializeField] private float _minAmount;
    [SerializeField] private float _maxAmount;

    private float _currentValue;

    public float Amount { get; private set; }

    private void Start()
    {
        Amount = _minAmount;
    }

    public void IncreaseHealth()
    {
        _currentValue = Amount + _amountOfChange;

        Amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
        _changed.Invoke();
    }

    public void ReduceHealth()
    {
        _currentValue = Amount - _amountOfChange;
        Amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
        _changed.Invoke();
    }
}
