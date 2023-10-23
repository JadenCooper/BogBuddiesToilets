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
    public PlayerController playerController;
    private Color orginalMapColor;
    public Sprite map;
    private Sprite orginalSprite;
    private Image image;
    [SerializeField]
    private Vector2 textDisplayStatus = Vector2.zero; // X = Displays Seen Y = Total Displays
    [SerializeField]
    private List<Collectible> collectibles = new List<Collectible>();
    public TextMeshProUGUI textDisplayCount;
    public GameObject joysticks;
    public bool GameHasStarted;
    private void Start()
    {
        image = PauseMenu.GetComponent<Image>();
        textDisplayStatus.y = collectibles.Count;
        orginalMapColor = image.color;
        orginalSprite = image.sprite;
    }
    public void Update()
    {
        //Update method runs and checks if escape has been pressed.
        if (Input.GetKeyDown(KeyCode.Escape) && GameHasStarted)
        {
            Pause();
        }
    }

    // This method is purely there to stop the play from opening and closing
    // the pause menu before the game has started.
    public void StartGameUpdate()
    {
        GameHasStarted = true;
    }
    public void Pause()
    {
        DisablePlayerMovement();
        if (PauseMenu.activeSelf)
        {
            // Pause Menu Is Already Active
            PauseMenu.SetActive(false);
            pauseButton.SetActive(true);
            joysticks.SetActive(true);
            Time.timeScale = 1f;
        }
        else
        {
            // Activate Pause Menu
            PauseMenu.SetActive(true);
            joysticks.SetActive(false);
            pauseButton.SetActive(false);
            UpdateTextDisplayTracker();
            Time.timeScale = 0f;
        }
    }
    public void TempUnpause()
    {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        DisablePlayerMovement();
    }
    public void UpdateTextDisplayTracker()
    {
        for (int i = 0; i < collectibles.Count; i++)
        {
            if (collectibles[i].collected)
            {
                textDisplayStatus.x++;
            }
        }
        textDisplayCount.text = textDisplayStatus.y.ToString();
        textDisplayCount.text = textDisplayStatus.x.ToString() + "/" +  textDisplayStatus.y.ToString();
        textDisplayStatus.x = 0; // Reset
    }
    public void DisablePlayerMovement()
    {
        playerController.CanMove = !playerController.CanMove;
    }
    public void MapChange()
    {
        if (image.color == orginalMapColor)
        {
            image.sprite = map;
            image.color = Color.white;
            image.preserveAspect = true;
        }
        else
        {
            image.sprite = orginalSprite;
            image.color = orginalMapColor;
            image.preserveAspect = false;
            IntialScreen.SetActive(true);
            MapScreen.SetActive(false);
        }
    }


}
