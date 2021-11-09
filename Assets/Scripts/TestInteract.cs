using UnityEngine;

public class TestInteract : GameBehavior, IInteractable
{
    [SerializeField] [Range(0.01F, 10F)]
    private float distance = 0.5F;
    private Transform _player;
    private void Start()
    {
        _player = GameManager.GetPlayer().transform;
    }

    private void Update()
    {
        var playerDistance = Vector3.Distance(_player.position, this.gameObject.transform.position);
        
        if (distance >= playerDistance)
        {
            OnStartInteract();
        }
        else
        {
            OnEndInteract();
        }
    }

    public void OnStartInteract()
    {
        ChatManager.EnableChatBox();
        ChatManager.SetChatBoxText("Hey lol");
    }

    public void OnEndInteract()
    {
        ChatManager.DisableChatBox();
        ChatManager.ClearText();
    }
}
