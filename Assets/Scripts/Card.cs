using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public int number;
    //役職つける
    public TMP_Text text;

    public void Init(int number)
    {
        this.number = number;
        text.text = number.ToString();
    }


    public void OnClickThis()
    {

    }


}
