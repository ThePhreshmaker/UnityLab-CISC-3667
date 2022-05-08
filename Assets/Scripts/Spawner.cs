using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fireball;
    private float nextFire = 0.5f;
    private float myTime = 0.0f;
    private float fireDelta = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        myTime = myTime + Time.deltaTime;
        if(Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + fireDelta;
            Spawn();
            nextFire = nextFire - myTime;
            myTime = 0.0f;
        }
    }

    void FixedUpdate()
    {
        //if (Input.GetButton("Fire1"))
            //Spawn();
    }
    void Spawn()
    {

        float xPos = player.transform.position.x;
        float yPos = player.transform.position.y;

        Vector2 position = new Vector2(xPos, yPos);
        Instantiate(fireball, position, Quaternion.identity);

    }
}
