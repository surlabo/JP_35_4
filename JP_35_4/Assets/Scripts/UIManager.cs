using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text point;
    public GameObject StartMenuPanel;
    public GameObject InGameMenuPanel;
    public GameManager gameManager;
    public Slider soundSlider;
    public TMP_Dropdown dropdown;
    public GameObject myImage;
    public Transform imageParent;
    public Button startButton;
    public Toggle myToggle;
    public Slider mySlider;

    private int count = 0;

    private void Start()
    {
        soundSlider.minValue = 0;
        soundSlider.maxValue = 100;
        var option = new TMP_Dropdown.OptionData("Option N");
        var option2 = new TMP_Dropdown.OptionData("Opiton M");
        var optionsList = new List<TMP_Dropdown.OptionData>();
        optionsList.Add(option);
        optionsList.Add(option2);
        dropdown.AddOptions(optionsList);
        startButton.onClick.AddListener(OnStartButtonClick);
        //myToggle.onValueChanged.AddListener(OnToggle);
        //mySlider.onValueChanged.AddListener(OnSlider);
        //StartCoroutine(Counter());
    }

    private void OnSlider(float value)
    {
        
    }

    //IEnumerator Counter()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1);
    //        count++;
    //        point.text = count.ToString();
    //    }
    //}

    public void OnCounterButtonClick()
    {
        
        count++;
        point.text = count.ToString();

        PlayerPrefs.SetInt("ID", count);
    }

    public void OnToggle(bool value)
    {
        var x = PlayerPrefs.GetInt("ID");
    }

    public void OnStartButtonClick()
    {
        Camera.main.gameObject.SetActive(false);
        StartMenuPanel.SetActive(false);
        InGameMenuPanel.SetActive(true);
        gameManager.StartGame();
    }

    public void OnOptionsButtonClick()
    {

    }

    public void OnToggleClick(bool value)
    {
        Debug.Log(value);
    }

    public void OnSliderChange(int value)
    {
        Debug.Log(soundSlider.value);
    }

    public void OnDropDownChanged(int value)
    {
        Debug.Log(value);
    }

    public void CreateImage()
    {
        var color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        var imageClone = Instantiate(myImage, imageParent);
        imageClone.GetComponent<Image>().color = color;
    }
}
