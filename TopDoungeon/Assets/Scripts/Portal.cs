using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll)
    {       
          
        if(coll.name=="player")
        {
            //Teleport the player
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            GameManager.instance.SaveState();
            SceneManager.LoadScene(sceneName);
            
        }
    }
}
