using UnityEngine;
using System.Collections;

public class ManagerHealth : MonoBehaviour
{
    private float _healthPlayer = 0f;
    private float _amountHealth = 10f;
    private float _minAmountOfHealth = 0f;
    private float _maxDelta = 5f;
    private float _currentValue;


    private void Start()
    {
        _healthPlayer = _minAmountOfHealth;
    }

    public void IncreaseHealth()
    {
        _currentValue = _healthPlayer + _amountHealth;

        if (_healthPlayer < 100)
        {
            StartCoroutine(ChangeSliderValue());
        }
    }

    public void ReduceHealth()
    {
        if (_healthPlayer > 0)
        {
            _healthPlayer-= _amountHealth;
        }
    }

    private IEnumerator ChangeSliderValue()
    {
        WaitForSeconds delayTime = new WaitForSeconds(0.1f);

        while (_healthPlayer< _currentValue)
        {
            _healthPlayer = Mathf.MoveTowards(_healthPlayer, _currentValue, _maxDelta);

            yield return delayTime;
        }
    }

    public float GetHealthPlayer()
    {
        return _healthPlayer;
    }
}
