using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }else if (Input.GetKey(KeyCode.J))
        {
            MultipleShoot(2);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            MultipleShoot(3);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            MultipleShoot(4);
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void MultipleShoot(int j)
    {

        for (int i = 0; i < j; i++)
        {
            GenericShoot(i);
        }
    }

    private void GenericShoot(float j)
    {
        Invoke("Shoot",j);
        
    }
    

    private void ResetShoot()
    {
        canShoot = true;
    }
}
