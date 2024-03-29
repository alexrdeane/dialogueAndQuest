﻿using UnityEngine;

[System.Serializable]
public class Quest
{


    //state of quest
    public QuestState state = QuestState.New;
    //name
    public string name;
    //description
    public string description;
    //experienceReward
    public int expReward;
    //goldReward
    public int goldReward;
    //goal
    public QuestGoal goal;
    //complete
    public void Complete()
    {
        state = QuestState.Completed;
    }
}

public enum QuestState
{
    New,
    Accepted,
    Failed,
    Completed,
    Claimed

}
