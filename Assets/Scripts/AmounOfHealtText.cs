using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AmounOfHealtText : MonoBehaviour
{
    private ManagerHealth _managerHealth;
    private TextMeshProUGUI _amountOfHealt;

    private void Start()
    {
        _amountOfHealt = GetComponent<TextMeshProUGUI>();
        _managerHealth = FindObjectOfType<ManagerHealth>();
    }

    private void Update()
    {
        _amountOfHealt.text = Convert.ToString(_managerHealth.GetHealthPlayer());
    }
}
