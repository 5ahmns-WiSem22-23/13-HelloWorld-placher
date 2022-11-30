using TMPro;
using UnityEngine;

public class HelloWorldUI : MonoBehaviour
{

    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI textEnd;


    public void Awake()
    {
        textEnd.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        textEnd.text = inputField.text;
        if (!textEnd.gameObject.activeSelf) textEnd.gameObject.SetActive(true);

    }
}
