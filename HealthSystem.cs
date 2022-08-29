using System;
public class HealthSystem
{
    public event EventHandler OnHealthUpdate;

    private int health;
    private int maxHealth;
    public HealthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        health = maxHealth;
    }
    public int GetHealth()
    {
        return health;
    }

    public float GetHealthPercentage()
    {
        return (float)health / maxHealth;
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (OnHealthUpdate != null) OnHealthUpdate(this, EventArgs.Empty);
    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > maxHealth) health = maxHealth;
        if (OnHealthUpdate != null) OnHealthUpdate(this, EventArgs.Empty);
        
    }

}
