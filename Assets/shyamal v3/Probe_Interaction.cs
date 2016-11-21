using UnityEngine;
using System.Collections;

public class Probe_Interaction : MonoBehaviour{
    public Rigidbody rb;
    public Vector3 startPos;
    public Vector3 startPos_otherball;
    public GameObject otherball;
    public GameObject sample;
	public int edge = 20;

    // Use this for initialization
    void Start()
    {
        startPos = transform.localPosition;
        startPos_otherball = otherball.transform.localPosition;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(15, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.localPosition.x >= edge ||
gameObject.transform.localPosition.x <= -edge || gameObject.transform.localPosition.z <= -edge || gameObject.transform.localPosition.z >= edge)
        {
            transform.localPosition = startPos;
            rb.velocity = new Vector3(15, 0, 0);
            otherball.transform.localPosition = startPos_otherball;
            otherball.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);

            sample.GetComponent<Destory_On_Trigger>().timerCheck = false;
            sample.GetComponent<Destory_On_Trigger>().timer = 0;


        }
    }

}
