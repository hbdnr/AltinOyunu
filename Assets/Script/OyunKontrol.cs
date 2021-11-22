using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public bool OAktif = true;
    public int AltinSayisi = 0;
    public UnityEngine.UI.Text asayisi;
    // Start is called before the first frame update
    void Start()
    {
        //ses için::::  GetComponent<AudioSource> ().start(); or .stop(); or .pause();
        asayisi.text = 0 + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AltinArttir()
    {
        AltinSayisi += 1;
        asayisi.text = AltinSayisi + "";
    }
}
