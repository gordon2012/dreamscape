using UnityEngine;
using System.Collections;



public class Teleport : MonoBehaviour {

    public GameObject target;

    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = target.transform.position;
    }

}
