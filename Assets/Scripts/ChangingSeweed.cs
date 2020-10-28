using UnityEngine;
using System.IO;



public class ChangingSeweed : MonoBehaviour
{
    public GameObject[] seweed = new GameObject[2];

    private string wearingBool; // 착용 여부
    private int iWearingSeweedNum; // 착용 번호 



    void Start()
    {
        wearingBool = "false";
        iWearingSeweedNum = 0;

    }

    public void seweed01Click() { seweedMethod(1); }
    public void seweed02Click() { seweedMethod(2); }


    public void seweedMethod(int iWearingSeweedNumCheck)
    {
        // 무언가 착용 O 
        if (wearingBool.Equals("true"))
        {

            // 해당 번호 착용중 -> 벗음
            if (iWearingSeweedNum == iWearingSeweedNumCheck)
            {
                Debug.Log(iWearingSeweedNum + "벗음");
                wearingBool = "false";
                iWearingSeweedNum = 0;
                seweed[iWearingSeweedNumCheck - 1].SetActive(false);

            }
            else
            {    // 다른 것 착용중 -> 벗음 -> 해당 번호 착용
                 // 그대로 착용중이기에 wearing(true/false)값은 변경하지 않음

                seweed[iWearingSeweedNum - 1].SetActive(false);
                seweed[iWearingSeweedNumCheck - 1].SetActive(true);
                Debug.Log(iWearingSeweedNum + "벗고" + iWearingSeweedNumCheck + "착용");
                iWearingSeweedNum = iWearingSeweedNumCheck;
            }

        }

        else
        { // 착용 X ->  착용
            Debug.Log(iWearingSeweedNumCheck + "착용");
            wearingBool = "true";
            iWearingSeweedNum = iWearingSeweedNumCheck;
            seweed[iWearingSeweedNumCheck - 1].SetActive(true);

        }

    } // end

}
