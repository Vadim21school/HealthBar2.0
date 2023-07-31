using UnityEngine;

[RequireComponent(typeof(HealthBar))]
public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private float _minAmount;
    [SerializeField] private float _maxAmount;

    public float Amount { get; private set; }

    private void Start()
    {
        Amount = _minAmount;
    }

    public void IncreaseAmount(float amountOfChange)
    {
        Amount = Mathf.Clamp(Amount + amountOfChange, _minAmount, _maxAmount);
    }

    public void ReduceAmount(float amountOfChange)
    {
        Amount = Mathf.Clamp(Amount - amountOfChange, _minAmount, _maxAmount);
    }
}
