using UnityEngine;

[RequireComponent(typeof(HealthBar))]
public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private float _minAmount;
    [SerializeField] private float _maxAmount;

    private float _currentValue;

    public float Amount { get; private set; }

    private void Start()
    {
        Amount = _minAmount;
    }

    public void IncreaseHealth(float amountOfChange)
    {
        _currentValue = Amount + amountOfChange;

        Amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
    }

    public void ReduceHealth(float amountOfChange)
    {
        _currentValue = Amount -    amountOfChange;
        Amount = Mathf.Clamp(_currentValue, _minAmount, _maxAmount);
    }
}
