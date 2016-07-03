using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    #region Public And Protected Members
    public float m_liveTime;
    #endregion
    // Use this for initialization

    void Awake()
    {
        m_transform = GetComponent<Transform>();
    }
    void Start () {
        
        
	}
	
    public void Launch(Vector3 _positionOfSpawn, Quaternion _rotationOfSpawn)
    {
        gameObject.SetActive(true);
        
        
        
        m_transform.position = _positionOfSpawn;
        m_transform.rotation = _rotationOfSpawn;

        startLiveTimer = Time.time;


    } 
	// Update is called once per frame
	void Update () {
        m_transform.Translate(m_transform.InverseTransformVector(m_transform.forward)*50*Time.deltaTime);
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
