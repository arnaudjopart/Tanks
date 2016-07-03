using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    #region Public and Protected Members

    public Transform m_cannon;
    
    public float m_speed;

    #endregion


    // Use this for initialization
    void Start () {
        m_rb = GetComponent<Rigidbody>();
        m_transform = GetComponent<Transform>();
        m_projectilesContainer = GameObject.Find("ProjectilesContainer");
        if (m_projectilesContainer)
        {
            Debug.Log("Ok Container");
        }
        m_poolManager = m_projectilesContainer.GetComponent<PoolManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void ManageMoveInput(Vector2 _vector)
    {
        Vector2 moveInput = _vector;

        m_rb.velocity = m_transform.forward * m_speed*moveInput.y;

        Quaternion rotation = Quaternion.Euler(new Vector3(0, moveInput.x*(2+Mathf.Abs(moveInput.y)*3), 0));
        m_transform.rotation *= rotation; 

    }

    public void Shoot()
    {
        Debug.Log( "Shoot" );
        Transform bullet = m_poolManager.GetFirstActiveFalse();
        print(bullet.GetComponent<Projectile>());
        bullet.GetComponent<Projectile>().Launch(m_cannon.position, m_cannon.rotation);
       

    }
    private Rigidbody m_rb;
    private Transform m_transform;
    private GameObject m_projectilesContainer;
    private PoolManager m_poolManager;
}
