using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class EnemyShipAI : MonoBehaviour
{
    public float minRangefromPlayer = 20f;
    public float maxRangefromPlayer = 30f;


    public GameObject enemylaserPrefab;
    public Transform player;
    public Transform enemyfirepoint;

    public Vector3 prefab_rotation;

    private float dist;
    //AI stats
    public int enemyhealth;
    public int currentenemyHealth;

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        currentenemyHealth = enemyhealth;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);

        transform.LookAt(player);
        if (dist <= minRangefromPlayer)
        {

           // ShootPlayer();
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            ShootPlayer();
        }
    }


    private void ShootPlayer()
    {
        //Vector3 targetDir = player.position - transform.position;

        //float angle = Vector3.Angle(targetDir, transform.forward);

        GameObject go = GameObject.Instantiate(enemylaserPrefab, enemyfirepoint.position, enemyfirepoint.rotation )as GameObject;

        GameObject.Destroy(go, 1.5f);

    }
}
