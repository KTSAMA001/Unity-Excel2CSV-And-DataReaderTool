using CSV_SPACE;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //csv�ļ�·��
    public string csvFilePath;

    public string idToFindHero = "1";
    public string idToFindLan = "1";

    void Update()
    {
        //ÿ��ִ��һ��
        if (Time.frameCount % 60 == 0)
        {
            /*      try
                      {
                          //IDΪidToFind�����Hero�Լ�Lan������
                          //����ָ���
                          Debug.Log("------------------Hero Data------------------------");
                          Debug.Log(HeroCSV.Load()[idToFindHero].ID);
                          Debug.Log(HeroCSV.Load()[idToFindHero].Name);
                          Debug.Log(HeroCSV.Load()[idToFindHero].SKILL);
                          Debug.Log("------------------Lan Data------------------------");
                          Debug.Log(LanCSV.Load()[idToFindLan].ID);
                          Debug.Log(LanCSV.Load()[idToFindLan].CN);
                          Debug.Log(LanCSV.Load()[idToFindLan].EN);

                      }
                      catch (Exception)
                      {
                          //������־ û������ִ���������
                          Debug.LogWarning("û������ִ���������");

                      }*/
        }
        if (Input.GetMouseButtonDown(0))
        {
            //��ȡHero����
        Debug.Log(HeroCSV.Load()[idToFindHero].Name);
        }
    }
}
