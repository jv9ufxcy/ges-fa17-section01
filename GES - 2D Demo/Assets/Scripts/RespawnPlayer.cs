using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour {

    public void Respawn()
    {
       
            if (Checkpoint.currentlyActiveCheckpoint == null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                transform.position =
                    Checkpoint.currentlyActiveCheckpoint.transform.position;
            }
        }
    }
