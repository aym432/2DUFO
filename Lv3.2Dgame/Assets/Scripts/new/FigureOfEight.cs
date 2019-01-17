using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FigureOfEight : MonoBehaviour
{
    //変数宣言
    //移動速度
    public float m_moveSpeed = 2f;

    //円の半径
    public float m_radius = 4f;

    //初期化
    void Start()
    {

    }

    //毎フレーム更新処理
    void Update()
    {
        //円運動
        MoveToCircle();
        //8の字運動
        MoveToFigureOfEight();
    }

    void MoveToCircle()
    {
        
        //経過時間の取得
        float time = Time.time;
        //円運動の座標演算
        float x = Mathf.Sin(time);
        float y = Mathf.Cos(time);

        //オブジェクトに座標を代入
        transform.position = new Vector2(x, y);
    }

    //8の字運動
    void MoveToFigureOfEight()
    {

    }
}
