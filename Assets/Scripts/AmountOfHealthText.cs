using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AmountOfHealthText : MonoBehaviour
{
    [SerializeField] private GameObject _managerHealth;

    private HealthPlayer _healthPlayer;
    private bool _isFindHealthPlayer;
    private TextMeshProUGUI _amountOfHealt;

    private void Start()
    {
        _amountOfHealt = GetComponent<TextMeshProUGUI>();
        _isFindHealthPlayer = _managerHealth.TryGetComponent<HealthPlayer>(out _healthPlayer);
    }

    public void ChangeText()
    {
        if(_isFindHealthPlayer == true)
            _amountOfHealt.text = Convert.ToString(_healthPlayer.Amount);
    }
}
