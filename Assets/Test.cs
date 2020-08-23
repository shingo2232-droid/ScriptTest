using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {   
        //要素を初期化
        int[] points = new int[5];

        // 5回処理を繰り返す
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;
        //配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
        }
        //配列の要素を逆順に表示する
        for (int i = points.Length - 1; 0 <= i; i--)
        {
            Debug.Log(points[i]);
            // 50
            // 40
            // 30
            // 20
            // 10
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}