using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIFrame[] frameArray;
    [SerializeField] private GameObject strikeImage;
    [SerializeField] private GameObject spareImage;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TextMeshProUGUI totalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int frameNumber = 1;

        foreach (UIFrame frame in frameArray)
        {
            frame.SetFrameNumber(frameNumber);
            frameNumber++;
        }

    }

    public void DisplayGameOverScreen(int totalScore)
    {
        totalScoreText.text = "TOTAL SCORE: " + totalScore.ToString();
        gameOverScreen.SetActive(true);
    }

    public void UpdateFirstThrowOnFrame(int currentFrameIndex, int throwScore)
    {
        frameArray[currentFrameIndex - 1].SetFirstThrowScore(throwScore);
    }

    public void UpdateSecondThrowOnFrame(int currentFrameIndex, int throwScore)
    {
        frameArray[currentFrameIndex - 1].SetSecondThrowScore(throwScore);
    }

    public void UpdateTotalScoreOnFrame(int currentFrameIndex, int totalScore)
    {
        frameArray[currentFrameIndex - 1].SetTotalScore(totalScore);
    }

    public void DisplayStrike()
    {
        strikeImage.SetActive(true);
        Invoke("HideImages", 3);
    }

    public void DisplaySpare()
    {
        spareImage.SetActive(true);
        Invoke("HideImages", 3);
    }

    private void HideImages()
    {
        strikeImage.SetActive(false);
        spareImage.SetActive(false);
    }
}
