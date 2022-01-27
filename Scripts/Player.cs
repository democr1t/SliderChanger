using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }
    public float MinHealth { get; private set; }
    public float MaxHealth { get; private set; }

    public UnityEvent OnHealthChange;

    void Start()
    {
        Health = MinHealth;
        MinHealth = 0f;
        MaxHealth = 100f;
    }

    public void TakeHeal(float amount)
    {
        Health += amount;
        
        if (Health > MaxHealth)
        {
            Health  = MaxHealth;
        }

        OnHealthChange.Invoke();
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;

        if (Health < MinHealth)
        {
            Health = MinHealth;
        }

        OnHealthChange.Invoke();
    }
}
