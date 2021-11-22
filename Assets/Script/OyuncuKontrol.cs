using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    
    public OyunKontrol Okontrol;
    private float hiz = 5;
    public UnityEngine.UI.Text bitisss;
    public GameObject sphere;
    public GameObject sphere1;
    //public AuidoClib altin,dusme; diyerek 2 farklý ses üzerinde onlarý unity de seçtikten sonra kullanabiliriz.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Okontrol.OAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            //ses için::::  GetComponent<AudioSource> ().playOnShote(altin, 1f); or .stop(); or .pause();
            Okontrol.AltinArttir();
            Destroy(c.gameObject);
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {  
            sphere.GetComponent<Rigidbody>().isKinematic = true;
            sphere1.GetComponent<Animator>().enabled = false;
            bitisss.text = "KAYBETTÝNÝZ...";
            Okontrol.OAktif = false;
        }
        else if (c.gameObject.tag.Equals("bitis"))
        {
            bitisss.text = "KAZANDINIZ...";
            Okontrol.OAktif = false;
        }
    }
}
