using UnityEngine;
using System.IO;



public class ChangingSushi : MonoBehaviour
{
    public GameObject[] sushi = new GameObject[7];

    private string wearingBool; // 착용 여부
    private int iWearingSushiNum; // 착용 번호 

    void Start()
    {
        wearingBool = "false";
        iWearingSushiNum = 0;

    }

    public void sushi01Click() { sushiMethod(1); }
    public void sushi02Click() { sushiMethod(2); }
    public void sushi03Click() { sushiMethod(3); }
    public void sushi04Click() { sushiMethod(4); }
    public void sushi05Click() { sushiMethod(5); }
    public void sushi06Click() { sushiMethod(6); }
    public void sushi07Click() { sushiMethod(7); }


    public void sushiMethod(int iWearingSushiNumCheck)
    {
        // 무언가 착용 O 
        if (wearingBool.Equals("true"))
        {

            // 해당 번호 착용중 -> 벗음
            if (iWearingSushiNum == iWearingSushiNumCheck)
            {
                Debug.Log(iWearingSushiNum + "벗음");
                wearingBool = "false";
                iWearingSushiNum = 0;
                sushi[iWearingSushiNumCheck - 1].SetActive(false);

            }
            else
            {    // 다른 것 착용중 -> 벗음 -> 해당 번호 착용
                 // 그대로 착용중이기에 wearing(true/false)값은 변경하지 않음

                sushi[iWearingSushiNum - 1].SetActive(false);
                sushi[iWearingSushiNumCheck - 1].SetActive(true);
                Debug.Log(iWearingSushiNum + "벗고" + iWearingSushiNumCheck + "착용");
                iWearingSushiNum = iWearingSushiNumCheck;
            }

        }

        else
        { // 착용 X ->  착용
            Debug.Log(iWearingSushiNumCheck + "착용");
            wearingBool = "true";
            iWearingSushiNum = iWearingSushiNumCheck;
            sushi[iWearingSushiNumCheck - 1].SetActive(true);

        }

    } // end

}
