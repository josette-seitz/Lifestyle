using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifestyleScript : MonoBehaviour {

    public GameObject passion;
    public GameObject thisIsMy;
    public GameObject lifestyle;
    public GameObject purplePs;
    public GameObject purplePsExit;
    public Material redSkybox;
    public GameObject lifestyle2;
    public GameObject music;
    public ParticleSystem musicPS;
    public ParticleSystem musicTrail;
    public GameObject invertedSpherePS;
    public GameObject think;
    public GameObject wonder;
    private Camera cam;
    private TextMeshPro textThink;
    private TextMeshPro textWonder;
    private RectTransform posThink;
    private RectTransform posWonder;
    public GameObject blastOff1;
    public GameObject blastOff2;
    public GameObject endPS;
    public GameObject loveText;

    void Start () {
        cam = GetComponent<Camera>();
        textThink = think.GetComponent<TextMeshPro>();
        textWonder = wonder.GetComponent<TextMeshPro>();
        posThink = textThink.GetComponent<RectTransform>();
        posWonder = textWonder.GetComponent<RectTransform>();
    }
	
	void Update () {
        float time = Time.time;
        if (time > 2.5)
        {
            passion.SetActive(true);
            iTween.RotateBy(passion, iTween.Hash("x", -.5f, "time", 10f));
        }
        if (time > 12)
        {
            passion.SetActive(false);
            thisIsMy.SetActive(true);

        }
        if (time > 12.5)
        {
            lifestyle.SetActive(true);
        }
        if(time > 15.25)
        {
            thisIsMy.SetActive(false);
            lifestyle.SetActive(false);
            purplePs.SetActive(false);
            purplePsExit.SetActive(true);
            RenderSettings.skybox = redSkybox;
        }
        if(time > 16.5)
        {
            musicTrail.gameObject.SetActive(true);
            music.SetActive(true);
            musicPS.gameObject.SetActive(true);
        }
        if (time > 22.5)
        {
            lifestyle2.SetActive(true);
            purplePsExit.SetActive(false);
        }
        if(time > 29)
        {
            music.SetActive(false);
            lifestyle2.SetActive(false);
            musicPS.gameObject.SetActive(false);
        }
        if(time > 29.4)
        {
            invertedSpherePS.SetActive(true);
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.black;
            musicTrail.gameObject.SetActive(false);
        }
        if (time > 32.5)
        {
            think.SetActive(true);
        }
        if(time > 33)
        {
            wonder.SetActive(true);
        }
        if(time > 36.5)
        {
            blastOff1.SetActive(true);
            blastOff2.SetActive(true);
        }
        if (time > 39.5)
        {
            posThink.position = new Vector3(-6.5f, 10.4f, -20.5f);
            textThink.SetText("this");
        }
        if (time > 40.5)
        {
            posWonder.position = new Vector3(-3.6f, 9.5f, -23.2f);
            textWonder.SetText("is my lifestyle");
        }
        if(time > 44.5)
        {
            blastOff1.SetActive(false);
            blastOff2.SetActive(false);
            textThink.gameObject.SetActive(false);
            textWonder.gameObject.SetActive(false);
            invertedSpherePS.SetActive(false);
            endPS.SetActive(true);
        }
        if(time > 46.5)
        {
            loveText.SetActive(true);
        }
    }
}
