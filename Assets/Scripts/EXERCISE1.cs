using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE1 : MonoBehaviour
{

    public GameObject SpherePrefap;
    public int Enemies = 1;
    private int EnemyWaves = 1;
    private float xLimit = 9f;
    private float yLimit = 5f;


    // Update is called once per frame
    void Update()
    {

        if (Enemies == 0) // This indicates that whenever we dont have any more enemies, a new wave would spawn at random position
        {
            EnemyWaves++;
            Enemies = EnemyWaves;

            for (int i = 0; i < EnemyWaves; i++)
            {
                
                Instantiate(SpherePrefap, RandomPosition(), SpherePrefap.transform.rotation);
            }


        }
    }

    //We indicate that we want random positions
    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }
}
