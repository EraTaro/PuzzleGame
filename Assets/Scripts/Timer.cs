using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private bool isStart = false;
    private bool isStop = false;
    private double countTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//        if (Input.GetMouseButtonDown(0))
//        {
            //タップされた時の処理
//            CountStart();
//        }

        if (isStart && !isStop)
        {
            countTime += Time.deltaTime;
            GetComponent<Text>().text = countTime.ToString("F2");
        }
	}

    public void CountStart() {
        isStart = true;
    }

    public void CountStop() {
        isStop = true;

        // ハイスコアを取得する。保存されてなければ0点。
        // Type == Number の場合
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(countTime);
    }
}
