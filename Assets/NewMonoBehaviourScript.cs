using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1.변수
        Debug.Log("Hello Unity");
        int  level =5 ;
        float strength = 15.5f;
        string PlayName="나검사";
        bool isFullLevel=false;
        
        Debug.Log("용사의 이름은?");
        Debug.Log(PlayName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?"); 
        Debug.Log(isFullLevel);

        //2. 그룹형 변수
        string[] monsters ={"슬라임","사막별","악마"};
        
        Debug.Log("용사의 이름은?");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]); 
        Debug.Log(monsters[2]); 

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맴에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        // 리스트 
        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30"); 
        
        items.RemoveAt(0) ;
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        // Debug.Log(items[1]); 

        //3. 연산자 
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp -10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        String title ="전설의";
        Debug.Log(title+" "+PlayName);

        int  fullLevel = 99;
        isFullLevel = level == fullLevel ;
        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level >10 ;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial); 

    } 
   
}
