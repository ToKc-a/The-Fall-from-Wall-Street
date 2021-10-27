using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] office;
    public GameObject[] human;
    public GameObject coin;

    void Start()
    {
        StartCoroutine(SpawnOffice());
        StartCoroutine(SpawnHumans());
        StartCoroutine(SpawnCoins());
    }

    IEnumerator SpawnOffice()
    {
        while(!Player.lose)
        {
            int i = Random.Range(0, office.Length);
            Instantiate(office[i], new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator SpawnHumans()
    {
        while (!Player.lose)
        {
            int h = Random.Range(0, human.Length);
            Instantiate(human[h], new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator SpawnCoins()
    {
        while (!Player.lose)
        {
            Instantiate(coin, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
