using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Tutorail : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject convo;
    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(3000);
        convo.SetActive(false);

        await Task.Delay(5000);
        tutorText.gameObject.SetActive(false);

    }


}
