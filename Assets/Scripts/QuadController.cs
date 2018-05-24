using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour {

    private GameObject[] correctQuads;
    private GameObject[] controlQuads;

    // Use this for initialization
    void Start()
    {
        //正解の配置を作成
        correctQuads = new GameObject[9];
        for (int i = 0; i < correctQuads.Length; ++i) {
            string quadNum = (i + 1).ToString();
            string quadName = "Quad (" + quadNum + ")";
            correctQuads[i] = GameObject.Find(quadName);
            Debug.Log("Quad" + (i+1).ToString());
        }
        correctQuads[8] = GameObject.Find("Quad (0)");
        
        //ランダムの配置を作成

    }

    // Update is called once per frame
    void Update()
    {
        getClickObject();
    }

    private GameObject getClickObject()
    {
        GameObject result = null;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                result = hit.collider.gameObject;
                Debug.Log(result.name);
                moveQuad(result);
            }
        }
        return result;
    }

    private void moveQuad(GameObject gameObject)
    {
        Vector3 quadVector = gameObject.transform.position;
        Vector3 quad0Vector = GameObject.Find("Quad (0)").transform.position;

        if (quad0Vector.x == quadVector.x || quad0Vector.y == quadVector.y)
        {
            GameObject.Find("Quad (0)").transform.position = new Vector3(quadVector.x, quadVector.y, quadVector.z);
            gameObject.transform.position = new Vector3(quad0Vector.x, quad0Vector.y, quad0Vector.z);
        }
    }
}
