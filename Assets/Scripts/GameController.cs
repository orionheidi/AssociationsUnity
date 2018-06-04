using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	string[] reci = { "HRVATSKA", "ZOO VRT", "OSTRVO", "LETNJIKOVAC" };

	string[] reci2 = { "LINKOLN", "VRHOVNI", "AUTOKRATA", "DRZAVA" };

	string[] reci3 = { "MARKS", "LEVICA", "MIRA MARKOVIC", "KINA" };

	string[] reci4 = { "FENSI", "BELE RUKAVICE", "ZENSKAROS", "PARFEMI" };

	public string odgovor1 = "BRIONI";
	public string odgovor2 = "KICOS";
	public string odgovor3 = "POLITICAR";
	public string odgovor4 = "KOMUNIZAM";
	public string konacan = "TITO";






	public GameObject recZaResenje;
	public GameObject mestozaUbacivanjeResenja;
	public GameObject mestozaUbacivanjeResenja1;
	public GameObject mestozaUbacivanjeResenja2;
	public GameObject mestozaUbacivanjeResenja3;


	public float razmakIzmedjuReci = 0.7f;

	public static int kolikoPutaInstanciratiRec;

	public InputField textInput;
	public InputField textInput2;
	public InputField textInput3;
	public InputField textInput4;
	public InputField textInput5;

	public static int brojProverenihOdgovora = 0;

	public GameObject recPogodjena;
	public GameObject recKonacna;
	public GameObject mestoZaPobednicuRec;
	public GameObject mestoZaPobednicuRec2;
	public GameObject mestoZaPobednicuRec3;
	public GameObject mestoZaPobednicuRec4;
	public GameObject mestoZaKonacnuRec;

	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	public GameObject cube5;

	public int brojPogodjenih = 0;
	public int brojPogodjenihDrugog = 0;
	public int brojPogodjenihTreceg = 0;
	public int brojPogodjenihCetvrtog = 0;

	public int brojPogodjenihX = 0;
	public int brojPogodjenihDrugogX = 0;
	public int brojPogodjenihTrecegX = 0;
	public int brojPogodjenihCetvrtogX = 0;


	public Image loadingBar;
	public Image loadingBarPlayer1;
	public Image loadingBarPlayer2;

	public float maxTime = 160f;
	float timeLeft;

	public float maxTimePlayer = 20f;
	float timeLeftPlayer1;
	float timeLeftPlayer2;

	public Text scoreText;
	public Text scoreText2;
	public int skorUkupan = 0;
	public int skorUkupan2 = 0;

	public bool daLiPlayer1Igra = false;
	public bool daLiPlayer2Igra = false;

	private bool playerOneGole = false;
	private bool playerTwoGole = false;

	void Start ()
	{
		PogodiPrvuKocuku ();
		PogodiDruguKocuku ();
		PogodiTrecuKocuku ();
		PogodiCetvrtuKocuku ();

		skorUkupan = 0;
		skorUkupanX = 0;

		timeLeft = maxTime;
		timeLeftPlayer1 = maxTimePlayer;
		timeLeftPlayer2 = maxTimePlayer;


	}


	void PogodiPrvuKocuku ()
	{

		for (int i = 0; i < reci.Length; i++) {
			GameObject instanciranaRec = Instantiate (recZaResenje, new Vector3 (0f, 0f, 0f), Quaternion.identity);

			if (i == 0)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja.transform.GetChild (0));


			if (i == 1)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja.transform.GetChild (1));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 7f + razmakIzmedjuReci, 0.0f);


			if (i == 2)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja.transform.GetChild (2));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 10.5f + razmakIzmedjuReci, 0.0f);


			if (i == 3)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja.transform.GetChild (3));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 14f + razmakIzmedjuReci, 0.0f);
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = reci [i].ToString ();
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();

			instanciranaRec.transform.GetChild (0).gameObject.SetActive (false);

			if (pogodnjen1 == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}

			if (konacni == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}
		}
	}


	void PogodiDruguKocuku ()
	{

		for (int i = 0; i < reci2.Length; i++) {
			GameObject instanciranaRec = Instantiate (recZaResenje, new Vector3 (0f, 0f, 0f), Quaternion.identity);
			if (i == 0)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja1.transform.GetChild (0));

			if (i == 1)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja1.transform.GetChild (1));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 7f + razmakIzmedjuReci, 0.0f);

			if (i == 2)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja1.transform.GetChild (2));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 10.5f + razmakIzmedjuReci, 0.0f);
			if (i == 3)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja1.transform.GetChild (3));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 14f + razmakIzmedjuReci, 0.0f);
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = reci2 [i].ToString ();
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
			instanciranaRec.transform.GetChild (0).gameObject.SetActive (false);

			if (pogodnjen3 == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}

			if (konacni == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}


		}
	}

	void PogodiTrecuKocuku ()
	{

		for (int i = 0; i < reci3.Length; i++) {
			GameObject instanciranaRec = Instantiate (recZaResenje, new Vector3 (0f, 0f, 0f), Quaternion.identity);
			if (i == 0)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja2.transform.GetChild (0));

			if (i == 1)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja2.transform.GetChild (1));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 7f + razmakIzmedjuReci, 0.0f);

			if (i == 2)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja2.transform.GetChild (2));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 10.5f + razmakIzmedjuReci, 0.0f);
			if (i == 3)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja2.transform.GetChild (3));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 14f + razmakIzmedjuReci, 0.0f);
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = reci3 [i].ToString ();
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
			instanciranaRec.transform.GetChild (0).gameObject.SetActive (false);

			if (pogodnjen4 == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}
			if (konacni == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}
		}
	}

	void PogodiCetvrtuKocuku ()
	{

		for (int i = 0; i < reci4.Length; i++) {
			GameObject instanciranaRec = Instantiate (recZaResenje, new Vector3 (0f, 0f, 0f), Quaternion.identity);
			if (i == 0)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja3.transform.GetChild (0));

			if (i == 1)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja3.transform.GetChild (1));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 7f + razmakIzmedjuReci, 0.0f);

			if (i == 2)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja3.transform.GetChild (2));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 10.5f + razmakIzmedjuReci, 0.0f);
			if (i == 3)
				instanciranaRec.transform.SetParent (mestozaUbacivanjeResenja3.transform.GetChild (3));
			instanciranaRec.transform.localPosition = new Vector3 (0.0f, 14f + razmakIzmedjuReci, 0.0f);
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = reci4 [i].ToString ();
			instanciranaRec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
			instanciranaRec.transform.GetChild (0).gameObject.SetActive (false);

			if (pogodnjen2 == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}
			if (konacni == true) {
				instanciranaRec.transform.GetChild (0).gameObject.SetActive (true);
			}
		}
	}

	public void LoadTimeForPlayer1 ()
	{
		if (timeLeftPlayer1 > 0) {
			daLiPlayer1Igra = true;

			daLiPlayer2Igra = false;

			timeLeftPlayer1 -= Time.deltaTime;

			loadingBarPlayer1.fillAmount = timeLeftPlayer1 / maxTimePlayer;

			ProveriOdgovor ();

			ProveriKonacni ();

		} else {

			LoadTimeForPlayer2 ();
          
		}
	}

	public void LoadTimeForPlayer2 ()
	{
       

		if (timeLeftPlayer2 > 0) {
			daLiPlayer2Igra = true;

			daLiPlayer1Igra = false;

			timeLeftPlayer2 -= Time.deltaTime;   

			loadingBarPlayer2.fillAmount = timeLeftPlayer2 / maxTimePlayer;

			ProveriOdgovor ();

			ProveriKonacni ();


		} else {
			timeLeftPlayer1 = maxTimePlayer;
			LoadTimeForPlayer1 ();
			timeLeftPlayer2 = maxTimePlayer;
		}
	}

    

	public void Update ()
	{
		LoadTimeForPlayer1 ();
     

		if (timeLeft > 0) {

			timeLeft -= Time.deltaTime;

			loadingBar.fillAmount = timeLeft / maxTime;
		} else {

			SceneManager.LoadScene (1);
		}
			

		if (Input.GetMouseButtonUp (0)) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				Debug.Log (hit.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text);

               
				IdiNaRec (hit.transform.gameObject);

			}
		}

		ProveriOdgovor ();
		ProveriKonacni ();


	}


	public void IdiNaRec (GameObject rec)
	{
		rec.transform.GetChild (0).gameObject.SetActive (true);


		for (int i = 0; i < reci.Length; i++) {
			if (rec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text == reci [i].ToString ()) {
				brojPogodjenih = brojPogodjenih + 10;
				brojPogodjenihX = brojPogodjenihX + 10;


			}

		}



		for (int i = 0; i < reci2.Length; i++) {
			if (rec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text == reci2 [i].ToString ()) {

				brojPogodjenihTreceg = brojPogodjenihTreceg + 10;
				brojPogodjenihTrecegX = brojPogodjenihTrecegX + 10;


			}


		}




		for (int i = 0; i < reci3.Length; i++) {
			if (rec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text == reci3 [i].ToString ()) {

				brojPogodjenihCetvrtog = brojPogodjenihCetvrtog + 10;
				brojPogodjenihCetvrtogX = brojPogodjenihCetvrtogX + 10;


			}


		}



		for (int i = 0; i < reci4.Length; i++) {
			if (rec.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text == reci4 [i].ToString ()) {

				brojPogodjenihDrugog = brojPogodjenihDrugog + 10;
				brojPogodjenihDrugogX = brojPogodjenihDrugogX + 10;



			}


		}



	}

  
	bool pogodnjen1 = false;
	bool pogodnjen2 = false;
	bool pogodnjen3 = false;
	bool pogodnjen4 = false;
	bool konacni = false;



	public int brojPogodakaPrvog = 0;
	public int brojPogodakaDrugog = 0;
	public int brojPogodakaTreceg = 0;
	public int brojPogodakaCetvrtog = 0;


	public int brojPogodakaPrvogX = 0;
	public int brojPogodakaDrugogX = 0;
	public int brojPogodakaTrecegX = 0;
	public int brojPogodakaCetvrtogX = 0;

	public int skorUkupanX = 0;


	GameObject intanciranaRecPobednik;


	public void ProveriOdgovor ()
	{
       
		if (Input.GetKeyDown (KeyCode.Return)) {

              
			if (!pogodnjen1) {
				if (textInput.GetComponent<InputField> ().text.ToLower () == odgovor1.ToLower ()) {
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
					intanciranaRecPobednik.transform.gameObject.SetActive (false);

					Debug.Log ("POGODJEN ODGOVOR1");
					textInput.gameObject.SetActive (false);
					cube1.gameObject.SetActive (false);

					intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec.transform);
					intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor1.ToString ();
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
					intanciranaRecPobednik.transform.gameObject.SetActive (true);

					intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

                       

					if (daLiPlayer1Igra == true) {
						int brojUkupnih = 50;

						brojPogodakaPrvog = brojUkupnih - brojPogodjenih;

						Debug.Log ("Broj Pogodjenih za prvi odgovor je: " + brojPogodakaPrvog);

						skorUkupan += brojPogodakaPrvog;

						scoreText.text = "Score: " + skorUkupan;
					}

					if (daLiPlayer2Igra == true) {
						int brojUkupnih = 50;

						brojPogodakaPrvogX = brojUkupnih - brojPogodjenihX;

						Debug.Log ("Broj Pogodjenih za prvi odgovor je: " + brojPogodakaPrvogX);

						skorUkupanX += brojPogodakaPrvogX;

						scoreText2.text = "Score: " + skorUkupanX;
					}
						

					pogodnjen1 = true;
					PogodiPrvuKocuku ();


				}
			} else {
				textInput.GetComponent<InputField> ().text = "";

			}

			if (!pogodnjen2) {
				if (textInput2.GetComponent<InputField> ().text.ToLower () == odgovor2.ToLower ()) {
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
					intanciranaRecPobednik.transform.gameObject.SetActive (false);

					Debug.Log ("POGODJEN ODGOVOR2");
					textInput2.gameObject.SetActive (false);
					cube2.gameObject.SetActive (false);

					intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec2.transform);
					intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor2.ToString ();
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
					intanciranaRecPobednik.transform.gameObject.SetActive (true);

					intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

       
					if (daLiPlayer1Igra == true) {

						int brojUkupnih2 = 50;

						brojPogodakaDrugog = brojUkupnih2 - brojPogodjenihDrugog;

						Debug.Log ("Broj Pogodjenih za drugi odgovor je: " + brojPogodakaDrugog);

						skorUkupan += brojPogodakaDrugog;

						scoreText.text = "Score: " + skorUkupan;
					}

					if (daLiPlayer2Igra == true) {
						int brojUkupnih2 = 50;

						brojPogodakaDrugogX = brojUkupnih2 - brojPogodjenihDrugogX;

						Debug.Log ("Broj Pogodjenih za drugi odgovor je: " + brojPogodakaDrugogX);

						skorUkupanX += brojPogodakaDrugogX;


						scoreText2.text = "Score: " + skorUkupanX;
					}

   
					pogodnjen2 = true;

					PogodiCetvrtuKocuku ();



				}
			} else {
				textInput2.GetComponent<InputField> ().text = "";

			}

			if (!pogodnjen3) {
				if (textInput3.GetComponent<InputField> ().text.ToUpper () == odgovor3.ToUpper ()) {
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
					intanciranaRecPobednik.transform.gameObject.SetActive (false);

					Debug.Log ("POGODJEN ODGOVOR3");
					textInput3.gameObject.SetActive (false);
					cube3.gameObject.SetActive (false);

					intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec3.transform);
					intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor3.ToString ();
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
					intanciranaRecPobednik.transform.gameObject.SetActive (true);

					intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

                   

					if (daLiPlayer1Igra == true) {
						int brojUkupnih3 = 50;

						brojPogodakaTreceg = brojUkupnih3 - brojPogodjenihTreceg;

						Debug.Log ("Broj Pogodjenih za treci odgovor je: " + brojPogodakaTreceg);

						skorUkupan += brojPogodakaTreceg;

						scoreText.text = "Score: " + skorUkupan;
					}

					if (daLiPlayer2Igra == true) {
						int brojUkupnih3 = 50;

						brojPogodakaTrecegX = brojUkupnih3 - brojPogodjenihTrecegX;

						Debug.Log ("Broj Pogodjenih za treci odgovor je: " + brojPogodakaTrecegX);

						skorUkupanX += brojPogodakaTrecegX;

						scoreText2.text = "Score: " + skorUkupanX;
					}


					pogodnjen3 = true;

					PogodiDruguKocuku ();


				}
			} else {
				textInput3.GetComponent<InputField> ().text = "";

			}

			if (!pogodnjen4) {
				if (textInput4.GetComponent<InputField> ().text.ToUpper () == odgovor4.ToUpper ()) {
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
					intanciranaRecPobednik.transform.gameObject.SetActive (false);

					Debug.Log ("POGODJEN ODGOVOR4");

					textInput4.gameObject.SetActive (false);
					cube4.gameObject.SetActive (false);

					intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec4.transform);
					intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor4.ToString ();
					intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
					intanciranaRecPobednik.transform.gameObject.SetActive (true);

					intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");


					if (daLiPlayer1Igra == true) {
						int brojUkupnih4 = 50;

						brojPogodakaCetvrtog = brojUkupnih4 - brojPogodjenihCetvrtog;

						Debug.Log ("Broj Pogodjenih za cetvrti odgovor je: " + brojPogodakaCetvrtog);

						skorUkupan += brojPogodakaCetvrtog;

						scoreText.text = "Score: " + skorUkupan;
					}

					if (daLiPlayer2Igra == true) {
						int brojUkupnih4 = 50;

						brojPogodakaCetvrtogX = brojUkupnih4 - brojPogodjenihCetvrtogX;

						Debug.Log ("Broj Pogodjenih za cetvrti odgovor je: " + brojPogodakaCetvrtogX);

						skorUkupanX += brojPogodakaCetvrtogX;

						scoreText2.text = "Score: " + skorUkupanX;
					}

 
					pogodnjen4 = true;

					PogodiTrecuKocuku ();


				}
			} else {
				textInput4.GetComponent<InputField> ().text = "";

			}

		}
        


	}


	IEnumerator EndScene ()
	{

		yield return new WaitForSeconds (3f);

		SceneManager.LoadScene (1);
	}



	public void ProveriKonacni ()
	{
		if (Input.GetKeyUp (KeyCode.Return)) {

			if (textInput5.GetComponent<InputField> ().text == konacan || textInput5.GetComponent<InputField> ().text == konacan.ToLower ()) {

				Debug.Log ("POGODJEN KONACAN");

				textInput5.gameObject.SetActive (false);
				cube5.gameObject.SetActive (false);

				GameObject instanciranaRecKonacna = Instantiate (recKonacna, new Vector3 (0f, 0f, 0f), Quaternion.identity);
				instanciranaRecKonacna.transform.SetParent (mestoZaKonacnuRec.transform);
				instanciranaRecKonacna.transform.localPosition = new Vector3 (0f, 0f, 0f);
				instanciranaRecKonacna.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = konacan.ToString ();
				instanciranaRecKonacna.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();

				instanciranaRecKonacna.GetComponent<Animator> ().Play ("rotatefull");
				konacni = true;

				if (daLiPlayer1Igra == true) {
					if (!pogodnjen1)
						skorUkupan += 50;

					if (!pogodnjen2)
						skorUkupan += 50;

					if (!pogodnjen3)
						skorUkupan += 50;

					if (!pogodnjen4)
						skorUkupan += 50;


					skorUkupan += 30;
					scoreText.text = "Score: " + skorUkupan;
				}

				if (daLiPlayer2Igra == true) {
					if (!pogodnjen1)
						skorUkupanX += 50;

					if (!pogodnjen2)
						skorUkupanX += 50;

					if (!pogodnjen3)
						skorUkupanX += 50;

					if (!pogodnjen4)
						skorUkupanX += 50;


					skorUkupanX += 30;
					scoreText2.text = "Score: " + skorUkupanX;
				}


				PlayerPrefs.SetInt ("playerScore", skorUkupan);
				PlayerPrefs.SetInt ("playerScore2", skorUkupanX);

				PogodiPrvuKocuku ();
				PogodiDruguKocuku ();
				PogodiTrecuKocuku ();
				PogodiCetvrtuKocuku ();


				if (!pogodnjen1)
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
				intanciranaRecPobednik.transform.gameObject.SetActive (false);

				textInput.gameObject.SetActive (false);
				cube1.gameObject.SetActive (false);

				intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec.transform);
				intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor1.ToString ();
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
				intanciranaRecPobednik.transform.gameObject.SetActive (true);

				intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

				if (!pogodnjen2)
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
				intanciranaRecPobednik.transform.gameObject.SetActive (false);

				textInput2.gameObject.SetActive (false);
				cube2.gameObject.SetActive (false);

				intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec2.transform);
				intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor2.ToString ();
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
				intanciranaRecPobednik.transform.gameObject.SetActive (true);

				intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

				if (!pogodnjen3)
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
				intanciranaRecPobednik.transform.gameObject.SetActive (false);

				textInput3.gameObject.SetActive (false);
				cube3.gameObject.SetActive (false);

				intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec3.transform);
				intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor3.ToString ();
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
				intanciranaRecPobednik.transform.gameObject.SetActive (true);

				intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

				if (!pogodnjen4)
					intanciranaRecPobednik = Instantiate (recPogodjena, new Vector3 (0f, 0f, 0f), Quaternion.identity);
				intanciranaRecPobednik.transform.gameObject.SetActive (false);
                
				textInput4.gameObject.SetActive (false);
				cube4.gameObject.SetActive (false);

				intanciranaRecPobednik.transform.SetParent (mestoZaPobednicuRec4.transform);
				intanciranaRecPobednik.transform.localPosition = new Vector3 (0f, 0f, 0f);
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().Text = odgovor4.ToString ();
				intanciranaRecPobednik.transform.GetChild (0).GetComponent<SimpleHelvetica> ().GenerateText ();
				intanciranaRecPobednik.transform.gameObject.SetActive (true);

				intanciranaRecPobednik.GetComponent<Animator> ().Play ("rotatefull");

				StartCoroutine (EndScene ());
			} else {
				textInput5.GetComponent<InputField> ().text = "";


			}

		}

	}
}

