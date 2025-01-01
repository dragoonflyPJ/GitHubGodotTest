using Godot;
using System;

public partial class testCSharpScr : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
 	Godot.Array<int> primes = new();
		GD.Print("Prueba de Edicion desde GitHub, nueva cuenta 123");
  		for(int i = 0; i < 100; i++){
    			bool prime = true;
    			for(int ni = 0; ni < primes.Size(); ni++) {
      				if((float) i % ni == 0) {
	  				prime = false; 
      					 break;
      				}
	  		if(prime) {
     				primes.Add(i);
	 			GD.Print(i);
    			}
    		}
	}

}
