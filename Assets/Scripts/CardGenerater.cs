using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerater : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    //Cardの生成：Prefabを生成する

    private void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            Spawn(i);
        }
    }

    public void Spawn(int number)
    {
        Card card = Instantiate(cardPrefab);
        card.Init(number);
    }
}
