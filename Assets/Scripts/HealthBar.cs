using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(HealthPlayer))]
public class HealthBar : MonoBehaviour
{
    private Slider _slider;
    private HealthPlayer _healthPlayerScript;
    private float _delayTime = 0.1f;
    private float _maxDelta = 10f;
    private Coroutine _changeAmount;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _healthPlayerScript = GetComponent<HealthPlayer>();
    }

    public void ChangeAmount()
    {
        if (_changeAmount != null)
        {
            StopCoroutine(ChangeSliderValue(_healthPlayerScript.Amount));
        }

        _changeAmount = StartCoroutine(ChangeSliderValue(_healthPlayerScript.Amount));
    }

    private IEnumerator ChangeSliderValue(float currentHealth)
    {
        WaitForSeconds delayTime = new WaitForSeconds(_delayTime);

        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _maxDelta);

            yield return delayTime;
        }
    }
}
