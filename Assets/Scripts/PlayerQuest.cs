using UnityEngine;
using System.Collections.Generic;

public class PlayerQuest : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < quests.Count; i++)
        {
            if(quests[i].goal.IsReached())
            {
                quests[i].Complete();
            }
        }
    }
}
