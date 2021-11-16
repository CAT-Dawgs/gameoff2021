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
        ChatManager.SetChatBoxText("You notice that there isn't much in this room. \n Just a \"lamp\", whatever that is.");
    }

    public void OnEndInteract()
    {
        ChatManager.DisableChatBox();
        ChatManager.ClearText();
    }
}
