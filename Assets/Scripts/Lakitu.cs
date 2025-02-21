using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lakitu : MonoBehaviour
{

    public float speed = 1;
    private Vector2 LakituDest;
    private float finalDest = 2;


    void Start()
    {
        LakituDest = new Vector2 (finalDest, transform.position.y);
        
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,LakituDest,1);
        StartCoroutine(LakituMovement());
    }

    IEnumerator LakituMovement()
    {
        finalDest = -2;
        yield return new WaitForSeconds(5f);
    }

}
