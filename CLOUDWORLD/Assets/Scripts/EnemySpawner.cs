using System;
using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject swarmerPrefab;

    [SerializeField] float swarmerInterval;

    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
    }

    IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(3f, 0f, 0f), Quaternion.identity);
        // yield return new WaitForSeconds(3);
        // Instantiate(enemy, new Vector3(0f, -10f, 0f), Quaternion.identity);
        // yield return new WaitForSeconds(3);
        // Instantiate(enemy, new Vector3(5f, -5f, 0f), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
