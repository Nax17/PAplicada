using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[Serializable]
public class PongScore
{
    public int Id;
    public string PlayerName;
    public int Score;
}

public class WebServiceClient : MonoBehaviour
{
    UnityWebRequest www;
    public static string WebServiceURL = "http://10.128.152.150:57085/api/values";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            StartCoroutine(SendWebRequest());
        }
    }
    IEnumerator SendWebRequest()
    {
        PongScore newScore = new PongScore { PlayerName = "Lantigua", Score = 200 };
        www = UnityWebRequest.Put(WebServiceURL, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("content-type", "application/json");
        yield return www.SendWebRequest();
        Debug.Log(www.downloadHandler.text);
    }
}
