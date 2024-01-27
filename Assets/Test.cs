using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;    // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;     //魔法


    // 攻撃用の関数
    public void Attack(int プラス)
    {
        Debug.Log(this.power +　プラス +"のダメージを与えた");
    }

    // (魔法）攻撃用の関数
    public void mp_Attack()
    {
        this.mp -= 5;
        Debug.Log( "魔法攻撃をした！残りMPは " + this.mp + "。");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
        Debug.Log(this.hp);
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack(0);
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        //**********発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう***********
        // （魔法）攻撃用の関数を呼び出す
        for (int i=1;i<=10; i++)
        {
            lastboss.mp_Attack ();
            if(i>=10)
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }

        //練習：新しくBossクラスのmidboss変数を作り、Attack関数やDefence関数を呼び出してみましょう。
        Boss fainalboss = new Boss();
        fainalboss.Attack(10);
        fainalboss.Defence(5);

        //**********課題：配列を宣言して出力しよう*************
        int[] array = { 5, 10, 15, 20, 30 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}