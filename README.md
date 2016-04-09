#hashtag_maze

Elevator Pitch
#Maze is a web application that builds an interactive visualization of a Twitter topic. It uses Twitter Rest API, three.js, and the Oculus Rift to build procedurally generated maze structures that contain tweets of the given topic, and allows the user to explore these tweets in 3-D space. The procedure for the maze will use characteristics of the tweets to help drive the randomness of the procedural generation.

Project Stack

Front End
As “Deliverable”
three.js: to deliver 3D representation
Unity: to deliver 3D representation
Twitter Rest API: to poll twitter for trending topics and gather tweets for viewing
As “Code Base”
javascript: generates document to represent an instance of a maze
C#: prefered language if we use Unity
Back End
(Non-Unity)
Web Server: runs instances of #Maze, serving it as a webpage to the browser
MySQL: optional cache to store #Maze instances as a way to handle Twitter bandwidth limit exception

Structures and Design
User connects to web server
Page loads script to initiate construction of a maze
Twitter API polls a trending topic to explore
Twitter API gathers tweets from trending topic and stores them into a set
Handling Bandwidth Limit: Pull data from SQL server instead
Scripts creates data representation of the maze
Deliverable reads maze data
Deliverable reads data from Twitter based process, creating a 2D plane of cells or areas to be the “floor plan” of the maze
Populate areas of the maze with floating text of tweets that created the maze, providing the visualization of the data
Processes anything necessary to make the maze “tangible” and “usable”
Handle Control and Oculus
Write control code that captures input to allow for interaction with maze
Have maze display on Oculus Rift
Optional: Command to load new maze instance
Optional: Control for allowing user to control maze query (rather than random trending topic)
Possibly Some Cleanup
