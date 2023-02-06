using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public GameObject SpawnW;
    public GameObject SpawnS;
    public GameObject SpawnA;
    public GameObject SpawnG;
    public GameObject UpW;
    public GameObject UpS;
    public GameObject UpA;
    public GameObject UpG;

    bool Spawn = true;

	private void Update()
	{
		if(GameManager.instance.RedCost >= 7 && Spawn) //코스트가 7이상이 되면 난수를 생성하고 난수에 따라 스위치문 실행
		{
            Spawn = false;
            switch (Random.Range(0, 6))
            {
                case 0:
                    SW();
                    Spawn = true;
                    break;
                case 1:
                    SS();
                    Spawn = true;
                    break;
                case 2:
                    SA();
                    Spawn = true;
                    break;
                case 3:
                    SG();
                    Spawn = true;
                    break;
                case 4:
                case 5:
                    break;
            }
		}

        if(GameManager.instance.RedCost == 10 && !Spawn) //코스트가 10이되면 실행
		{
            Spawn = true;
            switch(Random.Range(0,7))
			{
                case 0:
                    UW();
                    break;
                case 1:
                    US();
                    break;
                case 2:
                    UA();
                    break;
                case 3:
                    UG();
                    break;
                case 4:
                    SS();
                    break;
                case 5:
                    SA();
                    break;
                case 6:
                    SG();
                    break;
			}
		}

	}


	//스폰 로직 간편화
	void SW()
	{
        if(SpawnW.GetComponent<Unit_Spawn_Button>()!=null)
            SpawnW.GetComponent<Unit_Spawn_Button>().ClickWidEventR();
	}
	void SS()
	{
        SpawnS.GetComponent<Unit_Spawn_Button>().ClickEventR();
	}
    void SA()
    {
        SpawnA.GetComponent<Unit_Spawn_Button>().ClickEventR();
    }
    void SG()
    {
        SpawnG.GetComponent<Unit_Spawn_Button>().ClickEventR();
    }
    void UW()
	{
        if(UpW!=null)
            UpW.GetComponent<Upgrade_Button>().UpWidR();
	}
    void US()
	{
        if (UpS != null)
            UpS.GetComponent<Upgrade_Button>().ClickEventR();
	}
    void UA()
    {
        if (UpA != null)
            UpA.GetComponent<Upgrade_Button>().ClickEventR();
    }
    void UG()
    {
        if (UpG != null)
            UpG.GetComponent<Upgrade_Button>().ClickEventR();
    }
}
