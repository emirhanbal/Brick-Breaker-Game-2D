using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonMusic : MonoBehaviour
{
    static bool _musicisPlaying;
    void Start()
    {
        if ( !_musicisPlaying )
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            _musicisPlaying = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
