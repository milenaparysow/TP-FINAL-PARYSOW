using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    //chat gpt
    public GameObject[] things;
    public int currentIndex = -1;
    void Start()
    {
        DeactivateAll();
    }


    // es chat gpt 
    //borrar esto
    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= things.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }//chat gpt
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex <= 0)
            {//chat gpt
                currentIndex = things.Length - 1;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
    }//chat gpt

    void DeactivateAll()
    {//chat gpt
        for (int i = 0; i < things.Length; i++)
        {//chat gpt
            things[i].SetActive(false);
        }
    }
    //chat gpt
    void ActivaByIndex(int index)
    {
        things[index].SetActive(true);
    }
}



//chat gpt