using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;
    
    void Start()
    {
        discord = new Discord.Discord(928276049505165353, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity 
        {
            Details = "Why are you playing this",
            State = "Why, just why",
            Assets = {
                LargeImage = "logo"
            },
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
            {
                Debug.Log("Discord status set");
            }
            else
            {
                Debug.LogError("Discord status failed");
            }
        });
    }

    void Update()
    {
        discord.RunCallbacks();
    }
}
