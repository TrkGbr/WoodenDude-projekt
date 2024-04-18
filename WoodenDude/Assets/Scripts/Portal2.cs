using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Portal2 : MonoBehaviour
{
    private float delayBeforeDisappear = 5f;
    public Text MissionDescription;

    void Start()
    {
        ThirdMission();
    }

    public void ThirdMission()
    {
        MissionDescription.text = GameManager.Instance.ThirdMission;
        Invoke("DisappearText", delayBeforeDisappear);
    }

    private void DisappearText()
    {
        gameObject.SetActive(false);

    }
}