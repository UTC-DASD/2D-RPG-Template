using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stab : MonoBehaviour
{
    public float damage;
    public GameObject player;
    public GameObject self;
    public float attack_speed;
    private float attack;
    private void Awake()
    {
        player = GameObject.Find("Good Guy");
    }

    void Update()
    {
        if (new Vector2(self.transform.position.x-player.transform.position.x, self.transform.position.y - player.transform.position.y).magnitude <= 1f)
        {
            if(attack <= 0)
            {
                player.GetComponent<HealthCalculations>().take_damage(damage);
                attack = attack_speed;
            }
        }
        attack -= Time.deltaTime;
    }
}
