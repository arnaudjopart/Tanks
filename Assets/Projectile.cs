using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    #region Public And Protected Members
    public float m_liveTime;
    #endregion
    // Use this for initialization
    void Start () {
        m_transform = GetComponent<Transform>();
        startLiveTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        m_transform.Translate(m_transform.InverseTransformVector(m_transform.forward)*10*Time.deltaTime);
        if (Time.time > startLiveTimer + m_liveTime)
        {
            this.gameObject.SetActive(false);
        }
	}

    #region Private Memebers
    private Transform m_transform;
    private float startLiveTimer;
    #endregion
}
