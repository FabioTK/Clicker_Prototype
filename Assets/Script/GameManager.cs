using UnityEngine;
using TMPro;
using Singleton.Generic;

public class GameManager : Singleton<GameManager>
{


    private int _followers;
    [SerializeField] private int _followerMultiplier;
    [SerializeField] private TMP_Text _followersText;

    void Start()
    {
        if (PlayerPrefs.HasKey("Followers"))
        {
            _followers = PlayerPrefs.GetInt("Followers");
            _followersText.text = _followers.ToString();
        }
       
    }

    public void EarnFollowers()
    {
        _followers += _followerMultiplier;
        PlayerPrefs.SetInt("Followers", _followers);
        _followersText.text = _followers.ToString();
    }

}
