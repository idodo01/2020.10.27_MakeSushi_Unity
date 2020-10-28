using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPage : MonoBehaviour
{
    public GameObject[] pageArr = new GameObject[2];


    public void page01() { showPage(0); }
    public void page02() { showPage(1); }
   
    public void showPage(int checkNum)
    {
        for (int i = 0; i < pageArr.Length; i++)
        {
            if (i == checkNum)
            {
                pageArr[i].SetActive(true);
            }
            else
            {
                pageArr[i].SetActive(false);
            }
        }

    }


}