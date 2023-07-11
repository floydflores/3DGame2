using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Variables
    public int maxHealth;
    public int currentHealth;
    #endregion
    
    public void ChangeHealth(int damage)
    {
        currentHealth = currentHealth + damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
