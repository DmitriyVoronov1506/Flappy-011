using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)  // событие, возникающие при пересечении коллайдера, у которого тип - триггер
    {
        //Debug.Log(other.name);
        GameObject.Destroy(other.gameObject.transform.parent.gameObject);      
    }
}
