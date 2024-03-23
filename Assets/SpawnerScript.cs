using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject item;
    public float spawnRate = 0;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        spawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        } else {
            spawnItem();
            timer = 0;
        }
    }

    void spawnItem()
    {
        var pos = new float[] {
            transform.position.x - 8,
            transform.position.x,
            transform.position.x + 8
        };

        Instantiate(item, new Vector3(pos[UnityEngine.Random.Range(0, 3)], transform.position.y, transform.position.z), transform.rotation);
    }
}
