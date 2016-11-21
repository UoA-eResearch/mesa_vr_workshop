using UnityEngine;
using System.Collections;

public class Destory_On_Trigger : MonoBehaviour {
    public float timer = 0;
    public bool timerCheck = false;
    float timerMin = 0;
    float timerSec = 0;
    float timerMil = 0;
    public GameObject text;

    // Use this for initialization
    void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        timerCheck = !timerCheck;
    }

    // Update is called once per frame
    void Update () {
        if (timerCheck == true)
        {
            timer += Time.deltaTime;
        }
        text.GetComponent<TextMesh>().text = timer.ToString();
    }
}
