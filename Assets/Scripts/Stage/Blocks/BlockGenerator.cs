using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    [SerializeField] private BaseBlock[] blocks = null;
    private bool isGenerate;

    private void Start()
    {
        isGenerate = false;
    }

    private void Update()
    {
        GenerateBlock();
    }

    private void GenerateBlock()
    {
        if (BulletCount.IsBullet()) isGenerate = true; //弾が発射された
        if (isGenerate && !BulletCount.IsBullet()) //発射された弾が全部消えた
        {
            var index = Random.Range(0, blocks.Length);
            Instantiate(blocks[index], GeneratePosition(), Quaternion.identity);
            isGenerate = false;
        }
    }

    private static Vector3 GeneratePosition() => new Vector3(RandomPosition(), -5.5f, 0f);

    private static float RandomPosition() => Random.Range(-5f, 5f);
}
