using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeScript : MonoBehaviour
{
    [SerializeField]
    private float tubeSpeed = 1f;

    void Start()
    {
        
    }


    void Update()
    {
        this.transform.Translate(Vector2.left * (tubeSpeed * Time.deltaTime));
    }
}
