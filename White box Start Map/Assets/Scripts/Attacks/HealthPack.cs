using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public GameObject useText;
    public static bool hasPickedUpHealthPack = false;
    private bool hasEnteredTrigger = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (hasEnteredTrigger)
        {
            if (Input.GetKey(KeyCode.E))
            {
                hasPickedUpHealthPack = true;
                hasEnteredTrigger = false;
                gameObject.SetActive(false);
                useText.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        useText.SetActive(true);
        hasEnteredTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        useText.SetActive(false);
        hasEnteredTrigger = false;
        hasPickedUpHealthPack = false;
    }
}
