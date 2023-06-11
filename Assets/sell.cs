using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sell : MonoBehaviour
{
    [SerializeField] asset_show ass;

    // Update is called once per frame
    private void OnMouseDown()
    {
        ass.show_asset();
    }
}
