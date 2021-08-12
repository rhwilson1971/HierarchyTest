using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    public DropdownField menu;
    VisualElement root;
    // Start is called before the first frame update
    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        menu = root.Q<DropdownField>("fruits");

        var vegetables = root.Q<DropdownField>("vegetables");

        vegetables.RegisterValueChangedCallback(OnSelectedValue);

        //Debug.Log("i " + menu.value);
        //Debug.Log("i " + menu);

        //Debug.Log(menu.userData);
        //Debug.Log(menu.binding);
        //Debug.Log(menu.bindingPath);

        //List<string> items = new List<string>()
        //{
        //    "Apple",
        //    "Orange",
        //    "Pear",
        //    "Peach"
        //};

        //var dropDown = new DropdownField(items, 0);
        //dropDown.name = "more-fruits";
        //dropDown.label = "More fruits";

        //var holder = root.Q<VisualElement>();

        //holder.Add(dropDown);

        //dropDown.RegisterValueChangedCallback(OnSelectedValue);
        // DropdownMenuEventInfo
    }

    void OnSelectedValue(ChangeEvent<string> eventInfo)
    {
        var holder = root.Q<VisualElement>("holder");

        //foreach( var item in holder.Children())
        //{
        //    Debug.Log("eh? " + item);
        //}

        holder.Clear();

        //if (holder.ElementAt(0) == null)
        {
            Debug.Log(eventInfo.newValue);
            List<string> items = new List<string>()
            {
                "Apple",
                "Orange",
                "Pear",
                "Peach"
            };

            var dropDown = new DropdownField(items, 0);
            dropDown.name = "more-fruits";
            dropDown.label = "More fruits";
            holder.Add(dropDown);
        }
    }
}
