using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private Text interactableName;

    private InteractionObject targetInteraction;

    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;

        if (Physics.Raycast(origin, direction, out raycastHit, maxDistance))
        {
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
        }

        if (targetInteraction)
        {
            interactionText = targetInteraction.GetInteractionText();
        }
        
        SetInteractableNameText(interactionText);
    }

    private void SetInteractableNameText(string newText)
    {
        if (interactableName)
        {
            interactableName.text = newText;
        }
    }

    public void TryInteract()
    {
        if (targetInteraction)
        {
            targetInteraction.Interact();
        }
    }
}
