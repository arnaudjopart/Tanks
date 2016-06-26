using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {


    #region Public And Protected Members

    public float m_speed;
    public Player m_playerOne;
    public GameObject m_playerTwo;

    #endregion

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        ManageInputPlayerOne();

    }

    void ManageInputPlayerOne()
    {
        float HPad = Input.GetAxis("HorizontalPad");
        float VPad = Input.GetAxis("VerticalPad");

        print(VPad);

        playerOneMoveInput = new Vector2(HPad, VPad);

        m_playerOne.ManageMoveInput(playerOneMoveInput);
               
    }
   

    #region Private Members

    private Rigidbody m_rb;
    private Transform m_transform;

    private Vector2 playerOneMoveInput;

    #endregion  
}
