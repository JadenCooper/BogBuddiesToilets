using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public LookingMobile look;
    public PlayerController playerController;
    public void Pause()
    {
        look.CanMove = !look.CanMove;
        playerController.CanMove = !playerController.CanMove;
        if (PauseMenu.activeSelf)
        {
            // Pause Menu Is Already Active
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            // Activate Pause Menu
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
