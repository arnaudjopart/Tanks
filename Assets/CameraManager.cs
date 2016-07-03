using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

    public Transform player;
    public LayerMask m_layerOfCollision;

    // Use this for initialization
    void Awake()
    {
        m_camera = GetComponent<Camera>();
        m_transform = GetComponent<Transform>();
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ManageOrthographicSize();
	}

    private void ManageOrthographicSize()
    {
        Ray right = m_camera.ViewportPointToRay(new Vector3(1, 1f, m_transform.position.y));
        RaycastHit hitRight;
        if (Physics.Raycast(right, out hitRight, 150))
        {
            print(hitRight.point);
        }



        Ray leftLimit = m_camera.ViewportPointToRay(new Vector3(0, 0, m_transform.position.y));
        RaycastHit hit;
        if(Physics.Raycast(leftLimit,out hit,100))
        {
            //print(hit.point);
        }

        if (player.position.x < hit.point.x+5)
        {
            m_camera.fieldOfView+=50*Time.deltaTime;
        }
        
        
    }

    #region Private Members
    private Camera m_camera;
    private Transform m_transform;
    #endregion
}
