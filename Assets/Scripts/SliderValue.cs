using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderValue : MonoBehaviour
{
    private Slider _slider;
    private HealthPlayer _managerHealth;
    private float _amountOfHealth;
    private float _delayTime = 0.1f;
    private float _maxDelta = 10f;
    private Coroutine _changeAmount;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _managerHealth = GetComponent<HealthPlayer>();
        _amountOfHealth = _managerHealth.GetHealthPlayer();
    }

    public void ChangeAmount(float currentHealth)
    {
        if (_changeAmount != null)
        {
            StopCoroutine(ChangeSliderValue(currentHealth));
        }

        StartCoroutine(ChangeSliderValue(currentHealth));
        _amountOfHealth = currentHealth;
    }

    private IEnumerator ChangeSliderValue(float currentHealth)
    {
        WaitForSeconds delayTime = new WaitForSeconds(_delayTime);

        while (_amountOfHealth != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_amountOfHealth, currentHealth, _maxDelta);

            yield return delayTime;
        }
    }
}
