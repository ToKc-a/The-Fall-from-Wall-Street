using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemy;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(!Player.lose)
        {
            int i = Random.Range(0, enemy.Length);
            Instantiate(enemy[i], new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
