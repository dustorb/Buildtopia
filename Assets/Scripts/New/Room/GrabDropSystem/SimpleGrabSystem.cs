using UnityEngine;
/// <summary>
/// Simple example of Grabbing system.
/// </summary>
public class SimpleGrabSystem : MonoBehaviour
{
    // Reference to the character camera.
    [SerializeField]
    private Camera characterCamera;
    // Reference to the slot for holding picked item.
    [SerializeField]
    private Transform slot;
    // Reference to the currently held item.
    private PickableItem pickedItem;
    /// <summary>
    /// Method called very frame.
    /// </summary>
    /// 

    //disc logic
    public OpenGameIfDisc OpenGameIfDisc;
    public bool havedisc;
    public QuestManager QuestManager;
    public Animator insertDisk;



    private void Update()
    {
        // Execute logic only on button pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Check if player picked some item already
            if (pickedItem)
            {
                // If yes, drop picked item
                //DropItem(pickedItem);

                Ray ray = characterCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 20f))
                {
                    if (hit.collider.tag == "redCell" && havedisc)
                    {
                        OpenGameIfDisc.haveDiscInComputer = true;
                        DropItem(pickedItem);
                        insertDisk.Play("Play");
                    }

                }

            }

            else
            {
                // If no, try to pick item in front of the player
                // Create ray from center of the screen

                //var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                //RaycastHit hit;

                Ray ray = characterCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                // Shot ray to find object to pick
                if (Physics.Raycast(ray, out hit, 50f))
                {


                    // Check if object is pickable
                    var pickable = hit.transform.GetComponent<PickableItem>();
                    // If object has PickableItem class
                    if (pickable)
                    {
                        // Pick it
                        PickItem(pickable);
                        OpenGameIfDisc.haveGameDisc = true;
                        havedisc = true;
                        QuestManager.Quest3();
                    }
                }
            }
        }
    }
    /// <summary>
    /// Method for picking up item.
    /// </summary>
    /// <param name="item">Item.</param>
    private void PickItem(PickableItem item)
    {
        // Assign reference
        pickedItem = item;
        // Disable rigidbody and reset velocities
        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;
        // Set Slot as a parent
        item.transform.SetParent(slot);
        // Reset position and rotation
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;
    }
    /// <summary>
    /// Method for dropping item.
    /// </summary>
    /// <param name="item">Item.</param>
    private void DropItem(PickableItem item)
    {

        // Remove reference
        pickedItem = null;
        // Remove parent
        item.transform.SetParent(null);
        // Enable rigidbody
        item.Rb.isKinematic = false;
        // Add force to throw item a little bit
        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
        Destroy(item.gameObject);
    }
}
