using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    public int damage = 2;

    // Update is called once per frame
    void Update()
    {

        transform.position -= transform.forward * Time.deltaTime * 1000f;

    }
}
