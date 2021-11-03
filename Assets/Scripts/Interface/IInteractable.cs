/// <summary>
///   <para>IInteractable is the interface all intractable items use.</para>
/// </summary>
public interface IInteractable
{
    /// <summary>
    ///     <para>OnStartInteract is what is executed when the player interacts with the object.</para>
    /// </summary>
    public void OnStartInteract();
    
    /// <summary>
    ///     <para>OnEndInteract is what is executed when the player stops interacting with the object.</para>
    /// </summary>
    public void OnEndInteract();
}
