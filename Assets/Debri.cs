using UnityEngine;
using System.Collections;

public class Debri : MonoBehaviour {

    public float angle = 30F;
    public int score = 10;
    public Vector3 targetPos;

	// Use this for initialization
	void Start () {
        Transform target = GameObject.Find("Earth").transform;
        targetPos = target.position;
        this.transform.LookAt(target);
        this.transform.Rotate(new Vector3(0, 0, Random.Range(0, 30)), Space.World);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = this.transform.TransformDirection(Vector3.up);
        this.transform.RotateAround(targetPos, axis, angle * Time.deltaTime);
	}

    void OnMouseDown() {
        Destroy(gameObject);
    }
}
