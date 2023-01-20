using UnityEngine;
/*
//protected - only children can call it versus public
public abstract class Abstract: MonoBehaviour
{
    //doesnt have functionality on its own
        //relies on more concrete code to function
        //abstract cant have a body
        //add the word base to any abstract class where you can't add code into
            //MammalBase -> any classes then inherit from the base
            
    //can include the virtual phrase to allow the override of a non abstract class but still keep the overall method in abstractbase
        public abstract void Start();
            //makes start function required for any inherited classes

            public void Speak()
            {
                print("Speak");
                //can include non abstract methods that will be the same across all classes
            }

    //A new class//
    public class NewClass : Abstract
    {
        public override void Start()
        {
            print("Dog walking");
        }

        protected override void Speak()
        {
            base.Speak();
                //if commented out you can completely change the method 
            print("Bark");
        }
    }
}
*/
