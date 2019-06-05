﻿using UnityEngine;
using System.Collections;
[AddComponentMenu("Intro PRG/RPG/Player/Interact")]
public class Interact : MonoBehaviour
{
    #region Update
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            //create a ray
            Ray interact;
            //this ray is shooting out from the main cameras screen point center of screen
            interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;
            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(interact, out hitInfo, 10))
            {
                #region NPC tag
                //and that hits info is tagged NPC
                if (hitInfo.collider.CompareTag("DNPC"))
                {
                    Dialogue dlg = hitInfo.transform.GetComponent<Dialogue>();
                    if (dlg != null)
                    {
                        dlg.showDlg = true;
                        Movement.canMove = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }
                    //Debug that we hit a NPC
                    Debug.Log("hit NPC");
                }
                #endregion
                #region Item
                //and that hits info is tagged Item
                /*  if (hitInfo.collider.CompareTag("Item"))
                  {
                      //Debug that we hit an Item
                      Debug.Log("hit Item");
                  }
               */
                #endregion
                if (hitInfo.collider.CompareTag("QNPC"))
                {
                    Dialogue dlg = hitInfo.transform.GetComponent<Dialogue>();
                    if (dlg != null)
                    {
                        dlg.showDlg = true;
                        Movement.canMove = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }
                    //Debug that we hit a NPC
                    Debug.Log("hit NPC");
                }
            }


        }
    }
    #endregion
}






