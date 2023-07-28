using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderValue : MonoBehaviour
{
    private Slider _slider;
    private ManagerHealth _managerHealth;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _managerHealth = GetComponent<ManagerHealth>();
    }

    // Update is called once per frame
    private void Update()
    {
        _slider.value = _managerHealth.GetHealthPlayer();
    }
}
