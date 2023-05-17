using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject pauseButton;
    public GameObject MapScreen;
    public GameObject IntialScreen;
    public LookingMobile look;
    public PlayerController playerController;
    private Color orginalMapColor;
    public Sprite map;
    private Sprite orginalSprite;
    private Image image;
    [SerializeField]
    private Vector2 textDisplayStatus = Vector2.zero; // X = Displays Seen Y = Total Displays
    public TextMeshProUGUI textDisplayCount;
    public TextMeshProUGUI textDisplaySeenCount;
    private void Start()
    {
        image = PauseMenu.GetComponent<Image>();
        orginalMapColor = image.color;
        orginalSprite = image.sprite;
    }
    public void Pause()
    {
        DisablePlayerMovement();
        if (PauseMenu.activeSelf)
        {
            // Pause Menu Is Already Active
            PauseMenu.SetActive(false);
            pauseButton.SetActive(true);
            Time.timeScale = 1f;
        }
        else
        {
            // Activate Pause Menu
            PauseMenu.SetActive(true);
            pauseButton.SetActive(false);
            UpdateTextDisplayTracker();
            Time.timeScale = 0f;
        }
    }
    public void UpdateTextDisplayTracker()
    {
        textDisplayCount.text = textDisplayStatus.y.ToString();
        textDisplaySeenCount.text = textDisplayStatus.x.ToString() + '/';
    }

    public void IncreaseCount(bool CountIncrement)
    {
        if (CountIncrement)
        {
            // Increase Count
            textDisplayStatus.y++;
        }
        else
        {
            // Increase Seen
            textDisplayStatus.x++;
        }
    }
    public void DisablePlayerMovement()
    {
        look.CanMove = !look.CanMove;
        playerController.CanMove = !playerController.CanMove;
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
            IntialScreen.SetActive(true);
            MapScreen.SetActive(false);
        }
    }


}
