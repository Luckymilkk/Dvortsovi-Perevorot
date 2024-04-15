using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMeneger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] text;
    private int i =0 ;
    void Start()
    {
        text[0].SetActive(true);
    }

    public void NextButtonClick()
    {
        i++;
    }

     void Update()
    {
        if(i>0)
        {
            text[i].SetActive(true);
            text[i-1].SetActive(false);
        }
    }
}
