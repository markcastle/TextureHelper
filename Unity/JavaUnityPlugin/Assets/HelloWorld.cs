using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {

    Text textObj;

	void Start () {

        // Find the Text UI object attached to the game object this script is attached to
        textObj = gameObject.GetComponent<Text>();

        // Make the call using JNI to the Java Class and write out the response (or write 'Invalid Response From JNI' if there was a problem).
        textObj.text = CaptiveReality.Jni.Util.StaticCall<string>("sayHello", "Invalid Response From JNI", "com.captivereality.texturehelper.HelloWorld");
    }
	
}
