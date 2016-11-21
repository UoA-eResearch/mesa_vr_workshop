using UnityEngine;
using System.Collections;

public class spawn_gas : MonoBehaviour {
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 30; i++)
        {
            GameObject gasmol = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            gasmol.AddComponent<Rigidbody>();
            gasmol.GetComponent<Rigidbody>().useGravity = false;
            gasmol.GetComponent<Rigidbody>().drag = 0;
			gasmol.transform.parent = this.transform;
			gasmol.transform.localPosition = new Vector3((Random.value * 6 - 3), (Random.value * 6 - 3), (Random.value * 6 - 3));
            gasmol.transform.localScale = new Vector3(3, 3, 3);
            gasmol.GetComponent<Rigidbody>().velocity = new Vector3(Random.value * 20 - 10, Random.value * 20 - 10, Random.value * 20 - 10);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
