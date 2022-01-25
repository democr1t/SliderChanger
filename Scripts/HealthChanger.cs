using UnityEngine;
using UnityEngine.UI;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;

    private float _speed;
    private float _currentAmount;
    private float _targetAmount;
    private float _changeAmount;
    private float _maxHealth;
    private float _minHealth;
    
    private void Start()
    {
        _speed = 10f;
        _currentAmount = _healthbar.value;    
        _targetAmount = 0;
        _changeAmount = 10f;
        _maxHealth = 100f;
        _minHealth = 0;
    }

    private void Update()
    {
        _healthbar.value = Mathf.MoveTowards(_currentAmount, _targetAmount, _speed * Time.deltaTime);
        _currentAmount = _healthbar.value;
    }

    public void Heal()
    {
        _targetAmount += _changeAmount;

        if(_targetAmount > _maxHealth)
        {
            _targetAmount = _maxHealth;
        }
    }

    public void ToDamage() 
    {
        _targetAmount -= _changeAmount;
        
        if(_targetAmount < _minHealth)
        {
            _targetAmount = _minHealth;
        }
    }
}
