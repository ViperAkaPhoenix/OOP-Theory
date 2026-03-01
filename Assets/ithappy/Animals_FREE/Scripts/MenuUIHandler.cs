using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField catNameTextField;
    public TMP_InputField dogNameTextField;
    public TMP_InputField chickenNameTextField;

    private void SetAnimalNames()
    {
        GlobalInfo.Instance.catName = catNameTextField.text;
        GlobalInfo.Instance.dogName = dogNameTextField.text;
        GlobalInfo.Instance.chickenName = chickenNameTextField.text;
    }

    public void StartNew()
    {
        SetAnimalNames();
        SceneManager.LoadScene(1);

        //Debug.Log("Cat on menu:" + GlobalInfo.Instance.catName);
        //Debug.Log("Dog on menu:" + GlobalInfo.Instance.dogName);
        //Debug.Log("Chicken on menu:" + GlobalInfo.Instance.chickenName);
    }

}
