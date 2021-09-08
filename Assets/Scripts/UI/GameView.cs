using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GameView : MonoBehaviour
{
    public GameObject panelCouncil;
    public GameObject panelSettings;
    public GameObject panelEventExe;
    private Button buttonOpenExePanel;
    private Button buttonCloseExePanel;
    private RectTransform rectExePanel;
    
    //特别事件栏
    public GameObject scrollSpecialEvent;
    private RectTransform contentTransform;
    public RectTransform itemTransform;//设置添加的预制体

    void Start()
    {
        buttonOpenExePanel = panelEventExe.transform.Find("ButtonOpenExePanel").GetComponent<Button>();
        buttonCloseExePanel = panelEventExe.transform.Find("ButtonCloseExePanel").GetComponent<Button>();
        rectExePanel = panelEventExe.GetComponent<RectTransform>();
        contentTransform = scrollSpecialEvent.transform.Find("Viewport").Find("Content").GetComponent<RectTransform>();
    }
    
    public void ButtonTestEvent_OnClick()
    {
        Transform temp = Instantiate(itemTransform).transform;
        temp.SetParent(contentTransform);
        temp.localPosition = Vector3.zero;
        temp.localRotation = Quaternion.identity;
        temp.localScale = Vector3.one;
    }

    public void ButtonSettings_OnClick()
    {
        panelSettings.SetActive(true);
    }
    public void ButtonRelationship_OnClick()
    {
        
    }
    public void ButtonCouncil_OnClick()
    {
        panelCouncil.SetActive(true);
    }

    //Button in Council
    public void ButtonBacktoGame_OnClick()
    {
        panelCouncil.SetActive(false);
    }

    //Buttons in Settings
    public void ButtonSaveQuit_OnClick()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void ButtonResume_OnClick()
    {
        panelSettings.SetActive(false);
    }
    
    //Buttons in Event Exe
    public void ButtonOpenExePanel_OnClick()
    {
        buttonOpenExePanel.gameObject.SetActive(false);
        buttonCloseExePanel.gameObject.SetActive(true);
        OpenExePanel();
    }
    public void ButtonCloseExePanel_OnClick()
    {
        buttonOpenExePanel.gameObject.SetActive(true);
        buttonCloseExePanel.gameObject.SetActive(false);
        CloseExePanel();
    }

    void OpenExePanel()
    {
        rectExePanel.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right,0,rectExePanel.sizeDelta.x);
    }
    void CloseExePanel()
    {
        rectExePanel.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right,-rectExePanel.sizeDelta.x/2.0f,rectExePanel.sizeDelta.x);
    }
}
