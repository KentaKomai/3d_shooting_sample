using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

    public GameObject debri;
    public float interval = 1F;

    // Use this for initialization
    void Start() {
        StartCoroutine("SpawnDebris");
    }

    IEnumerator SpawnDebris() {
        while(true) {
            Instantiate(debri, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
