using TMPro; //serve per scrivere la data sul Canvas "DataOrario"
using UnityEngine;

public class DateTimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI dateTimeText; // data in formato TextMeshProUGUI 

    void Update()
    {
        string currentTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //setto il formato della data e dell'orario
        dateTimeText.text = currentTime; // mando in output l'orario
    }
}