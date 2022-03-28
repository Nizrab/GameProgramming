using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public int maxPlatforms = 20;
    public GameObject platform;
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;
    private Vector2 originPosition;
    // Start is called before the first frame update
    void Start()
    {
        originPosition = transform.position;
        Spawn();
    }
    void Spawn()
    {
        for (int i=0; i < maxPlatforms; i++)
        {
            Vector2 randomPositon = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPositon, Quaternion.identity);
            originPosition = randomPositon;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
