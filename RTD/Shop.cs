using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
    int[] randomMoney = new int[] { -100,-300,-400, 0, 200, 300, 400, 500 };
    int moneyup;
    public void SelectRandomTurret()
    {
        BuildManager.instance.SelectTurretToBuild();
    }
    public void RandomMoney()
    {   if(PlayerStat.Money >= 100)
        {
        PlayerStat.Money -= 100;
        moneyup = randomMoney[Random.Range(0, randomMoney.Length)];
        //print("" + moneyup);
        PlayerStat.Money += moneyup;
        }
    
        
        else
        {
        //print("도박을 할 수 없습니다.");
        return;

        }
    }
    private void Update()
    {
        if (PlayerStat.Money < 0)
        {
            PlayerStat.Money = 0;
        }
    }
}
