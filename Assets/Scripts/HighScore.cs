using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;

public class HighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore");

        //Scoreフィールドの降順でデータを取得
        query.OrderByDescending("Score");

        //検索件数を5件に設定
        query.Limit = 5;

        //データストアでの検索を行う
        query.FindAsync((List<NCMBObject> objList, NCMBException e) => {
            if (e != null)
            {
                //検索失敗時の処理
            }
            else
            {
                //検索成功時の処理
                this.GetComponent<Text>().text = objList.ToString();
            }
        });

    }

    // Update is called once per frame
    void Update () {
		
	}
}
