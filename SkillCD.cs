

	private float currentTime;
	private float SkillTime1;
	private float hasTime;
	private bool isCanAttack=true;
	public UISprite mySp;
	public UILabel myLab;

	// Use this for initialization
	void Start () {
		currentTime = 0;
		SkillTime1 = 5;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (mySp.fillAmount.Equals(1)) {
			return;
		}
		currentTime += Time.deltaTime;
		hasTime = SkillTime1 - Mathf.FloorToInt (currentTime);
		myLab.text = hasTime.ToString ();
		mySp.fillAmount = 1 / SkillTime1 * currentTime;
		if (currentTime>=SkillTime1) {
			currentTime = 0;
			isCanAttack = true;
			myLab.enabled = false;
			this.GetComponent<UIButton> ().enabled = true;
		}
	}

	void OnClick(){
		if (isCanAttack) {
			mySp.fillAmount = 0;
			isCanAttack = false;
			myLab.enabled = true;
			this.GetComponent<UIButton> ().enabled = false;
		}

	}
}
