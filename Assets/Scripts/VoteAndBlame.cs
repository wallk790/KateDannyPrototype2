using UnityEngine;
using System.Collections;

public class Blame : MonoBehaviour {
	
	void OnTriggerStay2D(Collider2D other){

		if(this.tag == "A"){
			if(Input.GetButtonDown("Select1")){

		if(other.CompareTag("BLAMEA")){
				KeepScore.phase1[0] = "a";
		}

		if(other.CompareTag("BLAMEB")){
				KeepScore.phase1[0] = "b";
		}

		if(other.CompareTag("BLAMEC")){
				KeepScore.phase1[0] = "c";
		}

		if(other.CompareTag("BLAMED")){
				KeepScore.phase1[0] = "d";
		}

		if(other.CompareTag("VOTEA")){
				KeepScore.phase2[0] = "a";
		}

		if(other.CompareTag("VOTEB")){
				KeepScore.phase2[0] = "b";
		}

		if(other.CompareTag("VOTEC")){
				KeepScore.phase2[0] = "c";
		}

		if(other.CompareTag("VOTED")){
				KeepScore.phase2[0] = "d";

		}
		}
		}

		if(this.tag == "B"){
			if(Input.GetButtonDown("Select2")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[1] = "a";
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[1] = "b";
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[1] = "c";
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[1] = "d";
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[1] = "a";
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[1] = "b";
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[1] = "c";
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[1] = "d";
				}
			}
		}

		if(this.tag == "C"){
			if(Input.GetButtonDown("Select3")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[2] = "a";
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[2] = "b";
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[2] = "c";
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[2] = "d";
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[2] = "a";
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[2] = "b";
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[2] = "c";

				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[2] = "d";

				}
			}
		}

		if(this.tag == "D"){
			if(Input.GetButtonDown("Select4")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[3] = "a";
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[3] = "b";
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[3] = "c";
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[3] = "d";

				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[3] = "a";

				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[3] = "b";

				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[3] = "c";

				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[3] = "d";
				}
			}
		}
	
		
	
		
	




	}

}
