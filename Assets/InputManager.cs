using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {


    #region Public And Protected Members

    public Player m_playerOne;
    public Player m_playerTwo;

    #endregion

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        ManageInputPlayerOne();
        ManageInputPlayerTwo();
    }

    void ManageInputPlayerOne()
    {
        float HPad = Input.GetAxis("HorizontalPad");
        float VPad = Input.GetAxis("VerticalPad");

        //print(VPad);

        playerOneMoveInput = new Vector2(HPad, VPad);

        m_playerOne.ManageMoveInput(playerOneMoveInput);
        
               
    }

    void ManageInputPlayerTwo()
    {
        float HPad = Input.GetAxis("Horizontal");
        float VPad = Input.GetAxis("Vertical");

        //print(VPad);

        playerTwoMoveInput = new Vector2(HPad, VPad);

        m_playerTwo.ManageMoveInput(playerTwoMoveInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_playerTwo.Shoot();
        }

    }


    #region Private Members

    private Rigidbody m_rb;
    private Transform m_transform;

    private Vector2 playerOneMoveInput, playerTwoMoveInput;

    #endregion  
}
