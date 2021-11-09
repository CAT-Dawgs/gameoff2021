using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatManager : GameBehavior
{
    [SerializeField]
    private GameObject chatBox;
    private string _chat;
    private TMP_Text _tmpText;
    private void Awake()
    {
        _tmpText = chatBox.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
    }

    public void EnableChatBox()
    {
        chatBox.SetActive(true);
    }

    public void DisableChatBox()
    {
        chatBox.SetActive(false);
    }
    /// <summary>
    /// Sets the text in the chat box.
    /// </summary>
    /// <param name="text">Text that you want chatted</param>
    public void SetChatBoxText(string text)
    {
        _tmpText.text = text;
    }

    /// <summary>
    /// Clears chat box.
    /// </summary>
    public void ClearText()
    {
        _chat = null;
    }

    void Update()
    {
        
    }
}
