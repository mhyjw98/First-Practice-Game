using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수

        int level = 1;
        float strength = 15.5f;
        string playerName = "뭉꾸";
        bool isFullLevel = false;
        int exp = 0;


        //2.그룹형 변수

        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 10;


        List<string> items = new List<string>();
        items.Add("생명의 물약(30LV)");
        items.Add("마나 물약(30LV)");

        //3.연산자
        

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level / 3.1f;

        int nextExp = 300 - (exp % 300);

        string title = "전설의";

        int fullLevel = 100;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        int health = 30;
        int mana = 15;
        bool isBadCondition = health <= 50 && mana <= 20;
        //bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";

        //4.키워드
        // int float string bool new List

        //5.조건문
        if (condition == "나쁨")
        {
            Debug.Log("체력을 회복하세요.");
        }
        else
        {
            Debug.Log("플레이어의 상태가 양호합니다.");
        }

        //6.반복문
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        health = Heal(health);

        //8.클래스

        Player player = new Player();
        player.id = 0;
        player.name = "링구";
        player.title = "바보";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");
        Debug.Log(player.move());
    }

    //7.함수(메소드)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다." + currentHealth);
        return currentHealth;
    }
}
