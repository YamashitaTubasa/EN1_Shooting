using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemyの体力用変数
    public int enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        // 生成時に体力を指定しておく
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // もし体力が0以下になったら
        if (enemyHp <= 0)
        {
            // 自分で消える
            Destroy(this.gameObject);
        }
    }
    // publicの付け忘れに注意
    public void Damage()
    {
        // Enemyの体力を1減らす
        enemyHp = enemyHp - 1;
        //現在の体力をConsoleビューに表示する
        Debug.Log(enemyHp);

    }
}
