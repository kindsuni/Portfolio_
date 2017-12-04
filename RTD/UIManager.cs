using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public Text life;
    public Image gameOver;
    public Text money;
    public Text wave;
    public Text killCount;
    public GameObject upgradePanel;
    private float fadeTime = 1f;
    public Text enemylife;
    Color colorToFadeTo;
  
	// Use this for initialization
	void Start () {
        gameOver.GetComponent<CanvasRenderer>().SetAlpha(0f);
        gameOver.CrossFadeAlpha(0, 0, true);
        upgradePanel.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
        gameOverCheck();
        GameMoney();
        CurrentWave();
        KillCount();
        EnemyLife();
	}
   void gameOverCheck()
    {
        life.text = "Life : " + PlayerStat.Lives;

		if(PlayerStat.Lives <= 0)
        {
            gameOver.CrossFadeAlpha(1, fadeTime, true);
            gameOver.transform.localPosition = new Vector3(0, 0, 0);
            
        }

    }
    void GameMoney()
    {
        money.text = "Money : " + PlayerStat.Money;
    }
    void CurrentWave()
    {
        wave.text = "현재 웨이브 : " + Spawner.currentWaveNumber;
    }
    public void ShowUpPanel()
    {
        PlayerStat.puse = true;
        upgradePanel.SetActive(true);
    }
    public void HideUpPanel()
    {
        PlayerStat.puse = false;
        upgradePanel.SetActive(false);
    }
    void KillCount()
    {
        killCount.text = EnemyKill.instance.killed + " Killed";
    }
   void EnemyLife()
    {
        enemylife.text = "EnemyHealth : "+Spawner.instance.waves[Spawner.currentWaveNumber-1].enemyHealth;
    }
}
