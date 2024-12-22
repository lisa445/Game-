using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Deck;
    float a = 1;
    float b = 3;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(a-=0.01f, b-=0.002f));
            GameObject NewDeck = Instantiate(Deck, new Vector3(Random.Range(-2.9f, 2.9f), 15, 10), Deck.transform.rotation);
        }
    }
}
