using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthCalculations : MonoBehaviour
{
    public float health;
    public void take_damage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
