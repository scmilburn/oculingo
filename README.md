#Oculingo Table of Contents
-Elevator Pitch
-Project Stack
-Structures and Design
-Sources

##Elevator Pitch
Oculingo is a Unity based educational tool used to help teach and test foreign languages. The player will select their desired language, and be presented with a scene containing objects to interact with. Depending on the mode of the game, lesson or quiz, the game will either explain the foreign name of the object or ask the player to pronounce it. The experience is fully VR immersive, meaning no interaction with any hardware besides wearables. The number of languages.
   
##Oculingo Stack
Unity: for Oculus Rift support. For displaying scenes and providing support for interaction.
Microphone(?): to understand user vocal input. Needs to support multiple languages

##Structures and Design
GameManager for handing flow of game
TitleScene for introducing Oculingo, choosing mode and language
StageScene for housing the Oculus camera and being the “stage” for each interactable object
LanguageObject prefab for storing 3d model of an object, its various names in different languages, and state of interactable
QuizMode to handle handling LanguageObjects interaction with camera, displaying goal prompt, playing audio prompt “StageScene.quiz(LanguageObject)” -> function uses native variable to construct a phrase to ask for the LanguageObject’s name in another language.
LessonMode to handle handling LanguageObjects interaction with camera, playing audio prompt “StageScene.lesson(LanguageObject)” -> function uses native variable to construct a phrase to ask for the LanguageObject’s name in another language.


    
##Sources
    Unity Asset Store
Props for the Classroom

    
    Voice recognition software
        UNITY BRIDGE (paid)
        https://www.assetstore.unity3d.com/en/#!/content/57425
        
        UDP voice recog server (free?)
        http://forum.unity3d.com/threads/windows-udp-voice-recognition-server.172758/

Open source 
https://github.com/giyoonhan/UnityVoiceRecognition
