using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed;
    private GameObject man;
	// Use this for initialization
	void Start () {
        man = GameObject.Find("Man");
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, man.transform.position, step);
    }
}
