using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject TubePrefab;

    private float spawnTime;
    private float leftTime;

    void Start()
    {
        spawnTime = 6f; // 6 sec
        leftTime = 0f;
    }

    void Update()
    {
        leftTime -= Time.deltaTime;

        if(leftTime <= 0)
        {
            // spawn
            GameObject.Instantiate(
                TubePrefab, 
                this.transform.position + Vector3.up * Random.Range(-2.6f, 2.6f), 
                Quaternion.identity);

            leftTime = spawnTime;
        }
    }
}
