using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    [SerializeField] private Player _player;

    private float _speed;
    private float _currentAmount;

    private void Start()
    {
        _speed = 1f;
        _currentAmount = 0;
    }

    private void Update()
    {
        _healthbar.value = Mathf.MoveTowards(_currentAmount, _player.Health, _speed * Time.deltaTime);
        _currentAmount = _healthbar.value;
    } 
}
