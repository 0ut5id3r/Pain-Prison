
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

//This script component will give health behavior to any object it is applied to. 
//Use the inspector to set the object starting health. 
//Call the TakeDamage function to take damage from the health.
//When the object dies it will call the objectHasDied Event.
//Use the inspector to have this event call other function on other scripts. 

public class Health : MonoBehaviour
{
    public int currentHealth;
    public UnityEvent objectHasDied;
    public HpBar hpBar;

    float maxHealth;

    void Start()
    {
        maxHealth = currentHealth;
    }

    public void TakeDamage(int DamageToTake)
    {
        currentHealth -= DamageToTake;

        if (currentHealth >= 0) hpBar.UpdateHealth((float)currentHealth / (float)maxHealth);

        if (currentHealth <= 0)
        {
            objectHasDied.Invoke();
            Destroy(this.gameObject);

        }
        if (currentHealth < 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
        if (currentHealth > 0)
        {
            Cursor.visible = true;
        }
    }
    
}

