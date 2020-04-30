using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DecalOnOff : MonoBehaviour
{
    Material _mat;
    bool showDecal = false;

    void OnMouseDown() {
        showDecal = !showDecal;
        if(showDecal)
            _mat.SetFloat("_ShowDecal", 1);
        else    
            _mat.SetFloat("_ShowDecal", 0);
    }

    private void Awake() {
        _mat = GetComponent<Renderer>().sharedMaterial;
    }
}
