using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour
{
        
    int powerUpCost = 300;
    List<Turret> turretList;
   
    public static PowerUp instance;
    
    public ButtonClicked[] buttons;
    int[] normalCurrentDamage =new int[6];
    int[] magicCurrentDamage = new int[6];
    int[] rareCurrentDamage = new int[6];
    int[] uniqueCurrentDamage = new int[6];
    int[] epicCurrentDamage = new int[6];

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;

        
        FirstCheck(0);
        FirstCheck(1);
        FirstCheck(2);
        FirstCheck(3);
        FirstCheck(4);
        FirstCheck(5);
    }
    private void OnEnable()
    {
        //buttons[0].onClick.AddListener(() => _PowerUp(0, Turret.Grade.nomal));
        //buttons[1].onClick.AddListener(() => _PowerUp(1, Turret.Grade.magic));
        buttons[0].button.onClick.AddListener(() => _PowerUp(buttons[0].type, buttons[0].grades));
        buttons[1].button.onClick.AddListener(() => _PowerUp(buttons[1].type, buttons[1].grades));
        buttons[2].button.onClick.AddListener(() => _PowerUp(buttons[2].type, buttons[2].grades));
        buttons[3].button.onClick.AddListener(() => _PowerUp(buttons[3].type, buttons[3].grades));
        buttons[4].button.onClick.AddListener(() => _PowerUp(buttons[4].type, buttons[4].grades));
        buttons[5].button.onClick.AddListener(() => _PowerUp(buttons[5].type, buttons[5].grades));
    }
    private void OnDisable()
    {
        //buttons[5].button.onClick.RemoveAllListeners();
    }
    public void _PowerUp(int type, Turret.Grade[] grades)
    {
       
        turretList = new List<Turret>(FindObjectsOfType<Turret>());
        Turret[] normalTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == grades[0]).ToArray();
        Turret[] magicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == grades[1]).ToArray();
        Turret[] rareTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == grades[2]).ToArray();
        Turret[] uniqueTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == grades[3]).ToArray();
        Turret[] epicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == grades[4]).ToArray();
        if (PlayerStat.Money >= powerUpCost)
        {
            PlayerStat.Money -= powerUpCost;
            for (int i = 0; i < normalTurrets.Length; i++)
            {
                normalTurrets[i].bulletDamage += 100;

                normalCurrentDamage[type] = normalTurrets[0].bulletDamage;
            }
            for (int i = 0; i < magicTurrets.Length; i++)
            {
                magicTurrets[i].bulletDamage += 200;

                magicCurrentDamage[type] = magicTurrets[0].bulletDamage;
            }
            for (int i = 0; i < rareTurrets.Length; i++)
            {
                rareTurrets[i].bulletDamage += 300;

                rareCurrentDamage[type] = rareTurrets[0].bulletDamage;
            }
            for (int i = 0; i < uniqueTurrets.Length; i++)
            {
                uniqueTurrets[i].bulletDamage += 500;

                uniqueCurrentDamage[type] = uniqueTurrets[0].bulletDamage;
            }
            for (int i = 0; i < epicTurrets.Length; i++)
            {
                epicTurrets[i].bulletDamage += 1000;

                epicCurrentDamage[type] = epicTurrets[0].bulletDamage;
            }
        }
        return;
    }
    public void CurrentPower(int type)
    {
        print("CurrentPower");
        Turret.Grade[] grades= new Turret.Grade[5];
        turretList = new List<Turret>(FindObjectsOfType<Turret>());
        Turret[] normalTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.nomal).ToArray();
        Turret[] magicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade ==Turret.Grade.magic ).ToArray();
        Turret[] rareTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.rare).ToArray();
        Turret[] uniqueTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.unique).ToArray();
        Turret[] epicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.epic).ToArray();
       
  
        for(int i = 0; i<normalTurrets.Length; i++)
        {
            normalTurrets[i].bulletDamage = normalCurrentDamage[type];
                print(normalTurrets[i].name);
           

        }
        for (int i = 0; i < magicTurrets.Length; i++)
        {
            magicTurrets[i].bulletDamage = magicCurrentDamage[type];
              
              
        }
        for (int i = 0; i < rareTurrets.Length; i++)
        {
            rareTurrets[i].bulletDamage = rareCurrentDamage[type];
        }      
        for (int i = 0; i < uniqueTurrets.Length; i++)
        {
            uniqueTurrets[i].bulletDamage = uniqueCurrentDamage[type];
                
        }
        for (int i = 0; i < epicTurrets.Length; i++)
        {
            epicTurrets[i].bulletDamage = epicCurrentDamage[type];
               
        }
        return;
        }
        
    void FirstCheck(int type)
    {
        Turret.Grade[] grades = new Turret.Grade[5];
        turretList = new List<Turret>(FindObjectsOfType<Turret>());
        Turret[] normalTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.nomal).ToArray();
        Turret[] magicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.magic).ToArray();
        Turret[] rareTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.rare).ToArray();
        Turret[] uniqueTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.unique).ToArray();
        Turret[] epicTurrets = turretList.FindAll(t => t.turretType == type && t.towerGrade == Turret.Grade.epic).ToArray();

        normalCurrentDamage[type] = normalTurrets[0].bulletDamage;
           // print("" + type + "Type " + "And " + normalTurrets[0].bulletDamage + "Damage");

            magicCurrentDamage[type] = magicTurrets[0].bulletDamage;
           // print("" + type + "Type " + "And " + magicTurrets[0].bulletDamage + "Damage");

            rareCurrentDamage[type] = rareTurrets[0].bulletDamage;
            //print("" + type + "Type " + "And " + rareTurrets[0].bulletDamage + "Damage");
        

            uniqueCurrentDamage[type] = uniqueTurrets[0].bulletDamage;
           // print("" + type + "Type " + "And " + uniqueTurrets[0].bulletDamage + "Damage");


            epicCurrentDamage[type] = epicTurrets[0].bulletDamage;
          //  print("" + type + "Type " + "And " + epicTurrets[0].bulletDamage + "Damage");

        return;
    }
}

    [System.Serializable]//구조체에서 넘길때 배열형태로 넘기기 때문에 필요함.
    public class ButtonClicked 
    {
        public Button button;
        public int type;
        public Turret.Grade[] grades;
    }


