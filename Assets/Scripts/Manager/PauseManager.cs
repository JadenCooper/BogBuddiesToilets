using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public LookingMobile look;
    public PlayerController playerController;
    private Color orginalMapColor;
    public Sprite map;
    private Sprite orginalSprite;
    private Image image;
    private void Start()
    {
        image = PauseMenu.GetComponent<Image>();
        orginalMapColor = image.color;
        orginalSprite = image.sprite;
    }
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

    public void MapChange()
    {
        if (image.color == orginalMapColor)
        {
            image.sprite = map;
            image.color = Color.white;
        }
        else
        {
            image.sprite = orginalSprite;
            image.color = orginalMapColor;
        }
    }
}
