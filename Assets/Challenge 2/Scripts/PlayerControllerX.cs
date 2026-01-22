using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    private float cooldownTimer = 2f;
    private float cooldown= 0;



    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }

        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cooldown <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                cooldown = cooldownTimer;
            }
            else
            {
                Debug.Log($"Wait {cooldown:F1} secondes !");
            }


        }
    }
}
