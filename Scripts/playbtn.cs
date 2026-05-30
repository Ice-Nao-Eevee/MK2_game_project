using UnityEngine;
using UnityEngine.SceneManagement; // WAJIB TAMBAHKAN INI

public class playbtn : MonoBehaviour
{
    [Header("UIMenu")]
    public GameObject UImenu;
    public GameObject Levels;
    public GameObject PanelSetting;
    public GameObject InfoMenu;

    [Header("Audio")]
    public AudioSource bgm; // Variabel baru untuk menampung musik

    void Start()
    {
        // Gunakan 'S' besar pada SetActive
        UImenu.SetActive(true);
        Levels.SetActive(false);
    }

    public void Play()
    {
        UImenu.SetActive(false);
        Levels.SetActive(true);
    }

    public void Back()
    {
        UImenu.SetActive(true);
        Levels.SetActive(false);
    }

    public void SettingBtnOn()
    {
        PanelSetting.SetActive(true);
        UImenu.SetActive(false);
    }

    public void SettingBtnOff()
    {
        PanelSetting.SetActive(false);
        UImenu.SetActive(true);
    }

    public void InfoBtnOn()
    {
        InfoMenu.SetActive(true);
        UImenu.SetActive(false);
    }

    public void InfoBtnOff()
    {
        InfoMenu.SetActive(false);
        UImenu.SetActive(true);
    }

    public void SoundOnBtn()
    {
        // Menyalakan musik
        if (bgm != null) bgm.UnPause();
    }

    public void SoundOffBtn()
    {
        // Berhentikan musik
        if (bgm != null) bgm.Pause();
    }

    public void LoadLevel1()
    {
        // Pastikan nama di dalam tanda petik sama persis dengan nama file scene kamu
        SceneManager.LoadScene("level1");
    }

    public void LoadLevel2()
    {

        // Pastikan nama di dalam tanda petik sama persis dengan nama file scene kamu
        SceneManager.LoadScene("level2");
    }

    public void LoadLevel3()
    {

        // Pastikan nama di dalam tanda petik sama persis dengan nama file scene kamu
        SceneManager.LoadScene("level3");
    }
}