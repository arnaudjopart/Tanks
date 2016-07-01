using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour {

    #region Public And Protected Members
    public int m_nbOfInstancies;
    public Transform m_prefab;
    #endregion

    // Use this for initialization
    void Start () {
        m_transform = GetComponent<Transform>();
        FillPool();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Transform GetFirstActiveFalse()
    {
        foreach(Transform obj in m_listOfInstancies)
        {
            if (!obj.gameObject.activeSelf)
            {
                obj.gameObject.SetActive(true);
                return obj;
            }
        }

        Transform newInstance = CreateInstance();
        m_listOfInstancies.Add(newInstance);
        return newInstance;

    }
    #region Utils

    private void FillPool()
    {
        for (int i = 0; i < m_nbOfInstancies; i++)
        {
            Transform instance = CreateInstance();

            m_listOfInstancies.Add(instance);

        }
    }
    private Transform CreateInstance()
    {
        Transform instance = Instantiate(m_prefab, m_transform.position, Quaternion.identity) as Transform;
        instance.SetParent(m_transform, false);
        instance.gameObject.SetActive(false);
        

        return instance;
        
    }

    
    #endregion
    #region Private Members
    private Transform m_transform;
    private List<Transform> m_listOfInstancies = new List<Transform>();
    #endregion
}
