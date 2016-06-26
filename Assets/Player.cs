using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    #region Public and Protected Members

    public GameObject m_bulletPrefab;
    public Transform cannon;
    public InputManager m_inputManager;
    public float m_speed;

    #endregion


    // Use this for initialization
    void Start () {
        m_rb = GetComponent<Rigidbody>();
        m_transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

       

        if( Input.GetKeyDown( KeyCode.Space ) )
        {
            Shoot();
        }
	}

    public void ManageMoveInput(Vector2 _vector)
    {
        Vector2 moveInput = _vector;

        m_rb.velocity = m_transform.forward * m_speed*moveInput.y;

        Quaternion rotation = Quaternion.Euler(new Vector3(0, moveInput.x*(2+Mathf.Abs(moveInput.y)*3), 0));
        m_transform.rotation *= rotation; 

    }

    private void Shoot()
    {
        Debug.Log( "Shoot" );
        GameObject bullet = Instantiate(m_bulletPrefab,cannon.position,m_transform.rotation) as GameObject;

    }
    private Rigidbody m_rb;
    private Transform m_transform;
}
