using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    [SerializeField] private BaseBlock[] enemies = null;
    [SerializeField] private float generateIntervalTime = 10f;

    private void Start()
    {
        StartCoroutine(GenerateEnemy());
    }

    private IEnumerator GenerateEnemy()
    {
        var generateInterval = new WaitForSeconds(generateIntervalTime);
        while (true)
        {
            var index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index],GeneratePosition(), Quaternion.identity);
            yield return generateInterval;
        }
    }

    private static Vector3 GeneratePosition() =>new Vector3(RandomPosition(), 1f, RandomPosition());

    private static float RandomPosition() => Random.Range(-9f, 9f);
}
