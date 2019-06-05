using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public bool showDlg;
    public string[] dlgText, lT,nT,dT;
    public Vector2 scr;
    public int index, optionsIndex;
    public int approval;

    private void OnGUI()
    {
        if (showDlg)
        {
            if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            GUI.Box(new Rect(0, 6 * scr.y, Screen.width, 3 * scr.y), dlgText[index]);
            if (!(index + 1 >= dlgText.Length - 1 || index == optionsIndex))
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Next"))
                {
                    index++;
                }
            }
            else if (index == optionsIndex)
            {
                if (GUI.Button(new Rect(13 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Yeah"))
                {
                    index++;
                    approval++;
                    approval = Mathf.Clamp(approval, -1,1);
                }
                if (GUI.Button(new Rect(14 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Nah"))
                {
                    index = dlgText.Length - 1;
                    approval--;
                    approval = Mathf.Clamp(approval, -1, 1);
                }
            }
            else
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Bye"))
                {
                    index = 0;
                    showDlg = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Movement.canMove = true;

                }
            }
        }
        switch(approval)
        {
            case 1:
                dlgText = lT;
                break;
            case 0:
                dlgText = nT;
                break;
            case -1:
                dlgText = dT;
                break;
        }
    }
}
