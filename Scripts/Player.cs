using UnityEngine;

public class Player : MonoBehaviour
{
    private float _minHealth = 0f;
    private float _maxHealth = 100f;

    public float Health { get; private set; }

    void Start()
    {
        Health = _minHealth;
    }

    public void TakeHeal(float amount)
    {
        Health += amount;

        if (Health > _maxHealth)
        {
            Health  = _maxHealth;
        }
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;

        if (Health < _minHealth)
        {
            Health = _minHealth;
        }
    }
}
