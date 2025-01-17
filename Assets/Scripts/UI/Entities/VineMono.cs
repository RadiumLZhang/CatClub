using System.Collections;
using System.Collections.Generic;
using Coffee.UIEffects;
using Language;
using UnityEngine;
using UnityEngine.UI;

public class VineMono : MonoBehaviour
{
    public int id;
    private UITransitionEffect effectVine;
    private UITransitionEffect effectBg;
    private UITransitionEffect effectText;
    private Transform relation;
    private Text relationText;
    public AudioSource adplayer;
    public int relationId;
    
    public bool Active { get; set; }
    
    private bool IsInit { get; set; }
    
    void Awake()
    {
        adplayer = GameObject.Find("AudioSource").GetComponent<AudioSource>();
        Init();
    }

    public void Init()
    {
        if (IsInit)
        {
            return;
        }

        IsInit = true;
        
        relation = transform.Find("Image");
        relationText = transform.Find("Image/Text").GetComponent<Text>();
        
        effectVine = transform.GetComponent<UITransitionEffect>();
        effectBg = relation.GetComponent<UITransitionEffect>();
        effectText = relationText.GetComponent<UITransitionEffect>();
    }


    public void Show(bool isReverse = false)
    {
        if (Active)
        {
            return;
        }
        
        gameObject.SetActive(true);

        if (isReverse)
        {
            effectVine.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex_Reverse");
            effectBg.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex_Reverse");
            effectText.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex_Reverse");
        }
        else
        {
            effectVine.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex");
            effectBg.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex");
            effectText.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex");
        }
        
        Active = true;
        effectVine.Show();
        effectBg.Show();
        effectText.Show();
        
        PlayBGM("AudioClips/主界面/藤蔓蔓延");
    }

    public void Hide()
    {
        if (!Active)
        {
            return;
        }
        
        Active = false;
        effectVine.Hide();
        effectBg.Hide();
        effectText.Hide();
    }

    public void SetText(int id)
    {
        relationId = id;

        var item = LanguageLoader.Instance.FindLanguageItem(id.ToString());
        if (item == null)
        {
            return;
        }
        
        relationText.text = item.Value;

        
        effectBg.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex");
        effectText.transitionTexture = Resources.Load<Texture>("Texture/UITransitionTex");
        
        effectText.Show();
        effectBg.Show();
    }

    public void PlayBGM(string path)
    {
        AudioClip m_clip = Resources.Load<AudioClip>(path);
        adplayer.clip = m_clip;
        adplayer.Play();
    }
}
