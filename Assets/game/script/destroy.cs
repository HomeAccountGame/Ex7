using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject platformPrefabMove;
    public GameObject TramploinPrefab;
    public GameObject myPlat;
    
    float maxDistance = 10.5f;
    int minHigh = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float random_y = player.transform.position.y + (minHigh + Random.Range(0.1f, 1.0f));
        if (collision.tag == "PlatformMoveing")
        {
             Instantiate(platformPrefabMove, new Vector2(Random.Range(-maxDistance, maxDistance), random_y), Quaternion.identity);
        }
        else if (collision.tag == "Platform" || collision.tag =="Trampoline")
        {
            int randomNumber = UnityEngine.Random.Range(1, 9);
            if (randomNumber == 5) //flip a coin to add trampoline or not
            {
                 Instantiate(TramploinPrefab, new Vector2(Random.Range(-maxDistance, maxDistance), random_y), Quaternion.identity);
            }
            else
            {
                 Instantiate(platformPrefab, new Vector2(Random.Range(-maxDistance, maxDistance), random_y), Quaternion.identity);

            }
        }
        Destroy(collision.gameObject);


    }
}
