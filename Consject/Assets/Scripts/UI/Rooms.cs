using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TMP_Dropdown dropRoomChosen;
    public TMP_Dropdown chosenLevel;
    public TMP_Dropdown chosenRoom;
    public TMP_InputField height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRoom()
    {
        if (dropRoomChosen.options.Count > 0)
        {
            var text = dropRoomChosen.options[dropRoomChosen.value].text;
            if (text != null)
            {
                dropRoomChosen.options.RemoveAt(dropRoomChosen.value);
                dropRoomChosen.RefreshShownValue();
                chosenRoom.options.Add(new TMP_Dropdown.OptionData(text));
                if (chosenRoom.options.Count == 1)
                {
                    chosenRoom.value = 0;
                    chosenRoom.value = 1;
                    chosenRoom.value = 0;
                }
                chosenRoom.RefreshShownValue();
            }
            else
            {
                dropRoomChosen.RefreshShownValue();
            }
        }
    }

    public void ChangedLevel()
    {
        var level = chosenLevel.options[chosenLevel.value].text;
        switch (level)
        {
            case "�tage 2":
                title.text = "Pi�ces du deuxi�me �tage";
                break;
            case "RDC":
                title.text = "Pi�ces du rez-de-chauss�e";
                break;
            case "Sous-sol":
                title.text = "Pi�ces du sous-sol";
                break;
        }
    }
}
