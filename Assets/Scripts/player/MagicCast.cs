using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCast : Mage
{
    public FireBall fireBallProjectilePrefab;
    public IceBall iceBallProjectilePrefab;
    public Transform launchOffSet;
    private Vector3 cursorVector;
    private Quaternion rotationToCursor;
    void Start()
    {
        //InvokeRepeating("ManaRegeneration", 1f, 1f);
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ManaRegeneration();
        
        
            if (Input.GetButtonDown("Fire1"))
            {
                if(manaUse(fireBallProjectilePrefab.ManaCost))
                for (int i = 0; i < 2; i++)
                    Instantiate(fireBallProjectilePrefab, launchOffSet.position, launchOffSet.rotation * Quaternion.Euler(0, 0, Random.Range(80, 100)));
            }
            if (Input.GetKeyDown(KeyCode.Mouse1) && Mana % fireBallProjectilePrefab.ManaCost == 0)
            {
                //for (int i = 0; i < 4; i++)
                Instantiate(iceBallProjectilePrefab, launchOffSet.position, launchOffSet.rotation * Quaternion.Euler(0, 0, Random.Range(80, 100)));
            }
        
    }
    


}
