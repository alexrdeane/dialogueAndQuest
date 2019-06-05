using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Intro PRG/RPG/Player/Movement")]
public class Movement : MonoBehaviour
{
    #region Variables
    public Vector3 moveDirection;
    private CharacterController _characterController;
    public float speed = 5;
    public static bool canMove;
    #endregion
    #region Start
    void Start()
    {
        canMove = true;
        _characterController = this.GetComponent<CharacterController>();
    }
    #endregion
    #region Update
    void Update()
    {
        if (canMove)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            _characterController.Move(moveDirection * Time.deltaTime);
        }
    }
    #endregion
}










