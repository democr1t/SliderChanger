using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    [SerializeField] private Player _player;

    private float _speed;
    private float _currentAmount;
    private float _smooth;

    private void Start()
    {
        _healthbar.maxValue = _player.MaxHealth;
        _healthbar.value = _player.MinHealth;
        _speed = 1f;
        _currentAmount = 0;
        _player.OnHealthChange.AddListener(Renew);
    }

    private void Renew()
    {
        while (_healthbar.value != _player.Health)
        {
            _healthbar.value = Mathf.MoveTowards(_currentAmount, _player.Health, _speed);
            _currentAmount = _healthbar.value;
        }
    }

    private void OnDisable()
    {
        _player.OnHealthChange.RemoveListener(Renew);
    }
}
