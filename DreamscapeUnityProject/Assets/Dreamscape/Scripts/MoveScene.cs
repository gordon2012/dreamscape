using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;



public class MoveScene : MonoBehaviour {

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
        // player.transform.position = target.transform.position;
        SceneManager.LoadScene("scene2");
    }

}
