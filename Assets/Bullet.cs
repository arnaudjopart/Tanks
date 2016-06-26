using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
        m_rb.velocity = transform.forward*50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private Rigidbody m_rb;

}
