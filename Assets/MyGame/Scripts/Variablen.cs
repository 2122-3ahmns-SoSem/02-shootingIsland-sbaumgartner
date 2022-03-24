using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    public GameObject x;
    Color farbe;
    int anzTuerenInstanz;
    bool fahren;
    bool hausBauen;
    int anzFenster;

    void Start()
    {
        Debug.Log(
            Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " +
            Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        farbe = Color.red;
        Debug.Log("Red " + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("Yellow " + farbe.ToString());

        farbe = Color.white;
        Debug.Log("White " + farbe.ToString());

        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString()); //nimm Instanz
        Debug.Log("bool fahren" + fahren.ToString());

        int anzTueren = int.Parse("4");
        float anzTuerenf = float.Parse("4");

        Debug.Log(anzTueren + " " + anzTuerenf + " " + anzTuerenInstanz);

        anzTueren = 0;
        anzFenster = 0;
        hausBauen = true;
    }

    void Update()
    {
        {
            if (hausBauen)
            {
                anzTueren = anzTueren + 3;
                anzFenster = anzFenster + 3;
            }

            if (anzTueren <= 15 & anzFenster <= 15)
            {
                hausBauen = true;
            }

            else
            {
                hausBauen = false;
            }
        }
    }
}
